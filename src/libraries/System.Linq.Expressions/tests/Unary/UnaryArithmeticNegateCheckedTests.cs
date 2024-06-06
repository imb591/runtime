// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace System.Linq.Expressions.Tests
{
    public static class UnaryArithmeticNegateCheckedTests
    {
        #region Test methods

        [Theory(Skip = "no call to CompileToMethod"), ClassData(typeof(CompilationTypes))]
        public static void CheckUnaryArithmeticNegateCheckedByteTest(CompilationType useInterpreter)
        {
            byte[] values = new byte[] { 0, 1, byte.MaxValue };
            for (int i = 0; i < values.Length; i++)
            {
                VerifyArithmeticNegateCheckedByte(values[i], useInterpreter);
            }
        }

        [Theory(Skip = "no call to CompileToMethod"), ClassData(typeof(CompilationTypes))]
        public static void CheckUnaryArithmeticNegateCheckedCharTest(CompilationType useInterpreter)
        {
            char[] values = new char[] { '\0', '\b', 'A', '\uffff' };
            for (int i = 0; i < values.Length; i++)
            {
                VerifyArithmeticNegateCheckedChar(values[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckUnaryArithmeticNegateCheckedDecimalTest(CompilationType useInterpreter)
        {
            decimal[] values = new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue };
            for (int i = 0; i < values.Length; i++)
            {
                VerifyArithmeticNegateCheckedDecimal(values[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckUnaryArithmeticNegateCheckedDoubleTest(CompilationType useInterpreter)
        {
            double[] values = new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN };
            for (int i = 0; i < values.Length; i++)
            {
                VerifyArithmeticNegateCheckedDouble(values[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckUnaryArithmeticNegateCheckedFloatTest(CompilationType useInterpreter)
        {
            float[] values = new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN };
            for (int i = 0; i < values.Length; i++)
            {
                VerifyArithmeticNegateCheckedFloat(values[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckUnaryArithmeticNegateCheckedIntTest(CompilationType useInterpreter)
        {
            int[] values = new int[] { 0, 1, -1, int.MinValue, int.MaxValue };
            for (int i = 0; i < values.Length; i++)
            {
                VerifyArithmeticNegateCheckedInt(values[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckUnaryArithmeticNegateCheckedLongTest(CompilationType useInterpreter)
        {
            long[] values = new long[] { 0, 1, -1, long.MinValue, long.MaxValue };
            for (int i = 0; i < values.Length; i++)
            {
                VerifyArithmeticNegateCheckedLong(values[i], useInterpreter);
            }
        }

        [Theory(Skip = "no call to CompileToMethod"), ClassData(typeof(CompilationTypes))]
        public static void CheckUnaryArithmeticNegateCheckedSByteTest(CompilationType useInterpreter)
        {
            sbyte[] values = new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue };
            for (int i = 0; i < values.Length; i++)
            {
                VerifyArithmeticNegateCheckedSByte(values[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckUnaryArithmeticNegateCheckedShortTest(CompilationType useInterpreter)
        {
            short[] values = new short[] { 0, 1, -1, short.MinValue, short.MaxValue };
            for (int i = 0; i < values.Length; i++)
            {
                VerifyArithmeticNegateCheckedShort(values[i], useInterpreter);
            }
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public static void ToStringTest()
        {
            UnaryExpression e = Expression.NegateChecked(Expression.Parameter(typeof(int), "x"));
            Assert.Equal("-x", e.ToString());
        }

        #endregion

        #region Test verifiers

        private static void VerifyArithmeticNegateCheckedByte(byte value, CompilationType useInterpreter)
        {
            Assert.Throws<InvalidOperationException>(() => Expression.NegateChecked(Expression.Constant(value, typeof(byte))));
        }

        private static void VerifyArithmeticNegateCheckedChar(char value, CompilationType useInterpreter)
        {
            Assert.Throws<InvalidOperationException>(() => Expression.NegateChecked(Expression.Constant(value, typeof(char))));
        }

        private static void VerifyArithmeticNegateCheckedDecimal(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.NegateChecked(Expression.Constant(value, typeof(decimal))),
                    Enumerable.Empty<ParameterExpression>());

            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(-value, f());
        }

        private static void VerifyArithmeticNegateCheckedDouble(double value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.NegateChecked(Expression.Constant(value, typeof(double))),
                    Enumerable.Empty<ParameterExpression>());

            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(-value, f());
        }

        private static void VerifyArithmeticNegateCheckedFloat(float value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.NegateChecked(Expression.Constant(value, typeof(float))),
                    Enumerable.Empty<ParameterExpression>());

            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(-value, f());
        }

        private static void VerifyArithmeticNegateCheckedInt(int value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.NegateChecked(Expression.Constant(value, typeof(int))),
                    Enumerable.Empty<ParameterExpression>());

            Func<int> f = e.Compile(useInterpreter);

            if (value == int.MinValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(-value, f());
        }

        private static void VerifyArithmeticNegateCheckedLong(long value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.NegateChecked(Expression.Constant(value, typeof(long))),
                    Enumerable.Empty<ParameterExpression>());

            Func<long> f = e.Compile(useInterpreter);

            if (value == long.MinValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(-value, f());
        }

        private static void VerifyArithmeticNegateCheckedSByte(sbyte value, CompilationType useInterpreter)
        {
            Assert.Throws<InvalidOperationException>(() => Expression.NegateChecked(Expression.Constant(value, typeof(sbyte))));
        }

        private static void VerifyArithmeticNegateCheckedShort(short value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.NegateChecked(Expression.Constant(value, typeof(short))),
                    Enumerable.Empty<ParameterExpression>());

            Func<short> f = e.Compile(useInterpreter);

            if (value == short.MinValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(-value, f());
        }

        #endregion

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        [ActiveIssue("https://github.com/mono/mono/issues/14919", TestRuntimes.Mono)]
        public static void VerifyIL_ShortNegateChecked()
        {
            ParameterExpression param = Expression.Parameter(typeof(short));
            Expression<Func<short, short>> f =
                Expression.Lambda<Func<short, short>>(Expression.NegateChecked(param), param);

            f.VerifyIL(
                @".method int16 ::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure,int16)
                {
                    .maxstack 2

                    IL_0000: ldc.i4.0
                    IL_0001: ldarg.1
                    IL_0002: sub.ovf
                    IL_0003: conv.ovf.i2
                    IL_0004: ret
                }");
        }
    }
}
