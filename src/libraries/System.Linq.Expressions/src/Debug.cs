
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace System.Diagnostics
{
    [ExcludeFromCodeCoverage]
    internal class Debug
    {
        public class AssertionException : Exception
        {
            public AssertionException(string? errorMessage) : base(errorMessage)
            {
            }
        }

        [Conditional("DEBUG")]
        public static void Assert([DoesNotReturnIf(false)]bool condition, string? errorMessage = null)
        {
            if (!condition)
            {
                throw new AssertionException(errorMessage);
            }
        }

        [Conditional("DEBUG")]
        [DoesNotReturn]
        public static void Fail(string? errorMessage = null)
        {
            throw new AssertionException(errorMessage);
        }

        [Conditional("DEBUG")]
        public static void Trace(object? data = null)
        {
            var frames = new System.Diagnostics.StackTrace().ToString().Split("\n");
            var test = frames.FirstOrDefault(x =>
                x.Contains("System.Linq.Expressions.Tests.")
                && !x.Contains("System.Linq.Expressions.Tests.ILPrinter")
                && !x.Contains("System.Linq.Expressions.Tests.StackSpillerTests.Test")
                && !x.Contains("System.Linq.Expressions.Tests.StackSpillerTests.Eval")
                && !x.Contains("System.Linq.Expressions.Tests.CompilerTests.VerifyMethodBuilderIL")
                && !x.Contains("System.Linq.Expressions.Tests.CompilerTests.VerifyIL")
                && !x.Contains("System.Linq.Expressions.Tests.ExpressionAssert.Verify"));
            System.IO.File.AppendAllText(System.IO.Path.Combine(Environment.GetEnvironmentVariable("HOME")!, "out.txt"), $"{data} {test}\n");
        }
    }
}
