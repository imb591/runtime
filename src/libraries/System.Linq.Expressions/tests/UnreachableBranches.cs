// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Linq.Expressions.Tests;
using System.Reflection;
using System.Reflection.Emit;
using Xunit;

namespace CompileToMethod.Tests;

public class UnreachableBranches
{
    [Fact]
    public void UnreachableBranchesInHacks()
    {
        var assemblyTypes = typeof(ExpressionExtensions).Assembly.GetTypes();
        var param = Expression.Parameter(typeof(Expression));

        var assignBinaryExpression = assemblyTypes.First(x => x.Name == "AssignBinaryExpression");
        var convertToAbe = Expression.Lambda<Func<Expression, object>>(Expression.Convert(Expression.Convert(param, assignBinaryExpression), typeof(object)), param).Compile(CompilationType.Compile);
        var e = Assert.Throws<InvalidCastException>(() => convertToAbe(param));
        Assert.Equal($"Unable to cast object of type {param.GetType()} to type {assignBinaryExpression}", e.Message);
        e = Assert.Throws<InvalidCastException>(() => convertToAbe(null!));
        Assert.Equal($"Unable to cast object of type  to type {assignBinaryExpression}", e.Message);

        var blockExpressionExt = assemblyTypes.First(x => x.Name == "BlockExpressionExt");
        var convertToBee = Expression.Lambda<Func<Expression, object>>(Expression.Convert(Expression.Convert(param, blockExpressionExt), typeof(object)), param).Compile(CompilationType.Compile);
        e = Assert.Throws<InvalidCastException>(() => convertToBee(param));
        Assert.Equal($"Unable to cast object of type {param.GetType()} to type {blockExpressionExt}", e.Message);
        e = Assert.Throws<InvalidCastException>(() => convertToBee(null!));
        Assert.Equal($"Unable to cast object of type  to type {blockExpressionExt}", e.Message);

        var byRefAssignBinaryExpression = assemblyTypes.First(x => x.Name == "ByRefAssignBinaryExpression");
        var brabeInstance = (Expression)Activator.CreateInstance(byRefAssignBinaryExpression,
            BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[] { param, param }, null, null);
        Assert.Equal(param.Type, brabeInstance?.Type);

        var parameterExpressionExt = assemblyTypes.First(x => x.Name == "ParameterExpressionExt");
        var convertToPee = Expression.Lambda<Func<Expression, object>>(Expression.Convert(Expression.Convert(param, parameterExpressionExt), typeof(object)), param).Compile(CompilationType.Compile);
        var def = Expression.Default(typeof(int));
        e = Assert.Throws<InvalidCastException>(() => convertToPee(def));
        Assert.Equal($"Unable to cast object of type {def.GetType()} to type {parameterExpressionExt}", e.Message);
        e = Assert.Throws<InvalidCastException>(() => convertToPee(null!));
        Assert.Equal($"Unable to cast object of type  to type {parameterExpressionExt}", e.Message);

        var parameterListWrapper = blockExpressionExt.GetNestedType("ParameterListWrapper", BindingFlags.NonPublic);
        Assert.NotNull(parameterListWrapper);
        var peeArray = Array.CreateInstance(parameterExpressionExt, 1);
        peeArray.SetValue(convertToPee(param), 0);
        var plwInstance = (IEnumerable)Activator.CreateInstance(parameterListWrapper,
            BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[] { peeArray }, null, null);
        Assert.NotNull(plwInstance);
        Assert.Equal(new[] { param }, plwInstance.ToList());

        var parameterProviderExtensions = assemblyTypes.First(x => x.Name == "ParameterProviderExtensions");
        var ppeIndexOfMethod = parameterProviderExtensions.GetMethod("IndexOf");
        var lambda = Expression.Lambda(Expression.Empty(), Enumerable.Repeat(0, 33).Select(_ => Expression.Parameter(typeof(int))).ToArray());
        var ppeInstance = Activator.CreateInstance(parameterProviderExtensions, new object[] { lambda });
        Assert.Equal(-1, ppeIndexOfMethod!.Invoke(ppeInstance, new object[] { null }));

        var arrayBuilder = assemblyTypes.First(x => x.Name == "ArrayBuilder`1").MakeGenericType(typeof(object));
        var arrayBuilderCapacity = arrayBuilder.GetProperty("Capacity");
        var abInstance = Activator.CreateInstance(arrayBuilder, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance,
            null, new object[] { 1 }, null, null);
        Assert.Equal(1, arrayBuilderCapacity!.GetValue(abInstance));
        var abEmptyInstance = Activator.CreateInstance(arrayBuilder);
        Assert.Equal(0, arrayBuilderCapacity!.GetValue(abEmptyInstance));
    }

    [Fact]
    public void StackSpilledMemberInit_DisabledScopeMergingOptimization_TriggersBlockWithByRefParametersExpressionCastBranches()
    {
        var specialLambdaName = (string)(typeof(ExpressionExtensions).GetField("s_specialLambdaName", BindingFlags.NonPublic | BindingFlags.Static)
            !.GetValue(null));
        Assert.NotNull(specialLambdaName);
        Assert.Equal(" ", specialLambdaName);
        Assert.False(ReferenceEquals(" ", specialLambdaName));
        var expr = Expression.Lambda<Func<StructWithWriteableProp>>(
            Expression.MemberInit(
                Expression.New(typeof(StructWithWriteableProp)),
                Expression.Bind(
                    typeof(StructWithWriteableProp).GetProperty(nameof(StructWithWriteableProp.Prop))!,
                    Expression.TryFinally(
                        Expression.Constant(1),
                        Expression.Empty()))),
            name: specialLambdaName,
            tailCall: false,
            parameters: null);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(1, func().Prop);
    }

    public struct StructWithWriteableProp
    {
        public int Prop { get; set; }
    }

    [Fact]
    public void LiftedComparisonWithClassAndStructAndMethod_TriggersLambdaCompiler_EmitLift_ArgumentNonValueTypeBranch()
    {
        var param1 = Expression.Parameter(typeof(WeirdComparison));
        var param2 = Expression.Parameter(typeof(string));
        var param3 = Expression.Parameter(typeof(WeirdComparison));
        var gt = Expression.GreaterThan(param1, param2, false, null);
        var eq = Expression.Equal(param1, param2, false, null);
        var eqVt = Expression.Equal(param1, param3, false, null);
        var plus = Expression.UnaryPlus(param1);
        param1.GetType().GetField("<Type>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(param1, typeof(WeirdComparison?));
        var expr1 = Expression.Lambda<Func<WeirdComparison?, string, bool>>(
            gt,
            param1, param2);
        var func1 = expr1.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.True(func1(new WeirdComparison("2"), "1"));
        Assert.False(func1(new WeirdComparison("2"), "2"));
        Assert.False(func1(new WeirdComparison("2"), null));
        Assert.False(func1(null, "2"));

        var expr2 = Expression.Lambda<Func<WeirdComparison?, string, bool>>(
            eq,
            param1, param2);
        var func2 = expr2.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.False(func2(new WeirdComparison("2"), "1"));
        Assert.True(func2(new WeirdComparison("2"), "2"));
        Assert.False(func2(new WeirdComparison("2"), null));
        Assert.False(func2(null, "2"));

        var expr3 = Expression.Lambda<Func<WeirdComparison?, WeirdComparison, bool>>(
            eqVt,
            param1, param3);
        var func3 = expr3.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.False(func3(new WeirdComparison("2"), new WeirdComparison("1")));
        Assert.True(func3(new WeirdComparison("2"), new WeirdComparison("2")));
        Assert.False(func3(null, new WeirdComparison("2")));

        var expr4 = Expression.Lambda<Func<WeirdComparison?, string>>(
            plus,
            param1);
        var func4 = expr4.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal("1", func4(new WeirdComparison("1")));
        Assert.Null(func4(null));
    }

    public readonly struct WeirdComparison
    {
        public readonly string Value;
        public WeirdComparison(string value) => Value = value;
        public static bool operator ==(WeirdComparison x, WeirdComparison y) => string.Equals(x.Value, y.Value, StringComparison.Ordinal);
        public static bool operator !=(WeirdComparison x, WeirdComparison y) => !string.Equals(x.Value, y.Value, StringComparison.Ordinal);
        public static bool operator ==(WeirdComparison x, string y) => string.Equals(x.Value, y, StringComparison.Ordinal);
        public static bool operator !=(WeirdComparison x, string y) => !string.Equals(x.Value, y, StringComparison.Ordinal);
        public override bool Equals(object obj) => obj is WeirdComparison x && this == x || obj is string y && this == y;
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator >(WeirdComparison x, string y) => string.Compare(x.Value, y, StringComparison.Ordinal) > 0;
        public static bool operator <(WeirdComparison x, string y) => string.Compare(x.Value, y, StringComparison.Ordinal) < 0;
        public static string operator +(WeirdComparison x) => x.Value;
    }

    [Fact]
    public void ByteAddition_TriggersLambdaCompiler_EmitConvertArithmeticResult_CheckedBranch()
    {
        var paramInt = Expression.Parameter(typeof(int));
        var paramUbyte = Expression.Parameter(typeof(byte));
        var paramSbyte = Expression.Parameter(typeof(sbyte));
        var incrUbyte = Expression.AddChecked(paramInt, paramInt);
        var incrSbyte = Expression.AddChecked(paramInt, paramInt);
        incrUbyte.GetType().GetField("<Type>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(incrUbyte, typeof(byte));
        incrUbyte.GetType().BaseType!.GetField("<Left>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(incrUbyte, paramUbyte);
        incrUbyte.GetType().BaseType!.GetField("<Right>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(incrUbyte, paramUbyte);
        incrSbyte.GetType().GetField("<Type>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(incrSbyte, typeof(sbyte));
        incrSbyte.GetType().BaseType!.GetField("<Left>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(incrSbyte, paramSbyte);
        incrSbyte.GetType().BaseType!.GetField("<Right>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(incrSbyte, paramSbyte);

        var exprUbyte = Expression.Lambda<Func<byte, byte>>(incrUbyte, paramUbyte);
        var funcUbyte = exprUbyte.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(2, funcUbyte(1));
        Assert.Throws<OverflowException>(() => funcUbyte(128));

        var exprSbyte = Expression.Lambda<Func<sbyte, sbyte>>(incrSbyte, paramSbyte);
        var funcSbyte = exprSbyte.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(2, funcSbyte(1));
        Assert.Throws<OverflowException>(() => funcSbyte(64));
    }

    [Fact]
    public void AndAlsoWithMethodInCondition_TriggersLambdaCompiler_EmitBranchLogical_MethodBranch()
    {
        var param1 = Expression.Parameter(typeof(LogicalClass));
        var param2 = Expression.Parameter(typeof(LogicalClass));
        var and = Expression.AndAlso(param1, param2);
        and.GetType().BaseType!.GetField("<Type>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(and, typeof(bool));
        and.GetType().GetField("_method", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(and, typeof(LogicalClass).GetMethod(nameof(LogicalClass.And), BindingFlags.Public | BindingFlags.Static));

        var expr = Expression.Lambda<Func<LogicalClass, LogicalClass, int>>(
            Expression.Condition(and, Expression.Constant(1), Expression.Constant(2)),
            param1, param2);
        var func = expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true);
        Assert.Equal(1, func(new LogicalClass(true), new LogicalClass(true)));
        Assert.Equal(2, func(new LogicalClass(true), new LogicalClass(false)));
        Assert.Equal(2, func(new LogicalClass(true), null));
        // this is broken, brfalse gets emitted to jump to the false branch expecting a bool
        // but if it's a fallthrough from the short-circuiting check (ie first param = false)
        // then there is a LogicalClass from the first param on the top of the stack
        // and brfalse instead checks if it's null and the true branch gets jumped on when it's not
        // (can't hack it with just bools because the compiler looks for op_False/op_True on the type declaring the And method)
        Assert.Equal(1, func(new LogicalClass(false), new LogicalClass(true)));
        Assert.Equal(1, func(new LogicalClass(false), new LogicalClass(false)));
        Assert.Equal(1, func(new LogicalClass(false), null));
        Assert.Equal(2, func(null, new LogicalClass(true)));
        Assert.Equal(2, func(null, new LogicalClass(false)));
        Assert.Equal(2, func(null, null));
    }

    public class LogicalClass
    {
        public readonly bool Value;
        public LogicalClass(bool value) => Value = value;
        public static bool operator false(LogicalClass v) => v != null && !v.Value;
        public static bool operator true(LogicalClass v) => v != null && v.Value;
        public static LogicalClass operator &(LogicalClass a1, LogicalClass a2) => new LogicalClass(And(a1, a2));
        public static bool And(LogicalClass a1, LogicalClass a2) => a1 != null && a2 != null && a1.Value && a2.Value;
    }

    [Fact]
    public void HackedMemberBinding_TriggersStackSpiller_UnhandledBindingBranch()
    {
        var binding = Expression.Bind(typeof(ClassWithProp).GetProperty(nameof(ClassWithProp.Prop))!, Expression.Constant(1));
        var expr = Expression.Lambda<Func<ClassWithProp>>(Expression.MemberInit(
            Expression.New(typeof(ClassWithProp)),
            binding));
        binding.GetType().BaseType!.GetField("<BindingType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance)!
            .SetValue(binding, (MemberBindingType)(-1));
        var e = Assert.Throws<ArgumentException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
        Assert.Equal("Unhandled binding", e.Message);
    }

    public class ClassWithProp
    {
        public int Prop { get; set; }
    }

    [Fact]
    public void NotInvocableExpressionInInvoke()
    {
        var param = Expression.Parameter(typeof(Action<int>));
        var invoke = Expression.Invoke(param, Expression.TryFinally(Expression.Constant(1), Expression.Empty()));
        param.GetType().GetField("<Type>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(param, typeof(object));
        var expr = Expression.Lambda<Action<object>>(
            invoke,
            param);
        var e = Assert.Throws<ArgumentException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
        Assert.StartsWith($"Expression of type '{typeof(object)}' cannot be invoked", e.Message);
    }

    [Fact]
    public void LambdaExpressionInInvoke()
    {
        var param = Expression.Parameter(typeof(Expression<Func<int>>));
        var invoke = Expression.Invoke(param);
        param.GetType().GetField("<Type>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(param, typeof(LambdaExpression));
        var expr = Expression.Lambda<Action<LambdaExpression>>(
            invoke,
            param);
        Assert.Throws<NullReferenceException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
    }

    [Fact]
    public void SwitchWithNullableValueAndNoComparison_TriggersSwitchExpression_IsLifted_ComparisonNullBranch()
    {
        var expr = Expression.Switch(Expression.Constant(1, typeof(int?)));
        Assert.Equal(true, typeof(ExpressionExtensions)
            .GetMethod("IsLifted", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static, new[] { typeof(SwitchExpression) })!
            .Invoke(null, new object[] { expr }));
    }

    private class PrivateType
    {
    }
    public struct Struct
    {
    }

    public static IEnumerable<object[]> UnemittableConstants()
    {
        object[] Data(object o, Type type = null) => new object[] { o, type ?? o?.GetType() ?? typeof(object) };

        yield return Data(new object());
        yield return Data(new DynamicMethod("Bad", typeof(void), Type.EmptyTypes));
        yield return Data(typeof(PrivateType));
        yield return Data(new Struct(), typeof(Struct?));
    }

    [Theory]
    [MemberData(nameof(UnemittableConstants))]
    public void LiveConstant(object value, Type type)
    {
        var specialLambdaName = (string)(typeof(ExpressionExtensions).GetField("s_specialLambdaName", BindingFlags.NonPublic | BindingFlags.Static)
            !.GetValue(null));
        Assert.NotNull(specialLambdaName);
        Assert.Equal(" ", specialLambdaName);
        Assert.False(ReferenceEquals(" ", specialLambdaName));
        var expr = Expression.Lambda<Func<object>>(
            Expression.Convert(Expression.Constant(value, type), typeof(object)),
            name: specialLambdaName,
            tailCall: false,
            parameters: null);
        var e = Assert.Throws<InvalidOperationException>(() => expr.Compile(CompilationType.CompileToMethod, withoutVisitor: true));
        Assert.Equal($"CompileToMethod cannot compile constant '{value}' because it is a non-trivial value, such as a live object. Instead, create an expression tree that can construct this value.", e.Message);
    }

    [Fact]
    public void CompilerScope_CurrentLambdaName()
    {
        var assemblyTypes = typeof(ExpressionExtensions).Assembly.GetTypes();
        var block = Expression.Block();
        var lambda = Expression.Lambda<Action>(block, name: "Lambda", tailCall: false, parameters: Array.Empty<ParameterExpression>());

        var compilerScope = assemblyTypes.First(x => x.Name == "CompilerScope");
        var compilerScopeCtor = compilerScope.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public,
            new[] { typeof(object), typeof(bool) });
        var compilerScopeCurrentLambda = compilerScope.GetProperty("CurrentLambdaName", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        var compilerScopeParent = compilerScope.GetField("_parent", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        var scopeInstance1 = compilerScopeCtor!.Invoke(new object[] { block, false });
        var scopeInstance2 = compilerScopeCtor!.Invoke(new object[] { lambda, false });
        compilerScopeParent!.SetValue(scopeInstance1, scopeInstance2);

        Assert.Equal(lambda.Name, compilerScopeCurrentLambda!.GetValue(scopeInstance1));
        Assert.Equal(lambda.Name, compilerScopeCurrentLambda!.GetValue(scopeInstance2));
    }
}
