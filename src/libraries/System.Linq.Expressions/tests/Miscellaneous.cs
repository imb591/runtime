// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Linq.Expressions.Tests;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Runtime.Loader;
using System.Text.RegularExpressions;
using Xunit;
using Xunit.Abstractions;

namespace CompileToMethod.Tests;

public class Miscellaneous
{
    [Fact]
    public static void CompileToMethodPreconditions_Null_TriggersContractUtilsRequiresNotNull()
    {
        Expression<Func<int>> lambda = () => 0;

        Assert.Throws<ArgumentNullException>("method", () => lambda.CompileToMethod(null!));
    }

    [Fact]
    public static void CompileToMethodPreconditions_InstanceMethod_TriggersContractUtilsRequires()
    {
        Expression<Func<int>> lambda = () => 0;

        var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("Coverage"), AssemblyBuilderAccess.Run);
        var moduleBuilder = assemblyBuilder.DefineDynamicModule("Coverage");
        var typeBuilder = moduleBuilder.DefineType("Coverage");
        var methodBuilder = typeBuilder.DefineMethod("Method", MethodAttributes.Public);
        Assert.Throws<ArgumentException>("method", () => lambda.CompileToMethod(methodBuilder));
    }

    [Fact]
    public static void CompileToMethodPreconditions_ModuleMethod_TriggersTypeBuilderError()
    {
        Expression<Func<int>> lambda = () => 0;

        var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("Coverage"), AssemblyBuilderAccess.Run);
        var moduleBuilder = assemblyBuilder.DefineDynamicModule("Coverage");
        var moduleMethodBuilder = moduleBuilder.DefineGlobalMethod("Coverage", MethodAttributes.Public | MethodAttributes.Static, typeof(int), Type.EmptyTypes);
        Assert.Throws<ArgumentException>(() => lambda.CompileToMethod(moduleMethodBuilder));
    }

    public class NonTestClass
    {
        public static Expression<Func<int, int, int>> SubtractingExpression() => (o1, o2) => o1 - o2;

        public static object TailCall(object param) => param;
        public static object TailCallRef(ref object param) => param;
        public static object TailCallOut([Out] object param) => param;

        public static int Method() => 42;
        public static bool Compare(int x, int y) => x == y;
        public static bool WithinTenNullable(int? x, int? y) => x == null && y == null || x != null && y != null && Math.Abs(x.Value - y.Value) < 10;
        public static bool SwitchByRefWithinTen(ref int x, ref int y) => Math.Abs(x - y) < 10;
    }

    [Fact]
    public static void LambdaWithTailCall_TriggersTypeExtensionsIsByRefParameter()
    {
        var method = typeof(NonTestClass).GetMethod(nameof(NonTestClass.TailCall), BindingFlags.Public | BindingFlags.Static)!;
        var param = Expression.Parameter(typeof(object));
        var expr = Expression.Lambda<Func<object, object>>(
            Expression.Call(method, param),
            true,
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var obj = new object();
        var result = func(obj);
        Assert.Same(obj, result);
    }

    [Fact]
    public static void LambdaWithTailCallRef_TriggersTypeExtensionsIsByRefParameter()
    {
        var method = typeof(NonTestClass).GetMethod(nameof(NonTestClass.TailCallRef), BindingFlags.Public | BindingFlags.Static)!;
        var param = Expression.Parameter(typeof(object));
        var expr = Expression.Lambda<Func<object, object>>(
            Expression.Call(method, param),
            true,
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var obj = new object();
        var result = func(obj);
        Assert.Same(obj, result);
    }

    [Fact]
    public static void LambdaWithTailCallOut_TriggersTypeExtensionsIsByRefParameter()
    {
        var method = typeof(NonTestClass).GetMethod(nameof(NonTestClass.TailCallOut), BindingFlags.Public | BindingFlags.Static)!;
        var param = Expression.Parameter(typeof(object));
        var expr = Expression.Lambda<Func<object, object>>(
            Expression.Call(method, param),
            true,
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var obj = new object();
        var result = func(obj);
        Assert.Same(obj, result);
    }

    [Fact]
    public static void InvocationWithExpressionReturningExpression_TriggersTypeUtilsFindGenericType()
    {
        var method = typeof(NonTestClass).GetMethod(nameof(NonTestClass.SubtractingExpression), BindingFlags.Public | BindingFlags.Static)!;
        var expr = Expression.Lambda<Func<int>>(
            Expression.Invoke(
                Expression.Call(method),
                Expression.TryFinally(
                    Expression.Constant(1),
                    Expression.Empty()),
                Expression.Constant(2)));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var result = func();
        Assert.Equal(-1, result);
    }

    [Fact]
    public static void LambdaWithTailBlockWithGoto_TriggersEmitBlockEmitAsTail()
    {
        LambdaWithTailBlockWithGoto_TriggersEmitBlockEmitAsTail_Executed = false;
        var field = typeof(Miscellaneous).GetField(nameof(LambdaWithTailBlockWithGoto_TriggersEmitBlockEmitAsTail_Executed),
            BindingFlags.Public | BindingFlags.Static)!;
        var label = Expression.Label(typeof(void), "ret");
        var expr = Expression.Lambda<Action>(
            Expression.Block(
                Expression.Assign(Expression.Field(null, field), Expression.Constant(true)),
                Expression.Goto(label),
                Expression.Assign(Expression.Field(null, field), Expression.Constant(false)),
                Expression.Goto(label, Expression.Block(Expression.Block())),
                Expression.Label(label)),
            true);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        func();
        Assert.True(LambdaWithTailBlockWithGoto_TriggersEmitBlockEmitAsTail_Executed);
    }

    public static bool LambdaWithTailBlockWithGoto_TriggersEmitBlockEmitAsTail_Executed;

    [Fact]
    public static void LambdaWithTailCondition_TriggersLambdaCompilerEmitConditionalExpressionTailBranch()
    {
        var param = Expression.Parameter(typeof(bool));
        var expr = Expression.Lambda<Func<bool, int>>(
            Expression.Condition(param, Expression.Constant(1), Expression.Constant(2)),
            true,
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(1, func(true));
        Assert.Equal(2, func(false));
    }

    [Fact]
    public static void LambdaWithTailAndAlso_TriggersEmitMethodAndAlsoTail()
    {
        var param1 = Expression.Parameter(typeof(LogicalClass));
        var param2 = Expression.Parameter(typeof(LogicalClass));
        var expr = Expression.Lambda<Func<LogicalClass, LogicalClass, LogicalClass>>(
            Expression.AndAlso(
                param1,
                param2,
                typeof(LogicalClass).GetMethod(nameof(LogicalClass.Nand), BindingFlags.Static | BindingFlags.Public)),
            true,
            param1, param2
        );
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.False(func(new LogicalClass(true), new LogicalClass(true)).Value);
        Assert.True(func(new LogicalClass(true), new LogicalClass(false)).Value);
        Assert.False(func(new LogicalClass(false), new LogicalClass(true)).Value); // short-circuit
        Assert.False(func(new LogicalClass(false), new LogicalClass(false)).Value); // short-circuit
    }

    [Fact]
    public static void LambdaWithTailOrElse_TriggersEmitMethodOrElseTail()
    {
        var param1 = Expression.Parameter(typeof(LogicalClass));
        var param2 = Expression.Parameter(typeof(LogicalClass));
        var expr = Expression.Lambda<Func<LogicalClass, LogicalClass, LogicalClass>>(
            Expression.OrElse(
                param1,
                param2,
                typeof(LogicalClass).GetMethod(nameof(LogicalClass.Nand), BindingFlags.Static | BindingFlags.Public)),
            true,
            param1, param2
        );
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.True(func(new LogicalClass(true), new LogicalClass(true)).Value); // short-circuit
        Assert.True(func(new LogicalClass(true), new LogicalClass(false)).Value);
        Assert.True(func(new LogicalClass(false), new LogicalClass(true)).Value);
        Assert.True(func(new LogicalClass(false), new LogicalClass(false)).Value);
    }

    public class LogicalClass
    {
        public bool Value;

        public LogicalClass(bool value)
        {
            Value = value;
        }

        public static bool operator false(LogicalClass op) => op.Value == false;
        public static bool operator true(LogicalClass op) => op.Value == true;
        public static bool operator &(LogicalClass op1, LogicalClass op2) => op1.Value && op2.Value;
        public static LogicalClass operator |(LogicalClass op1, LogicalClass op2) => new LogicalClass(op1.Value || op2.Value);
        public static LogicalClass Nand(LogicalClass first, LogicalClass second) => new LogicalClass(!(first.Value && second.Value));
    }

    [Fact]
    public static void TypeConstantWithNonTypeType_TriggersILGenEmit()
    {
        var expr = Expression.Lambda<Func<object>>(
            Expression.Constant(typeof(object), typeof(object)));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var result = func();
        Assert.Same(typeof(object), result);
    }

    [Fact]
    public static void MethodConstant_TriggersILGenEmit()
    {
        var method = typeof(NonTestClass).GetMethod(nameof(NonTestClass.Method), BindingFlags.Public | BindingFlags.Static);
        var expr = Expression.Lambda<Func<object>>(
            Expression.Constant(method, typeof(MethodInfo)));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var result = func();
        Assert.Same(method, result);
    }

    [Fact]
    public static void MethodBaseConstant_TriggersILGenEmit()
    {
        var method = typeof(NonTestClass).GetMethod(nameof(NonTestClass.Method), BindingFlags.Public | BindingFlags.Static);
        var expr = Expression.Lambda<Func<object>>(
            Expression.Constant(method, typeof(MethodBase)));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var result = func();
        Assert.Same(method, result);
    }

    [Fact]
    public static void GenericTypeMethodConstant_TriggersILGenEmit()
    {
        var method = typeof(Generic<object>).GetMethod(nameof(Generic<object>.Method), BindingFlags.Public | BindingFlags.Instance);
        var expr = Expression.Lambda<Func<object>>(
            Expression.Constant(method, typeof(MethodInfo)));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var result = func();
        Assert.Same(method, result);
    }

    public class Generic<T>
    {
        public void Method()
        {
        }
    }

    private static (MethodBuilder, ModuleBuilder) GenerateGlobalMethod()
    {
        var module = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("Name"), AssemblyBuilderAccess.Run).DefineDynamicModule("Module");
        var globalMethod = module.DefineGlobalMethod("GlobalMethod", MethodAttributes.Public | MethodAttributes.Static, typeof(void), Type.EmptyTypes);
        globalMethod.GetILGenerator().Emit(OpCodes.Ret);
        return (globalMethod, module);
    }

    [Fact]
    public static void GlobalMethodConstant_TriggersILGenEmit()
    {
        var (method, module) = GenerateGlobalMethod();
        var expr = Expression.Lambda<Func<object>>(
            Expression.Constant(method, typeof(MethodInfo)));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true, module);
        module.CreateGlobalFunctions();
        var result = func();
        Assert.Same(module.GetMethod("GlobalMethod"), result);
    }

    [Fact]
    public static void ConstructorConstant_TriggersILGenEmit()
    {
        var ctor = typeof(HasDefaultCtor).GetConstructor(Type.EmptyTypes)!;
        var expr = Expression.Lambda<Func<object>>(
            Expression.Constant(ctor, typeof(ConstructorInfo)));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var result = func();
        Assert.Same(ctor, result);
    }

    public class HasDefaultCtor
    {
    }

    [Fact]
    public static void BadMethodConstant_TriggersILGenEmit()
    {
        var method = typeof(Invisible).GetMethod(nameof(Invisible.Method), BindingFlags.Public | BindingFlags.Instance);
        var expr = Expression.Lambda<Func<object>>(
            Expression.Constant(method, typeof(MethodInfo)));
        Assert.Throws<InvalidOperationException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
    }

    private class Invisible
    {
        public void Method()
        {
        }
    }

    [Fact]
    public static void BadDynamicMethodConstant_TriggersShouldLdtoken()
    {
        var method = new DynamicMethod("DynamicMethod", typeof(void), Type.EmptyTypes);
        var expr = Expression.Lambda<Func<object>>(
            Expression.Constant(method, typeof(MethodInfo)));
        Assert.Throws<InvalidOperationException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
    }

    [Fact]
    public static void StaticFieldNullComparison_TriggersILGenEmitFieldAddress()
    {
        var field = typeof(Miscellaneous).GetField(nameof(StaticField), BindingFlags.Public | BindingFlags.Static)!;
        var expr = Expression.Lambda<Func<bool>>(
            Expression.Equal(
                Expression.Field(null, field),
                Expression.Constant(null)));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        StaticField = null;
        var result = func();
        Assert.True(result);
        StaticField = true;
        result = func();
        Assert.False(result);
        StaticField = false;
        result = func();
        Assert.False(result);
    }

    public static bool? StaticField;

    [Fact]
    public static void Quote_CompilationError()
    {
        var expr = Expression.Lambda<Func<Expression<Action>>>(
            Expression.Quote(
                Expression.Lambda<Action>(
                    Expression.Block(
                        Expression.Constant(0),
                        Expression.Empty())
                )
            )
        );
        Assert.Throws<NotSupportedException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
    }

    [Fact]
    public static void TryInsideFilter_CompilationError()
    {
        var expr = Expression.Lambda<Action>(
            Expression.TryCatch(
                Expression.Empty(),
                Expression.Catch(
                    typeof(Exception),
                    Expression.Empty(),
                    Expression.TryFinally(
                        Expression.Constant(true),
                        Expression.Empty()))));
        Assert.Throws<InvalidOperationException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
    }

    [Fact]
    public static void Switch_DefaultBodyNull_TriggersLambdaCompilerEmitSwitchCases()
    {
        var param = Expression.Parameter(typeof(int));
        var expr = Expression.Lambda<Func<int, int>>(
            Expression.Block(
                Expression.Switch(
                    typeof(void),
                    param,
                    null,
                    null,
                    Expression.SwitchCase(
                        Expression.Assign(param, Expression.Constant(1)),
                        Expression.Constant(0))),
                param),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(1, func(0));
        Assert.Equal(1, func(1));
        Assert.Equal(2, func(2));
    }

    [Fact]
    public static void SwitchSparseValues_TriggersLambdaCompilerMergeBuckets()
    {
        var param = Expression.Parameter(typeof(int));
        var cases = new[] { 0, 3, 6, 7 }.Select(i =>
            Expression.SwitchCase(
                Expression.Constant(i + 1),
                Expression.Constant(i))).ToArray();
        var expr = Expression.Lambda<Func<int, int>>(
            Expression.Switch(
                param,
                Expression.Constant(0),
                cases),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(1, func(0));
        Assert.Equal(0, func(1));
        Assert.Equal(0, func(2));
        Assert.Equal(4, func(3));
        Assert.Equal(0, func(4));
        Assert.Equal(0, func(5));
        Assert.Equal(7, func(6));
        Assert.Equal(8, func(7));
        Assert.Equal(0, func(8));
    }

    [Fact]
    public static void CoalesceWithConversion_TriggersLambdaCompilerEmitNullableCoalesceGetValue()
    {
        var inner = Expression.Parameter(typeof(int), "inner");
        var expr = Expression.Lambda<Func<int>>(
            Expression.Coalesce(
                Expression.Constant(2, typeof(int?)),
                Expression.Constant(1),
                Expression.Lambda<Func<int, int>>(inner, inner)
            ));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var result = func();
        Assert.Equal(2, result);
    }

    [Fact]
    public static void AndAlsoWithLeftNotAndAlso_TriggersLambdaCompilerEmitBranchAnd()
    {
        var param = Expression.Parameter(typeof(bool));
        var expr = Expression.Lambda<Func<bool, bool>>(
            Expression.AndAlso(
                Expression.Not(
                    Expression.AndAlso(param, Expression.Constant(true))),
                Expression.Constant(true)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.True(func(false));
        Assert.False(func(true));
    }

    [Fact]
    public static void AndAlsoWithLeftBlock_TriggersLambdaCompilerEmitBranchBlock()
    {
        var param = Expression.Parameter(typeof(bool));
        var expr = Expression.Lambda<Func<bool, bool>>(
            Expression.AndAlso(
                Expression.Block(
                    Expression.Assign(
                        Expression.Field(
                            null,
                            typeof(Miscellaneous).GetField(nameof(AndAlsoWithLeftBlock_TriggersLambdaCompilerEmitBranchBlock_State), BindingFlags.Public | BindingFlags.Static))!,
                        Expression.Constant(true)),
                    param),
                Expression.Constant(true)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);

        AndAlsoWithLeftBlock_TriggersLambdaCompilerEmitBranchBlock_State = false;
        Assert.False(func(false));
        Assert.True(AndAlsoWithLeftBlock_TriggersLambdaCompilerEmitBranchBlock_State);

        AndAlsoWithLeftBlock_TriggersLambdaCompilerEmitBranchBlock_State = false;
        Assert.True(func(true));
        Assert.True(AndAlsoWithLeftBlock_TriggersLambdaCompilerEmitBranchBlock_State);
    }

    public static bool AndAlsoWithLeftBlock_TriggersLambdaCompilerEmitBranchBlock_State;

    [Fact]
    public static void ValueTypeMemberMemberBinding_TriggersLambdaCompilerEmitMemberMemberBinding_ValueTypeBranch()
    {
        Expression<Func<Outer>> expr = () => new Outer { Inner = { Value = 42, } };
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var result = func();
        Assert.Equal(42, result.Inner.Value);
    }

    public struct Outer
    {
        public Inner Inner;
        public Inner InnerProp { get; set; }
        public InnerClass InnerClass;
        public CollectionStruct CollectionStructField;
        public CollectionStruct CollectionStructProperty { get; set; }
        public int Int;
    }

    public struct Inner
    {
        public int Value;
    }

    public struct CollectionStruct : IEnumerable<object>, IEnumerator<object>
    {
        public object Current => Object;

        public void Dispose()
        {
        }

        public IEnumerator<object> GetEnumerator() => this;

        public bool MoveNext() => false;

        public void Reset()
        {
        }

        public object Object;

        public void Add(object obj)
        {
            Object = obj;
        }
        public void Add(int obj)
        {
            Object = obj;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class OuterClass
    {
        public InnerClass InnerClass = new InnerClass();
    }

    public class InnerClass
    {
        public int Value;
    }

    [Fact]
    public static void ValueTypeListBinding_TriggersLambdaCompilerEmitMemberListBinding_ValueTypeBranch()
    {
        Expression<Func<Outer>> expr = () => new Outer { CollectionStructField = { new object(), } };
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var result = func();
        Assert.NotNull(result.CollectionStructField.Object);
    }

    [Fact]
    public static void ValueTypePropertyListBinding_TriggersLambdaCompilerEmitMemberListBinding_InitException()
    {
        Expression<Func<Outer>> expr = Expression.Lambda<Func<Outer>>(
            Expression.MemberInit(
                Expression.New(typeof(Outer)),
                Expression.ListBind(
                    typeof(Outer).GetProperty(nameof(Outer.CollectionStructProperty))!,
                    Expression.ElementInit(
                        typeof(CollectionStruct).GetMethod(nameof(CollectionStruct.Add), new[] { typeof(object) })!,
                        Expression.New(typeof(object))))));
        Assert.Throws<InvalidOperationException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
    }

    [Fact]
    public static void ValueTypeEmptyBinding_TriggersLambdaCompilerEmitMemberInit_KeepOnStackBranch()
    {
        Expression<Func<Outer>> expr = () => new Outer { Inner = { }, };
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var result = func();
        Assert.Equal(0, result.Inner.Value);
    }

    [Fact]
    public static void EmptyClassBinding_TriggersLambdaCompilerEmitMemberInit_KeepOnStackBranch()
    {
        Expression<Func<OuterClass>> expr = () => new OuterClass { };
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var result = func();
        Assert.Equal(0, result.InnerClass.Value);
    }

    [Fact]
    public void AndAlsoWithLiftedUserDefinedOperator_TriggersLambdaCompilerEmitAndAlsoBinaryExpression_LiftedBranch()
    {
        var param1 = Expression.Parameter(typeof(UserDefinedBoolOps?));
        var param2 = Expression.Parameter(typeof(UserDefinedBoolOps?));
        var expr = Expression.Lambda<Func<UserDefinedBoolOps?, UserDefinedBoolOps?, UserDefinedBoolOps?>>(
            Expression.AndAlso(
                param1,
                param2,
                typeof(UserDefinedBoolOps).GetMethod(nameof(UserDefinedBoolOps.And))),
            param1, param2);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Null(func(null, null));
        Assert.Null(func(new UserDefinedBoolOps(5), null));
        Assert.Null(func(null, new UserDefinedBoolOps(3)));
        Assert.Equal(1, func(new UserDefinedBoolOps(5), new UserDefinedBoolOps(3))?.Value);
        Assert.Equal(234, func(new UserDefinedBoolOps(234), null)?.Value);
        Assert.Null(func(null, new UserDefinedBoolOps(234)));
    }

    [Fact]
    public void OrElseWithLiftedUserDefinedOperator_TriggersLambdaCompilerEmitOrElseBinaryExpression_LiftedBranch()
    {
        var param1 = Expression.Parameter(typeof(UserDefinedBoolOps?));
        var param2 = Expression.Parameter(typeof(UserDefinedBoolOps?));
        var expr = Expression.Lambda<Func<UserDefinedBoolOps?, UserDefinedBoolOps?, UserDefinedBoolOps?>>(
            Expression.OrElse(
                param1,
                param2,
                typeof(UserDefinedBoolOps).GetMethod(nameof(UserDefinedBoolOps.Or))),
            param1, param2);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Null(func(null, null));
        Assert.Null(func(new UserDefinedBoolOps(5), null));
        Assert.Null(func(null, new UserDefinedBoolOps(3)));
        Assert.Equal(7, func(new UserDefinedBoolOps(5), new UserDefinedBoolOps(3))?.Value);
        Assert.Equal(123, func(new UserDefinedBoolOps(123), null)?.Value);
        Assert.Null(func(null, new UserDefinedBoolOps(123)));
    }

    public struct UserDefinedBoolOps
    {
        public int Value { get; }

        public UserDefinedBoolOps(int value) => Value = value;

        public static UserDefinedBoolOps And(UserDefinedBoolOps x, UserDefinedBoolOps y) => new(x.Value & y.Value);
        public static UserDefinedBoolOps Or(UserDefinedBoolOps x, UserDefinedBoolOps y) => new(x.Value | y.Value);

        public static bool operator true(UserDefinedBoolOps x) => x.Value == 123;
        public static bool operator false(UserDefinedBoolOps x) => x.Value == 234;
    }

    [Fact]
    public static void CallByRefWithParameterOfDerivedType_TriggersLambdaCompilerAddressOfParameterExpression_DifferentByRefTypesBranch()
    {
        var method = typeof(Base).GetMethod(nameof(Base.Go), BindingFlags.Static | BindingFlags.Public)!;
        var param = Expression.Parameter(typeof(Derived));
        var expr = Expression.Lambda<Action<Derived>>(
            Expression.Call(method, param),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var derived = new Derived();
        func(derived);
        Assert.Equal(1, derived.Prop);
    }

    [Fact]
    public static void CallByRefWithArrayIndexOfDerivedType_TriggersLambdaCompilerAddressOfBinaryExpression_DifferentByRefTypesBranch()
    {
        var method = typeof(Base).GetMethod(nameof(Base.Go), BindingFlags.Static | BindingFlags.Public)!;
        var param = Expression.Parameter(typeof(Derived[]));
        var expr = Expression.Lambda<Action<Derived[]>>(
            Expression.Call(method, Expression.ArrayIndex(param, Expression.Constant(0))),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var derived = new Derived[] { new Derived() };
        func(derived);
        Assert.Equal(1, derived[0].Prop);
    }

    [Fact]
    public static void CallByRefWithMemberOfDerivedType_TriggersLambdaCompilerAddressOfBinaryExpression_DifferentByRefTypesBranch()
    {
        var method = typeof(Base).GetMethod(nameof(Base.Go), BindingFlags.Static | BindingFlags.Public)!;
        var param = Expression.Parameter(typeof(DerivedContainer));
        var expr = Expression.Lambda<Action<DerivedContainer>>(
            Expression.Call(method, Expression.Property(param, typeof(DerivedContainer).GetProperty(nameof(DerivedContainer.Item))!)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var container = new DerivedContainer { Item = new Derived() };
        func(container);
        Assert.Equal(1, container.Item.Prop);
    }

    [Fact]
    public static void CallByRefWithMethodCallOfDerivedType_TriggersLambdaCompilerAddressOfBinaryExpression_DifferentByRefTypesBranch()
    {
        var method = typeof(Base).GetMethod(nameof(Base.Go), BindingFlags.Static | BindingFlags.Public)!;
        var param = Expression.Parameter(typeof(DerivedContainer));
        var expr = Expression.Lambda<Action<DerivedContainer>>(
            Expression.Call(method, Expression.Call(param, typeof(DerivedContainer).GetMethod(nameof(DerivedContainer.Get))!)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var container = new DerivedContainer { Item = new Derived() };
        func(container);
        Assert.Equal(1, container.Item.Prop);
    }

    [Fact]
    public static void CallByRefWithMultidimArrayOfDerivedType_TriggersLambdaCompilerAddressOfIndexExpression_DifferentByRefTypesBranch()
    {
        var method = typeof(Base).GetMethod(nameof(Base.Go), BindingFlags.Static | BindingFlags.Public)!;
        var param = Expression.Parameter(typeof(Derived[,]));
        var expr = Expression.Lambda<Action<Derived[,]>>(
            Expression.Call(method, Expression.ArrayAccess(param, Expression.Constant(0), Expression.Constant(0))),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var container = new Derived[1, 1];
        container[0, 0] = new Derived();
        func(container);
        Assert.Equal(1, container[0, 0].Prop);
    }

    [Fact]
    public static void CallByRefWithMultidimArrayIndexer_TriggersLambdaCompilerAddressOfWriteBackIndexExpression_NotNullIndexerBranch()
    {
        var method = typeof(Base).GetMethod(nameof(Base.Go), BindingFlags.Static | BindingFlags.Public)!;
        var param = Expression.Parameter(typeof(Base[,]));
        var expr = Expression.Lambda<Action<Base[,]>>(
            Expression.Call(method, Expression.ArrayAccess(param, Expression.Constant(0), Expression.Constant(0))),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var container = new Base[1, 1];
        container[0, 0] = new Base();
        func(container);
        Assert.Equal(1, container[0, 0].Prop);
    }

    [Fact]
    public static void CallByRefWithGetOnlyIndexer_TriggersLambdaCompilerAddressOfWriteBackIndexExpression_NotWriteableIndexerBranch()
    {
        var method = typeof(Base).GetMethod(nameof(Base.Go), BindingFlags.Static | BindingFlags.Public)!;
        var param = Expression.Parameter(typeof(GetOnlyIndexer));
        var expr = Expression.Lambda<Action<GetOnlyIndexer>>(
            Expression.Call(method, Expression.MakeIndex(param, typeof(GetOnlyIndexer).GetProperty("Item"), new[] { Expression.Constant(0) })),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var container = new GetOnlyIndexer { Value = new Base() };
        func(container);
        Assert.Equal(1, container.Value.Prop);
    }

    [Fact]
    public static void CallByRefWithStaticProperty_TriggersLambdaCompilerAddressOfWriteBackMemberExpression_NullInstanceBranch()
    {
        var method = typeof(Base).GetMethod(nameof(Base.Go), BindingFlags.Static | BindingFlags.Public)!;
        var expr = Expression.Lambda<Action>(
            Expression.Call(method, Expression.Property(null, typeof(BaseStaticContainer).GetProperty(nameof(BaseStaticContainer.Value))!)));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        BaseStaticContainer.Value = new Base { Prop = 0 };
        func();
        Assert.Equal(1, BaseStaticContainer.Value.Prop);
    }


    [Fact]
    public static void CallByRefWithStaticIndexer_TriggersLambdaCompilerAddressOfWriteBackIndexExpression_NullInstanceBranch()
    {
        var method = typeof(Base).GetMethod(nameof(Base.Go), BindingFlags.Static | BindingFlags.Public)!;
        var expr = Expression.Lambda<Action>(
            Expression.Call(method, Expression.MakeIndex(null!, typeof(BaseStaticContainer).GetProperty(nameof(BaseStaticContainer.Indexer))!, Array.Empty<Expression>())));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        BaseStaticContainer.Indexer = new Base { Prop = 0 };
        func();
        Assert.Equal(1, BaseStaticContainer.Indexer.Prop);
    }

    public class Base
    {
        public int Prop { get; set; }

        public static void Go(ref Base b)
        {
            ++b.Prop;
        }
    }

    public class Derived : Base
    {
    }

    public class DerivedContainer
    {
        public Derived Item { get; set; }

        public Derived Get() => Item;
    }

    public class GetOnlyIndexer
    {
        public Base Value { get; set; }
        public Base this[int i] => Value;
    }

    public class BaseStaticContainer
    {
        public static Base Value { get; set; }
        public static Base Indexer { get; set; }
    }

    [Fact]
    public void LabelWithVoidTarget_TriggersLambdaCompilerEmitLambdaCompilerEmitLabelExpression_TargetTypeVoidBranch()
    {
        var target = Expression.Label(typeof(void));
        var param = Expression.Parameter(typeof(CallNotifier));
        var expr = Expression.Lambda<Action<CallNotifier>>(Expression.Block(
            Expression.Label(target, Expression.Call(param, typeof(CallNotifier).GetMethod(nameof(CallNotifier.Call))!))
        ), param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var notifier = new CallNotifier();
        func(notifier);
        Assert.True(notifier.Called);
    }

    public class CallNotifier
    {
        public bool Called { get; private set; }

        public int Call()
        {
            Called = true;
            return 1;
        }
    }

    [Fact]
    public void LabelWithNonReturnTypeInTailCallLambda_TriggersLambdaCompilerEmitGotoExpression_NonTailCallBranch()
    {
        var target = Expression.Label(typeof(int));
        var expr = Expression.Lambda<Action>(
            Expression.Block(
                Expression.Return(target, Expression.Constant(1)),
                Expression.Label(target, Expression.Constant(0))),
            true);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        func();
    }

    [Fact]
    public void StackSpilledExpressionInSwitchCase_TriggersLambdaCompilerDefineBlockLabels_SpilledExpressionBlockBranch()
    {
        var param = Expression.Parameter(typeof(int));
        var expr = Expression.Lambda<Func<int, int>>(
            Expression.Switch(
                param,
                Expression.Add(Expression.Constant(1), Expression.TryFinally(Expression.Constant(2), Expression.Empty())),
                Expression.SwitchCase(
                    Expression.Add(Expression.Constant(1), Expression.TryFinally(Expression.Constant(4), Expression.Empty())),
                    Expression.Constant(0))),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(5, func(0));
        Assert.Equal(3, func(1));
    }

    [Fact]
    public void LabelOutsideBlock_TriggersLambdaCompilerEmitLabelExpression_DefineLabelWithoutThrowingException()
    {
        var label = Expression.Label("lbl");
        var expr = Expression.Lambda<Action>(
            Expression.Label(label));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        func();
    }

    [Fact]
    public void Varargs_TriggersLambdaCompiler_EmitMethodCall_VarargsBranch()
    {
        var method = typeof(VarargsMethod).GetMethod(nameof(VarargsMethod.Call), BindingFlags.Public | BindingFlags.Static)!;
        var expr = Expression.Lambda<Action>(
            Expression.Call(
                method,
                Expression.Constant(0)));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var e = Assert.Throws<InvalidProgramException>(() => func());
        Assert.Equal("Vararg calling convention not supported.", e.Message);
    }

    public class VarargsMethod
    {
        public static void Call(int _, __arglist)
        {
        }
    }

    [Fact]
    public void DynamicExpression_TriggersLambdaCompiler_EmitDynamicExpression()
    {
        var expr = Expression.Lambda<Action>(
            new WeirdDynamicExpression());
        var e = Assert.Throws<NotSupportedException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
        Assert.Equal("Dynamic expressions are not supported by CompileToMethod. Instead, create an expression tree that uses System.Runtime.CompilerServices.CallSite.", e.Message);
    }

    [Fact]
    public void DynamicExpressionWithArguments_TriggersStackSpiller_RewriteDynamicExpression()
    {
        var expr = Expression.Lambda<Action>(
            new WeirdDynamicExpression(
                Expression.TryFinally(Expression.Constant(1), Expression.Empty())));
        var e = Assert.Throws<NotSupportedException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
        Assert.Equal("Dynamic expressions are not supported by CompileToMethod. Instead, create an expression tree that uses System.Runtime.CompilerServices.CallSite.", e.Message);
    }

    public class WeirdDynamicExpression : Expression, IDynamicExpression
    {
        private readonly Expression[] _arguments;

        public WeirdDynamicExpression(params Expression[] arguments) => _arguments = arguments;

        public override ExpressionType NodeType => ExpressionType.Dynamic;
        public override Type Type => typeof(void);
        public override bool CanReduce => true;
        public override Expression Reduce() => Expression.Block();
        public Expression GetArgument(int index) => _arguments[index];
        public int ArgumentCount => _arguments.Length;
        public object CreateCallSite() => this;
        public Expression Rewrite(Expression[] args) => this;
        public Type DelegateType => typeof(Action);
    }

    [Fact]
    public void AndAlsoWithDerivedType_TriggersTypeExtensions_GetAnyStaticMethodValidated_FalseBranch()
    {
        var param1 = Expression.Parameter(typeof(DerivedBoolOps1));
        var param2 = Expression.Parameter(typeof(DerivedBoolOps1));
        var expr = Expression.Lambda<Func<DerivedBoolOps1, DerivedBoolOps1, DerivedBoolOps1>>(
            Expression.AndAlso(
                param1,
                param2,
                typeof(DerivedBoolOps1).GetMethod(nameof(DerivedBoolOps1.And))),
            param1, param2);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.True(func(new DerivedBoolOps1(true), new DerivedBoolOps1(true)).Value);
        Assert.False(func(new DerivedBoolOps1(true), new DerivedBoolOps1(false)).Value);
        Assert.False(func(new DerivedBoolOps1(false), new DerivedBoolOps1(true)).Value);
        Assert.False(func(new DerivedBoolOps1(false), new DerivedBoolOps1(false)).Value);
    }

    [Fact]
    public void AndAlsoWithDerivedType_TriggersTypeUtils_GetBooleanOperator_NonSpecialNameBranch()
    {
        var param1 = Expression.Parameter(typeof(DerivedBoolOps2));
        var param2 = Expression.Parameter(typeof(DerivedBoolOps2));
        var expr = Expression.Lambda<Func<DerivedBoolOps2, DerivedBoolOps2, DerivedBoolOps2>>(
            Expression.AndAlso(
                param1,
                param2,
                typeof(DerivedBoolOps2).GetMethod(nameof(DerivedBoolOps2.And))),
            param1, param2);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.True(func(new DerivedBoolOps2(true), new DerivedBoolOps2(true)).Value);
        Assert.False(func(new DerivedBoolOps2(true), new DerivedBoolOps2(false)).Value);
        Assert.False(func(new DerivedBoolOps2(false), new DerivedBoolOps2(true)).Value);
        Assert.False(func(new DerivedBoolOps2(false), new DerivedBoolOps2(false)).Value);
    }

    [Fact]
    public void AndAlsoWithDerivedType_TriggersTypeUtils_GetBooleanOperator_GenericParametersBranch()
    {
        var param1 = Expression.Parameter(typeof(DerivedBoolOps3));
        var param2 = Expression.Parameter(typeof(DerivedBoolOps3));
        var expr = Expression.Lambda<Func<DerivedBoolOps3, DerivedBoolOps3, DerivedBoolOps3>>(
            Expression.AndAlso(
                param1,
                param2,
                typeof(DerivedBoolOps3).GetMethod(nameof(DerivedBoolOps3.And))),
            param1, param2);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.True(func(new DerivedBoolOps3(true), new DerivedBoolOps3(true)).Value);
        Assert.False(func(new DerivedBoolOps3(true), new DerivedBoolOps3(false)).Value);
        Assert.False(func(new DerivedBoolOps3(false), new DerivedBoolOps3(true)).Value);
        Assert.False(func(new DerivedBoolOps3(false), new DerivedBoolOps3(false)).Value);
    }

    public class BaseBoolOps
    {
        public bool Value { get; }

        public BaseBoolOps(bool value) => Value = value;

        public static bool operator false(BaseBoolOps ops) => !ops.Value;
        public static bool operator true(BaseBoolOps ops) => ops.Value;
    }

    public class DerivedBoolOps1 : BaseBoolOps
    {
        public DerivedBoolOps1(bool value) : base(value) {}
        public static DerivedBoolOps1 And(DerivedBoolOps1 first, DerivedBoolOps1 second) => new DerivedBoolOps1(first.Value && second.Value);
    }

    public class DerivedBoolOps2 : BaseBoolOps
    {
        public DerivedBoolOps2(bool value) : base(value) {}
        public static bool op_False(DerivedBoolOps2 x) => !x.Value;
        public static bool op_True(DerivedBoolOps2 x) => x.Value;
        public static DerivedBoolOps2 And(DerivedBoolOps2 first, DerivedBoolOps2 second) => new DerivedBoolOps2(first.Value && second.Value);
    }

    public class DerivedBoolOps3 : BaseBoolOps
    {
        public DerivedBoolOps3(bool value) : base(value) {}
        public static bool op_False<T>(DerivedBoolOps3 x) => !x.Value;
        public static bool op_True<T>(DerivedBoolOps3 x) => x.Value;
        public static DerivedBoolOps3 And(DerivedBoolOps3 first, DerivedBoolOps3 second) => new DerivedBoolOps3(first.Value && second.Value);
    }

    [Fact]
    public void SwitchWithByRefComparison_TriggersTypeUtils_GetNonRefType_ByRefBranch()
    {
        var param = Expression.Parameter(typeof(int));
        var expr = Expression.Lambda<Func<int, int>>(
            Expression.Switch(
                param,
                Expression.Constant(0),
                typeof(NonTestClass).GetMethod(nameof(NonTestClass.SwitchByRefWithinTen)),
                Expression.SwitchCase(Expression.Constant(10), Expression.Constant(10)),
                Expression.SwitchCase(Expression.Constant(20), Expression.Constant(20))),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(10, func(11));
        Assert.Equal(20, func(21));
        Assert.Equal(0, func(31));
    }

    [Fact]
    public void CastDelegates_TriggersTypeUtils_HasReferenceConversionTo_SourceAssignableFromDestBranch()
    {
        var param = Expression.Parameter(typeof(Func<object>));
        var expr = Expression.Lambda<Func<Func<object>, Func<string>>>(
            Expression.Convert(param, typeof(Func<string>)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Func<string> f = () => "";
        Assert.Same(f, func(f));
    }

    public interface IInterface
    {
    }

    public class NonImplementingBase
    {
    }

    public class ImplementingDerived : NonImplementingBase, IInterface
    {
    }

    [Fact]
    public void CastDelegates_TriggersTypeUtils_HasReferenceConversionTo_InterfaceCastBranch1()
    {
        var param = Expression.Parameter(typeof(Func<IInterface>));
        var expr = Expression.Lambda<Func<Func<IInterface>, Func<NonImplementingBase>>>(
            Expression.Convert(param, typeof(Func<NonImplementingBase>)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Func<ImplementingDerived> f = () => new ImplementingDerived();
        Assert.Same(f, func(f));
    }

    [Fact]
    public void CastDelegates_TriggersTypeUtils_HasReferenceConversionTo_InterfaceCastBranch2()
    {
        var param = Expression.Parameter(typeof(Func<NonImplementingBase>));
        var expr = Expression.Lambda<Func<Func<NonImplementingBase>, Func<IInterface>>>(
            Expression.Convert(param, typeof(Func<IInterface>)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Func<ImplementingDerived> f = () => new ImplementingDerived();
        Assert.Same(f, func(f));
    }

    [Fact]
    public void CastDelegates_TriggersTypeUtils_HasReferenceConversionTo_DelegateCastBranch()
    {
        var param = Expression.Parameter(typeof(Func<Func<IInterface>>));
        var expr = Expression.Lambda<Func<Func<Func<IInterface>>, Func<Func<NonImplementingBase>>>>(
            Expression.Convert(param, typeof(Func<Func<NonImplementingBase>>)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Func<Func<ImplementingDerived>> f = () => () => new ImplementingDerived();
        Assert.Same(f, func(f));
    }

    [Fact]
    public void CastDelegates_TriggersTypeUtils_StrictHasReferenceConversionTo_SourceInterfaceBranch()
    {
        var param = Expression.Parameter(typeof(Func<IInterface[]>));
        var expr = Expression.Lambda<Func<Func<IInterface[]>, Func<NonImplementingBase[]>>>(
            Expression.Convert(param, typeof(Func<NonImplementingBase[]>)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Func<ImplementingDerived[]> f = () => Array.Empty<ImplementingDerived>();
        Assert.Same(f, func(f));
    }

    [Fact]
    public void CastDelegates_TriggersTypeUtils_StrictHasReferenceConversionTo_DestinationInterfaceBranch()
    {
        var param = Expression.Parameter(typeof(Func<NonImplementingBase[]>));
        var expr = Expression.Lambda<Func<Func<NonImplementingBase[]>, Func<IInterface[]>>>(
            Expression.Convert(param, typeof(Func<IInterface[]>)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Func<ImplementingDerived[]> f = () => Array.Empty<ImplementingDerived>();
        Assert.Same(f, func(f));
    }

    [Fact]
    public void CastDelegates_TriggersTypeUtils_StrictHasReferenceConversionTo_SecondLoopIterationBranch()
    {
        var param = Expression.Parameter(typeof(Func<IInterface[][]>));
        var expr = Expression.Lambda<Func<Func<IInterface[][]>, Func<NonImplementingBase[][]>>>(
            Expression.Convert(param, typeof(Func<NonImplementingBase[][]>)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Func<ImplementingDerived[][]> f = () => Array.Empty<ImplementingDerived[]>();
        Assert.Same(f, func(f));
    }

    [Fact]
    public void CastDelegates_TriggersTypeUtils_StrictHasReferenceConversionTo_HasInterfaceToArrayConversionBranch()
    {
        var param = Expression.Parameter(typeof(Func<IEnumerable<IInterface>[]>));
        var expr = Expression.Lambda<Func<Func<IEnumerable<IInterface>[]>, Func<NonImplementingBase[][]>>>(
            Expression.Convert(param, typeof(Func<NonImplementingBase[][]>)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Func<ImplementingDerived[][]> f = () => Array.Empty<ImplementingDerived[]>();
        Assert.Same(f, func(f));
    }

    [Fact]
    public void CastDelegates_TriggersTypeUtils_StrictHasReferenceConversionTo_HasArrayToInterfaceConversionBranch()
    {
        var param = Expression.Parameter(typeof(Func<IInterface[][]>));
        var expr = Expression.Lambda<Func<Func<IInterface[][]>, Func<IEnumerable<NonImplementingBase>[]>>>(
            Expression.Convert(param, typeof(Func<IEnumerable<NonImplementingBase>[]>)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Func<ImplementingDerived[][]> f = () => Array.Empty<ImplementingDerived[]>();
        Assert.Same(f, func(f));
    }

    [Fact]
    public void CastDelegates_TriggersTypeUtils_StrictHasReferenceConversionTo_DelegateConversionBranch()
    {
        var param = Expression.Parameter(typeof(Func<Func<IInterface>[]>));
        var expr = Expression.Lambda<Func<Func<Func<IInterface>[]>, Func<Func<NonImplementingBase>[]>>>(
            Expression.Convert(param, typeof(Func<Func<NonImplementingBase>[]>)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Func<Func<ImplementingDerived>[]> f = () => Array.Empty<Func<ImplementingDerived>>();
        Assert.Same(f, func(f));
    }

    [Fact]
    public void CallCollectibleMethod_TriggersTypeExtensions_GetParametersCached_IsCollectibleBranch()
    {
        var assembly = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("Collectible"), AssemblyBuilderAccess.RunAndCollect);
        var module = assembly.DefineDynamicModule("Collectible");
        var calledTypeBuilder = module.DefineType("C", TypeAttributes.Class | TypeAttributes.Public);
        var calledMethodBuilder = calledTypeBuilder.DefineMethod("M", MethodAttributes.Public | MethodAttributes.Static, typeof(int), Type.EmptyTypes);
        var ilg = calledMethodBuilder.GetILGenerator();
        ilg.Emit(OpCodes.Ldc_I4_1);
        ilg.Emit(OpCodes.Ret);
        var typeBuilder = module.DefineType("T", TypeAttributes.Class | TypeAttributes.Public);
        var methodBuilder = typeBuilder.DefineMethod("M", MethodAttributes.Public | MethodAttributes.Static);
        var called = calledTypeBuilder.CreateType().GetMethod("M");
        var expr = Expression.Lambda<Func<int>>(Expression.Call(called!));
        expr.CompileToMethod(methodBuilder);
        var type = typeBuilder.CreateType();
        var result = type.GetMethod("M")!.Invoke(null, Array.Empty<object>());
        Assert.Equal(1, result);
    }

    [Fact]
    public void BlockWithUnmergedScopeAndHoistedVars_TriggersLocalBoxStorage_FreeLocal()
    {
        var x = Expression.Parameter(typeof(int));
        var f = Expression.Parameter(typeof(Func<int>));

        var e = Expression.Lambda<Func<int, Func<int>>>(
            Expression.Block(
                new[] { f, x },
                Expression.Assign(x, Expression.Constant(1)),
                Expression.AddAssign(x, Expression.Constant(1)),
                Expression.AddAssign(x, Expression.Constant(1)),
                Expression.Lambda<Func<int>>(
                    Expression.MultiplyAssign(x, Expression.Constant(2))
                )
            ),
            x
        );

        Func<int, Func<int>> d = e.Compile(CompilationType.CompileToMethod, withoutVisitor: true);

        Func<int> i = d(1);

        Assert.Equal(6, i());
        Assert.Equal(12, i());
    }

    [Fact]
    public void UseByRefVariableInInnerLambda_TriggersVariableBinder_Reference_CannotCloseOverByRefBranch()
    {
        var param = Expression.Parameter(typeof(int).MakeByRefType(), "byref");
        var expr = Expression.Lambda<TakeIntByRefReturnDelegate>(
            Expression.Lambda<Action>(
                Expression.AddAssign(param, Expression.Constant(1)),
                name: "inner",
                parameters: Array.Empty<ParameterExpression>()),
            name: "outer",
            new[] { param });
        var e = Assert.Throws<InvalidOperationException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
        Assert.Equal("Cannot close over byref parameter 'byref' referenced in lambda 'inner'", e.Message);
    }

    public delegate Action TakeIntByRefReturnDelegate(ref int x);

    [Fact]
    public void NamedInnerLambda_NamesMethodInTypeBuilder()
    {
        var curr = Expression.Parameter(typeof(int));
        var expr = Expression.Lambda<Func<Func<int>>>(
            Expression.Block(new[] { curr }, new Expression[]
            {
                Expression.Assign(curr, Expression.Constant(0)),
                Expression.Lambda<Func<int>>(Expression.AddAssign(curr, Expression.Constant(1)), "inner", Array.Empty<ParameterExpression>()),
            }));
        var assemblyName = new AssemblyName("CompiledExpressions_NamedInnerLambda");
        var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
        var moduleBuilder = assemblyBuilder.DefineDynamicModule("CompiledExpressions");
        var typeBuilder = moduleBuilder.DefineType("C");
        var methodBuilder = typeBuilder.DefineMethod("M", MethodAttributes.Public | MethodAttributes.Static);
        expr.CompileToMethod(methodBuilder);
        var type = typeBuilder.CreateType();
        Assert.NotNull(type.GetMethod("inner", BindingFlags.NonPublic | BindingFlags.Static));
        var act1 = (Func<int>)type.GetMethod("M")!.Invoke(null, Array.Empty<object>());
        Assert.NotNull(act1);
        Assert.Equal(1, act1());
        Assert.Equal(2, act1());
        var act2 = (Func<int>)type.GetMethod("M")!.Invoke(null, Array.Empty<object>());
        Assert.NotNull(act2);
        Assert.Equal(1, act2());
        Assert.Equal(2, act2());
    }

    [Fact]
    public void UnoptimizableSwitchWithoutDefault_TriggersLambdaCompiler_EmitSwitchExpression_NoDefaultLabelBranch()
    {
        var param = Expression.Parameter(typeof(int));
        var expr = Expression.Lambda<Func<int, int>>(
            Expression.Block(
                Expression.Switch(
                    param,
                    defaultBody: null,
                    comparison: typeof(NonTestClass).GetMethod(nameof(NonTestClass.Compare), BindingFlags.Public | BindingFlags.Static),
                    Expression.SwitchCase(
                        Expression.Block(Expression.Assign(param, Expression.Constant(1)), Expression.Empty()),
                        Expression.Constant(0))),
                param),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(1, func(0));
        Assert.Equal(1, func(1));
        Assert.Equal(2, func(2));
    }

    [Fact]
    public void DebugInfoExpression_TriggersLambdaCompiler_EmitExpressionNopBranch()
    {
        var expr = Expression.Lambda<Func<int>>(
            Expression.Block(
                Expression.DebugInfo(Expression.SymbolDocument("file"), 1, 2, 3, 4),
                Expression.Constant(1)));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(1, func());
    }

    [Fact]
    public void VarArgsProperty_TriggersLambdaCompiler_EmitCall_UnexpectedVarArgsCall()
    {
        var assemblyName = new AssemblyName("CompiledExpressions_VarArgsProp");
        var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
        var moduleBuilder = assemblyBuilder.DefineDynamicModule("CompiledExpressions");
        var typeBuilder = moduleBuilder.DefineType("C");
        var propBuilder = typeBuilder.DefineProperty("P", PropertyAttributes.None, CallingConventions.VarArgs, typeof(int), Type.EmptyTypes);
        var methodBuilder = typeBuilder.DefineMethod("get_P", MethodAttributes.Public | MethodAttributes.Static, CallingConventions.VarArgs, typeof(int), Type.EmptyTypes);
        propBuilder.SetGetMethod(methodBuilder);
        var ilg = methodBuilder.GetILGenerator();
        ilg.Emit(OpCodes.Ldc_I4_1);
        ilg.Emit(OpCodes.Ret);
        var type = typeBuilder.CreateType();

        var expr = Expression.Lambda<Func<int>>(
            Expression.Property(null, type.GetProperty("P")!));
        var e = Assert.Throws<InvalidOperationException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
        Assert.Equal("Unexpected VarArgs call to method 'Int32 get_P(...)'", e.Message);
    }

    [Fact]
    public void LabelWithLabelValue_TriggersLambdaCompiler_TryPushLabelBlock_BlockParentNotContainingLabelBranch()
    {
        var expr = Expression.Lambda<Func<int>>(
            Expression.Block(
                Expression.Label(
                    Expression.Label(typeof(int)),
                    Expression.Label(
                        Expression.Label(typeof(int)),
                        Expression.Constant(1)))));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(1, func());
    }

    [Fact]
    public void SpilledInitializerOfValueTypePropertyMember_TriggersStackSpiller_RequireNoValueProperty()
    {
        var expr = Expression.Lambda<Func<Outer>>(
            Expression.MemberInit(
                Expression.New(typeof(Outer)),
                Expression.MemberBind(
                    typeof(Outer).GetProperty(nameof(Outer.InnerProp))!,
                    Expression.Bind(
                        typeof(Inner).GetField(nameof(Inner.Value))!,
                        Expression.TryFinally(
                            Expression.Constant(1),
                            Expression.Empty())))));
        var e = Assert.Throws<InvalidOperationException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
        Assert.Equal("Cannot auto initialize members of value type through property 'Inner InnerProp', use assignment instead", e.Message);
    }

    [Fact]
    public void SpilledInitializerOfValueTypePropertyList_TriggersStackSpiller_RequireNoValueProperty()
    {
        var expr = Expression.Lambda<Func<Outer>>(
            Expression.MemberInit(
                Expression.New(typeof(Outer)),
                Expression.ListBind(
                    typeof(Outer).GetProperty(nameof(Outer.CollectionStructProperty))!,
                    Expression.ElementInit(
                        typeof(CollectionStruct).GetMethod(nameof(CollectionStruct.Add), new[] { typeof(object) })!,
                        Expression.TryFinally(
                            Expression.New(typeof(object)),
                            Expression.Empty())))));
        var e = Assert.Throws<InvalidOperationException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
        Assert.Equal("Cannot auto initialize members of value type through property 'CollectionStruct CollectionStructProperty', use assignment instead", e.Message);
    }

    [Fact]
    public void SpilledInitializerOfValueTypeFieldMember_TriggersStackSpiller_RequireNoValueProperty_FieldBranch()
    {
        var expr = Expression.Lambda<Func<Outer>>(
            Expression.MemberInit(
                Expression.New(typeof(Outer)),
                Expression.MemberBind(
                    typeof(Outer).GetField(nameof(Outer.Inner))!,
                    Expression.Bind(
                        typeof(Inner).GetField(nameof(Inner.Value))!,
                        Expression.TryFinally(
                            Expression.Constant(1),
                            Expression.Empty())))));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(1, func().Inner.Value);
    }

    [Fact]
    public void SpilledInitializerOfValueTypeFieldList_TriggersStackSpiller_RequireNoValueProperty_FieldBranch()
    {
        var expr = Expression.Lambda<Func<Outer>>(
            Expression.MemberInit(
                Expression.New(typeof(Outer)),
                Expression.ListBind(
                    typeof(Outer).GetField(nameof(Outer.CollectionStructField))!,
                    Expression.ElementInit(
                        typeof(CollectionStruct).GetMethod(nameof(CollectionStruct.Add), new[] { typeof(object) })!,
                        Expression.New(typeof(object))))));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.NotNull(func().CollectionStructField.Object);
    }

    [Fact]
    public void SpilledInitializerOfValueTypeFieldListWithValueTypeElement_TriggersStackSpiller_ListBindingRewriter_AsExpression_ValueTypeBranch()
    {
        var expr = Expression.Lambda<Func<Outer>>(
            Expression.MemberInit(
                Expression.New(typeof(Outer)),
                Expression.ListBind(
                    typeof(Outer).GetField(nameof(Outer.CollectionStructField))!,
                    Expression.ElementInit(
                        typeof(CollectionStruct).GetMethod(nameof(CollectionStruct.Add), new[] { typeof(int) })!,
                        Expression.TryFinally(
                            Expression.Constant(1),
                            Expression.Empty())))));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(1, func().CollectionStructField.Object);
    }

    [Fact]
    public void CopiedMemberInitWithIntactMemberMemberBinding_TriggersStackSpiller_MemberMemberBindingRewriter_AsBinding_IntactBranch()
    {
        var expr = Expression.Lambda<Func<Outer>>(
            Expression.MemberInit(
                Expression.New(typeof(Outer)),
                Expression.Bind(typeof(Outer).GetField(nameof(Outer.Int))!, new Extension(Expression.Constant(2))),
                Expression.MemberBind(
                    typeof(Outer).GetField(nameof(Outer.Inner))!,
                    Expression.Bind(
                        typeof(Inner).GetField(nameof(Inner.Value))!,
                        Expression.Constant(1)))));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var obj = func();
        Assert.Equal(2, obj.Int);
        Assert.Equal(1, obj.Inner.Value);
    }

    [Fact]
    public void CopiedMemberInitWithIntactListMemberBinding_TriggersStackSpiller_ListMemberBindingRewriter_AsBinding_IntactBranch()
    {
        var expr = Expression.Lambda<Func<Outer>>(
            Expression.MemberInit(
                Expression.New(typeof(Outer)),
                Expression.Bind(typeof(Outer).GetField(nameof(Outer.Int))!, new Extension(Expression.Constant(1))),
                Expression.ListBind(
                    typeof(Outer).GetField(nameof(Outer.CollectionStructField))!,
                    Expression.ElementInit(
                        typeof(CollectionStruct).GetMethod(nameof(CollectionStruct.Add), new[] { typeof(object) })!,
                        Expression.New(typeof(object))))));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var obj = func();
        Assert.Equal(1, obj.Int);
        Assert.NotNull(obj.CollectionStructField.Object);
    }

    class Extension : Expression
    {
        private readonly Expression _reduced;

        public Extension(Expression reduced) => _reduced = reduced;

        public override bool CanReduce => true;
        public override ExpressionType NodeType => ExpressionType.Extension;
        public override Type Type => _reduced.Type;
        public override Expression Reduce() => _reduced;
    }

    [Fact]
    public void SpilledMethodCallWithInstanceFieldAccessArgument_TriggersStackSpiller_ChildRewriter_ShouldSaveToTemp_NoOptimizationBranch()
    {
        var param = Expression.Parameter(typeof(ClassWithFields));
        var expr = Expression.Lambda<Func<ClassWithFields, int>>(
            Expression.Call(
                typeof(ClassWithFields).GetMethod(nameof(ClassWithFields.Add), BindingFlags.Public | BindingFlags.Static)!,
                Expression.Field(param, typeof(ClassWithFields).GetField(nameof(ClassWithFields.InstanceInt))!),
                Expression.TryFinally(
                    Expression.Call(param, typeof(ClassWithFields).GetMethod(nameof(ClassWithFields.GetInstance))!),
                    Expression.Empty())
            ),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(3, func(new ClassWithFields { InstanceInt = 1 }));
    }

    [Fact]
    public void SpilledMethodCallWithStaticWriteableFieldAccessArgument_TriggersStackSpiller_ChildRewriter_ShouldSaveToTemp_NoOptimizationBranch()
    {
        var expr = Expression.Lambda<Func<int>>(
            Expression.Call(
                typeof(ClassWithFields).GetMethod(nameof(ClassWithFields.Add), BindingFlags.Public | BindingFlags.Static)!,
                Expression.Field(null, typeof(ClassWithFields).GetField(nameof(ClassWithFields.StaticInt))!),
                Expression.TryFinally(
                    Expression.Call(typeof(ClassWithFields).GetMethod(nameof(ClassWithFields.GetStatic))!),
                    Expression.Empty())
            ));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        ClassWithFields.StaticInt = 1;
        Assert.Equal(3, func());
    }

    [Fact]
    public void SpilledMethodCallWithInstanceReadonlyFieldAccessArgument_TriggersStackSpiller_ChildRewriter_ShouldSaveToTemp_NoOptimizationBranch()
    {
        var param = Expression.Parameter(typeof(ClassWithFields));
        var expr = Expression.Lambda<Func<ClassWithFields, int>>(
            Expression.Call(
                typeof(ClassWithFields).GetMethod(nameof(ClassWithFields.Add), BindingFlags.Public | BindingFlags.Static)!,
                Expression.Field(param, typeof(ClassWithFields).GetField(nameof(ClassWithFields.InstanceReadonlyInt))!),
                Expression.TryFinally(
                    Expression.Call(param, typeof(ClassWithFields).GetMethod(nameof(ClassWithFields.GetInstance))!),
                    Expression.Empty())
            ),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(3, func(new ClassWithFields { InstanceInt = 1 }));
    }

    public class ClassWithFields
    {
        public static int StaticInt;
        public int InstanceInt;
        public readonly int InstanceReadonlyInt = 1;

        public static int Add(int x, int y) => x + y;
        public int GetInstance() => ++InstanceInt;
        public static int GetStatic() => ++StaticInt;
    }

    [Fact]
    public void StackSpilledSwitchWithTwoTestValues_TriggersStackSpiller_RewriteSwitchExpression_CopyBecausePreviousCopiedBranch()
    {
        var param = Expression.Parameter(typeof(int));
        var expr = Expression.Lambda<Func<int, int>>(
            Expression.Add(
                Expression.Constant(1),
                Expression.Switch(
                    param,
                    Expression.Constant(2),
                    Expression.SwitchCase(
                        Expression.Constant(4),
                        Expression.TryFinally(Expression.Constant(40), Expression.Empty()),
                        Expression.TryFinally(Expression.Constant(41), Expression.Empty())))),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(3, func(0));
        Assert.Equal(5, func(40));
        Assert.Equal(5, func(41));
    }

    [Fact]
    public void StackSpilledTypeBinaryExpression_TriggersStackSpiller_RewriteTypeBinaryExpression_RewriteActionNotNoneBranch()
    {
        var param1 = Expression.Parameter(typeof(bool));
        var param2 = Expression.Parameter(typeof(object));
        var expr = Expression.Lambda<Func<bool, object, bool>>(
            Expression.And(
                param1,
                Expression.TypeEqual(Expression.TryFinally(param2, Expression.Empty()), typeof(string))),
            param1, param2);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.False(func(false, 1));
        Assert.False(func(false, "1"));
        Assert.False(func(true, 1));
        Assert.True(func(true, "1"));
    }

    [Fact]
    public void StackSpilledMemberExpression_TriggersStackSpiller_RewriteMemberExpression_CheckNotRefInstanceBranch_ClassProperty()
    {
        var param = Expression.Parameter(typeof(ClassWithMembers));
        var expr = Expression.Lambda<Func<ClassWithMembers, int>>(
            Expression.Add(
                Expression.Constant(1),
                Expression.Property(
                    Expression.TryFinally(param, Expression.Empty()),
                    nameof(ClassWithMembers.Prop))),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(3, func(new ClassWithMembers { Prop = 2 }));
    }

    [Fact]
    public void StackSpilledMemberExpression_TriggersStackSpiller_RewriteMemberExpression_CheckNotRefInstanceBranch_ClassField()
    {
        var param = Expression.Parameter(typeof(ClassWithMembers));
        var expr = Expression.Lambda<Func<ClassWithMembers, int>>(
            Expression.Add(
                Expression.Constant(1),
                Expression.Field(
                    Expression.TryFinally(param, Expression.Empty()),
                    nameof(ClassWithMembers.Field))),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(3, func(new ClassWithMembers { Field = 2 }));
    }

    [Fact]
    public void StackSpilledMemberExpression_TriggersStackSpiller_RewriteMemberExpression_CheckNotRefInstanceBranch_StructProperty()
    {
        var param = Expression.Parameter(typeof(StructWithMembers));
        var expr = Expression.Lambda<Func<StructWithMembers, int>>(
            Expression.Add(
                Expression.Constant(1),
                Expression.Property(
                    Expression.TryFinally(param, Expression.Empty()),
                    nameof(StructWithMembers.Prop))),
            param);
        var e = Assert.Throws<NotSupportedException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
        Assert.Equal($"TryExpression is not supported as a child expression when accessing a member on type '{typeof(StructWithMembers)}' because it is a value type. Construct the tree so the TryExpression is not nested inside of this expression.", e.Message);
    }

    [Fact]
    public void StackSpilledMemberExpression_TriggersStackSpiller_RewriteMemberExpression_CheckNotRefInstanceBranch_StructField()
    {
        var param = Expression.Parameter(typeof(StructWithMembers));
        var expr = Expression.Lambda<Func<StructWithMembers, int>>(
            Expression.Add(
                Expression.Constant(1),
                Expression.Field(
                    Expression.TryFinally(param, Expression.Empty()),
                    nameof(StructWithMembers.Field))),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(3, func(new StructWithMembers { Field = 2 }));
    }

    public class ClassWithMembers
    {
        public int Prop { get; set; }
        public int Field;
    }
    public struct StructWithMembers
    {
        public int Prop { get; set; }
        public int Field;
    }

    [Fact]
    public void ExtensionAssignment_TriggersStackSpiller_RewriteAssignBinaryExpression_ExtensionAssignmentBranch()
    {
        var param = Expression.Parameter(typeof(ClassWithMembers));
        var expr = Expression.Lambda<Action<ClassWithMembers>>(
            Expression.Assign(
                new AssignableExtension(
                    Expression.Field(param, nameof(ClassWithMembers.Field))),
                Expression.Constant(1)),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        var instance = new ClassWithMembers();
        func(instance);
        Assert.Equal(1, instance.Field);
    }

    [Fact]
    public void ExtensionAssignment_TriggersStackSpiller_RewriteAssignBinaryExpression_InvalidLvalueBranch()
    {
        var param = Expression.Parameter(typeof(ClassWithMembers));
        var expr = Expression.Lambda<Action<ClassWithMembers>>(
            Expression.Assign(
                new AssignableExtension(
                    Expression.Field(param, nameof(ClassWithMembers.Field)),
                    ExpressionType.Constant),
                Expression.Constant(1)),
            param);
        var e = Assert.Throws<InvalidOperationException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
        Assert.Equal("Invalid lvalue for assignment: Constant.", e.Message);
    }

    public class AssignableExtension : Expression
    {
        private readonly Expression _inner;
        private readonly ExpressionType _expressionType;

        public AssignableExtension(Expression inner, ExpressionType type = ExpressionType.Extension)
        {
            _inner = inner;
            _expressionType = type;
        }

        public override Expression Reduce() => _inner;
        public override bool CanReduce => true;
        public override Type Type => _inner.Type;
        public override ExpressionType NodeType
        {
            get
            {
                var frame = new StackFrame(1);
                return frame.GetMethod()?.Name == "RequiresCanWrite"
                    ? ExpressionType.Parameter
                    : _expressionType;
            }
        }
    }

    [Fact]
    public void SpilledBinaryExpressionWithByRefParam_TriggersStackSpiller_RequireNoRefArgs_ErrorBranch()
    {
        var param = Expression.Parameter(typeof(int));
        var expr = Expression.Lambda<Func<int, int>>(
            Expression.Add(
                Expression.Constant(1),
                Expression.TryFinally(param, Expression.Empty()),
                typeof(ByRefPlus).GetMethod(nameof(ByRefPlus.Plus), BindingFlags.Public | BindingFlags.Static)!),
            param);
        var e = Assert.Throws<NotSupportedException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
        Assert.Equal("TryExpression is not supported as an argument to method 'Int32 Plus(Int32 ByRef, Int32 ByRef)' because it has an argument with by-ref type. Construct the tree so the TryExpression is not nested inside of this expression.", e.Message);
    }

    [Fact]
    public void SpilledUnaryExpressionWithByRefParam_TriggersStackSpiller_RequireNoRefArgs_ErrorBranch()
    {
        var param = Expression.Parameter(typeof(int));
        var expr = Expression.Lambda<Func<int, int>>(
            Expression.Add(
                Expression.Constant(1),
                Expression.UnaryPlus(
                    Expression.TryFinally(param, Expression.Empty()),
                    typeof(ByRefPlus).GetMethod(nameof(ByRefPlus.UnaryPlus), BindingFlags.Public | BindingFlags.Static)!)),
            param);
        var e = Assert.Throws<NotSupportedException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
        Assert.Equal("TryExpression is not supported as an argument to method 'Int32 UnaryPlus(Int32 ByRef)' because it has an argument with by-ref type. Construct the tree so the TryExpression is not nested inside of this expression.", e.Message);
    }

    public class ByRefPlus
    {
        public static int UnaryPlus(ref int op1) => op1;
        public static int Plus(ref int op1, ref int op2) => op1 + op2;
    }

    [Fact]
    public void ConcretelyTypedExpressionInInvoke_TriggersFindGenericType_HierarchyBranch()
    {
        Expression<Func<int, int>> produce = x => x + 1;
        var param1 = Expression.Parameter(produce.GetType());
        var param2 = Expression.Parameter(typeof(int));
        var expr = Expression.Lambda(
            Expression.Add(
                Expression.Constant(1),
                Expression.Invoke(
                    param1,
                    Expression.TryFinally(param2, Expression.Empty()))),
            param1, param2);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(3, func.DynamicInvoke(produce, 1));
    }

    [Fact]
    public void SwitchWithNullableValueAndNullableComparison_Triggers_IsLifted_TypesEquivalentBranch()
    {
        var param = Expression.Parameter(typeof(int?));
        var expr = Expression.Lambda<Func<int?, int>>(
            Expression.Switch(
                param,
                Expression.Constant(0),
                typeof(NonTestClass).GetMethod(nameof(NonTestClass.WithinTenNullable))!,
                Expression.SwitchCase(
                    Expression.Constant(1),
                    Expression.Constant(10, typeof(int?))),
                Expression.SwitchCase(
                    Expression.Constant(2),
                    Expression.Constant(20, typeof(int?))),
                Expression.SwitchCase(
                    Expression.Constant(3),
                    Expression.Constant(null, typeof(int?)))),
            param);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(1, func(11));
        Assert.Equal(2, func(21));
        Assert.Equal(3, func(null));
        Assert.Equal(0, func(31));
    }

    [Fact]
    public void GenericParameterConstant()
    {
        var genericParam = typeof(List<>).GetGenericArguments()[0];
        var expr = Expression.Lambda<Func<Type>>(
            Expression.Constant(genericParam));
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Throws<BadImageFormatException>(() => func());
    }

    [Fact]
    public void TypeBuilderConstant()
    {
        var assembly = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("Collectible"), AssemblyBuilderAccess.RunAndCollect);
        var module = assembly.DefineDynamicModule("Collectible");
        var typeBuilder = module.DefineType("T", TypeAttributes.Class | TypeAttributes.NotPublic);
        var methodBuilder = typeBuilder.DefineMethod("M", MethodAttributes.Public | MethodAttributes.Static);
        var expr = Expression.Lambda<Func<Type>>(
            Expression.Constant(typeBuilder, typeof(Type)));
        expr.CompileToMethod(methodBuilder);

        var type = typeBuilder.CreateType();
        Assert.Equal(type, type.GetMethod("M")!.Invoke(null, Array.Empty<object>()));
    }

    [Fact]
    public void SymbolGeneration()
    {
        var symbolInfo = Expression.SymbolDocument("Expressions", SymLanguageType.CSharp);
        var param = Expression.Parameter(typeof(int), "p");
        var expr = Expression.Lambda<Func<int>>(
            Expression.Block(
                typeof(int),
                new[] { param },
                new Expression[]
                {
                    Expression.DebugInfo(symbolInfo, 1, 1, 1, 10),
                    Expression.Assign(param, Expression.Constant(1)),
                    Expression.ClearDebugInfo(symbolInfo),
                    Expression.ClearDebugInfo(symbolInfo),
                    Expression.PreIncrementAssign(param),
                    Expression.ClearDebugInfo(symbolInfo),
                    Expression.PreIncrementAssign(param),
                    Expression.DebugInfo(symbolInfo, 2, 1, 2, 10),
                    Expression.PreIncrementAssign(param),
                    Expression.DebugInfo(symbolInfo, 3, 1, 3, 10),
                    param,
                }));

        var assemblyName = new AssemblyName("SymbolGeneration");
        var assemblyBuilder = new PersistedAssemblyBuilder(assemblyName, typeof(object).Assembly);
        var moduleBuilder = assemblyBuilder.DefineDynamicModule("SymbolGeneration");
        var typeBuilder = moduleBuilder.DefineType("C");
        var methodBuilder = typeBuilder.DefineMethod("M", MethodAttributes.Public | MethodAttributes.Static);

        var symbolGenerator = new ExpressionDebugInfoGenerator(moduleBuilder);
        expr.CompileToMethod(methodBuilder, symbolGenerator);

        typeBuilder.CreateType();

        var mdb = assemblyBuilder.GenerateMetadata(out var il, out var fieldData, out var pdbMetadata);

        using var stream = new MemoryStream();
        var peHeaderBuilder = new PEHeaderBuilder(
            imageCharacteristics: Characteristics.ExecutableImage | Characteristics.Dll);
        var peBuilder = new ManagedPEBuilder(
            header: peHeaderBuilder,
            metadataRootBuilder: new MetadataRootBuilder(mdb),
            ilStream: il,
            mappedFieldData: fieldData,
            strongNameSignatureSize: 0);
        var peBlob = new BlobBuilder();
        peBuilder.Serialize(peBlob);
        peBlob.WriteContentTo(stream);
        stream.Seek(0, SeekOrigin.Begin);

        var assembly = AssemblyLoadContext.Default.LoadFromStream(stream);
        var method = assembly.GetType("C")!.GetMethod("M");

        using var sw = new StringWriter();
        var ilWriter = new ReadableILStringToTextWriter(sw);
        var ilProvider = new PersistedMethodBuilderILProvider(method);
        var ilReader = new ILReader(ilProvider, new ModuleScopeTokenResolver(method));
        ilReader.Accept(new ReadableILStringVisitor(ilWriter));
        var methodIl = sw.ToString();
        VerifyIL(methodIl, @"
            IL_0000: nop
            IL_0001: ldc.i4.1
            IL_0002: stloc.0
            IL_0003: nop
            IL_0004: ldloc.0
            IL_0005: ldc.i4.1
            IL_0006: add
            IL_0007: stloc.0
            IL_0008: ldloc.0
            IL_0009: ldc.i4.1
            IL_000a: add
            IL_000b: stloc.0
            IL_000c: nop
            IL_000d: ldloc.0
            IL_000e: ldc.i4.1
            IL_000f: add
            IL_0010: stloc.0
            IL_0011: nop
            IL_0012: ldloc.0
            IL_0013: ret
        ");

        var func = method!.CreateDelegate<Func<int>>();
        Assert.Equal(4, func());

        var portablePdbBlob = new BlobBuilder();
        var pdbBuilder = new PortablePdbBuilder(pdbMetadata, mdb.GetRowCounts(), default);
        pdbBuilder.Serialize(portablePdbBlob);
        using var pdbStream = new MemoryStream();
        portablePdbBlob.WriteContentTo(pdbStream);
        pdbStream.Seek(0, SeekOrigin.Begin);

        using var provider = MetadataReaderProvider.FromPortablePdbStream(pdbStream);
        var reader = provider.GetMetadataReader();
        var mdi = reader.GetMethodDebugInformation(MetadataTokens.MethodDebugInformationHandle(methodBuilder.MetadataToken));
        using var docEnumerator = reader.Documents.GetEnumerator();
        Assert.Equal(1, reader.Documents.Count);
        Assert.True(docEnumerator.MoveNext());
        var doc1 = reader.GetDocument(docEnumerator.Current);
        Assert.Equal(symbolInfo.FileName, reader.GetString(doc1.Name));
        Assert.Equal(symbolInfo.Language, reader.GetGuid(doc1.Language));
        Assert.False(docEnumerator.MoveNext());

        using var spcEnumerator = mdi.GetSequencePoints().GetEnumerator();
        Assert.True(spcEnumerator.MoveNext());
        var sp = spcEnumerator.Current;
        Assert.Equal(doc1, reader.GetDocument(sp.Document));
        Assert.Equal(1, sp.StartLine);
        Assert.False(sp.IsHidden);
        Assert.Equal(0x0, sp.Offset);
        Assert.Equal(1, sp.StartColumn);
        Assert.Equal(1, sp.EndLine);
        Assert.Equal(10, sp.EndColumn);
        Assert.True(spcEnumerator.MoveNext());
        sp = spcEnumerator.Current;
        Assert.True(sp.IsHidden);
        Assert.Equal(0x3, sp.Offset);
        Assert.True(spcEnumerator.MoveNext());
        sp = spcEnumerator.Current;
        Assert.Equal(doc1, reader.GetDocument(sp.Document));
        Assert.Equal(2, sp.StartLine);
        Assert.False(sp.IsHidden);
        Assert.Equal(0xc, sp.Offset);
        Assert.Equal(1, sp.StartColumn);
        Assert.Equal(2, sp.EndLine);
        Assert.Equal(10, sp.EndColumn);
        Assert.True(spcEnumerator.MoveNext());
        sp = spcEnumerator.Current;
        Assert.Equal(doc1, reader.GetDocument(sp.Document));
        Assert.Equal(3, sp.StartLine);
        Assert.False(sp.IsHidden);
        Assert.Equal(0x11, sp.Offset);
        Assert.Equal(1, sp.StartColumn);
        Assert.Equal(3, sp.EndLine);
        Assert.Equal(10, sp.EndColumn);
        Assert.False(spcEnumerator.MoveNext());

        using var localScopes = reader.GetLocalScopes(MetadataTokens.MethodDefinitionHandle(methodBuilder.MetadataToken)).GetEnumerator();
        Assert.True(localScopes.MoveNext());
        LocalScope localScope = reader.GetLocalScope(localScopes.Current);
        using var localEnumerator = localScope.GetLocalVariables().GetEnumerator();
        Assert.True(localEnumerator.MoveNext());
        Assert.Equal(param.Name, reader.GetString(reader.GetLocalVariable(localEnumerator.Current).Name));
        Assert.False(localScopes.MoveNext());


        static string Normalize(string s)
        {
            var normalizeRegex = new Regex(@"lambda_method[0-9]*");
            IEnumerable<string> lines =
                s
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .Where(line => !line.StartsWith("//"))
                .Select(beforeLambdaUniquifierRemoval => normalizeRegex.Replace(beforeLambdaUniquifierRemoval, "lambda_method"));
            return string.Join("\n", lines);
        }
        static void VerifyIL(string actual, string expected)
        {
            string nExpected = Normalize(expected);
            string nActual = Normalize(actual);
            try
            {
                Assert.Equal(nExpected, nActual);
            }
            catch (Exception xunit)
            {
                throw new Exception($"IL assertion failed. Expected (normalized):\n{nExpected}\n\nActual:\n{actual}", xunit);
            }
        }

    }

    [Fact]
    public void SymbolGeneration_InvalidModule()
    {
        var symbolInfo = Expression.SymbolDocument("Expressions", SymLanguageType.CSharp);
        var expr = Expression.Lambda<Func<int>>(
            Expression.Block(
                typeof(int),
                new Expression[]
                {
                    Expression.DebugInfo(symbolInfo, 1, 1, 1, 10),
                    Expression.Constant(1),
                }));

        var assemblyName = new AssemblyName("SymbolGeneration");
        var assemblyBuilder = new PersistedAssemblyBuilder(assemblyName, typeof(object).Assembly);
        var moduleBuilder = assemblyBuilder.DefineDynamicModule("SymbolGeneration");
        var typeBuilder = moduleBuilder.DefineType("C");
        var methodBuilder = typeBuilder.DefineMethod("M", MethodAttributes.Public | MethodAttributes.Static);
        var assemblyBuilder2 = new PersistedAssemblyBuilder(assemblyName, typeof(object).Assembly);
        var moduleBuilder2 = assemblyBuilder2.DefineDynamicModule("SymbolGeneration");

        var symbolGenerator = new ExpressionDebugInfoGenerator(moduleBuilder2);
        var e = Assert.Throws<InvalidOperationException>(() => expr.CompileToMethod(methodBuilder, symbolGenerator));
        Assert.Equal("Method is built on a module not corresponding to the debug info generator", e.Message);
    }
}
