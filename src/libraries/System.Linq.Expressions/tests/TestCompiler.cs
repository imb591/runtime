using System;
using System.Collections.Generic;
using System.Linq.Expressions.Tests;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using Xunit;

namespace System.Linq.Expressions
{
    internal class ConstantReplacerVisitor : ExpressionVisitor
    {
        private readonly List<LiveConstant> _constants = new List<LiveConstant>();
        public IReadOnlyCollection<LiveConstant> Constants => _constants;

        private ParameterExpression AddConstant(object value, Type type)
        {
            var lc = _constants.FirstOrDefault(c => c.Parameter.Type == type && c.Value.Value == value);
            if (lc != null)
            {
                return lc.Parameter;
            }
            lc = new LiveConstant(Expression.Parameter(type), Expression.Constant(value, type));
            _constants.Add(lc);
            return lc.Parameter;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            var typeInfo = node.Type.GetTypeInfo();
            if (typeInfo.IsPrimitive
                || node.Type == typeof(decimal)
                || node.Type == typeof(string)
                || typeof(Type).GetTypeInfo().IsAssignableFrom(node.Type)
                || (typeInfo.IsGenericType && typeInfo.GetGenericTypeDefinition() == typeof(Nullable<>) && typeInfo.GetGenericArguments()[0].GetTypeInfo().IsPrimitive))
            {
                return node;
            }
            if (node.Value == null)
            {
                return node;
            }
            return AddConstant(node.Value, node.Type);
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            if (node.Expression.NodeType == ExpressionType.Quote)
            {
                return node.Update(node.Expression, Visit(node.Arguments));
            }
            return base.VisitInvocation(node);
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            if (node.NodeType == ExpressionType.Quote)
            {
                var lambda = (LambdaExpression)node.Operand;
                return AddConstant(lambda, node.Type);
            }
            return base.VisitUnary(node);
        }
    }

    class LiveConstant
    {
        public LiveConstant(ParameterExpression parameter, ConstantExpression value)
        {
            Parameter = parameter;
            Value = value;
        }

        public ParameterExpression Parameter { get; }

        public ConstantExpression Value { get; }
    }

    static class TestCompiler
    {
        private static int Counter = 0;

        public static string AssemblyName(string className) => "CompiledExpressions" + className;

        public static T Compile<T>(this Expression<T> expression, CompilationType compilationType, bool withoutVisitor = false, ModuleBuilder module = null)
            where T : class, Delegate
        {
            return compilationType switch
            {
                CompilationType.Interpret => expression.Compile(preferInterpretation: true),
                CompilationType.Compile => expression.Compile(preferInterpretation: false),
                CompilationType.CompileToMethod => (T)CompileToTestMethod(expression, withoutVisitor, module),
                CompilationType.WithoutPreference => expression.Compile(),
                _ => throw new ArgumentOutOfRangeException(nameof(compilationType), compilationType, null),
            };
        }

        public static Delegate Compile(this LambdaExpression expression, CompilationType compilationType, bool withoutVisitor = false, ModuleBuilder module = null)
        {
            return compilationType switch
            {
                CompilationType.Interpret => expression.Compile(preferInterpretation: true),
                CompilationType.Compile => expression.Compile(preferInterpretation: false),
                CompilationType.CompileToMethod => CompileToTestMethod(expression, withoutVisitor, module),
                CompilationType.WithoutPreference => expression.Compile(),
                _ => throw new ArgumentOutOfRangeException(nameof(compilationType), compilationType, null),
            };
        }

        public static Delegate CompileToTestMethod(this LambdaExpression expression, bool withoutVisitor = false, ModuleBuilder moduleBuilder = null)
        {
            int current = Interlocked.Increment(ref Counter);
            var assemblyName = new AssemblyName("CompiledExpressions" + current);
            var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            moduleBuilder ??= assemblyBuilder.DefineDynamicModule("CompiledExpressions");
            var typeBuilder = moduleBuilder.DefineType("C" + current);
            var methodBuilder = typeBuilder.DefineMethod("M", MethodAttributes.Public | MethodAttributes.Static);
            if (withoutVisitor)
            {
                return CompileSimple(expression, typeBuilder, methodBuilder);
            }
            var visitor = new ConstantReplacerVisitor();
            var expressionBodyWithoutConstants = visitor.Visit(expression.Body);
            if (visitor.Constants.Count == 0 && expression.Parameters.Count < 65_535)
            {
                return CompileSimple(expression, typeBuilder, methodBuilder);
            }
            var parameters = expression.Parameters.Concat(visitor.Constants.Select(c => c.Parameter)).ToList();
            var expressionWithoutConstants = Expression.Lambda(expressionBodyWithoutConstants, parameters);
            expressionWithoutConstants.CompileToMethod(methodBuilder);
            var typeInfo = typeBuilder.CreateTypeInfo();
            var type = typeInfo.AsType();
            var method = type.GetMethod(methodBuilder.Name) ?? throw new NullReferenceException($"Method {methodBuilder.Name} not found");
            var expr = Expression.Lambda(
                expression.Type,
                Expression.Call(method, expression.Parameters.Concat(visitor.Constants.Select(c => (Expression)c.Value))),
                expression.Parameters);
            return expr.Compile();
        }

        public static MethodBuilder CompileToMethodBuilder(this LambdaExpression expression, string className)
        {
            var assemblyName = new AssemblyName("CompiledExpressions" + className);
            var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            var moduleBuilder = assemblyBuilder.DefineDynamicModule("CompiledExpressions");
            var typeBuilder = moduleBuilder.DefineType(className);
            var methodBuilder = typeBuilder.DefineMethod("M", MethodAttributes.Public | MethodAttributes.Static);
            expression.CompileToMethod(methodBuilder);
            typeBuilder.CreateTypeInfo();
            return methodBuilder;
        }

        private static Delegate CompileSimple(LambdaExpression expression, TypeBuilder typeBuilder, MethodBuilder methodBuilder)
        {
            expression.CompileToMethod(methodBuilder);
            var typeInfo = typeBuilder.CreateTypeInfo();
            var type = typeInfo.AsType();
            var method = type.GetMethod(methodBuilder.Name) ?? throw new NullReferenceException($"Method {methodBuilder.Name} not found");
            return method.CreateDelegate(expression.Type, null);
        }
    }

    public class ActiveIssueAttribute : Attribute
    {
        public ActiveIssueAttribute(string link, string runtime = "", string platforms = "", string runtimes = "")
        {
        }
        public ActiveIssueAttribute(string link, Type type, string data = "")
        {
        }
    }

    public class TestPlatforms
    {
        public const string tvOS = nameof(tvOS);
        public const string MacCatalyst = nameof(MacCatalyst);
    }

    public class ConditionalFactAttribute : FactAttribute
    {
        public ConditionalFactAttribute(Type type, string member, string member2 = "")
        {
        }
    }
    public class ConditionalTheoryAttribute : TheoryAttribute
    {
        public ConditionalTheoryAttribute(Type type, string member)
        {
        }
    }

    public class PlatformDetection
    {
        public const bool IsNonZeroLowerBoundArraySupported = true;
        public const bool IsLinqExpressionsBuiltWithIsInterpretingOnly = false;
        public static readonly bool IsNotLinqExpressionsBuiltWithIsInterpretingOnly = true;
        public const bool IsReflectionEmitSupported = true;
        public const bool IsRareEnumsSupported = true;
        public const bool IsNotMonoRuntime = true;
        public const bool IsNotNativeAot = true;
    }

    public static class TestRuntimes
    {
        public const string Mono = nameof(Mono);
    }

    public class OuterLoopAttribute : Attribute
    {
        public OuterLoopAttribute(string justification)
        {
        }
    }

    public static class AssertExtensions
    {
        public static void Throws<T>(string x, Action a) where T: Exception => Assert.Throws<T>(a);
        public static void Throws<T>(string x, Func<object> a) where T: Exception => Assert.Throws<T>(a);
        public static void ThrowsOnAot<T>(Action a) => a();
    }

}

[AttributeUsage(AttributeTargets.Assembly)]
public class SkipOnCoreClr : Attribute
{
    public SkipOnCoreClr(string link, int configuration)
    {
    }
}

public static class RuntimeConfiguration
{
    public const int Release = 0;
}

namespace Microsoft.DotNet.RemoteExecutor
{
    public static class RemoteExecutor
    {
        public const bool IsSupported = false;

        public static RemoteInvokeHandle Invoke(Action action, RemoteInvokeOptions options)
        {
            action();
            return new RemoteInvokeHandle();
        }
    }

    public class RemoteInvokeOptions
    {
        public Dictionary<string, string> RuntimeConfigurationOptions { get; } = new();
    }

    public class RemoteInvokeHandle : IDisposable
    {
        public void Dispose()
        {
        }
    }
}

namespace System.Linq.Expressions.Interpreter
{
    public class LightLambda
    {
    }
}
