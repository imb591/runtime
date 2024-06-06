// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace System.Linq.Expressions.Tests
{
    public static class AsNullableTests
    {
        [Fact(Skip = "no call to CompileToMethod")]
        public static void NotLiftedEvenOnNullableOperand()
        {
            Assert.False(Expression.TypeAs(Expression.Constant(E.A, typeof(E?)), typeof(E?)).IsLifted);
            Assert.False(Expression.TypeAs(Expression.Constant(E.A, typeof(E?)), typeof(Enum)).IsLifted);
        }

        #region Test methods

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableEnumAsEnumTypeTest(CompilationType useInterpreter)
        {
            E?[] array = new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableEnumAsEnumType(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckEnumAsNullableEnumTypeTest(CompilationType useInterpreter)
        {
            E[] array = { 0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyEnumAsNullableEnumType(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableEnumAsNullableEnumTypeTest(CompilationType useInterpreter)
        {
            E?[] array = { null, 0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableEnumAsNullableEnumType(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckLongAsNullableEnumTypeTest(CompilationType useInterpreter)
        {
            long[] array = { 0, 1, long.MinValue, long.MaxValue };
            foreach (long value in array)
            {
                VerifyLongAsNullableEnumType(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableLongAsNullableEnumTypeTest(CompilationType useInterpreter)
        {
            long?[] array = { null, 0, 1, long.MinValue, long.MaxValue };
            foreach (long? value in array)
            {
                VerifyNullableLongAsNullableEnumType(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableEnumAsObjectTest(CompilationType useInterpreter)
        {
            E?[] array = new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableEnumAsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableIntAsObjectTest(CompilationType useInterpreter)
        {
            int?[] array = new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableIntAsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableIntAsValueTypeTest(CompilationType useInterpreter)
        {
            int?[] array = new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableIntAsValueType(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableStructAsIEquatableOfStructTest(CompilationType useInterpreter)
        {
            S?[] array = new S?[] { null, default(S), new S() };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableStructAsIEquatableOfStruct(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableStructAsObjectTest(CompilationType useInterpreter)
        {
            S?[] array = new S?[] { null, default(S), new S() };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableStructAsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckNullableStructAsValueTypeTest(CompilationType useInterpreter)
        {
            S?[] array = new S?[] { null, default(S), new S() };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyNullableStructAsValueType(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertGenericWithStructRestrictionCastObjectAsEnum(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionAsObjectHelper<E>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertGenericWithStructRestrictionCastObjectAsStruct(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionAsObjectHelper<S>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertGenericWithStructRestrictionCastObjectAsStructWithStringAndField(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionAsObjectHelper<Scs>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertGenericWithStructRestrictionCastValueTypeAsEnum(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionAsValueTypeHelper<E>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertGenericWithStructRestrictionCastValueTypeAsStruct(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionAsValueTypeHelper<S>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertGenericWithStructRestrictionCastValueTypeAsStructWithStringAndField(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionAsValueTypeHelper<Scs>(useInterpreter);
        }

        #endregion

        #region Generic helpers

        private static void CheckGenericWithStructRestrictionAsObjectHelper<Ts>(CompilationType useInterpreter) where Ts : struct
        {
            Ts[] array = new Ts[] { default(Ts), new Ts() };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyGenericWithStructRestrictionAsObject<Ts>(array[i], useInterpreter);
            }
        }

        private static void CheckGenericWithStructRestrictionAsValueTypeHelper<Ts>(CompilationType useInterpreter) where Ts : struct
        {
            Ts[] array = new Ts[] { default(Ts), new Ts() };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyGenericWithStructRestrictionAsValueType<Ts>(array[i], useInterpreter);
            }
        }

        #endregion

        #region Test verifiers

        private static void VerifyNullableEnumAsEnumType(E? value, CompilationType useInterpreter)
        {
            Expression<Func<Enum>> e =
                Expression.Lambda<Func<Enum>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(E?)), typeof(Enum)),
                    Enumerable.Empty<ParameterExpression>());
            Func<Enum> f = e.Compile(useInterpreter);

            Assert.Equal(value as ValueType, f());
        }

        private static void VerifyEnumAsNullableEnumType(E value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e = Expression.Lambda<Func<E?>>(
                Expression.TypeAs(Expression.Constant(value), typeof(E?)));
            Func<E?> f = e.Compile(useInterpreter);
            Assert.Equal(value, f());
        }

        private static void VerifyNullableEnumAsNullableEnumType(E? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e = Expression.Lambda<Func<E?>>(
                Expression.TypeAs(Expression.Constant(value, typeof(E?)), typeof(E?)));
            Func<E?> f = e.Compile(useInterpreter);
            Assert.Equal(value, f());
        }

        private static void VerifyLongAsNullableEnumType(long value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e = Expression.Lambda<Func<E?>>(
                Expression.TypeAs(Expression.Constant(value), typeof(E?)));
            Func<E?> f = e.Compile(useInterpreter);
            Assert.False(f().HasValue);
        }

        private static void VerifyNullableLongAsNullableEnumType(long? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e = Expression.Lambda<Func<E?>>(
                Expression.TypeAs(Expression.Constant(value, typeof(long?)), typeof(E?)));
            Func<E?> f = e.Compile(useInterpreter);
            Assert.False(f().HasValue);
        }

        private static void VerifyNullableEnumAsObject(E? value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(E?)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyNullableIntAsObject(int? value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(int?)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyNullableIntAsValueType(int? value, CompilationType useInterpreter)
        {
            Expression<Func<ValueType>> e =
                Expression.Lambda<Func<ValueType>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(int?)), typeof(ValueType)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ValueType> f = e.Compile(useInterpreter);

            Assert.Equal(value as ValueType, f());
        }

        private static void VerifyNullableStructAsIEquatableOfStruct(S? value, CompilationType useInterpreter)
        {
            Expression<Func<IEquatable<S>>> e =
                Expression.Lambda<Func<IEquatable<S>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(S?)), typeof(IEquatable<S>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEquatable<S>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEquatable<S>, f());
        }

        private static void VerifyNullableStructAsObject(S? value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(S?)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyNullableStructAsValueType(S? value, CompilationType useInterpreter)
        {
            Expression<Func<ValueType>> e =
                Expression.Lambda<Func<ValueType>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(S?)), typeof(ValueType)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ValueType> f = e.Compile(useInterpreter);

            Assert.Equal(value as ValueType, f());
        }

        private static void VerifyGenericWithStructRestrictionAsObject<Ts>(Ts value, CompilationType useInterpreter) where Ts : struct
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(Ts)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyGenericWithStructRestrictionAsValueType<Ts>(Ts value, CompilationType useInterpreter) where Ts : struct
        {
            Expression<Func<ValueType>> e =
                Expression.Lambda<Func<ValueType>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(Ts)), typeof(ValueType)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ValueType> f = e.Compile(useInterpreter);

            Assert.Equal(value as ValueType, f());
        }

        #endregion
    }
}
