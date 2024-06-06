// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace System.Linq.Expressions.Tests
{
    public static class IsNullableTests
    {
        #region Test methods

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableEnumIsEnumTypeTest(CompilationType useInterpreter)
        {
            E?[] array = new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableEnumIsEnumType(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableEnumIsObjectTest(CompilationType useInterpreter)
        {
            E?[] array = new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableEnumIsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableIntIsObjectTest(CompilationType useInterpreter)
        {
            int?[] array = new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableIntIsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableIntIsValueTypeTest(CompilationType useInterpreter)
        {
            int?[] array = new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableIntIsValueType(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableStructIsIEquatableOfStructTest(CompilationType useInterpreter)
        {
            S?[] array = new S?[] { null, default(S), new S() };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableStructIsIEquatableOfStruct(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableStructIsObjectTest(CompilationType useInterpreter)
        {
            S?[] array = new S?[] { null, default(S), new S() };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableStructIsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableStructIsValueTypeTest(CompilationType useInterpreter)
        {
            S?[] array = new S?[] { null, default(S), new S() };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableStructIsValueType(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertGenericWithStructRestrictionCastObjectAsEnum(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionIsObjectHelper<E>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertGenericWithStructRestrictionCastObjectAsStruct(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionIsObjectHelper<S>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertGenericWithStructRestrictionCastObjectAsStructWithStringAndField(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionIsObjectHelper<Scs>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertGenericWithStructRestrictionCastValueTypeAsEnum(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionIsValueTypeHelper<E>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertGenericWithStructRestrictionCastValueTypeAsStruct(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionIsValueTypeHelper<S>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertGenericWithStructRestrictionCastValueTypeAsStructWithStringAndField(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionIsValueTypeHelper<Scs>(useInterpreter);
        }

        #endregion

        #region Generic helpers

        private static void CheckGenericWithStructRestrictionIsObjectHelper<Ts>(CompilationType useInterpreter) where Ts : struct
        {
            Ts[] array = new Ts[] { default(Ts), new Ts() };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyGenericWithStructRestrictionIsObject<Ts>(array[i], useInterpreter);
            }
        }

        private static void CheckGenericWithStructRestrictionIsValueTypeHelper<Ts>(CompilationType useInterpreter) where Ts : struct
        {
            Ts[] array = new Ts[] { default(Ts), new Ts() };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyGenericWithStructRestrictionIsValueType<Ts>(array[i], useInterpreter);
            }
        }

        #endregion

        #region Test verifiers

        private static void VerifyNullableEnumIsEnumType(E? value, CompilationType useInterpreter)
        {
            Expression<Func<bool>> e =
                Expression.Lambda<Func<bool>>(
                    Expression.TypeIs(Expression.Constant(value, typeof(E?)), typeof(Enum)),
                    Enumerable.Empty<ParameterExpression>());
            Func<bool> f = e.Compile(useInterpreter);

            Assert.Equal(value.HasValue, f());
        }

        private static void VerifyNullableEnumIsObject(E? value, CompilationType useInterpreter)
        {
            Expression<Func<bool>> e =
                Expression.Lambda<Func<bool>>(
                    Expression.TypeIs(Expression.Constant(value, typeof(E?)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<bool> f = e.Compile(useInterpreter);

            Assert.Equal(value.HasValue, f());
        }

        private static void VerifyNullableIntIsObject(int? value, CompilationType useInterpreter)
        {
            Expression<Func<bool>> e =
                Expression.Lambda<Func<bool>>(
                    Expression.TypeIs(Expression.Constant(value, typeof(int?)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<bool> f = e.Compile(useInterpreter);

            Assert.Equal(value.HasValue, f());
        }

        private static void VerifyNullableIntIsValueType(int? value, CompilationType useInterpreter)
        {
            Expression<Func<bool>> e =
                Expression.Lambda<Func<bool>>(
                    Expression.TypeIs(Expression.Constant(value, typeof(int?)), typeof(ValueType)),
                    Enumerable.Empty<ParameterExpression>());
            Func<bool> f = e.Compile(useInterpreter);

            Assert.Equal(value.HasValue, f());
        }

        private static void VerifyNullableStructIsIEquatableOfStruct(S? value, CompilationType useInterpreter)
        {
            Expression<Func<bool>> e =
                Expression.Lambda<Func<bool>>(
                    Expression.TypeIs(Expression.Constant(value, typeof(S?)), typeof(IEquatable<S>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<bool> f = e.Compile(useInterpreter);

            Assert.Equal(value.HasValue, f());
        }

        private static void VerifyNullableStructIsObject(S? value, CompilationType useInterpreter)
        {
            Expression<Func<bool>> e =
                Expression.Lambda<Func<bool>>(
                    Expression.TypeIs(Expression.Constant(value, typeof(S?)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<bool> f = e.Compile(useInterpreter);

            Assert.Equal(value.HasValue, f());
        }

        private static void VerifyNullableStructIsValueType(S? value, CompilationType useInterpreter)
        {
            Expression<Func<bool>> e =
                Expression.Lambda<Func<bool>>(
                    Expression.TypeIs(Expression.Constant(value, typeof(S?)), typeof(ValueType)),
                    Enumerable.Empty<ParameterExpression>());
            Func<bool> f = e.Compile(useInterpreter);

            Assert.Equal(value.HasValue, f());
        }

        private static void VerifyGenericWithStructRestrictionIsObject<Ts>(Ts value, CompilationType useInterpreter) where Ts : struct
        {
            Expression<Func<bool>> e =
                Expression.Lambda<Func<bool>>(
                    Expression.TypeIs(Expression.Constant(value, typeof(Ts)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<bool> f = e.Compile(useInterpreter);
            Assert.True(f());
        }

        private static void VerifyGenericWithStructRestrictionIsValueType<Ts>(Ts value, CompilationType useInterpreter) where Ts : struct
        {
            Expression<Func<bool>> e =
                Expression.Lambda<Func<bool>>(
                    Expression.TypeIs(Expression.Constant(value, typeof(Ts)), typeof(ValueType)),
                    Enumerable.Empty<ParameterExpression>());
            Func<bool> f = e.Compile(useInterpreter);
            Assert.True(f());
        }

        #endregion
    }
}
