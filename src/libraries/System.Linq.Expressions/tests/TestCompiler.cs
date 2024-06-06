using System;
using System.Collections.Generic;
using System.Linq.Expressions.Tests;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using Xunit;

namespace System.Linq.Expressions
{
    static class TestCompiler
    {
        public static T Compile<T>(this Expression<T> expression, CompilationType compilationType, bool withoutVisitor = false)
            where T : class, Delegate
        {
            return compilationType switch
            {
                CompilationType.Interpret => expression.Compile(preferInterpretation: true),
                CompilationType.Compile => expression.Compile(preferInterpretation: false),
                CompilationType.WithoutPreference => expression.Compile(),
                _ => throw new ArgumentOutOfRangeException(nameof(compilationType), compilationType, null),
            };
        }

        public static Delegate Compile(this LambdaExpression expression, CompilationType compilationType, bool withoutVisitor = false)
        {
            return compilationType switch
            {
                CompilationType.Interpret => expression.Compile(preferInterpretation: true),
                CompilationType.Compile => expression.Compile(preferInterpretation: false),
                CompilationType.WithoutPreference => expression.Compile(),
                _ => throw new ArgumentOutOfRangeException(nameof(compilationType), compilationType, null),
            };
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
