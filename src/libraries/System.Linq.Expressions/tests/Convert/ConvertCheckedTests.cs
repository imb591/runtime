// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace System.Linq.Expressions.Tests
{
    public static class ConvertCheckedTests
    {
        #region Test methods

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToByteTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToCharTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToDecimalTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToDoubleTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToEnumTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToFloatTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToIntTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToLongTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToSByteTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToShortTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToUIntTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToULongTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToUShortTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedByteToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyCheckedByteToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToByteTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToCharTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToDecimalTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToDoubleTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToEnumTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToFloatTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToIntTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToLongTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToSByteTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToShortTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToUIntTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToULongTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToUShortTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableByteToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyCheckedNullableByteToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToByteTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToCharTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToDecimalTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToDoubleTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToEnumTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToFloatTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToIntTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToLongTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToSByteTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToShortTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToUIntTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToULongTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToUShortTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedCharToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedCharToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToByteTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToCharTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToDecimalTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToDoubleTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToEnumTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToFloatTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToIntTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToLongTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToSByteTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToShortTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToUIntTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToULongTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToUShortTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableCharToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyCheckedNullableCharToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToByteTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToCharTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToDecimalTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToDoubleTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToFloatTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToIntTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToLongTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToSByteTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToShortTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToUIntTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToULongTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToUShortTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDecimalToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedDecimalToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToByteTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToCharTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToDecimalTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToDoubleTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToFloatTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToIntTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToLongTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToSByteTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToShortTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToUIntTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToULongTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToUShortTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDecimalToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyCheckedNullableDecimalToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToByteTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToCharTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToDecimalTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToDoubleTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToEnumTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToFloatTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToIntTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToLongTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToSByteTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToShortTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToUIntTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToULongTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToUShortTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedDoubleToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedDoubleToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToByteTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToCharTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToDecimalTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToDoubleTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToEnumTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToFloatTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToIntTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToLongTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToSByteTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToShortTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToUIntTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToULongTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToUShortTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableDoubleToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyCheckedNullableDoubleToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToByteTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToCharTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToDoubleTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToEnumTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToFloatTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToIntTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToLongTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToSByteTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToShortTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToUIntTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToULongTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToUShortTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedEnumToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToByteTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToCharTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToDoubleTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToEnumTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToFloatTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToIntTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToLongTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToSByteTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToShortTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToUIntTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToULongTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToUShortTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyCheckedNullableEnumToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToByteTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToCharTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToDoubleTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToEnumTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToFloatTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToIntTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToLongTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToSByteTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToShortTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToUIntTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToULongTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToUShortTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedEnumLongToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedEnumLongToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToByteTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToCharTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToDoubleTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToEnumTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToFloatTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToIntTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToLongTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToSByteTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToShortTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToUIntTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToULongTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToUShortTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableEnumLongToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyCheckedNullableEnumLongToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToByteTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToCharTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToDecimalTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToDoubleTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToEnumTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToFloatTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToIntTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToLongTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToSByteTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToShortTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToUIntTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToULongTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToUShortTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedFloatToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedFloatToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToByteTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToCharTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToDecimalTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToDoubleTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToEnumTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToFloatTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToIntTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToLongTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToSByteTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToShortTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToUIntTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToULongTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToUShortTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableFloatToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyCheckedNullableFloatToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToByteTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToCharTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToDecimalTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToDoubleTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToEnumTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToFloatTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToIntTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToLongTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToSByteTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToShortTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToUIntTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToULongTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToUShortTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedIntToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedIntToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToByteTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToCharTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToDecimalTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToDoubleTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToEnumTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToFloatTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToIntTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToLongTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToSByteTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToShortTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToUIntTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToULongTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToUShortTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableIntToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyCheckedNullableIntToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToByteTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToCharTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToDecimalTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToDoubleTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToEnumTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToFloatTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToIntTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToLongTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToSByteTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToShortTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToUIntTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToULongTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToUShortTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedLongToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedLongToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToByteTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToCharTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToDecimalTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToDoubleTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToEnumTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToFloatTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToIntTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToLongTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToSByteTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToShortTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToUIntTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToULongTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToUShortTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableLongToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyCheckedNullableLongToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToCharTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToDecimalTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToDoubleTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToEnumTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToFloatTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToSByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToUIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToULongTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToUShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedSByteToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedSByteToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToCharTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToDecimalTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToDoubleTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToEnumTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToFloatTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToSByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToUIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToULongTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToUShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableSByteToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyCheckedNullableSByteToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToByteTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToCharTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToDecimalTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToDoubleTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToEnumTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToFloatTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToIntTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToLongTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToSByteTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToShortTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToUIntTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToULongTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToUShortTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedShortToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedShortToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToByteTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToCharTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToDecimalTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToDoubleTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToEnumTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToFloatTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToIntTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToLongTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToSByteTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToShortTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToUIntTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToULongTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToUShortTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableShortToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyCheckedNullableShortToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToByteTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToCharTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToDecimalTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToDoubleTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToEnumTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToFloatTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToIntTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToLongTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToSByteTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToShortTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToUIntTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToULongTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToUShortTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUIntToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyCheckedUIntToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToByteTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToCharTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToDecimalTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToDoubleTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToEnumTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToFloatTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToIntTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToLongTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToSByteTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToShortTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToUIntTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToULongTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToUShortTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUIntToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyCheckedNullableUIntToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToByteTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToCharTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToDecimalTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToDoubleTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToEnumTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToFloatTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToIntTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToLongTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToSByteTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToShortTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToUIntTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToULongTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToUShortTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedULongToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyCheckedULongToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToByteTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToCharTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToDecimalTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToDoubleTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToEnumTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToFloatTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToIntTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToLongTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToSByteTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToShortTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToUIntTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToULongTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToUShortTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableULongToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyCheckedNullableULongToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToByteTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToCharTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToDecimalTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToDoubleTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToEnumTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToFloatTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToIntTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToLongTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToSByteTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToShortTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToUIntTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToULongTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToUShortTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedUShortToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyCheckedUShortToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToByteTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToCharTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToDecimalTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToDoubleTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToEnumTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToFloatTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToIntTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToLongTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToSByteTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToShortTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToUIntTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToULongTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToUShortTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCheckedNullableUShortToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyCheckedNullableUShortToNullableUShort(value, useInterpreter);
            }
        }

        #endregion

        #region Test verifiers

        private static void VerifyCheckedByteToByte(byte value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToNullableByte(byte value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToChar(byte value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedByteToNullableChar(byte value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedByteToDecimal(byte value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToNullableDecimal(byte value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToDouble(byte value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToNullableDouble(byte value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToEnum(byte value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedByteToNullableEnum(byte value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedByteToEnumLong(byte value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedByteToNullableEnumLong(byte value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedByteToFloat(byte value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToNullableFloat(byte value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToInt(byte value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToNullableInt(byte value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToLong(byte value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToNullableLong(byte value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToSByte(byte value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedByteToNullableSByte(byte value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedByteToShort(byte value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToNullableShort(byte value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToUInt(byte value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToNullableUInt(byte value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToULong(byte value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToNullableULong(byte value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToUShort(byte value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedByteToNullableUShort(byte value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableByteToByte(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableByte(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableByteToChar(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((char)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableChar(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal((char?)value, f());
        }

        private static void VerifyCheckedNullableByteToDecimal(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableDecimal(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableByteToDouble(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableDouble(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableByteToEnum(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((E)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableEnum(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E?)value, f());
        }

        private static void VerifyCheckedNullableByteToEnumLong(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableEnumLong(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyCheckedNullableByteToFloat(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableFloat(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableByteToInt(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableInt(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableByteToLong(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableLong(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableByteToSByte(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                byte unboxed = value.GetValueOrDefault();
                if (unboxed > sbyte.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((sbyte)unboxed, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableSByte(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedNullableByteToShort(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableShort(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableByteToUInt(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableUInt(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableByteToULong(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableULong(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableByteToUShort(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableByteToNullableUShort(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(byte?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToByte(char value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedCharToNullableByte(char value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedCharToChar(char value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToNullableChar(char value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToDecimal(char value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToNullableDecimal(char value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToDouble(char value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToNullableDouble(char value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToEnum(char value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedCharToNullableEnum(char value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedCharToEnumLong(char value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedCharToNullableEnumLong(char value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedCharToFloat(char value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToNullableFloat(char value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToInt(char value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToNullableInt(char value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToLong(char value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToNullableLong(char value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToSByte(char value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value < sbyte.MinValue | value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedCharToNullableSByte(char value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedCharToShort(char value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedCharToNullableShort(char value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedCharToUInt(char value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToNullableUInt(char value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToULong(char value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToNullableULong(char value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToUShort(char value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedCharToNullableUShort(char value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableCharToByte(char? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableCharToNullableByte(char? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableCharToChar(char? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableCharToNullableChar(char? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableCharToDecimal(char? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableCharToNullableDecimal(char? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableCharToDouble(char? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableCharToNullableDouble(char? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableCharToEnum(char? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((E)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableCharToNullableEnum(char? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E?)value, f());
        }

        private static void VerifyCheckedNullableCharToEnumLong(char? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableCharToNullableEnumLong(char? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyCheckedNullableCharToFloat(char? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableCharToNullableFloat(char? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableCharToInt(char? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableCharToNullableInt(char? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableCharToLong(char? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableCharToNullableLong(char? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableCharToSByte(char? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                char unboxed = value.GetValueOrDefault();
                if (unboxed > sbyte.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((sbyte)unboxed, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableCharToNullableSByte(char? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < sbyte.MinValue | value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedNullableCharToShort(char? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableCharToNullableShort(char? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableCharToUInt(char? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableCharToNullableUInt(char? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableCharToULong(char? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableCharToNullableULong(char? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableCharToUShort(char? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableCharToNullableUShort(char? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(char?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedDecimalToByte(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            byte expected = 0;
            try
            {
                expected = (byte)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToNullableByte(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            byte expected = 0;
            try
            {
                expected = (byte)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToChar(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            char expected = '\0';
            try
            {
                expected = (char)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToNullableChar(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            char expected = '\0';
            try
            {
                expected = (char)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToDecimal(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedDecimalToNullableDecimal(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedDecimalToDouble(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyCheckedDecimalToNullableDouble(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyCheckedDecimalToFloat(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyCheckedDecimalToNullableFloat(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyCheckedDecimalToInt(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            int expected = 0;
            try
            {
                expected = (int)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToNullableInt(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            int expected = 0;
            try
            {
                expected = (int)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToLong(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            long expected = 0;
            try
            {
                expected = (long)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToNullableLong(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            long expected = 0;
            try
            {
                expected = (long)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToSByte(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            sbyte expected = 0;
            try
            {
                expected = (sbyte)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToNullableSByte(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            sbyte expected = 0;
            try
            {
                expected = (sbyte)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToShort(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            short expected = 0;
            try
            {
                expected = (short)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToNullableShort(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            short expected = 0;
            try
            {
                expected = (short)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToUInt(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            uint expected = 0;
            try
            {
                expected = (uint)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToNullableUInt(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            uint expected = 0;
            try
            {
                expected = (uint)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToULong(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            ulong expected = 0;
            try
            {
                expected = (ulong)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToNullableULong(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            ulong expected = 0;
            try
            {
                expected = (ulong)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToUShort(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            ushort expected = 0;
            try
            {
                expected = (ushort)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDecimalToNullableUShort(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            ushort expected = 0;
            try
            {
                expected = (ushort)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableDecimalToByte(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                byte expected = 0;
                try
                {
                    expected = (byte)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDecimalToNullableByte(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                byte expected = 0;
                try
                {
                    expected = (byte)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Null(f());
        }

        private static void VerifyCheckedNullableDecimalToChar(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                char expected = '\0';
                try
                {
                    expected = (char)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDecimalToNullableChar(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                char expected = '\0';
                try
                {
                    expected = (char)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Null(f());
        }

        private static void VerifyCheckedNullableDecimalToDecimal(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDecimalToNullableDecimal(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableDecimalToDouble(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((double?)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDecimalToNullableDouble(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal((double?)value, f());
        }

        private static void VerifyCheckedNullableDecimalToFloat(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((float)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDecimalToNullableFloat(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float?)value, f());
        }

        private static void VerifyCheckedNullableDecimalToInt(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                int expected = 0;
                try
                {
                    expected = (int)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDecimalToNullableInt(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                int expected = 0;
                try
                {
                    expected = (int)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Null(f());
        }

        private static void VerifyCheckedNullableDecimalToLong(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                long expected = 0;
                try
                {
                    expected = (long)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDecimalToNullableLong(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                long expected = 0;
                try
                {
                    expected = (long)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Null(f());
        }

        private static void VerifyCheckedNullableDecimalToSByte(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                sbyte expected = 0;
                try
                {
                    expected = (sbyte)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDecimalToNullableSByte(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                sbyte expected = 0;
                try
                {
                    expected = (sbyte)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Null(f());
        }

        private static void VerifyCheckedNullableDecimalToShort(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                short expected = 0;
                try
                {
                    expected = (short)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDecimalToNullableShort(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                short expected = 0;
                try
                {
                    expected = (short)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Null(f());
        }

        private static void VerifyCheckedNullableDecimalToUInt(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                uint expected = 0;
                try
                {
                    expected = (uint)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDecimalToNullableUInt(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                uint expected = 0;
                try
                {
                    expected = (uint)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Null(f());
        }

        private static void VerifyCheckedNullableDecimalToULong(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                ulong expected = 0;
                try
                {
                    expected = (ulong)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDecimalToNullableULong(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                ulong expected = 0;
                try
                {
                    expected = (ulong)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Null(f());
        }

        private static void VerifyCheckedNullableDecimalToUShort(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                ushort expected = 0;
                try
                {
                    expected = (ushort)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDecimalToNullableUShort(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(decimal?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                ushort expected = 0;
                try
                {
                    expected = (ushort)value.GetValueOrDefault();
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Null(f());
        }

        private static void VerifyCheckedDoubleToByte(double value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            byte expected = 0;
            try
            {
                expected = checked((byte)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToNullableByte(double value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            byte expected = 0;
            try
            {
                expected = checked((byte)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToChar(double value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            char expected = '\0';
            try
            {
                expected = checked((char)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToNullableChar(double value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            char expected = '\0';
            try
            {
                expected = checked((char)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToDecimal(double value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            decimal expected = 0;
            try
            {
                expected = (decimal)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToNullableDecimal(double value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            decimal expected = 0;
            try
            {
                expected = (decimal)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToDouble(double value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedDoubleToNullableDouble(double value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedDoubleToEnum(double value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            E expected = 0;
            try
            {
                expected = checked((E)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToNullableEnum(double value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            E expected = 0;
            try
            {
                expected = checked((E)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToEnumLong(double value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            El expected = 0;
            try
            {
                expected = checked((El)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToNullableEnumLong(double value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            El expected = 0;
            try
            {
                expected = checked((El)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToFloat(double value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyCheckedDoubleToNullableFloat(double value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyCheckedDoubleToInt(double value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            int expected = 0;
            try
            {
                expected = checked((int)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToNullableInt(double value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            int expected = 0;
            try
            {
                expected = checked((int)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToLong(double value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            long expected = 0;
            try
            {
                expected = checked((long)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToNullableLong(double value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            long expected = 0;
            try
            {
                expected = checked((long)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToSByte(double value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            sbyte expected = 0;
            try
            {
                expected = checked((sbyte)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToNullableSByte(double value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            sbyte expected = 0;
            try
            {
                expected = checked((sbyte)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToShort(double value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            short expected = 0;
            try
            {
                expected = checked((short)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToNullableShort(double value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            short expected = 0;
            try
            {
                expected = checked((short)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToUInt(double value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            uint expected = 0;
            try
            {
                expected = checked((uint)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToNullableUInt(double value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            uint expected = 0;
            try
            {
                expected = checked((uint)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToULong(double value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            ulong expected = 0;
            try
            {
                expected = checked((ulong)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToNullableULong(double value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            ulong expected = 0;
            try
            {
                expected = checked((ulong)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToUShort(double value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            ushort expected = 0;
            try
            {
                expected = checked((ushort)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedDoubleToNullableUShort(double value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            ushort expected = 0;
            try
            {
                expected = checked((ushort)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableDoubleToByte(double? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                byte expected = 0;
                try
                {
                    expected = checked((byte)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableByte(double? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            byte? expected = null;
            try
            {
                expected = checked((byte?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableDoubleToChar(double? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                char expected = '\0';
                try
                {
                    expected = checked((char)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableChar(double? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            char? expected = null;
            try
            {
                expected = checked((char?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableDoubleToDecimal(double? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                decimal expected = 0;
                try
                {
                    expected = checked((decimal)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableDecimal(double? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            decimal? expected = null;
            try
            {
                expected = (decimal?)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableDoubleToDouble(double? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableDouble(double? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableDoubleToEnum(double? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                E expected = 0;
                try
                {
                    expected = checked((E)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableEnum(double? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            E? expected = null;
            try
            {
                expected = checked((E?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableDoubleToEnumLong(double? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                El expected = 0;
                try
                {
                    expected = checked((El)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableEnumLong(double? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            El? expected = null;
            try
            {
                expected = checked((El?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableDoubleToFloat(double? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((float)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableFloat(double? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float?)value, f());
        }

        private static void VerifyCheckedNullableDoubleToInt(double? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                int expected = 0;
                try
                {
                    expected = checked((int)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableInt(double? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            int? expected = null;
            try
            {
                expected = checked((int?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableDoubleToLong(double? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                long expected = 0;
                try
                {
                    expected = checked((long)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableLong(double? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            long? expected = null;
            try
            {
                expected = checked((long?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableDoubleToSByte(double? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                sbyte expected = 0;
                try
                {
                    expected = checked((sbyte)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableSByte(double? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            sbyte? expected = null;
            try
            {
                expected = checked((sbyte?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableDoubleToShort(double? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                short expected = 0;
                try
                {
                    expected = checked((short)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableShort(double? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            short? expected = null;
            try
            {
                expected = checked((short?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableDoubleToUInt(double? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                uint expected = 0;
                try
                {
                    expected = checked((uint)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableUInt(double? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            uint? expected = null;
            try
            {
                expected = checked((uint?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableDoubleToULong(double? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                ulong expected = 0;
                try
                {
                    expected = checked((ulong)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableULong(double? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            ulong? expected = null;
            try
            {
                expected = checked((ulong?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableDoubleToUShort(double? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                ushort expected = 0;
                try
                {
                    expected = checked((ushort)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableDoubleToNullableUShort(double? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(double?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            ushort? expected = null;
            try
            {
                expected = checked((ushort?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedEnumToByte(E value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value < 0 | (int)value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedEnumToNullableByte(E value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (value < 0 | (int)value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedEnumToChar(E value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value < 0 | (int)value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedEnumToNullableChar(E value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (value < (E)char.MinValue | value > (E)char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedEnumToDouble(E value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyCheckedEnumToNullableDouble(E value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyCheckedEnumToEnum(E value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedEnumToNullableEnum(E value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedEnumToEnumLong(E value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedEnumToNullableEnumLong(E value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedEnumToFloat(E value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyCheckedEnumToNullableFloat(E value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyCheckedEnumToInt(E value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal((int)value, f());
        }

        private static void VerifyCheckedEnumToNullableInt(E value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal((int)value, f());
        }

        private static void VerifyCheckedEnumToLong(E value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal((long)value, f());
        }

        private static void VerifyCheckedEnumToNullableLong(E value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal((long)value, f());
        }

        private static void VerifyCheckedEnumToSByte(E value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if ((int)value < sbyte.MinValue | (int)value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedEnumToNullableSByte(E value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (value < 0 | (int)value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedEnumToShort(E value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value < (E)short.MinValue | value > (E)short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedEnumToNullableShort(E value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (value < (E)short.MinValue | value > (E)short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedEnumToUInt(E value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedEnumToNullableUInt(E value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedEnumToULong(E value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value, f());
        }

        private static void VerifyCheckedEnumToNullableULong(E value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value, f());
        }

        private static void VerifyCheckedEnumToUShort(E value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value < 0 | (int)value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedEnumToNullableUShort(E value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value < 0 | (int)value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedNullableEnumToByte(E? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | (int)value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableEnumToNullableByte(E? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0 | (int)value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableEnumToChar(E? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() < 0 | (int)value.GetValueOrDefault() > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedNullableEnumToNullableChar(E? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value.GetValueOrDefault() < 0 | (int)value.GetValueOrDefault() > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedNullableEnumToDouble(E? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((double)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableEnumToNullableDouble(E? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal((double?)value, f());
        }

        private static void VerifyCheckedNullableEnumToEnum(E? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableEnumToNullableEnum(E? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableEnumToEnumLong(E? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableEnumToNullableEnumLong(E? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyCheckedNullableEnumToFloat(E? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((float)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableEnumToNullableFloat(E? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float?)value, f());
        }

        private static void VerifyCheckedNullableEnumToInt(E? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((int)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableEnumToNullableInt(E? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal((int?)value, f());
        }

        private static void VerifyCheckedNullableEnumToLong(E? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((long)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableEnumToNullableLong(E? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal((long?)value, f());
        }

        private static void VerifyCheckedNullableEnumToSByte(E? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                E unboxed = value.GetValueOrDefault();
                if ((int)unboxed < sbyte.MinValue | (int)unboxed > sbyte.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((sbyte)unboxed, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableEnumToNullableSByte(E? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0 | (int)value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedNullableEnumToShort(E? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if ((int)value.GetValueOrDefault() < short.MinValue | (int)value.GetValueOrDefault() > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedNullableEnumToNullableShort(E? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if ((int)value.GetValueOrDefault() < short.MinValue | (int)value.GetValueOrDefault() > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedNullableEnumToUInt(E? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedNullableEnumToNullableUInt(E? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint?)value, f());
        }

        private static void VerifyCheckedNullableEnumToULong(E? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value, f());
        }

        private static void VerifyCheckedNullableEnumToNullableULong(E? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedNullableEnumToUShort(E? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() < 0 | (int)value.GetValueOrDefault() > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedNullableEnumToNullableUShort(E? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(E?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value.GetValueOrDefault() < 0 | (int)value.GetValueOrDefault() > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedEnumLongToByte(El value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value < 0 | (long)value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedEnumLongToNullableByte(El value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (value < 0 | (long)value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedEnumLongToChar(El value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value < 0 | (long)value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedEnumLongToNullableChar(El value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (value < 0 | (long)value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedEnumLongToDouble(El value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyCheckedEnumLongToNullableDouble(El value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyCheckedEnumLongToEnum(El value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if ((long)value < int.MinValue | (long)value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedEnumLongToNullableEnum(El value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            if ((long)value < int.MinValue | (long)value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedEnumLongToEnumLong(El value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedEnumLongToNullableEnumLong(El value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedEnumLongToFloat(El value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyCheckedEnumLongToNullableFloat(El value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyCheckedEnumLongToInt(El value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if ((long)value < int.MinValue | (long)value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((int)value, f());
        }

        private static void VerifyCheckedEnumLongToNullableInt(El value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            if ((long)value < int.MinValue | (long)value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((int)value, f());
        }

        private static void VerifyCheckedEnumLongToLong(El value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal((long)value, f());
        }

        private static void VerifyCheckedEnumLongToNullableLong(El value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal((long)value, f());
        }

        private static void VerifyCheckedEnumLongToSByte(El value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if ((long)value < sbyte.MinValue | (long)value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedEnumLongToNullableSByte(El value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if ((long)value < 0 | (long)value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedEnumLongToShort(El value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if ((long)value < short.MinValue | (long)value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedEnumLongToNullableShort(El value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if ((long)value < short.MinValue | (long)value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedEnumLongToUInt(El value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value < 0 | (long)value > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedEnumLongToNullableUInt(El value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (value < 0 | (long)value > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedEnumLongToULong(El value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value, f());
        }

        private static void VerifyCheckedEnumLongToNullableULong(El value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value, f());
        }

        private static void VerifyCheckedEnumLongToUShort(El value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value < 0 | (long)value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedEnumLongToNullableUShort(El value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value < 0 | (long)value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToByte(El? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | (long)value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToNullableByte(El? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0 | (long)value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToChar(El? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | (long)value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToNullableChar(El? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0 | (long)value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToDouble(El? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((double)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableEnumLongToNullableDouble(El? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal((double?)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToEnum(El? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                if ((long)value.GetValueOrDefault() < int.MinValue || (long)value.GetValueOrDefault() > int.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((E)value.GetValueOrDefault(), f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableEnumLongToNullableEnum(El? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if ((long)value < int.MinValue | (long)value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToEnumLong(El? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableEnumLongToNullableEnumLong(El? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableEnumLongToFloat(El? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((float)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableEnumLongToNullableFloat(El? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float?)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToInt(El? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if ((long)value < int.MinValue | (long)value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((int)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToNullableInt(El? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if ((long)value < int.MinValue | (long)value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((int)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToLong(El? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((long)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableEnumLongToNullableLong(El? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal((long?)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToSByte(El? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                El unboxed = value.GetValueOrDefault();
                if ((long)unboxed < sbyte.MinValue | (long)unboxed > sbyte.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((sbyte)unboxed, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableEnumLongToNullableSByte(El? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0 | (long)value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToShort(El? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if ((long)value < short.MinValue | (long)value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToNullableShort(El? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if ((long)value < short.MinValue | (long)value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToUInt(El? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | (long)value > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToNullableUInt(El? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0 | (long)value > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToULong(El? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableEnumLongToNullableULong(El? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            if ((!value.HasValue))
                Assert.Null(f());
            else if (value.GetValueOrDefault() < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong?)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableEnumLongToUShort(El? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | (long)value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedNullableEnumLongToNullableUShort(El? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(El?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0 | (long)value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedFloatToByte(float value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            byte expected = 0;
            try
            {
                expected = checked((byte)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToNullableByte(float value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            byte? expected = null;
            try
            {
                expected = checked((byte?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToChar(float value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            char expected = '\0';
            try
            {
                expected = checked((char)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToNullableChar(float value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            char expected = '\0';
            try
            {
                expected = checked((char)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToDecimal(float value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            decimal expected = 0;
            try
            {
                expected = (decimal)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToNullableDecimal(float value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            decimal expected = 0;
            try
            {
                expected = (decimal)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToDouble(float value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedFloatToNullableDouble(float value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedFloatToEnum(float value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            E expected = 0;
            try
            {
                expected = checked((E)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToNullableEnum(float value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            E expected = 0;
            try
            {
                expected = checked((E)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToEnumLong(float value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            El expected = 0;
            try
            {
                expected = checked((El)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToNullableEnumLong(float value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            El expected = 0;
            try
            {
                expected = checked((El)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToFloat(float value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedFloatToNullableFloat(float value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedFloatToInt(float value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            int expected = 0;
            try
            {
                expected = checked((int)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToNullableInt(float value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            int expected = 0;
            try
            {
                expected = checked((int)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToLong(float value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            long expected = 0;
            try
            {
                expected = checked((long)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToNullableLong(float value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            long expected = 0;
            try
            {
                expected = checked((long)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToSByte(float value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            sbyte expected = 0;
            try
            {
                expected = checked((sbyte)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToNullableSByte(float value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            sbyte expected = 0;
            try
            {
                expected = checked((sbyte)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToShort(float value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            short expected = 0;
            try
            {
                expected = checked((short)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToNullableShort(float value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            short expected = 0;
            try
            {
                expected = checked((short)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToUInt(float value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            uint expected = 0;
            try
            {
                expected = checked((uint)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToNullableUInt(float value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            uint expected = 0;
            try
            {
                expected = checked((uint)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToULong(float value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            ulong expected = 0;
            try
            {
                expected = checked((ulong)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToNullableULong(float value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            ulong expected = 0;
            try
            {
                expected = checked((ulong)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToUShort(float value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            ushort expected = 0;
            try
            {
                expected = checked((ushort)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedFloatToNullableUShort(float value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            ushort expected = 0;
            try
            {
                expected = checked((ushort)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableFloatToByte(float? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                byte expected = 0;
                try
                {
                    expected = checked((byte)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableByte(float? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            byte? expected = null;
            try
            {
                expected = checked((byte?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableFloatToChar(float? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                char expected = '\0';
                try
                {
                    expected = checked((char)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableChar(float? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            char? expected = null;
            try
            {
                expected = checked((char?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableFloatToDecimal(float? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                decimal expected = 0;
                try
                {
                    expected = checked((decimal)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableDecimal(float? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            decimal? expected = null;
            try
            {
                expected = (decimal?)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableFloatToDouble(float? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableDouble(float? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableFloatToEnum(float? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                E expected = 0;
                try
                {
                    expected = checked((E)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableEnum(float? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            E? expected = null;
            try
            {
                expected = checked((E?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableFloatToEnumLong(float? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                El expected = 0;
                try
                {
                    expected = checked((El)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableEnumLong(float? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            El? expected = null;
            try
            {
                expected = checked((El?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableFloatToFloat(float? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableFloat(float? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableFloatToInt(float? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                int expected = 0;
                try
                {
                    expected = checked((int)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableInt(float? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            int? expected = null;
            try
            {
                expected = checked((int?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableFloatToLong(float? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                long expected = 0;
                try
                {
                    expected = checked((long)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableLong(float? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            long? expected = null;
            try
            {
                expected = checked((long?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableFloatToSByte(float? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                sbyte expected = 0;
                try
                {
                    expected = checked((sbyte)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableSByte(float? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            sbyte? expected = null;
            try
            {
                expected = checked((sbyte?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableFloatToShort(float? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                short expected = 0;
                try
                {
                    expected = checked((short)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableShort(float? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            short? expected = null;
            try
            {
                expected = checked((short?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableFloatToUInt(float? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                uint expected = 0;
                try
                {
                    expected = checked((uint)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableUInt(float? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            uint? expected = null;
            try
            {
                expected = checked((uint?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableFloatToULong(float? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                ulong expected = 0;
                try
                {
                    expected = checked((ulong)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableULong(float? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            ulong? expected = null;
            try
            {
                expected = checked((ulong?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedNullableFloatToUShort(float? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                ushort expected = 0;
                try
                {
                    expected = checked((ushort)value.GetValueOrDefault());
                }
                catch (OverflowException)
                {
                    Assert.Throws<OverflowException>(() => f());
                    return;
                }

                Assert.Equal(expected, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableFloatToNullableUShort(float? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(float?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            ushort? expected = null;
            try
            {
                expected = checked((ushort?)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedIntToByte(int value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value < 0 | value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedIntToNullableByte(int value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            byte expected = 0;
            try
            {
                expected = checked((byte)value);
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyCheckedIntToChar(int value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value < 0 | value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedIntToNullableChar(int value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (value < 0 | value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedIntToDecimal(int value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedIntToNullableDecimal(int value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedIntToDouble(int value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedIntToNullableDouble(int value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedIntToEnum(int value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedIntToNullableEnum(int value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedIntToEnumLong(int value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedIntToNullableEnumLong(int value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedIntToFloat(int value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedIntToNullableFloat(int value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedIntToInt(int value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedIntToNullableInt(int value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedIntToLong(int value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedIntToNullableLong(int value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedIntToSByte(int value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value < sbyte.MinValue | value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedIntToNullableSByte(int value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (value < sbyte.MinValue | value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedIntToShort(int value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value < short.MinValue | value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedIntToNullableShort(int value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (value < short.MinValue | value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedIntToUInt(int value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedIntToNullableUInt(int value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedIntToULong(int value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedIntToNullableULong(int value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedIntToUShort(int value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value < 0 | value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedIntToNullableUShort(int value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value < 0 | value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedNullableIntToByte(int? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableIntToNullableByte(int? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0 | value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableIntToChar(int? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedNullableIntToNullableChar(int? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0 | value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedNullableIntToDecimal(int? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableIntToNullableDecimal(int? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableIntToDouble(int? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableIntToNullableDouble(int? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableIntToEnum(int? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((E)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableIntToNullableEnum(int? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E?)value, f());
        }

        private static void VerifyCheckedNullableIntToEnumLong(int? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableIntToNullableEnumLong(int? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyCheckedNullableIntToFloat(int? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableIntToNullableFloat(int? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableIntToInt(int? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableIntToNullableInt(int? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableIntToLong(int? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableIntToNullableLong(int? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableIntToSByte(int? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                int unboxed = value.GetValueOrDefault();
                if (unboxed < sbyte.MinValue | unboxed > sbyte.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((sbyte)unboxed, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableIntToNullableSByte(int? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < sbyte.MinValue | value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedNullableIntToShort(int? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < short.MinValue | value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedNullableIntToNullableShort(int? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < short.MinValue | value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedNullableIntToUInt(int? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedNullableIntToNullableUInt(int? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint?)value, f());
        }

        private static void VerifyCheckedNullableIntToULong(int? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value, f());
        }

        private static void VerifyCheckedNullableIntToNullableULong(int? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint?)value, f());
        }

        private static void VerifyCheckedNullableIntToUShort(int? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                if (value.GetValueOrDefault() < 0 | value.GetValueOrDefault() > ushort.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((ushort)value.GetValueOrDefault(), f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableIntToNullableUShort(int? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(int?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value.GetValueOrDefault() < 0 | value.GetValueOrDefault() > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort?)value, f());
        }

        private static void VerifyCheckedLongToByte(long value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value < 0 | value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedLongToNullableByte(long value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (value < 0 | value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedLongToChar(long value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value < 0 | value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedLongToNullableChar(long value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (value < 0 | value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedLongToDecimal(long value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedLongToNullableDecimal(long value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedLongToDouble(long value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedLongToNullableDouble(long value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedLongToEnum(long value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value < int.MinValue | value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedLongToNullableEnum(long value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            if (value < int.MinValue | value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedLongToEnumLong(long value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedLongToNullableEnumLong(long value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedLongToFloat(long value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedLongToNullableFloat(long value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedLongToInt(long value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value < int.MinValue | value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedLongToNullableInt(long value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            if (value < int.MinValue | value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((int)value, f());
        }

        private static void VerifyCheckedLongToLong(long value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedLongToNullableLong(long value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedLongToSByte(long value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value < sbyte.MinValue | value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedLongToNullableSByte(long value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (value < sbyte.MinValue | value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedLongToShort(long value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value < short.MinValue | value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedLongToNullableShort(long value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (value < short.MinValue | value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedLongToUInt(long value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value < 0 | value > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedLongToNullableUInt(long value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (value < 0 | value > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedLongToULong(long value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value, f());
        }

        private static void VerifyCheckedLongToNullableULong(long value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value, f());
        }

        private static void VerifyCheckedLongToUShort(long value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value < 0 | value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedLongToNullableUShort(long value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value < 0 | value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedNullableLongToByte(long? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableLongToNullableByte(long? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0 | value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableLongToChar(long? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableLongToNullableChar(long? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0 | value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableLongToDecimal(long? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableLongToNullableDecimal(long? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableLongToDouble(long? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableLongToNullableDouble(long? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableLongToEnum(long? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                if (value.GetValueOrDefault() < int.MinValue || value.GetValueOrDefault() > int.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((E)value.GetValueOrDefault(), f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableLongToNullableEnum(long? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < int.MinValue | value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((E)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableLongToEnumLong(long? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableLongToNullableEnumLong(long? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyCheckedNullableLongToFloat(long? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableLongToNullableFloat(long? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableLongToInt(long? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < int.MinValue | value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableLongToNullableInt(long? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            if (value < int.MinValue | value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableLongToLong(long? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableLongToNullableLong(long? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableLongToSByte(long? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                long unboxed = value.GetValueOrDefault();
                if (unboxed < sbyte.MinValue | unboxed > sbyte.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((sbyte)unboxed, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableLongToNullableSByte(long? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < sbyte.MinValue | value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedNullableLongToShort(long? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < short.MinValue | value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableLongToNullableShort(long? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (value < short.MinValue | value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableLongToUInt(long? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | value > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableLongToNullableUInt(long? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (value < 0 | value > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableLongToULong(long? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value, f());
        }

        private static void VerifyCheckedNullableLongToNullableULong(long? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong?)value, f());
        }

        private static void VerifyCheckedNullableLongToUShort(long? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableLongToNullableUShort(long? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(long?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value < 0 | value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToByte(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedSByteToNullableByte(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedSByteToChar(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedSByteToNullableChar(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedSByteToDecimal(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToNullableDecimal(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToDouble(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToNullableDouble(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToEnum(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedSByteToNullableEnum(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedSByteToEnumLong(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedSByteToNullableEnumLong(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedSByteToFloat(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToNullableFloat(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToInt(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToNullableInt(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToLong(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToNullableLong(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToSByte(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToNullableSByte(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToShort(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToNullableShort(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedSByteToUInt(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedSByteToNullableUInt(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedSByteToULong(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedSByteToNullableULong(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedSByteToUShort(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedSByteToNullableUShort(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedNullableSByteToByte(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableSByteToNullableByte(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableSByteToChar(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedNullableSByteToNullableChar(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char?)value, f());
        }

        private static void VerifyCheckedNullableSByteToDecimal(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableSByteToNullableDecimal(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableSByteToDouble(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableSByteToNullableDouble(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableSByteToEnum(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((E)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableSByteToNullableEnum(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E?)value, f());
        }

        private static void VerifyCheckedNullableSByteToEnumLong(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableSByteToNullableEnumLong(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyCheckedNullableSByteToFloat(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableSByteToNullableFloat(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableSByteToInt(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableSByteToNullableInt(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableSByteToLong(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableSByteToNullableLong(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableSByteToSByte(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableSByteToNullableSByte(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableSByteToShort(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableSByteToNullableShort(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableSByteToUInt(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableSByteToNullableUInt(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint?)value, f());
        }

        private static void VerifyCheckedNullableSByteToULong(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableSByteToNullableULong(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong?)value, f());
        }

        private static void VerifyCheckedNullableSByteToUShort(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                if (value.GetValueOrDefault() < 0)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((ushort)value.GetValueOrDefault(), f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableSByteToNullableUShort(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(sbyte?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort?)value, f());
        }

        private static void VerifyCheckedShortToByte(short value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value < 0 | value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedShortToNullableByte(short value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (value < 0 | value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedShortToChar(short value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedShortToNullableChar(short value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedShortToDecimal(short value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedShortToNullableDecimal(short value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedShortToDouble(short value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedShortToNullableDouble(short value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedShortToEnum(short value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedShortToNullableEnum(short value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedShortToEnumLong(short value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedShortToNullableEnumLong(short value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedShortToFloat(short value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedShortToNullableFloat(short value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedShortToInt(short value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedShortToNullableInt(short value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedShortToLong(short value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedShortToNullableLong(short value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedShortToSByte(short value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value < sbyte.MinValue | value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedShortToNullableSByte(short value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (value < sbyte.MinValue | value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedShortToShort(short value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedShortToNullableShort(short value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedShortToUInt(short value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedShortToNullableUInt(short value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedShortToULong(short value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value, f());
        }

        private static void VerifyCheckedShortToNullableULong(short value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value, f());
        }

        private static void VerifyCheckedShortToUShort(short value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedShortToNullableUShort(short value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedNullableShortToByte(short? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableShortToNullableByte(short? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < 0 | value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableShortToChar(short? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableShortToNullableChar(short? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (value < 0 | value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char?)value, f());
        }

        private static void VerifyCheckedNullableShortToDecimal(short? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableShortToNullableDecimal(short? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableShortToDouble(short? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableShortToNullableDouble(short? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableShortToEnum(short? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((E)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableShortToNullableEnum(short? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E?)value, f());
        }

        private static void VerifyCheckedNullableShortToEnumLong(short? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableShortToNullableEnumLong(short? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyCheckedNullableShortToFloat(short? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableShortToNullableFloat(short? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableShortToInt(short? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableShortToNullableInt(short? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableShortToLong(short? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableShortToNullableLong(short? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableShortToSByte(short? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                short unboxed = value.GetValueOrDefault();
                if (unboxed < sbyte.MinValue | unboxed > sbyte.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((sbyte)unboxed, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableShortToNullableSByte(short? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value < sbyte.MinValue | value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedNullableShortToShort(short? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableShortToNullableShort(short? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableShortToUInt(short? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0 | value > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableShortToNullableUInt(short? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (value < 0 | value > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint?)value, f());
        }

        private static void VerifyCheckedNullableShortToULong(short? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableShortToNullableULong(short? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            if (value < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ulong?)value, f());
        }

        private static void VerifyCheckedNullableShortToUShort(short? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableShortToNullableUShort(short? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(short?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value.GetValueOrDefault() < 0)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort?)value, f());
        }

        private static void VerifyCheckedUIntToByte(uint value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedUIntToNullableByte(uint value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedUIntToChar(uint value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToNullableChar(uint value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedUIntToDecimal(uint value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToNullableDecimal(uint value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToDouble(uint value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToNullableDouble(uint value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToEnum(uint value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedUIntToNullableEnum(uint value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            if (value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedUIntToEnumLong(uint value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedUIntToNullableEnumLong(uint value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedUIntToFloat(uint value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToNullableFloat(uint value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToInt(uint value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((int)value, f());
        }

        private static void VerifyCheckedUIntToNullableInt(uint value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            if (value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((int)value, f());
        }

        private static void VerifyCheckedUIntToLong(uint value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToNullableLong(uint value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToSByte(uint value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedUIntToNullableSByte(uint value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedUIntToShort(uint value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedUIntToNullableShort(uint value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedUIntToUInt(uint value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToNullableUInt(uint value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToULong(uint value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToNullableULong(uint value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToUShort(uint value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedUIntToNullableUShort(uint value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedNullableUIntToByte(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableUIntToNullableByte(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableUIntToChar(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableUIntToNullableChar(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (value.GetValueOrDefault() > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUIntToDecimal(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUIntToNullableDecimal(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUIntToDouble(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUIntToNullableDouble(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUIntToEnum(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                if (value.GetValueOrDefault() > int.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((E)value.GetValueOrDefault(), f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUIntToNullableEnum(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            if (value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((E?)value, f());
        }

        private static void VerifyCheckedNullableUIntToEnumLong(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUIntToNullableEnumLong(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyCheckedNullableUIntToFloat(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUIntToNullableFloat(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUIntToInt(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((int)value, f());
        }

        private static void VerifyCheckedNullableUIntToNullableInt(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            if (value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((int?)value, f());
        }

        private static void VerifyCheckedNullableUIntToLong(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else
                Assert.Equal((long)value, f());
        }

        private static void VerifyCheckedNullableUIntToNullableLong(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUIntToSByte(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                uint unboxed = value.GetValueOrDefault();
                if (unboxed > sbyte.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((sbyte)unboxed, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUIntToNullableSByte(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedNullableUIntToShort(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableUIntToNullableShort(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (value.GetValueOrDefault() > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short?)value, f());
        }

        private static void VerifyCheckedNullableUIntToUInt(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUIntToNullableUInt(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUIntToULong(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUIntToNullableULong(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUIntToUShort(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUIntToNullableUShort(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(uint?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value.GetValueOrDefault() > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedULongToByte(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedULongToNullableByte(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedULongToChar(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedULongToNullableChar(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (value > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedULongToDecimal(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedULongToNullableDecimal(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedULongToDouble(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedULongToNullableDouble(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedULongToEnum(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedULongToNullableEnum(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            if (value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedULongToEnumLong(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value > long.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedULongToNullableEnumLong(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            if (value > long.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedULongToFloat(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedULongToNullableFloat(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedULongToInt(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((int)value, f());
        }

        private static void VerifyCheckedULongToNullableInt(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            if (value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((int)value, f());
        }

        private static void VerifyCheckedULongToLong(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value > long.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((long)value, f());
        }

        private static void VerifyCheckedULongToNullableLong(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            if (value > long.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((long)value, f());
        }

        private static void VerifyCheckedULongToSByte(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value > (ulong)sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedULongToNullableSByte(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (value > (ulong)sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedULongToShort(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value > (ulong)short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedULongToNullableShort(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (value > (ulong)short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedULongToUInt(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedULongToNullableUInt(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (value > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((uint)value, f());
        }

        private static void VerifyCheckedULongToULong(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedULongToNullableULong(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedULongToUShort(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedULongToNullableUShort(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((ushort)value, f());
        }

        private static void VerifyCheckedNullableULongToByte(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                if (value.GetValueOrDefault() > byte.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((byte)value.GetValueOrDefault(), f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableULongToNullableByte(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableULongToChar(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableULongToNullableChar(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            if (value.GetValueOrDefault() > char.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableULongToDecimal(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableULongToNullableDecimal(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableULongToDouble(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((double)value, f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableULongToNullableDouble(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableULongToEnum(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                if (value.GetValueOrDefault() > int.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((E)value.GetValueOrDefault(), f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableULongToNullableEnum(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            if (value.GetValueOrDefault() > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((E?)value, f());
        }

        private static void VerifyCheckedNullableULongToEnumLong(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                if (value > long.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((El)value.GetValueOrDefault(), f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableULongToNullableEnumLong(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            if (value > long.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((El?)value, f());
        }

        private static void VerifyCheckedNullableULongToFloat(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableULongToNullableFloat(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableULongToInt(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((int)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableULongToNullableInt(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            if (value > int.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((int?)value, f());
        }

        private static void VerifyCheckedNullableULongToLong(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value > long.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((long)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableULongToNullableLong(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            if (value.GetValueOrDefault() > long.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((long?)value, f());
        }

        private static void VerifyCheckedNullableULongToSByte(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                ulong unboxed = value.GetValueOrDefault();
                if (unboxed > (ulong)sbyte.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((sbyte)unboxed, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableULongToNullableSByte(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value > (long)sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedNullableULongToShort(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() > (ulong)short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableULongToNullableShort(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (value.GetValueOrDefault() > (ulong)short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short?)value, f());
        }

        private static void VerifyCheckedNullableULongToUInt(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableULongToNullableUInt(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            if (value.GetValueOrDefault() > uint.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableULongToULong(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableULongToNullableULong(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableULongToUShort(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableULongToNullableUShort(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ulong?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            if (value.GetValueOrDefault() > ushort.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToByte(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedUShortToNullableByte(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedUShortToChar(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal((char)value, f());
        }

        private static void VerifyCheckedUShortToNullableChar(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal((char?)value, f());
        }

        private static void VerifyCheckedUShortToDecimal(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToNullableDecimal(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToDouble(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToNullableDouble(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToEnum(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedUShortToNullableEnum(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCheckedUShortToEnumLong(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedUShortToNullableEnumLong(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCheckedUShortToFloat(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToNullableFloat(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToInt(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToNullableInt(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToLong(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToNullableLong(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToSByte(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedUShortToNullableSByte(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedUShortToShort(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedUShortToNullableShort(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value, f());
        }

        private static void VerifyCheckedUShortToUInt(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToNullableUInt(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToULong(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToNullableULong(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToUShort(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedUShortToNullableUShort(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUShortToByte(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUShortToNullableByte(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value > byte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((byte)value, f());
        }

        private static void VerifyCheckedNullableUShortToChar(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value.GetValueOrDefault() > char.MaxValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else
                Assert.Equal(value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableUShortToNullableChar(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal((char?)value, f());
        }

        private static void VerifyCheckedNullableUShortToDecimal(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUShortToNullableDecimal(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUShortToDouble(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUShortToNullableDouble(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUShortToEnum(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((E)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUShortToNullableEnum(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E?)value, f());
        }

        private static void VerifyCheckedNullableUShortToEnumLong(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUShortToNullableEnumLong(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyCheckedNullableUShortToFloat(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUShortToNullableFloat(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUShortToInt(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUShortToNullableInt(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUShortToLong(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUShortToNullableLong(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUShortToSByte(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                ushort unboxed = value.GetValueOrDefault();
                if (unboxed > sbyte.MaxValue)
                    Assert.Throws<OverflowException>(() => f());
                else
                    Assert.Equal((sbyte)unboxed, f());
            }
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUShortToNullableSByte(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Null(f());
            else if (value > sbyte.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((sbyte)value, f());
        }

        private static void VerifyCheckedNullableUShortToShort(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (!value.HasValue)
                Assert.Throws<InvalidOperationException>(() => f());
            else if (value > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short)value.GetValueOrDefault(), f());
        }

        private static void VerifyCheckedNullableUShortToNullableShort(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            if (value.GetValueOrDefault() > short.MaxValue)
                Assert.Throws<OverflowException>(() => f());
            else
                Assert.Equal((short?)value, f());
        }

        private static void VerifyCheckedNullableUShortToUInt(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUShortToNullableUInt(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUShortToULong(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUShortToNullableULong(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCheckedNullableUShortToUShort(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyCheckedNullableUShortToNullableUShort(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.ConvertChecked(Expression.Constant(value, typeof(ushort?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        #endregion

        [Fact]
        public static void OpenGenericnType()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.ConvertChecked(Expression.Constant(null), typeof(List<>)));
        }

        [Fact]
        public static void TypeContainingGenericParameters()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.ConvertChecked(Expression.Constant(null), typeof(List<>.Enumerator)));
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.ConvertChecked(Expression.Constant(null), typeof(List<>).MakeGenericType(typeof(List<>))));
        }

        [Fact]
        public static void ByRefType()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.ConvertChecked(Expression.Constant(null), typeof(object).MakeByRefType()));
        }

        [Fact]
        public static void PointerType()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.ConvertChecked(Expression.Constant(null), typeof(int*)));
        }

        public static IEnumerable<object[]> Conversions()
        {
            yield return new object[] { 3, 3 };
            yield return new object[] { (byte)3, 3 };
            yield return new object[] { 3, 3.0 };
            yield return new object[] { 3.0, 3 };
            yield return new object[] { 24910, (short)24910 };
        }

        [Theory, PerCompilationType(nameof(Conversions))]
        public static void ConvertCheckedMakeUnary(object source, object result, CompilationType useInterpreter)
        {
            LambdaExpression lambda = Expression.Lambda(
                Expression.MakeUnary(ExpressionType.ConvertChecked, Expression.Constant(source), result.GetType())
                );
            Delegate del = lambda.Compile(useInterpreter);
            Assert.Equal(result, del.DynamicInvoke());
        }

        [Fact]
        public static void CannotConvertNonVoidToVoid()
        {
            Assert.Throws<InvalidOperationException>(() => Expression.ConvertChecked(Expression.Constant(1), typeof(void)));
            Assert.Throws<InvalidOperationException>(() => Expression.ConvertChecked(Expression.Constant("a"), typeof(void)));
            Assert.Throws<InvalidOperationException>(() => Expression.ConvertChecked(Expression.Constant(DateTime.MinValue), typeof(void)));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertVoidToVoid(CompilationType useInterpreter)
        {
            Action act = Expression.Lambda<Action>(Expression.ConvertChecked(Expression.Empty(), typeof(void)))
                .Compile(useInterpreter);
            act();
        }

        interface IInterface
        {
        }

        class NonSealed
        {
        }

        class Derived : NonSealed, IInterface
        {
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void NonSealedArrayToIfaceArray(CompilationType useInterpreter)
        {
            checked
            {
                Expression<Func<NonSealed[][], IInterface[][]>> e = a => (IInterface[][])a;
                Func<NonSealed[][], IInterface[][]> f = e.Compile(useInterpreter);
                Derived[][] arr = new[] {new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
                Assert.Same(arr, f(arr));
                Assert.Null(f(null));
                Assert.Throws<InvalidCastException>(() => f(Array.Empty<NonSealed[]>()));
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void IfaceArrayToNonSealedArray(CompilationType useInterpreter)
        {
            checked
            {
                Expression<Func<IInterface[][], NonSealed[][]>> e = a => (NonSealed[][])a;
                Func<IInterface[][], NonSealed[][]> f = e.Compile(useInterpreter);
                Derived[][] arr = new[] {new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
                Assert.Same(arr, f(arr));
                Assert.Null(f(null));
                Assert.Throws<InvalidCastException>(() => f(Array.Empty<IInterface[]>()));
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void NonSealedICollectionToIfaceArray(CompilationType useInterpreter)
        {
            checked
            {
                Expression<Func<ICollection<NonSealed[]>, IInterface[][]>> e = a => (IInterface[][])a;
                Func<ICollection<NonSealed[]>, IInterface[][]> f = e.Compile(useInterpreter);
                Derived[][] arr = new[] {new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
                Assert.Same(arr, f(arr));
                Assert.Null(f(null));
                Assert.Throws<InvalidCastException>(() => f(Array.Empty<NonSealed[]>()));
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void IfaceArrayToNonSealedIList(CompilationType useInterpreter)
        {
            checked
            {
                Expression<Func<IInterface[][], IList<NonSealed>[]>> e = a => (IList<NonSealed>[])a;
                Func<IInterface[][], IList<NonSealed>[]> f = e.Compile(useInterpreter);
                Derived[][] arr = new[] {new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
                Assert.Same(arr, f(arr));
                Assert.Null(f(null));
                Assert.Throws<InvalidCastException>(() => f(Array.Empty<IInterface[]>()));
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void NonSealedArrayToIfaceIEnumerable(CompilationType useInterpreter)
        {
            checked
            {
                Expression<Func<NonSealed[][], IEnumerable<IInterface>[]>> e = a => (IEnumerable<IInterface>[])a;
                Func<NonSealed[][], IEnumerable<IInterface>[]> f = e.Compile(useInterpreter);
                Derived[][] arr = new[] {new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
                Assert.Same(arr, f(arr));
                Assert.Null(f(null));
                Assert.Throws<InvalidCastException>(() => f(Array.Empty<NonSealed[]>()));
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void IfaceIReadonlyCollectionToNonSealedArray(CompilationType useInterpreter)
        {
            checked
            {
                Expression<Func<IReadOnlyCollection<IInterface>[], NonSealed[][]>> e = a => (NonSealed[][])a;
                Func<IReadOnlyCollection<IInterface>[], NonSealed[][]> f = e.Compile(useInterpreter);
                Derived[][] arr = new[] {new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
                Assert.Same(arr, f(arr));
                Assert.Null(f(null));
                Assert.Throws<InvalidCastException>(() => f(Array.Empty<IInterface[]>()));
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void IFaceIListToObjectArray(CompilationType useInterpreter)
        {
            checked
            {
                Expression<Func<IList<IInterface[]>, object[][]>> e = a => (object[][])a;
                Func<IList<IInterface[]>, object[][]> f = e.Compile(useInterpreter);
                Derived[][] arr = new[] {new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
                Assert.Same(arr, f(arr));
                Assert.Null(f(null));
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ObjectIListToIFaceArray(CompilationType useInterpreter)
        {
            checked
            {
                Expression<Func<IList<object[]>, IInterface[][]>> e = a => (IInterface[][])a;
                Func<IList<object[]>, IInterface[][]> f = e.Compile(useInterpreter);
                Derived[][] arr = new[] {new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
                Assert.Same(arr, f(arr));
                Assert.Null(f(null));
                Assert.Throws<InvalidCastException>(() => f(Array.Empty<string[]>()));
            }
        }

        [Fact]
        public static void IfaceToNonSZArray()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.ConvertChecked(Expression.Default(typeof(IList<NonSealed>[])), typeof(NonSealed[,][])));
        }

        [Fact]
        public static void NonSZArrayToIface()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.ConvertChecked(Expression.Default(typeof(NonSealed[,][])), typeof(IList<NonSealed>[])));
        }

        [Fact]
        public static void ArrayToNonArrayCompatibleIFace()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.ConvertChecked(Expression.Default(typeof(NonSealed[][])), typeof(IEquatable<NonSealed>[])));
            Assert.Throws<InvalidOperationException>(
                () => Expression.ConvertChecked(
                    Expression.Default(typeof(NonSealed[][])), typeof(IDictionary<NonSealed, NonSealed>[])));
        }

        [Fact]
        public static void NonArrayCompatibleIFaceToArray()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.ConvertChecked(Expression.Default(typeof(IEquatable<NonSealed>[])), typeof(NonSealed[][])));
            Assert.Throws<InvalidOperationException>(
                () => Expression.ConvertChecked(
                    Expression.Default(typeof(IDictionary<NonSealed, NonSealed>[])), typeof(NonSealed[][])));
        }

        [Fact]
        public static void ArrayToNotRelated()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.ConvertChecked(Expression.Default(typeof(NonSealed[][][])), typeof(string[][])));
        }
    }
}
