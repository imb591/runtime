// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;
using Xunit;

namespace System.Linq.Expressions.Tests
{
    public static class BinaryPowerTests
    {
        #region Test methods

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckBytePowerTest(CompilationType useInterpreter)
        {
            byte[] array = new byte[] { 0, 1, byte.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    VerifyBytePower(array[i], array[j], useInterpreter);
                }
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckSBytePowerTest(CompilationType useInterpreter)
        {
            sbyte[] array = new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    VerifySBytePower(array[i], array[j], useInterpreter);
                }
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckUShortPowerTest(CompilationType useInterpreter)
        {
            ushort[] array = new ushort[] { 0, 1, ushort.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    VerifyUShortPower(array[i], array[j], useInterpreter);
                }
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckShortPowerTest(CompilationType useInterpreter)
        {
            short[] array = new short[] { 0, 1, -1, short.MinValue, short.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    VerifyShortPower(array[i], array[j], useInterpreter);
                }
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckUIntPowerTest(CompilationType useInterpreter)
        {
            uint[] array = new uint[] { 0, 1, uint.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    VerifyUIntPower(array[i], array[j], useInterpreter);
                }
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIntPowerTest(CompilationType useInterpreter)
        {
            int[] array = new int[] { 0, 1, -1, int.MinValue, int.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    VerifyIntPower(array[i], array[j], useInterpreter);
                }
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckULongPowerTest(CompilationType useInterpreter)
        {
            ulong[] array = new ulong[] { 0, 1, ulong.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    VerifyULongPower(array[i], array[j], useInterpreter);
                }
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckLongPowerTest(CompilationType useInterpreter)
        {
            long[] array = new long[] { 0, 1, -1, long.MinValue, long.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    VerifyLongPower(array[i], array[j], useInterpreter);
                }
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckFloatPowerTest(CompilationType useInterpreter)
        {
            float[] array = new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    VerifyFloatPower(array[i], array[j], useInterpreter);
                }
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckDoublePowerTest(CompilationType useInterpreter)
        {
            double[] array = new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    VerifyDoublePower(array[i], array[j], useInterpreter);
                }
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckDecimalPowerTest(CompilationType useInterpreter)
        {
            decimal[] array = new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    VerifyDecimalPower(array[i], array[j], useInterpreter);
                }
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCharPowerTest(CompilationType useInterpreter)
        {
            char[] array = new char[] { '\0', '\b', 'A', '\uffff' };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    VerifyCharPower(array[i], array[j], useInterpreter);
                }
            }
        }

        #endregion

        #region Test verifiers

        private static void VerifyBytePower(byte a, byte b, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Power(
                        Expression.Constant(a, typeof(byte)),
                        Expression.Constant(b, typeof(byte)),
                        typeof(BinaryPowerTests).GetTypeInfo().GetDeclaredMethod("PowerByte")
                    ));
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(PowerByte(a, b), f());
        }

        private static void VerifySBytePower(sbyte a, sbyte b, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Power(
                        Expression.Constant(a, typeof(sbyte)),
                        Expression.Constant(b, typeof(sbyte)),
                        typeof(BinaryPowerTests).GetTypeInfo().GetDeclaredMethod("PowerSByte")
                    ));
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(PowerSByte(a, b), f());
        }

        private static void VerifyUShortPower(ushort a, ushort b, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Power(
                        Expression.Constant(a, typeof(ushort)),
                        Expression.Constant(b, typeof(ushort)),
                        typeof(BinaryPowerTests).GetTypeInfo().GetDeclaredMethod("PowerUShort")
                    ));
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(PowerUShort(a, b), f());
        }

        private static void VerifyShortPower(short a, short b, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Power(
                        Expression.Constant(a, typeof(short)),
                        Expression.Constant(b, typeof(short)),
                        typeof(BinaryPowerTests).GetTypeInfo().GetDeclaredMethod("PowerShort")
                    ));
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(PowerShort(a, b), f());
        }

        private static void VerifyUIntPower(uint a, uint b, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Power(
                        Expression.Constant(a, typeof(uint)),
                        Expression.Constant(b, typeof(uint)),
                        typeof(BinaryPowerTests).GetTypeInfo().GetDeclaredMethod("PowerUInt")
                    ));
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(PowerUInt(a, b), f());
        }

        private static void VerifyIntPower(int a, int b, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Power(
                        Expression.Constant(a, typeof(int)),
                        Expression.Constant(b, typeof(int)),
                        typeof(BinaryPowerTests).GetTypeInfo().GetDeclaredMethod("PowerInt")
                    ));
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(PowerInt(a, b), f());
        }

        private static void VerifyULongPower(ulong a, ulong b, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Power(
                        Expression.Constant(a, typeof(ulong)),
                        Expression.Constant(b, typeof(ulong)),
                        typeof(BinaryPowerTests).GetTypeInfo().GetDeclaredMethod("PowerULong")
                    ));
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(PowerULong(a, b), f());
        }

        private static void VerifyLongPower(long a, long b, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Power(
                        Expression.Constant(a, typeof(long)),
                        Expression.Constant(b, typeof(long)),
                        typeof(BinaryPowerTests).GetTypeInfo().GetDeclaredMethod("PowerLong")
                    ));
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(PowerLong(a, b), f());
        }

        private static void VerifyFloatPower(float a, float b, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Power(
                        Expression.Constant(a, typeof(float)),
                        Expression.Constant(b, typeof(float)),
                        typeof(BinaryPowerTests).GetTypeInfo().GetDeclaredMethod("PowerFloat")
                    ));
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(PowerFloat(a, b), f());
        }

        private static void VerifyDoublePower(double a, double b, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Power(
                        Expression.Constant(a, typeof(double)),
                        Expression.Constant(b, typeof(double)),
                        typeof(BinaryPowerTests).GetTypeInfo().GetDeclaredMethod("PowerDouble")
                    ));
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(PowerDouble(a, b), f());
        }

        private static void VerifyDecimalPower(decimal a, decimal b, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Power(
                        Expression.Constant(a, typeof(decimal)),
                        Expression.Constant(b, typeof(decimal)),
                        typeof(BinaryPowerTests).GetTypeInfo().GetDeclaredMethod("PowerDecimal")
                    ));
            Func<decimal> f = e.Compile(useInterpreter);

            decimal expected = 0;
            try
            {
                expected = PowerDecimal(a, b);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCharPower(char a, char b, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Power(
                        Expression.Constant(a, typeof(char)),
                        Expression.Constant(b, typeof(char)),
                        typeof(BinaryPowerTests).GetTypeInfo().GetDeclaredMethod("PowerChar")
                    ));
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal(PowerChar(a, b), f());
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public static void ToStringTest()
        {
            BinaryExpression e = Expression.Power(Expression.Parameter(typeof(double), "a"), Expression.Parameter(typeof(double), "b"));
            Assert.Equal("(a ** b)", e.ToString());
        }

        #endregion

        #region Helper methods

        public static byte PowerByte(byte a, byte b)
        {
            return unchecked((byte)Math.Pow(a, b));
        }

        public static sbyte PowerSByte(sbyte a, sbyte b)
        {
            return unchecked((sbyte)Math.Pow(a, b));
        }

        public static ushort PowerUShort(ushort a, ushort b)
        {
            return unchecked((ushort)Math.Pow(a, b));
        }

        public static short PowerShort(short a, short b)
        {
            return unchecked((short)Math.Pow(a, b));
        }

        public static uint PowerUInt(uint a, uint b)
        {
            return unchecked((uint)Math.Pow(a, b));
        }

        public static int PowerInt(int a, int b)
        {
            return unchecked((int)Math.Pow(a, b));
        }

        public static ulong PowerULong(ulong a, ulong b)
        {
            return unchecked((ulong)Math.Pow(a, b));
        }

        public static long PowerLong(long a, long b)
        {
            return unchecked((long)Math.Pow(a, b));
        }

        public static float PowerFloat(float a, float b)
        {
            return (float)Math.Pow(a, b);
        }

        public static double PowerDouble(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static decimal PowerDecimal(decimal a, decimal b)
        {
            return (decimal)Math.Pow((double)a, (double)b);
        }

        public static char PowerChar(char a, char b)
        {
            return unchecked((char)Math.Pow(a, b));
        }

        #endregion
    }
}
