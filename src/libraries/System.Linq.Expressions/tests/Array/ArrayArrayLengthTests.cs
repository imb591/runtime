// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace System.Linq.Expressions.Tests
{
    public static class ArrayArrayLengthTests
    {
        #region Boolean tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckBoolArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckBoolArrayArrayLengthExpression(GenerateBoolArrayArray(0), useInterpreter);
            CheckBoolArrayArrayLengthExpression(GenerateBoolArrayArray(1), useInterpreter);
            CheckBoolArrayArrayLengthExpression(GenerateBoolArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionBoolArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionBoolArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Byte tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckByteArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckByteArrayArrayLengthExpression(GenerateByteArrayArray(0), useInterpreter);
            CheckByteArrayArrayLengthExpression(GenerateByteArrayArray(1), useInterpreter);
            CheckByteArrayArrayLengthExpression(GenerateByteArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionByteArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionByteArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Custom tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckCustomArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckCustomArrayArrayLengthExpression(GenerateCustomArrayArray(0), useInterpreter);
            CheckCustomArrayArrayLengthExpression(GenerateCustomArrayArray(1), useInterpreter);
            CheckCustomArrayArrayLengthExpression(GenerateCustomArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionCustomArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionCustomArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Char tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckCharArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckCharArrayArrayLengthExpression(GenerateCharArrayArray(0), useInterpreter);
            CheckCharArrayArrayLengthExpression(GenerateCharArrayArray(1), useInterpreter);
            CheckCharArrayArrayLengthExpression(GenerateCharArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionCharArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionCharArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Custom2 tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckCustom2ArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckCustom2ArrayArrayLengthExpression(GenerateCustom2ArrayArray(0), useInterpreter);
            CheckCustom2ArrayArrayLengthExpression(GenerateCustom2ArrayArray(1), useInterpreter);
            CheckCustom2ArrayArrayLengthExpression(GenerateCustom2ArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionCustom2ArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionCustom2ArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Decimal tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckDecimalArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckDecimalArrayArrayLengthExpression(GenerateDecimalArrayArray(0), useInterpreter);
            CheckDecimalArrayArrayLengthExpression(GenerateDecimalArrayArray(1), useInterpreter);
            CheckDecimalArrayArrayLengthExpression(GenerateDecimalArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionDecimalArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionDecimalArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Delegate tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckDelegateArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckDelegateArrayArrayLengthExpression(GenerateDelegateArrayArray(0), useInterpreter);
            CheckDelegateArrayArrayLengthExpression(GenerateDelegateArrayArray(1), useInterpreter);
            CheckDelegateArrayArrayLengthExpression(GenerateDelegateArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionDelegateArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionDelegateArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Double tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckDoubleArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckDoubleArrayArrayLengthExpression(GenerateDoubleArrayArray(0), useInterpreter);
            CheckDoubleArrayArrayLengthExpression(GenerateDoubleArrayArray(1), useInterpreter);
            CheckDoubleArrayArrayLengthExpression(GenerateDoubleArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionDoubleArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionDoubleArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Enum tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckEnumArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckEnumArrayArrayLengthExpression(GenerateEnumArrayArray(0), useInterpreter);
            CheckEnumArrayArrayLengthExpression(GenerateEnumArrayArray(1), useInterpreter);
            CheckEnumArrayArrayLengthExpression(GenerateEnumArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionEnumArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionEnumArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region EnumLong tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckEnumLongArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckEnumLongArrayArrayLengthExpression(GenerateEnumLongArrayArray(0), useInterpreter);
            CheckEnumLongArrayArrayLengthExpression(GenerateEnumLongArrayArray(1), useInterpreter);
            CheckEnumLongArrayArrayLengthExpression(GenerateEnumLongArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionEnumLongArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionEnumLongArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Float tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckFloatArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckFloatArrayArrayLengthExpression(GenerateFloatArrayArray(0), useInterpreter);
            CheckFloatArrayArrayLengthExpression(GenerateFloatArrayArray(1), useInterpreter);
            CheckFloatArrayArrayLengthExpression(GenerateFloatArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionFloatArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionFloatArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Func tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckFuncArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckFuncArrayArrayLengthExpression(GenerateFuncArrayArray(0), useInterpreter);
            CheckFuncArrayArrayLengthExpression(GenerateFuncArrayArray(1), useInterpreter);
            CheckFuncArrayArrayLengthExpression(GenerateFuncArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionFuncArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionFuncArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Interface tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckInterfaceArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckInterfaceArrayArrayLengthExpression(GenerateInterfaceArrayArray(0), useInterpreter);
            CheckInterfaceArrayArrayLengthExpression(GenerateInterfaceArrayArray(1), useInterpreter);
            CheckInterfaceArrayArrayLengthExpression(GenerateInterfaceArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionInterfaceArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionInterfaceArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region IEquatableCustom tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckIEquatableCustomArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckIEquatableCustomArrayArrayLengthExpression(GenerateIEquatableCustomArrayArray(0), useInterpreter);
            CheckIEquatableCustomArrayArrayLengthExpression(GenerateIEquatableCustomArrayArray(1), useInterpreter);
            CheckIEquatableCustomArrayArrayLengthExpression(GenerateIEquatableCustomArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionIEquatableCustomArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionIEquatableCustomArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region IEquatableCustom2 tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckIEquatableCustom2ArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckIEquatableCustom2ArrayArrayLengthExpression(GenerateIEquatableCustom2ArrayArray(0), useInterpreter);
            CheckIEquatableCustom2ArrayArrayLengthExpression(GenerateIEquatableCustom2ArrayArray(1), useInterpreter);
            CheckIEquatableCustom2ArrayArrayLengthExpression(GenerateIEquatableCustom2ArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionIEquatableCustom2ArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionIEquatableCustom2ArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Int tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckIntArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckIntArrayArrayLengthExpression(GenerateIntArrayArray(0), useInterpreter);
            CheckIntArrayArrayLengthExpression(GenerateIntArrayArray(1), useInterpreter);
            CheckIntArrayArrayLengthExpression(GenerateIntArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionIntArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionIntArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Long tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckLongArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckLongArrayArrayLengthExpression(GenerateLongArrayArray(0), useInterpreter);
            CheckLongArrayArrayLengthExpression(GenerateLongArrayArray(1), useInterpreter);
            CheckLongArrayArrayLengthExpression(GenerateLongArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionLongArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionLongArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Object tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckObjectArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckObjectArrayArrayLengthExpression(GenerateObjectArrayArray(0), useInterpreter);
            CheckObjectArrayArrayLengthExpression(GenerateObjectArrayArray(1), useInterpreter);
            CheckObjectArrayArrayLengthExpression(GenerateObjectArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionObjectArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionObjectArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Struct tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckStructArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckStructArrayArrayLengthExpression(GenerateStructArrayArray(0), useInterpreter);
            CheckStructArrayArrayLengthExpression(GenerateStructArrayArray(1), useInterpreter);
            CheckStructArrayArrayLengthExpression(GenerateStructArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionStructArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionStructArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region SByte tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckSByteArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckSByteArrayArrayLengthExpression(GenerateSByteArrayArray(0), useInterpreter);
            CheckSByteArrayArrayLengthExpression(GenerateSByteArrayArray(1), useInterpreter);
            CheckSByteArrayArrayLengthExpression(GenerateSByteArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionSByteArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionSByteArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region StructWithString tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckStructWithStringArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckStructWithStringArrayArrayLengthExpression(GenerateStructWithStringArrayArray(0), useInterpreter);
            CheckStructWithStringArrayArrayLengthExpression(GenerateStructWithStringArrayArray(1), useInterpreter);
            CheckStructWithStringArrayArrayLengthExpression(GenerateStructWithStringArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionStructWithStringArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionStructWithStringArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region StructWithStringAndValue tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckStructWithStringAndValueArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckStructWithStringAndValueArrayArrayLengthExpression(GenerateStructWithStringAndValueArrayArray(0), useInterpreter);
            CheckStructWithStringAndValueArrayArrayLengthExpression(GenerateStructWithStringAndValueArrayArray(1), useInterpreter);
            CheckStructWithStringAndValueArrayArrayLengthExpression(GenerateStructWithStringAndValueArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionStructWithStringAndValueArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionStructWithStringAndValueArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Short tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckShortArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckShortArrayArrayLengthExpression(GenerateShortArrayArray(0), useInterpreter);
            CheckShortArrayArrayLengthExpression(GenerateShortArrayArray(1), useInterpreter);
            CheckShortArrayArrayLengthExpression(GenerateShortArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionShortArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionShortArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region StructWithTwoValues tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckStructWithTwoValuesArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckStructWithTwoValuesArrayArrayLengthExpression(GenerateStructWithTwoValuesArrayArray(0), useInterpreter);
            CheckStructWithTwoValuesArrayArrayLengthExpression(GenerateStructWithTwoValuesArrayArray(1), useInterpreter);
            CheckStructWithTwoValuesArrayArrayLengthExpression(GenerateStructWithTwoValuesArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionStructWithTwoValuesArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionStructWithTwoValuesArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region StructWithValue tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckStructWithValueArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckStructWithValueArrayArrayLengthExpression(GenerateStructWithValueArrayArray(0), useInterpreter);
            CheckStructWithValueArrayArrayLengthExpression(GenerateStructWithValueArrayArray(1), useInterpreter);
            CheckStructWithValueArrayArrayLengthExpression(GenerateStructWithValueArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionStructWithValueArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionStructWithValueArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region String tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckStringArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckStringArrayArrayLengthExpression(GenerateStringArrayArray(0), useInterpreter);
            CheckStringArrayArrayLengthExpression(GenerateStringArrayArray(1), useInterpreter);
            CheckStringArrayArrayLengthExpression(GenerateStringArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionStringArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionStringArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region UInt tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckUIntArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckUIntArrayArrayLengthExpression(GenerateUIntArrayArray(0), useInterpreter);
            CheckUIntArrayArrayLengthExpression(GenerateUIntArrayArray(1), useInterpreter);
            CheckUIntArrayArrayLengthExpression(GenerateUIntArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionUIntArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionUIntArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region ULong tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckULongArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckULongArrayArrayLengthExpression(GenerateULongArrayArray(0), useInterpreter);
            CheckULongArrayArrayLengthExpression(GenerateULongArrayArray(1), useInterpreter);
            CheckULongArrayArrayLengthExpression(GenerateULongArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionULongArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionULongArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region UShort tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckUShortArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckUShortArrayArrayLengthExpression(GenerateUShortArrayArray(0), useInterpreter);
            CheckUShortArrayArrayLengthExpression(GenerateUShortArrayArray(1), useInterpreter);
            CheckUShortArrayArrayLengthExpression(GenerateUShortArrayArray(5), useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionUShortArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionUShortArrayArrayLength(null, useInterpreter);
        }

        #endregion

        #region Generic tests

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericCustomArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericArrayArrayLengthTestHelper<C>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericCustomArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericArrayArrayLengthTestHelper<C>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericEnumArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericArrayArrayLengthTestHelper<E>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericEnumArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericArrayArrayLengthTestHelper<E>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericObjectArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericArrayArrayLengthTestHelper<object>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericObjectArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericArrayArrayLengthTestHelper<object>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericStructArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericArrayArrayLengthTestHelper<S>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericStructArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericArrayArrayLengthTestHelper<S>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericStructWithStringAndValueArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericArrayArrayLengthTestHelper<Scs>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericStructWithStringAndValueArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericArrayArrayLengthTestHelper<Scs>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericCustomWithClassRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericWithClassRestrictionArrayArrayLengthTestHelper<C>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericCustomWithClassRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericWithClassRestrictionArrayArrayLengthTestHelper<C>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericObjectWithClassRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericWithClassRestrictionArrayArrayLengthTestHelper<object>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericObjectWithClassRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericWithClassRestrictionArrayArrayLengthTestHelper<object>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericCustomWithSubClassRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericWithSubClassRestrictionArrayArrayLengthTestHelper<C>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericCustomWithSubClassRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericWithSubClassRestrictionArrayArrayLengthTestHelper<C>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericCustomWithClassAndNewRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericWithClassAndNewRestrictionArrayArrayLengthTestHelper<C>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericCustomWithClassAndNewRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericWithClassAndNewRestrictionArrayArrayLengthTestHelper<C>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericObjectWithClassAndNewRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericWithClassAndNewRestrictionArrayArrayLengthTestHelper<object>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericObjectWithClassAndNewRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericWithClassAndNewRestrictionArrayArrayLengthTestHelper<object>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericCustomWithSubClassAndNewRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericWithSubClassAndNewRestrictionArrayArrayLengthTestHelper<C>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericCustomWithSubClassAndNewRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericWithSubClassAndNewRestrictionArrayArrayLengthTestHelper<C>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericEnumWithStructRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionArrayArrayLengthTestHelper<E>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericEnumWithStructRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericWithStructRestrictionArrayArrayLengthTestHelper<E>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericStructWithStructRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionArrayArrayLengthTestHelper<S>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericStructWithStructRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericWithStructRestrictionArrayArrayLengthTestHelper<S>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckGenericStructWithStringAndValueWithStructRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionArrayArrayLengthTestHelper<Scs>(useInterpreter);
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public static void CheckExceptionGenericStructWithStringAndValueWithStructRestrictionArrayArrayLengthTest(CompilationType useInterpreter)
        {
            CheckExceptionGenericWithStructRestrictionArrayArrayLengthTestHelper<Scs>(useInterpreter);
        }

        #endregion

        #region Generic helpers

        private static void CheckGenericArrayArrayLengthTestHelper<T>(CompilationType useInterpreter)
        {
            CheckGenericArrayArrayLengthExpression<T>(GenerateGenericArrayArray<T>(0), useInterpreter);
            CheckGenericArrayArrayLengthExpression<T>(GenerateGenericArrayArray<T>(1), useInterpreter);
            CheckGenericArrayArrayLengthExpression<T>(GenerateGenericArrayArray<T>(5), useInterpreter);
        }

        private static void CheckExceptionGenericArrayArrayLengthTestHelper<T>(CompilationType useInterpreter)
        {
            CheckExceptionGenericArrayArrayLength<T>(null, useInterpreter);
        }

        private static void CheckGenericWithClassRestrictionArrayArrayLengthTestHelper<Tc>(CompilationType useInterpreter) where Tc : class
        {
            CheckGenericWithClassRestrictionArrayArrayLengthExpression<Tc>(GenerateGenericWithClassRestrictionArrayArray<Tc>(0), useInterpreter);
            CheckGenericWithClassRestrictionArrayArrayLengthExpression<Tc>(GenerateGenericWithClassRestrictionArrayArray<Tc>(1), useInterpreter);
            CheckGenericWithClassRestrictionArrayArrayLengthExpression<Tc>(GenerateGenericWithClassRestrictionArrayArray<Tc>(5), useInterpreter);
        }

        private static void CheckExceptionGenericWithClassRestrictionArrayArrayLengthTestHelper<Tc>(CompilationType useInterpreter) where Tc : class
        {
            CheckExceptionGenericWithClassRestrictionArrayArrayLength<Tc>(null, useInterpreter);
        }

        private static void CheckGenericWithSubClassRestrictionArrayArrayLengthTestHelper<TC>(CompilationType useInterpreter) where TC : C
        {
            CheckGenericWithSubClassRestrictionArrayArrayLengthExpression<TC>(GenerateGenericWithSubClassRestrictionArrayArray<TC>(0), useInterpreter);
            CheckGenericWithSubClassRestrictionArrayArrayLengthExpression<TC>(GenerateGenericWithSubClassRestrictionArrayArray<TC>(1), useInterpreter);
            CheckGenericWithSubClassRestrictionArrayArrayLengthExpression<TC>(GenerateGenericWithSubClassRestrictionArrayArray<TC>(5), useInterpreter);
        }

        private static void CheckExceptionGenericWithSubClassRestrictionArrayArrayLengthTestHelper<TC>(CompilationType useInterpreter) where TC : C
        {
            CheckExceptionGenericWithSubClassRestrictionArrayArrayLength<TC>(null, useInterpreter);
        }

        private static void CheckGenericWithClassAndNewRestrictionArrayArrayLengthTestHelper<Tcn>(CompilationType useInterpreter) where Tcn : class, new()
        {
            CheckGenericWithClassAndNewRestrictionArrayArrayLengthExpression<Tcn>(GenerateGenericWithClassAndNewRestrictionArrayArray<Tcn>(0), useInterpreter);
            CheckGenericWithClassAndNewRestrictionArrayArrayLengthExpression<Tcn>(GenerateGenericWithClassAndNewRestrictionArrayArray<Tcn>(1), useInterpreter);
            CheckGenericWithClassAndNewRestrictionArrayArrayLengthExpression<Tcn>(GenerateGenericWithClassAndNewRestrictionArrayArray<Tcn>(5), useInterpreter);
        }

        private static void CheckExceptionGenericWithClassAndNewRestrictionArrayArrayLengthTestHelper<Tcn>(CompilationType useInterpreter) where Tcn : class, new()
        {
            CheckExceptionGenericWithClassAndNewRestrictionArrayArrayLength<Tcn>(null, useInterpreter);
        }

        private static void CheckGenericWithSubClassAndNewRestrictionArrayArrayLengthTestHelper<TCn>(CompilationType useInterpreter) where TCn : C, new()
        {
            CheckGenericWithSubClassAndNewRestrictionArrayArrayLengthExpression<TCn>(GenerateGenericWithSubClassAndNewRestrictionArrayArray<TCn>(0), useInterpreter);
            CheckGenericWithSubClassAndNewRestrictionArrayArrayLengthExpression<TCn>(GenerateGenericWithSubClassAndNewRestrictionArrayArray<TCn>(1), useInterpreter);
            CheckGenericWithSubClassAndNewRestrictionArrayArrayLengthExpression<TCn>(GenerateGenericWithSubClassAndNewRestrictionArrayArray<TCn>(5), useInterpreter);
        }

        private static void CheckExceptionGenericWithSubClassAndNewRestrictionArrayArrayLengthTestHelper<TCn>(CompilationType useInterpreter) where TCn : C, new()
        {
            CheckExceptionGenericWithSubClassAndNewRestrictionArrayArrayLength<TCn>(null, useInterpreter);
        }

        private static void CheckGenericWithStructRestrictionArrayArrayLengthTestHelper<Ts>(CompilationType useInterpreter) where Ts : struct
        {
            CheckGenericWithStructRestrictionArrayArrayLengthExpression<Ts>(GenerateGenericWithStructRestrictionArrayArray<Ts>(0), useInterpreter);
            CheckGenericWithStructRestrictionArrayArrayLengthExpression<Ts>(GenerateGenericWithStructRestrictionArrayArray<Ts>(1), useInterpreter);
            CheckGenericWithStructRestrictionArrayArrayLengthExpression<Ts>(GenerateGenericWithStructRestrictionArrayArray<Ts>(5), useInterpreter);
        }

        private static void CheckExceptionGenericWithStructRestrictionArrayArrayLengthTestHelper<Ts>(CompilationType useInterpreter) where Ts : struct
        {
            CheckExceptionGenericWithStructRestrictionArrayArrayLength<Ts>(null, useInterpreter);
        }

        #endregion

        #region Generate array

        private static bool[][] GenerateBoolArrayArray(int size)
        {
            bool[][] array = new bool[][] { null, new bool[0], new bool[] { true, false }, new bool[100] };
            bool[][] result = new bool[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static byte[][] GenerateByteArrayArray(int size)
        {
            byte[][] array = new byte[][] { null, new byte[0], new byte[] { 0, 1, byte.MaxValue }, new byte[100] };
            byte[][] result = new byte[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static C[][] GenerateCustomArrayArray(int size)
        {
            C[][] array = new C[][] { null, new C[0], new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[100] };
            C[][] result = new C[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static char[][] GenerateCharArrayArray(int size)
        {
            char[][] array = new char[][] { null, new char[0], new char[] { '\0', '\b', 'A', '\uffff' }, new char[100] };
            char[][] result = new char[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static D[][] GenerateCustom2ArrayArray(int size)
        {
            D[][] array = new D[][] { null, new D[0], new D[] { null, new D(), new D(0), new D(5) }, new D[100] };
            D[][] result = new D[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static decimal[][] GenerateDecimalArrayArray(int size)
        {
            decimal[][] array = new decimal[][] { null, new decimal[0], new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue }, new decimal[100] };
            decimal[][] result = new decimal[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static Delegate[][] GenerateDelegateArrayArray(int size)
        {
            Delegate[][] array = new Delegate[][] { null, new Delegate[0], new Delegate[] { null, (Func<object>)delegate () { return null; }, (Func<int, int>)delegate (int i) { return i + 1; }, (Action<object>)delegate { } }, new Delegate[100] };
            Delegate[][] result = new Delegate[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static double[][] GenerateDoubleArrayArray(int size)
        {
            double[][] array = new double[][] { null, new double[0], new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN }, new double[100] };
            double[][] result = new double[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static E[][] GenerateEnumArrayArray(int size)
        {
            E[][] array = new E[][] { null, new E[0], new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue }, new E[100] };
            E[][] result = new E[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static El[][] GenerateEnumLongArrayArray(int size)
        {
            El[][] array = new El[][] { null, new El[0], new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue }, new El[100] };
            El[][] result = new El[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static float[][] GenerateFloatArrayArray(int size)
        {
            float[][] array = new float[][] { null, new float[0], new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN }, new float[100] };
            float[][] result = new float[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static Func<object>[][] GenerateFuncArrayArray(int size)
        {
            Func<object>[][] array = new Func<object>[][] { null, new Func<object>[0], new Func<object>[] { null, (Func<object>)delegate () { return null; } }, new Func<object>[100] };
            Func<object>[][] result = new Func<object>[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static I[][] GenerateInterfaceArrayArray(int size)
        {
            I[][] array = new I[][] { null, new I[0], new I[] { null, new C(), new D(), new D(0), new D(5) }, new I[100] };
            I[][] result = new I[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static IEquatable<C>[][] GenerateIEquatableCustomArrayArray(int size)
        {
            IEquatable<C>[][] array = new IEquatable<C>[][] { null, new IEquatable<C>[0], new IEquatable<C>[] { null, new C(), new D(), new D(0), new D(5) }, new IEquatable<C>[100] };
            IEquatable<C>[][] result = new IEquatable<C>[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static IEquatable<D>[][] GenerateIEquatableCustom2ArrayArray(int size)
        {
            IEquatable<D>[][] array = new IEquatable<D>[][] { null, new IEquatable<D>[0], new IEquatable<D>[] { null, new D(), new D(0), new D(5) }, new IEquatable<D>[100] };
            IEquatable<D>[][] result = new IEquatable<D>[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static int[][] GenerateIntArrayArray(int size)
        {
            int[][] array = new int[][] { null, new int[0], new int[] { 0, 1, -1, int.MinValue, int.MaxValue }, new int[100] };
            int[][] result = new int[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static long[][] GenerateLongArrayArray(int size)
        {
            long[][] array = new long[][] { null, new long[0], new long[] { 0, 1, -1, long.MinValue, long.MaxValue }, new long[100] };
            long[][] result = new long[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static object[][] GenerateObjectArrayArray(int size)
        {
            object[][] array = new object[][] { null, new object[0], new object[] { null, new object(), new C(), new D(3) }, new object[100] };
            object[][] result = new object[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static S[][] GenerateStructArrayArray(int size)
        {
            S[][] array = new S[][] { null, new S[0], new S[] { default(S), new S() }, new S[100] };
            S[][] result = new S[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static sbyte[][] GenerateSByteArrayArray(int size)
        {
            sbyte[][] array = new sbyte[][] { null, new sbyte[0], new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue }, new sbyte[100] };
            sbyte[][] result = new sbyte[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static Sc[][] GenerateStructWithStringArrayArray(int size)
        {
            Sc[][] array = new Sc[][] { null, new Sc[0], new Sc[] { default(Sc), new Sc(), new Sc(null) }, new Sc[100] };
            Sc[][] result = new Sc[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static Scs[][] GenerateStructWithStringAndValueArrayArray(int size)
        {
            Scs[][] array = new Scs[][] { null, new Scs[0], new Scs[] { default(Scs), new Scs(), new Scs(null, new S()) }, new Scs[100] };
            Scs[][] result = new Scs[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static short[][] GenerateShortArrayArray(int size)
        {
            short[][] array = new short[][] { null, new short[0], new short[] { 0, 1, -1, short.MinValue, short.MaxValue }, new short[100] };
            short[][] result = new short[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static Sp[][] GenerateStructWithTwoValuesArrayArray(int size)
        {
            Sp[][] array = new Sp[][] { null, new Sp[0], new Sp[] { default(Sp), new Sp(), new Sp(5, 5.0) }, new Sp[100] };
            Sp[][] result = new Sp[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static Ss[][] GenerateStructWithValueArrayArray(int size)
        {
            Ss[][] array = new Ss[][] { null, new Ss[0], new Ss[] { default(Ss), new Ss(), new Ss(new S()) }, new Ss[100] };
            Ss[][] result = new Ss[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static string[][] GenerateStringArrayArray(int size)
        {
            string[][] array = new string[][] { null, new string[0], new string[] { null, "", "a", "foo" }, new string[100] };
            string[][] result = new string[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static uint[][] GenerateUIntArrayArray(int size)
        {
            uint[][] array = new uint[][] { null, new uint[0], new uint[] { 0, 1, uint.MaxValue }, new uint[100] };
            uint[][] result = new uint[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static ulong[][] GenerateULongArrayArray(int size)
        {
            ulong[][] array = new ulong[][] { null, new ulong[0], new ulong[] { 0, 1, ulong.MaxValue }, new ulong[100] };
            ulong[][] result = new ulong[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static ushort[][] GenerateUShortArrayArray(int size)
        {
            ushort[][] array = new ushort[][] { null, new ushort[0], new ushort[] { 0, 1, ushort.MaxValue }, new ushort[100] };
            ushort[][] result = new ushort[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static T[][] GenerateGenericArrayArray<T>(int size)
        {
            T[][] array = new T[][] { null, new T[0], new T[] { default(T) }, new T[100] };
            T[][] result = new T[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static Tc[][] GenerateGenericWithClassRestrictionArrayArray<Tc>(int size) where Tc : class
        {
            Tc[][] array = new Tc[][] { null, new Tc[0], new Tc[] { null, default(Tc) }, new Tc[100] };
            Tc[][] result = new Tc[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static TC[][] GenerateGenericWithSubClassRestrictionArrayArray<TC>(int size) where TC : C
        {
            TC[][] array = new TC[][] { null, new TC[0], new TC[] { null, default(TC), (TC)new C() }, new TC[100] };
            TC[][] result = new TC[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static Tcn[][] GenerateGenericWithClassAndNewRestrictionArrayArray<Tcn>(int size) where Tcn : class, new()
        {
            Tcn[][] array = new Tcn[][] { null, new Tcn[0], new Tcn[] { null, default(Tcn), new Tcn() }, new Tcn[100] };
            Tcn[][] result = new Tcn[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static TCn[][] GenerateGenericWithSubClassAndNewRestrictionArrayArray<TCn>(int size) where TCn : C, new()
        {
            TCn[][] array = new TCn[][] { null, new TCn[0], new TCn[] { null, default(TCn), new TCn(), (TCn)new C() }, new TCn[100] };
            TCn[][] result = new TCn[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        private static Ts[][] GenerateGenericWithStructRestrictionArrayArray<Ts>(int size) where Ts : struct
        {
            Ts[][] array = new Ts[][] { null, new Ts[0], new Ts[] { default(Ts), new Ts() }, new Ts[100] };
            Ts[][] result = new Ts[size][];
            for (int i = 0; i < size; i++)
            {
                result[i] = array[i % array.Length];
            }

            return result;
        }

        #endregion

        #region Check length expression

        private static void CheckBoolArrayArrayLengthExpression(bool[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(bool[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckByteArrayArrayLengthExpression(byte[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(byte[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckCustomArrayArrayLengthExpression(C[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(C[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckCharArrayArrayLengthExpression(char[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(char[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckCustom2ArrayArrayLengthExpression(D[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(D[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckDecimalArrayArrayLengthExpression(decimal[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(decimal[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckDelegateArrayArrayLengthExpression(Delegate[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(Delegate[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckDoubleArrayArrayLengthExpression(double[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(double[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckEnumArrayArrayLengthExpression(E[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(E[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckEnumLongArrayArrayLengthExpression(El[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(El[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckFloatArrayArrayLengthExpression(float[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(float[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckFuncArrayArrayLengthExpression(Func<object>[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(Func<object>[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckInterfaceArrayArrayLengthExpression(I[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(I[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckIEquatableCustomArrayArrayLengthExpression(IEquatable<C>[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(IEquatable<C>[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckIEquatableCustom2ArrayArrayLengthExpression(IEquatable<D>[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(IEquatable<D>[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckIntArrayArrayLengthExpression(int[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(int[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckLongArrayArrayLengthExpression(long[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(long[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckObjectArrayArrayLengthExpression(object[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(object[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckStructArrayArrayLengthExpression(S[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(S[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckSByteArrayArrayLengthExpression(sbyte[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(sbyte[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckStructWithStringArrayArrayLengthExpression(Sc[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(Sc[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckStructWithStringAndValueArrayArrayLengthExpression(Scs[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(Scs[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckShortArrayArrayLengthExpression(short[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(short[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckStructWithTwoValuesArrayArrayLengthExpression(Sp[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(Sp[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckStructWithValueArrayArrayLengthExpression(Ss[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(Ss[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckStringArrayArrayLengthExpression(string[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(string[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckUIntArrayArrayLengthExpression(uint[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(uint[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckULongArrayArrayLengthExpression(ulong[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(ulong[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckUShortArrayArrayLengthExpression(ushort[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(ushort[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckGenericArrayArrayLengthExpression<T>(T[][] array, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(T[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckGenericWithClassRestrictionArrayArrayLengthExpression<Tc>(Tc[][] array, CompilationType useInterpreter) where Tc : class
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(Tc[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckGenericWithSubClassRestrictionArrayArrayLengthExpression<TC>(TC[][] array, CompilationType useInterpreter) where TC : C
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(TC[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckGenericWithClassAndNewRestrictionArrayArrayLengthExpression<Tcn>(Tcn[][] array, CompilationType useInterpreter) where Tcn : class, new()
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(Tcn[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckGenericWithSubClassAndNewRestrictionArrayArrayLengthExpression<TCn>(TCn[][] array, CompilationType useInterpreter) where TCn : C, new()
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(TCn[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        private static void CheckGenericWithStructRestrictionArrayArrayLengthExpression<Ts>(Ts[][] array, CompilationType useInterpreter) where Ts : struct
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ArrayLength(Expression.Constant(array, typeof(Ts[][]))),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);
            Assert.Equal(array.Length, f());
        }

        #endregion

        #region Check exception array length

        private static void CheckExceptionBoolArrayArrayLength(bool[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckBoolArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckBoolArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionByteArrayArrayLength(byte[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckByteArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckByteArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionCustomArrayArrayLength(C[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckCustomArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckCustomArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionCharArrayArrayLength(char[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckCharArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckCharArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionCustom2ArrayArrayLength(D[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckCustom2ArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckCustom2ArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionDecimalArrayArrayLength(decimal[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckDecimalArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckDecimalArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionDelegateArrayArrayLength(Delegate[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckDelegateArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckDelegateArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionDoubleArrayArrayLength(double[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckDoubleArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckDoubleArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionEnumArrayArrayLength(E[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckEnumArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckEnumArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionEnumLongArrayArrayLength(El[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckEnumLongArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckEnumLongArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionFloatArrayArrayLength(float[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckFloatArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckFloatArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionFuncArrayArrayLength(Func<object>[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckFuncArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckFuncArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionInterfaceArrayArrayLength(I[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckInterfaceArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckInterfaceArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionIEquatableCustomArrayArrayLength(IEquatable<C>[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckIEquatableCustomArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckIEquatableCustomArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionIEquatableCustom2ArrayArrayLength(IEquatable<D>[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckIEquatableCustom2ArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckIEquatableCustom2ArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionIntArrayArrayLength(int[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckIntArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckIntArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionLongArrayArrayLength(long[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckLongArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckLongArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionObjectArrayArrayLength(object[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckObjectArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckObjectArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionStructArrayArrayLength(S[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckStructArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckStructArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionSByteArrayArrayLength(sbyte[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckSByteArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckSByteArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionStructWithStringArrayArrayLength(Sc[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckStructWithStringArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckStructWithStringArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionStructWithStringAndValueArrayArrayLength(Scs[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckStructWithStringAndValueArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckStructWithStringAndValueArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionShortArrayArrayLength(short[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckShortArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckShortArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionStructWithTwoValuesArrayArrayLength(Sp[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckStructWithTwoValuesArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckStructWithTwoValuesArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionStructWithValueArrayArrayLength(Ss[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckStructWithValueArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckStructWithValueArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionStringArrayArrayLength(string[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckStringArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckStringArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionUIntArrayArrayLength(uint[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckUIntArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckUIntArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionULongArrayArrayLength(ulong[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckULongArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckULongArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionUShortArrayArrayLength(ushort[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckUShortArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckUShortArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionGenericArrayArrayLength<T>(T[][] array, CompilationType useInterpreter)
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckGenericArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckGenericArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionGenericWithClassRestrictionArrayArrayLength<Tc>(Tc[][] array, CompilationType useInterpreter) where Tc : class
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckGenericWithClassRestrictionArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckGenericWithClassRestrictionArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionGenericWithSubClassRestrictionArrayArrayLength<TC>(TC[][] array, CompilationType useInterpreter) where TC : C
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckGenericWithSubClassRestrictionArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckGenericWithSubClassRestrictionArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionGenericWithClassAndNewRestrictionArrayArrayLength<Tcn>(Tcn[][] array, CompilationType useInterpreter) where Tcn : class, new()
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckGenericWithClassAndNewRestrictionArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckGenericWithClassAndNewRestrictionArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionGenericWithSubClassAndNewRestrictionArrayArrayLength<TCn>(TCn[][] array, CompilationType useInterpreter) where TCn : C, new()
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckGenericWithSubClassAndNewRestrictionArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckGenericWithSubClassAndNewRestrictionArrayArrayLengthExpression(array, useInterpreter));
        }

        private static void CheckExceptionGenericWithStructRestrictionArrayArrayLength<Ts>(Ts[][] array, CompilationType useInterpreter) where Ts : struct
        {
            if (array == null)
                Assert.Throws<NullReferenceException>(() => CheckGenericWithStructRestrictionArrayArrayLengthExpression(array, useInterpreter));
            else
                Assert.Throws<IndexOutOfRangeException>(() => CheckGenericWithStructRestrictionArrayArrayLengthExpression(array, useInterpreter));
        }

        #endregion

        #region Regression tests

        [Fact]
        public static void ArrayLength_MultiDimensionalOf1()
        {
            foreach (var e in new Expression[] { Expression.Parameter(typeof(int).MakeArrayType(1)), Expression.Constant(new int[2, 2]) })
            {
                AssertExtensions.Throws<ArgumentException>("array", () => Expression.ArrayLength(e));
            }
        }

        #endregion
    }
}
