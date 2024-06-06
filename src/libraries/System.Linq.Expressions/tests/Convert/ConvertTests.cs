// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Reflection;
using Xunit;

namespace System.Linq.Expressions.Tests
{
    public static class ConvertTests
    {
        #region Test methods

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToByteTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToCharTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToDecimalTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToDoubleTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToEnumTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToFloatTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToIntTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToLongTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToSByteTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToSByteRetIntTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToSByteRetInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToShortTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToUIntTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToULongTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToUShortTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertByteToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (byte value in new byte[] { 0, 1, byte.MaxValue })
            {
                VerifyByteToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToByteTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToCharTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToDecimalTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToDoubleTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToEnumTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToFloatTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToIntTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToLongTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToSByteTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToShortTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToUIntTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToULongTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToUShortTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableByteToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (byte? value in new byte?[] { null, 0, 1, byte.MaxValue })
            {
                VerifyNullableByteToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToByteTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToCharTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToDecimalTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToDoubleTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToEnumTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToFloatTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToIntTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToLongTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToSByteTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToShortTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToUIntTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToULongTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToUShortTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertCharToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (char value in new char[] { '\0', '\b', 'A', '\uffff' })
            {
                VerifyCharToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToByteTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToCharTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToDecimalTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToDoubleTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToEnumTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToFloatTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToIntTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToLongTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToSByteTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToShortTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToUIntTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToULongTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToUShortTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableCharToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (char? value in new char?[] { null, '\0', '\b', 'A', '\uffff' })
            {
                VerifyNullableCharToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToByteTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToCharTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToDecimalTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToDoubleTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToFloatTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToIntTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToLongTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToSByteTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToShortTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToUIntTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToULongTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToUShortTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDecimalToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (decimal value in new decimal[] { decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyDecimalToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToByteTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToCharTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToDecimalTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToDoubleTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToFloatTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToIntTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToLongTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToSByteTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToShortTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToUIntTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToULongTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToUShortTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDecimalToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (decimal? value in new decimal?[] { null, decimal.Zero, decimal.One, decimal.MinusOne, decimal.MinValue, decimal.MaxValue })
            {
                VerifyNullableDecimalToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToByteTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToCharTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToDecimalTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToDoubleTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToEnumTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToFloatTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToIntTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToLongTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToSByteTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToShortTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToUIntTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToULongTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToUShortTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertDoubleToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (double value in new double[] { 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyDoubleToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToByteTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToCharTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToDecimalTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToDoubleTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToEnumTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToFloatTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToIntTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToLongTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToSByteTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToShortTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToUIntTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToULongTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToUShortTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableDoubleToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (double? value in new double?[] { null, 0, 1, -1, double.MinValue, double.MaxValue, double.Epsilon, double.NegativeInfinity, double.PositiveInfinity, double.NaN })
            {
                VerifyNullableDoubleToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToByteTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToCharTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToDoubleTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToEnumTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToFloatTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToIntTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToLongTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToSByteTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToShortTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToUIntTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToULongTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToUShortTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (E value in new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyEnumToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToByteTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToCharTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToDoubleTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToEnumTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToFloatTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToIntTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToLongTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToSByteTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToShortTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToUIntTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToULongTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToUShortTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (E? value in new E?[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue })
            {
                VerifyNullableEnumToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToByteTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToCharTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToDoubleTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToEnumTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToFloatTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToIntTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToLongTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToSByteTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToShortTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToUIntTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToULongTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToUShortTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertEnumLongToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (El value in new El[] { (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyEnumLongToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToByteTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToCharTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToDoubleTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToEnumTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToFloatTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToIntTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToLongTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToSByteTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToShortTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToUIntTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToULongTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToUShortTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableEnumLongToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (El? value in new El?[] { null, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue })
            {
                VerifyNullableEnumLongToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToByteTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToCharTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToDecimalTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToDoubleTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToEnumTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToFloatTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToIntTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToLongTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToSByteTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToShortTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToUIntTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToULongTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToUShortTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertFloatToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (float value in new float[] { 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyFloatToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToByteTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToCharTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToDecimalTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToDoubleTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToEnumTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToFloatTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToIntTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToLongTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToSByteTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToShortTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToUIntTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToULongTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToUShortTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableFloatToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (float? value in new float?[] { null, 0, 1, -1, float.MinValue, float.MaxValue, float.Epsilon, float.NegativeInfinity, float.PositiveInfinity, float.NaN })
            {
                VerifyNullableFloatToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToByteTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToCharTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToDecimalTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToDoubleTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToEnumTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToFloatTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToIntTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToLongTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToSByteTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToShortTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToUIntTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToULongTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToUShortTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertIntToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (int value in new int[] { 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyIntToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToByteTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToCharTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToDecimalTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToDoubleTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToEnumTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToFloatTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToIntTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToLongTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToSByteTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToShortTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToUIntTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToULongTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToUShortTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableIntToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (int? value in new int?[] { null, 0, 1, -1, int.MinValue, int.MaxValue })
            {
                VerifyNullableIntToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToByteTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToCharTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToDecimalTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToDoubleTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToEnumTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToFloatTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToIntTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToLongTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToSByteTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToShortTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToUIntTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToULongTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToUShortTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertLongToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (long value in new long[] { 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyLongToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToByteTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToCharTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToDecimalTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToDoubleTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToEnumTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToFloatTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToIntTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToLongTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToSByteTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToShortTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToUIntTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToULongTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToUShortTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableLongToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (long? value in new long?[] { null, 0, 1, -1, long.MinValue, long.MaxValue })
            {
                VerifyNullableLongToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToByteRetIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToByteRetInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToCharTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToDecimalTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToDoubleTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToEnumTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToFloatTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToSByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToUIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToULongTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToUShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertSByteToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte value in new sbyte[] { 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifySByteToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToCharTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToDecimalTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToDoubleTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToEnumTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToFloatTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToSByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToUIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToULongTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToUShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableSByteToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (sbyte? value in new sbyte?[] { null, 0, 1, -1, sbyte.MinValue, sbyte.MaxValue })
            {
                VerifyNullableSByteToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToByteTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToCharTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToDecimalTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToDoubleTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToEnumTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToFloatTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToIntTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToLongTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToSByteTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToShortTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToUIntTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToULongTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToUShortTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToUShortRetIntTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToUShortRetInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertShortToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (short value in new short[] { 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyShortToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToByteTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToCharTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToDecimalTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToDoubleTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToEnumTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToFloatTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToIntTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToLongTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToSByteTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToShortTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToUIntTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToULongTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToUShortTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableShortToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (short? value in new short?[] { null, 0, 1, -1, short.MinValue, short.MaxValue })
            {
                VerifyNullableShortToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToByteTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToCharTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToDecimalTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToDoubleTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToEnumTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToFloatTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToIntTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToLongTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToSByteTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToShortTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToUIntTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToULongTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToUShortTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUIntToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (uint value in new uint[] { 0, 1, uint.MaxValue })
            {
                VerifyUIntToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToByteTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToCharTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToDecimalTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToDoubleTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToEnumTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToFloatTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToIntTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToLongTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToSByteTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToShortTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToUIntTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToULongTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToUShortTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUIntToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (uint? value in new uint?[] { null, 0, 1, uint.MaxValue })
            {
                VerifyNullableUIntToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToByteTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToCharTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToDecimalTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToDoubleTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToEnumTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToFloatTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToIntTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToLongTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToSByteTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToShortTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToUIntTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToULongTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToUShortTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertULongToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (ulong value in new ulong[] { 0, 1, ulong.MaxValue })
            {
                VerifyULongToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToByteTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToCharTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToDecimalTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToDoubleTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToEnumTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToFloatTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToIntTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToLongTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToSByteTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToShortTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToUIntTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToULongTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToUShortTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableULongToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (ulong? value in new ulong?[] { null, 0, 1, ulong.MaxValue })
            {
                VerifyNullableULongToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToByteTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToCharTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToDecimalTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToDoubleTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToEnumTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToFloatTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToIntTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToLongTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToSByteTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToShortTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToShortRetIntTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToShortRetInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToUIntTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToULongTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToUShortTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertUShortToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (ushort value in new ushort[] { 0, 1, ushort.MaxValue })
            {
                VerifyUShortToNullableUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToByteTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableByteTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToCharTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableCharTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableChar(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToDecimalTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableDecimalTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableDecimal(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToDoubleTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableDoubleTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableDouble(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToEnumTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableEnumTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableEnum(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableEnumLongTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableEnumLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToFloatTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableFloatTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableFloat(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToIntTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableIntTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToLongTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableLongTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableLong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToSByteTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableSByteTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableSByte(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToShortTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableShortTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToUIntTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableUIntTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableUInt(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToULongTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableULongTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableULong(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToUShortTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToUShort(value, useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertNullableUShortToNullableUShortTest(CompilationType useInterpreter)
        {
            foreach (ushort? value in new ushort?[] { null, 0, 1, ushort.MaxValue })
            {
                VerifyNullableUShortToNullableUShort(value, useInterpreter);
            }
        }

        #endregion

        #region Test verifiers

        private static void VerifyByteToByte(byte value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToNullableByte(byte value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToChar(byte value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal((char)value, f());
        }

        private static void VerifyByteToNullableChar(byte value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal((char)value, f());
        }

        private static void VerifyByteToDecimal(byte value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToNullableDecimal(byte value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToDouble(byte value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToNullableDouble(byte value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToEnum(byte value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyByteToNullableEnum(byte value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyByteToEnumLong(byte value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyByteToNullableEnumLong(byte value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyByteToFloat(byte value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToNullableFloat(byte value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToInt(byte value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToNullableInt(byte value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToLong(byte value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToNullableLong(byte value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToSByte(byte value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyByteToSByteRetInt(byte value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(sbyte)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal((int)unchecked((sbyte)value), f());
        }

        private static void VerifyByteToNullableSByte(byte value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyByteToShort(byte value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToNullableShort(byte value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToUInt(byte value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToNullableUInt(byte value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToULong(byte value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToNullableULong(byte value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToUShort(byte value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyByteToNullableUShort(byte value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableByteToByte(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableByte(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableByteToChar(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((char)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableChar(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal((char?)value, f());
        }

        private static void VerifyNullableByteToDecimal(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableDecimal(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableByteToDouble(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableDouble(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableByteToEnum(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((E)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableEnum(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E?)value, f());
        }

        private static void VerifyNullableByteToEnumLong(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value, f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableEnumLong(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyNullableByteToFloat(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableFloat(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableByteToInt(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableInt(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableByteToLong(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableLong(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableByteToSByte(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((sbyte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableSByte(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte?)value), f());
        }

        private static void VerifyNullableByteToShort(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableShort(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableByteToUInt(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableUInt(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableByteToULong(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableULong(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableByteToUShort(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableByteToNullableUShort(byte? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(byte?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToByte(char value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyCharToNullableByte(char value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyCharToChar(char value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToNullableChar(char value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToDecimal(char value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToNullableDecimal(char value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToDouble(char value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToNullableDouble(char value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToEnum(char value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCharToNullableEnum(char value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyCharToEnumLong(char value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCharToNullableEnumLong(char value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyCharToFloat(char value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToNullableFloat(char value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToInt(char value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToNullableInt(char value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToLong(char value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToNullableLong(char value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToSByte(char value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyCharToNullableSByte(char value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyCharToShort(char value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyCharToNullableShort(char value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyCharToUInt(char value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToNullableUInt(char value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToULong(char value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToNullableULong(char value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToUShort(char value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyCharToNullableUShort(char value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableCharToByte(char? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((byte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableByte(char? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte?)value), f());
        }

        private static void VerifyNullableCharToChar(char? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableChar(char? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableCharToDecimal(char? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableDecimal(char? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableCharToDouble(char? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableDouble(char? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableCharToEnum(char? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((E)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableEnum(char? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E?)value, f());
        }

        private static void VerifyNullableCharToEnumLong(char? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableEnumLong(char? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyNullableCharToFloat(char? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableFloat(char? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableCharToInt(char? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableInt(char? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableCharToLong(char? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableLong(char? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableCharToSByte(char? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((sbyte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableSByte(char? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte?)value), f());
        }

        private static void VerifyNullableCharToShort(char? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((short)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableShort(char? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short?)value), f());
        }

        private static void VerifyNullableCharToUInt(char? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableUInt(char? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableCharToULong(char? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableULong(char? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableCharToUShort(char? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableCharToNullableUShort(char? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(char?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyDecimalToByte(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(byte)),
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

        private static void VerifyDecimalToNullableByte(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(byte?)),
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

        private static void VerifyDecimalToChar(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(char)),
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

        private static void VerifyDecimalToNullableChar(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(char?)),
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

        private static void VerifyDecimalToDecimal(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyDecimalToNullableDecimal(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyDecimalToDouble(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyDecimalToNullableDouble(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyDecimalToFloat(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyDecimalToNullableFloat(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyDecimalToInt(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(int)),
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

        private static void VerifyDecimalToNullableInt(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(int?)),
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

        private static void VerifyDecimalToLong(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(long)),
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

        private static void VerifyDecimalToNullableLong(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(long?)),
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

        private static void VerifyDecimalToSByte(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(sbyte)),
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

        private static void VerifyDecimalToNullableSByte(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(sbyte?)),
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

        private static void VerifyDecimalToShort(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(short)),
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

        private static void VerifyDecimalToNullableShort(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(short?)),
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

        private static void VerifyDecimalToUInt(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(uint)),
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

        private static void VerifyDecimalToNullableUInt(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(uint?)),
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

        private static void VerifyDecimalToULong(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(ulong)),
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

        private static void VerifyDecimalToNullableULong(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(ulong?)),
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

        private static void VerifyDecimalToUShort(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(ushort)),
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

        private static void VerifyDecimalToNullableUShort(decimal value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal)), typeof(ushort?)),
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

        private static void VerifyNullableDecimalToByte(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(byte)),
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

        private static void VerifyNullableDecimalToNullableByte(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            byte? expected = null;
            try
            {
                expected = (byte?)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyNullableDecimalToChar(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(char)),
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

        private static void VerifyNullableDecimalToNullableChar(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            char? expected = null;
            try
            {
                expected = (char?)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyNullableDecimalToDecimal(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDecimalToNullableDecimal(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableDecimalToDouble(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((double)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDecimalToNullableDouble(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal((double?)value, f());
        }

        private static void VerifyNullableDecimalToFloat(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((float)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDecimalToNullableFloat(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float?)value, f());
        }

        private static void VerifyNullableDecimalToInt(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(int)),
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

        private static void VerifyNullableDecimalToNullableInt(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            int? expected = null;
            try
            {
                expected = (int?)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyNullableDecimalToLong(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(long)),
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

        private static void VerifyNullableDecimalToNullableLong(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            long? expected = null;
            try
            {
                expected = (long?)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyNullableDecimalToSByte(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(sbyte)),
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

        private static void VerifyNullableDecimalToNullableSByte(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            sbyte? expected = null;
            try
            {
                expected = (sbyte?)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyNullableDecimalToShort(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(short)),
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

        private static void VerifyNullableDecimalToNullableShort(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            short? expected = null;
            try
            {
                expected = (short?)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyNullableDecimalToUInt(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(uint)),
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

        private static void VerifyNullableDecimalToNullableUInt(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            uint? expected = null;
            try
            {
                expected = (uint?)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyNullableDecimalToULong(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(ulong)),
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

        private static void VerifyNullableDecimalToNullableULong(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            ulong? expected = null;
            try
            {
                expected = (ulong?)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyNullableDecimalToUShort(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(ushort)),
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

        private static void VerifyNullableDecimalToNullableUShort(decimal? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(decimal?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            ushort? expected = null;
            try
            {
                expected = (ushort?)value;
            }
            catch (OverflowException)
            {
                Assert.Throws<OverflowException>(() => f());
                return;
            }

            Assert.Equal(expected, f());
        }

        private static void VerifyDoubleToByte(double value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyDoubleToNullableByte(double value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyDoubleToChar(double value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char)value), f());
        }

        private static void VerifyDoubleToNullableChar(double value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyDoubleToDecimal(double value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(decimal)),
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

        private static void VerifyDoubleToNullableDecimal(double value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(decimal?)),
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

        private static void VerifyDoubleToDouble(double value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyDoubleToNullableDouble(double value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyDoubleToEnum(double value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E)value), f());
        }

        private static void VerifyDoubleToNullableEnum(double value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E)value), f());
        }

        private static void VerifyDoubleToEnumLong(double value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((El)value), f());
        }

        private static void VerifyDoubleToNullableEnumLong(double value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((El)value), f());
        }

        private static void VerifyDoubleToFloat(double value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyDoubleToNullableFloat(double value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyDoubleToInt(double value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int)value), f());
        }

        private static void VerifyDoubleToNullableInt(double value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int)value), f());
        }

        private static void VerifyDoubleToLong(double value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((long)value), f());
        }

        private static void VerifyDoubleToNullableLong(double value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((long)value), f());
        }

        private static void VerifyDoubleToSByte(double value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyDoubleToNullableSByte(double value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyDoubleToShort(double value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyDoubleToNullableShort(double value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyDoubleToUInt(double value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyDoubleToNullableUInt(double value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyDoubleToULong(double value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyDoubleToNullableULong(double value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyDoubleToUShort(double value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyDoubleToNullableUShort(double value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyNullableDoubleToByte(double? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((byte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDoubleToNullableByte(double? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte?)value), f());
        }

        private static void VerifyNullableDoubleToChar(double? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((char)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDoubleToNullableChar(double? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyNullableDoubleToDecimal(double? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                decimal expected = 0;
                try
                {
                    expected = (decimal)value.GetValueOrDefault();
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

        private static void VerifyNullableDoubleToNullableDecimal(double? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(decimal?)),
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

        private static void VerifyNullableDoubleToDouble(double? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDoubleToNullableDouble(double? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableDoubleToEnum(double? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((E)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDoubleToNullableEnum(double? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E?)value), f());
        }

        private static void VerifyNullableDoubleToEnumLong(double? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((El)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDoubleToNullableEnumLong(double? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((El?)value), f());
        }

        private static void VerifyNullableDoubleToFloat(double? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((float)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDoubleToNullableFloat(double? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float?)value, f());
        }

        private static void VerifyNullableDoubleToInt(double? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((int)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDoubleToNullableInt(double? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int?)value), f());
        }

        private static void VerifyNullableDoubleToLong(double? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((long)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDoubleToNullableLong(double? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((long?)value), f());
        }

        private static void VerifyNullableDoubleToSByte(double? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((sbyte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDoubleToNullableSByte(double? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte?)value), f());
        }

        private static void VerifyNullableDoubleToShort(double? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((short)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDoubleToNullableShort(double? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short?)value), f());
        }

        private static void VerifyNullableDoubleToUInt(double? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((uint)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDoubleToNullableUInt(double? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint?)value), f());
        }

        private static void VerifyNullableDoubleToULong(double? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ulong)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDoubleToNullableULong(double? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong?)value), f());
        }

        private static void VerifyNullableDoubleToUShort(double? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ushort)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableDoubleToNullableUShort(double? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(double?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort?)value), f());
        }

        private static void VerifyEnumToByte(E value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyEnumToNullableByte(E value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyEnumToChar(E value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char)value), f());
        }

        private static void VerifyEnumToNullableChar(E value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyEnumToDouble(E value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyEnumToNullableDouble(E value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyEnumToEnum(E value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyEnumToNullableEnum(E value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyEnumToEnumLong(E value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyEnumToNullableEnumLong(E value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyEnumToFloat(E value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyEnumToNullableFloat(E value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyEnumToInt(E value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal((int)value, f());
        }

        private static void VerifyEnumToNullableInt(E value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal((int)value, f());
        }

        private static void VerifyEnumToLong(E value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal((long)value, f());
        }

        private static void VerifyEnumToNullableLong(E value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal((long)value, f());
        }

        private static void VerifyEnumToSByte(E value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyEnumToNullableSByte(E value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyEnumToShort(E value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyEnumToNullableShort(E value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyEnumToUInt(E value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyEnumToNullableUInt(E value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint?)value), f());
        }

        private static void VerifyEnumToULong(E value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyEnumToNullableULong(E value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyEnumToUShort(E value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyEnumToNullableUShort(E value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyNullableEnumToByte(E? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((byte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumToNullableByte(E? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte?)value), f());
        }

        private static void VerifyNullableEnumToChar(E? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((char)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumToNullableChar(E? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyNullableEnumToDouble(E? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((double)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumToNullableDouble(E? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal((double?)value, f());
        }

        private static void VerifyNullableEnumToEnum(E? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumToNullableEnum(E? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableEnumToEnumLong(E? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumToNullableEnumLong(E? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyNullableEnumToFloat(E? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((float)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumToNullableFloat(E? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float?)value, f());
        }

        private static void VerifyNullableEnumToInt(E? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((int)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumToNullableInt(E? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal((int?)value, f());
        }

        private static void VerifyNullableEnumToLong(E? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((long)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumToNullableLong(E? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal((long?)value, f());
        }

        private static void VerifyNullableEnumToSByte(E? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((sbyte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumToNullableSByte(E? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte?)value), f());
        }

        private static void VerifyNullableEnumToShort(E? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((short)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumToNullableShort(E? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short?)value), f());
        }

        private static void VerifyNullableEnumToUInt(E? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((uint)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumToNullableUInt(E? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint?)value), f());
        }

        private static void VerifyNullableEnumToULong(E? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ulong)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumToNullableULong(E? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong?)value), f());
        }

        private static void VerifyNullableEnumToUShort(E? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ushort)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumToNullableUShort(E? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(E?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort?)value), f());
        }

        private static void VerifyEnumLongToByte(El value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyEnumLongToNullableByte(El value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyEnumLongToChar(El value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char)value), f());
        }

        private static void VerifyEnumLongToNullableChar(El value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyEnumLongToDouble(El value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyEnumLongToNullableDouble(El value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyEnumLongToEnum(El value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E)value), f());
        }

        private static void VerifyEnumLongToNullableEnum(El value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E)value), f());
        }

        private static void VerifyEnumLongToEnumLong(El value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyEnumLongToNullableEnumLong(El value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyEnumLongToFloat(El value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyEnumLongToNullableFloat(El value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float)value, f());
        }

        private static void VerifyEnumLongToInt(El value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int)value), f());
        }

        private static void VerifyEnumLongToNullableInt(El value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int)value), f());
        }

        private static void VerifyEnumLongToLong(El value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal((long)value, f());
        }

        private static void VerifyEnumLongToNullableLong(El value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal((long)value, f());
        }

        private static void VerifyEnumLongToSByte(El value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyEnumLongToNullableSByte(El value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyEnumLongToShort(El value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyEnumLongToNullableShort(El value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyEnumLongToUInt(El value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyEnumLongToNullableUInt(El value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyEnumLongToULong(El value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyEnumLongToNullableULong(El value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyEnumLongToUShort(El value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyEnumLongToNullableUShort(El value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyNullableEnumLongToByte(El? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((byte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumLongToNullableByte(El? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte?)value), f());
        }

        private static void VerifyNullableEnumLongToChar(El? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((char)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumLongToNullableChar(El? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyNullableEnumLongToDouble(El? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((double)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumLongToNullableDouble(El? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal((double?)value, f());
        }

        private static void VerifyNullableEnumLongToEnum(El? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((E)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumLongToNullableEnum(El? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E?)value), f());
        }

        private static void VerifyNullableEnumLongToEnumLong(El? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumLongToNullableEnumLong(El? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableEnumLongToFloat(El? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((float)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumLongToNullableFloat(El? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal((float?)value, f());
        }

        private static void VerifyNullableEnumLongToInt(El? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((int)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumLongToNullableInt(El? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int?)value), f());
        }

        private static void VerifyNullableEnumLongToLong(El? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((long)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumLongToNullableLong(El? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal((long?)value, f());
        }

        private static void VerifyNullableEnumLongToSByte(El? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((sbyte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumLongToNullableSByte(El? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte?)value), f());
        }

        private static void VerifyNullableEnumLongToShort(El? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((short)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumLongToNullableShort(El? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short?)value), f());
        }

        private static void VerifyNullableEnumLongToUInt(El? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((uint)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumLongToNullableUInt(El? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint?)value), f());
        }

        private static void VerifyNullableEnumLongToULong(El? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ulong)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumLongToNullableULong(El? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong?)value), f());
        }

        private static void VerifyNullableEnumLongToUShort(El? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ushort)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableEnumLongToNullableUShort(El? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(El?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort?)value), f());
        }

        private static void VerifyFloatToByte(float value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyFloatToNullableByte(float value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyFloatToChar(float value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char)value), f());
        }

        private static void VerifyFloatToNullableChar(float value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyFloatToDecimal(float value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(decimal)),
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

        private static void VerifyFloatToNullableDecimal(float value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(decimal?)),
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

        private static void VerifyFloatToDouble(float value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyFloatToNullableDouble(float value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal((double)value, f());
        }

        private static void VerifyFloatToEnum(float value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E)value), f());
        }

        private static void VerifyFloatToNullableEnum(float value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E)value), f());
        }

        private static void VerifyFloatToEnumLong(float value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((El)value), f());
        }

        private static void VerifyFloatToNullableEnumLong(float value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((El)value), f());
        }

        private static void VerifyFloatToFloat(float value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyFloatToNullableFloat(float value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyFloatToInt(float value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int)value), f());
        }

        private static void VerifyFloatToNullableInt(float value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int)value), f());
        }

        private static void VerifyFloatToLong(float value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((long)value), f());
        }

        private static void VerifyFloatToNullableLong(float value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((long)value), f());
        }

        private static void VerifyFloatToSByte(float value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyFloatToNullableSByte(float value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyFloatToShort(float value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyFloatToNullableShort(float value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyFloatToUInt(float value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyFloatToNullableUInt(float value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyFloatToULong(float value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyFloatToNullableULong(float value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyFloatToUShort(float value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyFloatToNullableUShort(float value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyNullableFloatToByte(float? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((byte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableFloatToNullableByte(float? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte?)value), f());
        }

        private static void VerifyNullableFloatToChar(float? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((char)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableFloatToNullableChar(float? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyNullableFloatToDecimal(float? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
            {
                decimal expected = 0;
                try
                {
                    expected = (decimal)value.GetValueOrDefault();
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

        private static void VerifyNullableFloatToNullableDecimal(float? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(decimal?)),
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

        private static void VerifyNullableFloatToDouble(float? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableFloatToNullableDouble(float? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableFloatToEnum(float? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((E)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableFloatToNullableEnum(float? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E?)value), f());
        }

        private static void VerifyNullableFloatToEnumLong(float? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((El)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableFloatToNullableEnumLong(float? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((El?)value), f());
        }

        private static void VerifyNullableFloatToFloat(float? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableFloatToNullableFloat(float? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableFloatToInt(float? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((int)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableFloatToNullableInt(float? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int?)value), f());
        }

        private static void VerifyNullableFloatToLong(float? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((long)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableFloatToNullableLong(float? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((long?)value), f());
        }

        private static void VerifyNullableFloatToSByte(float? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((sbyte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableFloatToNullableSByte(float? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte?)value), f());
        }

        private static void VerifyNullableFloatToShort(float? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((short)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableFloatToNullableShort(float? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short?)value), f());
        }

        private static void VerifyNullableFloatToUInt(float? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((uint)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableFloatToNullableUInt(float? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint?)value), f());
        }

        private static void VerifyNullableFloatToULong(float? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ulong)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableFloatToNullableULong(float? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong?)value), f());
        }

        private static void VerifyNullableFloatToUShort(float? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ushort)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableFloatToNullableUShort(float? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(float?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort?)value), f());
        }

        private static void VerifyIntToByte(int value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyIntToNullableByte(int value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyIntToChar(int value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char)value), f());
        }

        private static void VerifyIntToNullableChar(int value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyIntToDecimal(int value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyIntToNullableDecimal(int value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyIntToDouble(int value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyIntToNullableDouble(int value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyIntToEnum(int value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyIntToNullableEnum(int value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyIntToEnumLong(int value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyIntToNullableEnumLong(int value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyIntToFloat(int value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyIntToNullableFloat(int value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyIntToInt(int value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyIntToNullableInt(int value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyIntToLong(int value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyIntToNullableLong(int value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyIntToSByte(int value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyIntToNullableSByte(int value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyIntToShort(int value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyIntToNullableShort(int value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyIntToUInt(int value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyIntToNullableUInt(int value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyIntToULong(int value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyIntToNullableULong(int value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyIntToUShort(int value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyIntToNullableUShort(int value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyNullableIntToByte(int? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((byte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableByte(int? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte?)value), f());
        }

        private static void VerifyNullableIntToChar(int? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((char)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableChar(int? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyNullableIntToDecimal(int? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableDecimal(int? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableIntToDouble(int? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableDouble(int? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableIntToEnum(int? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((E)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableEnum(int? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E?)value, f());
        }

        private static void VerifyNullableIntToEnumLong(int? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableEnumLong(int? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyNullableIntToFloat(int? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableFloat(int? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableIntToInt(int? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableInt(int? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableIntToLong(int? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableLong(int? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableIntToSByte(int? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((sbyte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableSByte(int? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte?)value), f());
        }

        private static void VerifyNullableIntToShort(int? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((short)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableShort(int? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short?)value), f());
        }

        private static void VerifyNullableIntToUInt(int? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((uint)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableUInt(int? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint?)value), f());
        }

        private static void VerifyNullableIntToULong(int? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ulong)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableULong(int? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong?)value), f());
        }

        private static void VerifyNullableIntToUShort(int? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ushort)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableIntToNullableUShort(int? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(int?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort?)value), f());
        }

        private static void VerifyLongToByte(long value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyLongToNullableByte(long value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyLongToChar(long value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char)value), f());
        }

        private static void VerifyLongToNullableChar(long value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyLongToDecimal(long value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyLongToNullableDecimal(long value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyLongToDouble(long value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyLongToNullableDouble(long value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyLongToEnum(long value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E)value), f());
        }

        private static void VerifyLongToNullableEnum(long value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E)value), f());
        }

        private static void VerifyLongToEnumLong(long value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyLongToNullableEnumLong(long value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyLongToFloat(long value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyLongToNullableFloat(long value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyLongToInt(long value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int)value), f());
        }

        private static void VerifyLongToNullableInt(long value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int)value), f());
        }

        private static void VerifyLongToLong(long value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyLongToNullableLong(long value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyLongToSByte(long value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyLongToNullableSByte(long value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyLongToShort(long value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyLongToNullableShort(long value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyLongToUInt(long value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyLongToNullableUInt(long value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyLongToULong(long value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyLongToNullableULong(long value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyLongToUShort(long value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyLongToNullableUShort(long value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyNullableLongToByte(long? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((byte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableByte(long? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte?)value), f());
        }

        private static void VerifyNullableLongToChar(long? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((char)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableChar(long? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyNullableLongToDecimal(long? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableDecimal(long? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableLongToDouble(long? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableDouble(long? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableLongToEnum(long? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((E)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableEnum(long? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E?)value), f());
        }

        private static void VerifyNullableLongToEnumLong(long? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableEnumLong(long? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyNullableLongToFloat(long? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableFloat(long? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableLongToInt(long? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((int)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableInt(long? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int?)value), f());
        }

        private static void VerifyNullableLongToLong(long? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableLong(long? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableLongToSByte(long? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((sbyte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableSByte(long? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte?)value), f());
        }

        private static void VerifyNullableLongToShort(long? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((short)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableShort(long? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short?)value), f());
        }

        private static void VerifyNullableLongToUInt(long? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((uint)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableUInt(long? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint?)value), f());
        }

        private static void VerifyNullableLongToULong(long? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ulong)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableULong(long? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong?)value), f());
        }

        private static void VerifyNullableLongToUShort(long? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ushort)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableLongToNullableUShort(long? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(long?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort?)value), f());
        }

        private static void VerifySByteToByte(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifySByteToByteRetInt(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(byte)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal((int)unchecked((byte)value), f());
        }

        private static void VerifySByteToNullableByte(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifySByteToChar(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char)value), f());
        }

        private static void VerifySByteToNullableChar(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char)value), f());
        }

        private static void VerifySByteToDecimal(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToNullableDecimal(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToDouble(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToNullableDouble(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToEnum(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifySByteToNullableEnum(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifySByteToEnumLong(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifySByteToNullableEnumLong(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifySByteToFloat(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToNullableFloat(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToInt(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToNullableInt(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToLong(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToNullableLong(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToSByte(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToNullableSByte(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToShort(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToNullableShort(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifySByteToUInt(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifySByteToNullableUInt(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifySByteToULong(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifySByteToNullableULong(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifySByteToUShort(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifySByteToNullableUShort(sbyte value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyNullableSByteToByte(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((byte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableByte(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte?)value), f());
        }

        private static void VerifyNullableSByteToChar(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((char)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableChar(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyNullableSByteToDecimal(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableDecimal(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableSByteToDouble(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableDouble(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableSByteToEnum(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((E)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableEnum(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E?)value, f());
        }

        private static void VerifyNullableSByteToEnumLong(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableEnumLong(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyNullableSByteToFloat(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableFloat(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableSByteToInt(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableInt(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableSByteToLong(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableLong(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableSByteToSByte(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableSByte(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableSByteToShort(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableShort(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableSByteToUInt(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((uint)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableUInt(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint?)value), f());
        }

        private static void VerifyNullableSByteToULong(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ulong)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableULong(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong?)value), f());
        }

        private static void VerifyNullableSByteToUShort(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ushort)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableSByteToNullableUShort(sbyte? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(sbyte?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort?)value), f());
        }

        private static void VerifyShortToByte(short value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyShortToNullableByte(short value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyShortToChar(short value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char)value), f());
        }

        private static void VerifyShortToNullableChar(short value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyShortToDecimal(short value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyShortToNullableDecimal(short value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyShortToDouble(short value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyShortToNullableDouble(short value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyShortToEnum(short value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyShortToNullableEnum(short value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyShortToEnumLong(short value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyShortToNullableEnumLong(short value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyShortToFloat(short value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyShortToNullableFloat(short value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyShortToInt(short value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyShortToNullableInt(short value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyShortToLong(short value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyShortToNullableLong(short value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyShortToSByte(short value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyShortToNullableSByte(short value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyShortToShort(short value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyShortToNullableShort(short value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyShortToUInt(short value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyShortToNullableUInt(short value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyShortToULong(short value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyShortToNullableULong(short value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong)value), f());
        }

        private static void VerifyShortToUShort(short value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyShortToUShortRetInt(short value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Convert(Expression.Constant(value, typeof(short)), typeof(ushort)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal((int)unchecked((ushort)value), f());
        }

        private static void VerifyShortToNullableUShort(short value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyNullableShortToByte(short? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((byte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableByte(short? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte?)value), f());
        }

        private static void VerifyNullableShortToChar(short? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((char)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableChar(short? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyNullableShortToDecimal(short? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableDecimal(short? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableShortToDouble(short? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableDouble(short? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableShortToEnum(short? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((E)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableEnum(short? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E?)value, f());
        }

        private static void VerifyNullableShortToEnumLong(short? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableEnumLong(short? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyNullableShortToFloat(short? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableFloat(short? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableShortToInt(short? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableInt(short? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableShortToLong(short? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableLong(short? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableShortToSByte(short? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((sbyte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableSByte(short? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte?)value), f());
        }

        private static void VerifyNullableShortToShort(short? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableShort(short? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableShortToUInt(short? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((uint)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableUInt(short? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint?)value), f());
        }

        private static void VerifyNullableShortToULong(short? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ulong)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableULong(short? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ulong?)value), f());
        }

        private static void VerifyNullableShortToUShort(short? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ushort)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableShortToNullableUShort(short? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(short?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort?)value), f());
        }

        private static void VerifyUIntToByte(uint value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyUIntToNullableByte(uint value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyUIntToChar(uint value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char)value), f());
        }

        private static void VerifyUIntToNullableChar(uint value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyUIntToDecimal(uint value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUIntToNullableDecimal(uint value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUIntToDouble(uint value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUIntToNullableDouble(uint value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUIntToEnum(uint value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E)value), f());
        }

        private static void VerifyUIntToNullableEnum(uint value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E)value), f());
        }

        private static void VerifyUIntToEnumLong(uint value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyUIntToNullableEnumLong(uint value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyUIntToFloat(uint value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUIntToNullableFloat(uint value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUIntToInt(uint value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int)value), f());
        }

        private static void VerifyUIntToNullableInt(uint value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int)value), f());
        }

        private static void VerifyUIntToLong(uint value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUIntToNullableLong(uint value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUIntToSByte(uint value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyUIntToNullableSByte(uint value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyUIntToShort(uint value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyUIntToNullableShort(uint value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyUIntToUInt(uint value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUIntToNullableUInt(uint value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUIntToULong(uint value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUIntToNullableULong(uint value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUIntToUShort(uint value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyUIntToNullableUShort(uint value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyNullableUIntToByte(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((byte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableByte(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte?)value), f());
        }

        private static void VerifyNullableUIntToChar(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((char)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableChar(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyNullableUIntToDecimal(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableDecimal(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableUIntToDouble(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableDouble(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableUIntToEnum(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((E)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableEnum(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E?)value), f());
        }

        private static void VerifyNullableUIntToEnumLong(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableEnumLong(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyNullableUIntToFloat(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableFloat(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableUIntToInt(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((int)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableInt(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int?)value), f());
        }

        private static void VerifyNullableUIntToLong(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableLong(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal((long?)value, f());
        }

        private static void VerifyNullableUIntToSByte(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((sbyte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableSByte(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte?)value), f());
        }

        private static void VerifyNullableUIntToShort(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((short)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableShort(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short?)value), f());
        }

        private static void VerifyNullableUIntToUInt(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableUInt(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableUIntToULong(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableULong(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableUIntToUShort(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ushort)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUIntToNullableUShort(uint? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(uint?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort?)value), f());
        }

        private static void VerifyULongToByte(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyULongToNullableByte(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyULongToChar(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char)value), f());
        }

        private static void VerifyULongToNullableChar(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyULongToDecimal(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyULongToNullableDecimal(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyULongToDouble(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyULongToNullableDouble(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyULongToEnum(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E)value), f());
        }

        private static void VerifyULongToNullableEnum(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E)value), f());
        }

        private static void VerifyULongToEnumLong(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((El)value), f());
        }

        private static void VerifyULongToNullableEnumLong(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((El)value), f());
        }

        private static void VerifyULongToFloat(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyULongToNullableFloat(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyULongToInt(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int)value), f());
        }

        private static void VerifyULongToNullableInt(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int)value), f());
        }

        private static void VerifyULongToLong(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((long)value), f());
        }

        private static void VerifyULongToNullableLong(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((long)value), f());
        }

        private static void VerifyULongToSByte(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyULongToNullableSByte(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyULongToShort(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyULongToNullableShort(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyULongToUInt(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyULongToNullableUInt(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint)value), f());
        }

        private static void VerifyULongToULong(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyULongToNullableULong(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyULongToUShort(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyULongToNullableUShort(ulong value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort)value), f());
        }

        private static void VerifyNullableULongToByte(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((byte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableByte(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte?)value), f());
        }

        private static void VerifyNullableULongToChar(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((char)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableChar(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((char?)value), f());
        }

        private static void VerifyNullableULongToDecimal(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableDecimal(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableULongToDouble(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableDouble(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableULongToEnum(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((E)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableEnum(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((E?)value), f());
        }

        private static void VerifyNullableULongToEnumLong(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((El)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableEnumLong(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((El?)value), f());
        }

        private static void VerifyNullableULongToFloat(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableFloat(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableULongToInt(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((int)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableInt(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((int?)value), f());
        }

        private static void VerifyNullableULongToLong(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((long)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableLong(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((long?)value), f());
        }

        private static void VerifyNullableULongToSByte(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((sbyte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableSByte(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte?)value), f());
        }

        private static void VerifyNullableULongToShort(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((short)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableShort(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short?)value), f());
        }

        private static void VerifyNullableULongToUInt(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((uint)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableUInt(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((uint?)value), f());
        }

        private static void VerifyNullableULongToULong(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableULong(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableULongToUShort(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((ushort)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableULongToNullableUShort(ulong? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ulong?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((ushort?)value), f());
        }

        private static void VerifyUShortToByte(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyUShortToNullableByte(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte)value), f());
        }

        private static void VerifyUShortToChar(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            Assert.Equal((char)value, f());
        }

        private static void VerifyUShortToNullableChar(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal((char?)value, f());
        }

        private static void VerifyUShortToDecimal(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToNullableDecimal(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToDouble(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToNullableDouble(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToEnum(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyUShortToNullableEnum(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E)value, f());
        }

        private static void VerifyUShortToEnumLong(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyUShortToNullableEnumLong(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El)value, f());
        }

        private static void VerifyUShortToFloat(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToNullableFloat(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToInt(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToNullableInt(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToLong(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToNullableLong(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToSByte(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyUShortToNullableSByte(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte)value), f());
        }

        private static void VerifyUShortToShort(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyUShortToShortRetInt(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(short)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            Assert.Equal((int)unchecked((short)value), f());
        }

        private static void VerifyUShortToNullableShort(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short)value), f());
        }

        private static void VerifyUShortToUInt(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToNullableUInt(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToULong(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToNullableULong(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToUShort(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyUShortToNullableUShort(ushort value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableUShortToByte(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<byte>> e =
                Expression.Lambda<Func<byte>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(byte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((byte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableByte(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<byte?>> e =
                Expression.Lambda<Func<byte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(byte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<byte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((byte?)value), f());
        }

        private static void VerifyNullableUShortToChar(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<char>> e =
                Expression.Lambda<Func<char>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(char)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((char)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableChar(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<char?>> e =
                Expression.Lambda<Func<char?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(char?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<char?> f = e.Compile(useInterpreter);

            Assert.Equal((char?)value, f());
        }

        private static void VerifyNullableUShortToDecimal(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal>> e =
                Expression.Lambda<Func<decimal>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(decimal)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableDecimal(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<decimal?>> e =
                Expression.Lambda<Func<decimal?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(decimal?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<decimal?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableUShortToDouble(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<double>> e =
                Expression.Lambda<Func<double>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(double)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableDouble(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<double?>> e =
                Expression.Lambda<Func<double?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(double?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<double?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableUShortToEnum(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<E>> e =
                Expression.Lambda<Func<E>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(E)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((E)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableEnum(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<E?>> e =
                Expression.Lambda<Func<E?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(E?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<E?> f = e.Compile(useInterpreter);

            Assert.Equal((E?)value, f());
        }

        private static void VerifyNullableUShortToEnumLong(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<El>> e =
                Expression.Lambda<Func<El>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(El)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal((El)value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableEnumLong(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<El?>> e =
                Expression.Lambda<Func<El?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(El?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<El?> f = e.Compile(useInterpreter);

            Assert.Equal((El?)value, f());
        }

        private static void VerifyNullableUShortToFloat(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<float>> e =
                Expression.Lambda<Func<float>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(float)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableFloat(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<float?>> e =
                Expression.Lambda<Func<float?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(float?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<float?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableUShortToInt(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<int>> e =
                Expression.Lambda<Func<int>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(int)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableInt(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<int?>> e =
                Expression.Lambda<Func<int?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(int?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<int?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableUShortToLong(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<long>> e =
                Expression.Lambda<Func<long>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(long)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableLong(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<long?>> e =
                Expression.Lambda<Func<long?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(long?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<long?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableUShortToSByte(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte>> e =
                Expression.Lambda<Func<sbyte>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(sbyte)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((sbyte)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableSByte(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<sbyte?>> e =
                Expression.Lambda<Func<sbyte?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(sbyte?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<sbyte?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((sbyte?)value), f());
        }

        private static void VerifyNullableUShortToShort(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<short>> e =
                Expression.Lambda<Func<short>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(short)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(unchecked((short)value.GetValueOrDefault()), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableShort(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<short?>> e =
                Expression.Lambda<Func<short?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(short?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<short?> f = e.Compile(useInterpreter);

            Assert.Equal(unchecked((short?)value), f());
        }

        private static void VerifyNullableUShortToUInt(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<uint>> e =
                Expression.Lambda<Func<uint>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(uint)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableUInt(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<uint?>> e =
                Expression.Lambda<Func<uint?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(uint?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<uint?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableUShortToULong(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong>> e =
                Expression.Lambda<Func<ulong>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(ulong)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value.GetValueOrDefault(), f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableULong(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<ulong?>> e =
                Expression.Lambda<Func<ulong?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(ulong?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ulong?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        private static void VerifyNullableUShortToUShort(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort>> e =
                Expression.Lambda<Func<ushort>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(ushort)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort> f = e.Compile(useInterpreter);

            if (value.HasValue)
                Assert.Equal(value, f());
            else
                Assert.Throws<InvalidOperationException>(() => f());
        }

        private static void VerifyNullableUShortToNullableUShort(ushort? value, CompilationType useInterpreter)
        {
            Expression<Func<ushort?>> e =
                Expression.Lambda<Func<ushort?>>(
                    Expression.Convert(Expression.Constant(value, typeof(ushort?)), typeof(ushort?)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ushort?> f = e.Compile(useInterpreter);

            Assert.Equal(value, f());
        }

        #endregion

        private class PerverselyNamedMembers
        {
            public readonly uint Field;

            public PerverselyNamedMembers(uint value)
            {
                Field = value;
            }

            public static uint op_Implicit()
            {
                return 0x8BADF00D;
            }
        }

        private struct HalfLiftedTo
        {
        }

        private struct ImplicitHalfLiftedFrom
        {
            public bool NullEquiv { get; set; }

            public static implicit operator HalfLiftedTo? (ImplicitHalfLiftedFrom source) =>
                source.NullEquiv ? default(HalfLiftedTo?) : new HalfLiftedTo();
        }

        private struct ExplicitHalfLiftedFrom
        {
            public bool NullEquiv { get; set; }

            public static explicit operator HalfLiftedTo? (ExplicitHalfLiftedFrom source) =>
                source.NullEquiv ? default(HalfLiftedTo?) : new HalfLiftedTo();
        }

        private struct ImplicitHalfLiftedOverloaded
        {
            public static implicit operator HalfLiftedTo?(ImplicitHalfLiftedOverloaded source) => new HalfLiftedTo();

            public static implicit operator HalfLiftedTo?(ImplicitHalfLiftedOverloaded? source) => new HalfLiftedTo();
        }

        private struct ImplicitHalfLiftedFromReverse
        {
            public static implicit operator HalfLiftedTo(ImplicitHalfLiftedFromReverse? source) => new HalfLiftedTo();
        }

        private struct HalfLiftedToTargetOperator
        {
            public static implicit operator HalfLiftedToTargetOperator?(HalfLiftedFromTargetOperator source) =>
                source.NullEquiv ? default(HalfLiftedToTargetOperator?) : new HalfLiftedToTargetOperator();
        }

        private struct HalfLiftedFromTargetOperator
        {
            public bool NullEquiv { get; set; }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ImplicitHalfLiftedConversionFromCSCompiler(CompilationType useInterpreter)
        {
            Expression<Func<ImplicitHalfLiftedFrom?, HalfLiftedTo?>> e = x => x;
            Func<ImplicitHalfLiftedFrom?, HalfLiftedTo?> f = e.Compile(useInterpreter);
            Assert.NotNull(f(new ImplicitHalfLiftedFrom()));
            Assert.Null(f(new ImplicitHalfLiftedFrom { NullEquiv = true }));
            Assert.Null(f(null));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ExplicitHalfLiftedConversionFromCSCompiler(CompilationType useInterpreter)
        {
            Expression<Func<ExplicitHalfLiftedFrom?, HalfLiftedTo?>> e = x => (HalfLiftedTo?)x;
            Func<ExplicitHalfLiftedFrom?, HalfLiftedTo?> f = e.Compile(useInterpreter);
            Assert.NotNull(f(new ExplicitHalfLiftedFrom()));
            Assert.Null(f(new ExplicitHalfLiftedFrom { NullEquiv = true }));
            Assert.Null(f(null));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ImplicitHalfLiftedOverloadedConversionFromCSCompiler(CompilationType useInterpreter)
        {
            Expression<Func<ImplicitHalfLiftedOverloaded?, HalfLiftedTo?>> e = x => x;
            Func<ImplicitHalfLiftedOverloaded?, HalfLiftedTo?> f = e.Compile(useInterpreter);
            Assert.NotNull(f(new ImplicitHalfLiftedOverloaded()));
            Assert.NotNull(f(null));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ImplicitHalfLiftedConversion(CompilationType useInterpreter)
        {
            ParameterExpression x = Expression.Parameter(typeof(ImplicitHalfLiftedFrom?));
            Expression<Func<ImplicitHalfLiftedFrom?, HalfLiftedTo?>> e =
                Expression.Lambda<Func<ImplicitHalfLiftedFrom?, HalfLiftedTo?>>(
                    Expression.Convert(x, typeof(HalfLiftedTo?)),
                    x);
            Func<ImplicitHalfLiftedFrom?, HalfLiftedTo?> f = e.Compile(useInterpreter);
            Assert.NotNull(f(new ImplicitHalfLiftedFrom()));
            Assert.Null(f(new ImplicitHalfLiftedFrom { NullEquiv = true }));
            Assert.Null(f(null));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ExplicitHalfLiftedConversion(CompilationType useInterpreter)
        {
            ParameterExpression x = Expression.Parameter(typeof(ExplicitHalfLiftedFrom?));
            Expression<Func<ExplicitHalfLiftedFrom?, HalfLiftedTo?>> e =
                Expression.Lambda<Func<ExplicitHalfLiftedFrom?, HalfLiftedTo?>>(
                    Expression.Convert(x, typeof(HalfLiftedTo?)),
                    x);
            Func<ExplicitHalfLiftedFrom?, HalfLiftedTo?> f = e.Compile(useInterpreter);
            Assert.NotNull(f(new ExplicitHalfLiftedFrom()));
            Assert.Null(f(new ExplicitHalfLiftedFrom { NullEquiv = true }));
            Assert.Null(f(null));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ImplicitHalfLiftedOverloadedConversion(CompilationType useInterpreter)
        {
            ParameterExpression x = Expression.Parameter(typeof(ImplicitHalfLiftedOverloaded?));
            Expression<Func<ImplicitHalfLiftedOverloaded?, HalfLiftedTo?>> e =
                Expression.Lambda<Func<ImplicitHalfLiftedOverloaded?, HalfLiftedTo?>>(
                    Expression.Convert(x, typeof(HalfLiftedTo?)),
                    x);
            Func<ImplicitHalfLiftedOverloaded?, HalfLiftedTo?> f = e.Compile(useInterpreter);
            Assert.NotNull(f(new ImplicitHalfLiftedOverloaded()));
            Assert.NotNull(f(null));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ImplicitHalfLiftedConversionExplicitlySetMethod(CompilationType useInterpreter)
        {
            ParameterExpression x = Expression.Parameter(typeof(ImplicitHalfLiftedFrom?));
            Expression<Func<ImplicitHalfLiftedFrom?, HalfLiftedTo?>> e =
                Expression.Lambda<Func<ImplicitHalfLiftedFrom?, HalfLiftedTo?>>(
                    Expression.Convert(x, typeof(HalfLiftedTo?), typeof(ImplicitHalfLiftedFrom).GetMethod("op_Implicit")),
                    x);
            Func<ImplicitHalfLiftedFrom?, HalfLiftedTo?> f = e.Compile(useInterpreter);
            Assert.NotNull(f(new ImplicitHalfLiftedFrom()));
            Assert.Null(f(new ImplicitHalfLiftedFrom { NullEquiv = true }));
            Assert.Null(f(null));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ExplicitHalfLiftedConversionExplicitlySetMethod(CompilationType useInterpreter)
        {
            ParameterExpression x = Expression.Parameter(typeof(ExplicitHalfLiftedFrom?));
            Expression<Func<ExplicitHalfLiftedFrom?, HalfLiftedTo?>> e =
                Expression.Lambda<Func<ExplicitHalfLiftedFrom?, HalfLiftedTo?>>(
                    Expression.Convert(x, typeof(HalfLiftedTo?), typeof(ExplicitHalfLiftedFrom).GetMethod("op_Explicit")),
                    x);
            Func<ExplicitHalfLiftedFrom?, HalfLiftedTo?> f = e.Compile(useInterpreter);
            Assert.NotNull(f(new ExplicitHalfLiftedFrom()));
            Assert.Null(f(new ExplicitHalfLiftedFrom { NullEquiv = true }));
            Assert.Null(f(null));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ImplicitHalfLiftedOverloadedConversionExplicitlySetMethod(CompilationType useInterpreter)
        {
            List<MethodInfo> opMethods =
                typeof(ImplicitHalfLiftedOverloaded).GetMethods().Where(m => m.Name == "op_Implicit").ToList();
            MethodInfo direct =
                opMethods.First(m => m.GetParameters()[0].ParameterType == typeof(ImplicitHalfLiftedOverloaded?));
            MethodInfo liftNeeded =
                opMethods.First(m => m.GetParameters()[0].ParameterType == typeof(ImplicitHalfLiftedOverloaded));
            ParameterExpression x = Expression.Parameter(typeof(ImplicitHalfLiftedOverloaded?));
            Expression<Func<ImplicitHalfLiftedOverloaded?, HalfLiftedTo?>> e =
                Expression.Lambda<Func<ImplicitHalfLiftedOverloaded?, HalfLiftedTo?>>(
                    Expression.Convert(x, typeof(HalfLiftedTo?), direct),
                    x);
            Func<ImplicitHalfLiftedOverloaded?, HalfLiftedTo?> f = e.Compile(useInterpreter);
            Assert.NotNull(f(new ImplicitHalfLiftedOverloaded()));
            Assert.NotNull(f(null));
            e = Expression.Lambda<Func<ImplicitHalfLiftedOverloaded?, HalfLiftedTo?>>(
                Expression.Convert(x, typeof(HalfLiftedTo?), liftNeeded), x);
            f = e.Compile(useInterpreter);
            Assert.NotNull(f(new ImplicitHalfLiftedOverloaded()));
            Assert.Null(f(null));
        }

        [Fact]
        public static void ImplicitHalfLiftedReverseConversion()
        {
            // In the case where there is a conversion from? -> to, then if
            // we want to do from? -> to? we should do two conversions;
            // from? -> to -> to?, since converting any value to the nullable
            // form of its type is always possible and well-defined.
            // The compiler correctly does this double-conversion in such cases.
            // We should probably not allow it to be done as a single lifted operation.
            ParameterExpression x = Expression.Parameter(typeof(ImplicitHalfLiftedFromReverse?));
            Assert.Throws<InvalidOperationException>(() => Expression.Convert(
                x, typeof(HalfLiftedTo?), typeof(ImplicitHalfLiftedFromReverse).GetMethod("op_Implicit")));
            Assert.Throws<InvalidOperationException>(() => Expression.Convert(
                x, typeof(HalfLiftedTo?)));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ImplicitHalfLiftedConversionOpOnTargetFromCSCompiler(CompilationType useInterpreter)
        {
            Expression<Func<HalfLiftedFromTargetOperator?, HalfLiftedToTargetOperator?>> e = x => x;
            Func<HalfLiftedFromTargetOperator?, HalfLiftedToTargetOperator?> f = e.Compile(useInterpreter);
            Assert.NotNull(f(new HalfLiftedFromTargetOperator()));
            Assert.Null(f(new HalfLiftedFromTargetOperator { NullEquiv = true }));
            Assert.Null(f(null));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ImplicitHalfLiftedConversionOpOnTarget(CompilationType useInterpreter)
        {
            ParameterExpression x = Expression.Parameter(typeof(HalfLiftedFromTargetOperator?));
            Expression<Func<HalfLiftedFromTargetOperator?, HalfLiftedToTargetOperator?>> e =
                Expression.Lambda<Func<HalfLiftedFromTargetOperator?, HalfLiftedToTargetOperator?>>(
                    Expression.Convert(x, typeof(HalfLiftedToTargetOperator?)),
                    x);
            Func<HalfLiftedFromTargetOperator?, HalfLiftedToTargetOperator?> f = e.Compile(useInterpreter);
            Assert.NotNull(f(new HalfLiftedFromTargetOperator()));
            Assert.Null(f(new HalfLiftedFromTargetOperator { NullEquiv = true }));
            Assert.Null(f(null));
        }

        [Fact]
        public static void ExplicitOpImplicit()
        {
            Assert.Throws<InvalidOperationException>(() => Expression.Convert(Expression.Constant(new PerverselyNamedMembers(0)), typeof(uint)));
        }

        [Fact]
        public static void OpenGenericnType()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.Convert(Expression.Constant(null), typeof(List<>)));
        }

        [Fact]
        public static void TypeContainingGenericParameters()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.Convert(Expression.Constant(null), typeof(List<>.Enumerator)));
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.Convert(Expression.Constant(null), typeof(List<>).MakeGenericType(typeof(List<>))));
        }

        [Fact]
        public static void ByRefType()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.Convert(Expression.Constant(null), typeof(object).MakeByRefType()));
        }

        [Fact]
        public static void PointerType()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.Convert(Expression.Constant(null), typeof(int*)));
        }

        public static IEnumerable<object[]> Conversions()
        {
            yield return new object[] { 3, 3 };
            yield return new object[] { (byte)3, 3 };
            yield return new object[] { 3, 3.0 };
            yield return new object[] { 3.0, 3 };
            yield return new object[] { 12345678, (short)24910 };
        }

        [Theory, PerCompilationType(nameof(Conversions))]
        public static void ConvertMakeUnary(object source, object result, CompilationType useInterpreter)
        {
            LambdaExpression lambda = Expression.Lambda(
                Expression.MakeUnary(ExpressionType.Convert, Expression.Constant(source), result.GetType())
                );
            Delegate del = lambda.Compile(useInterpreter);
            Assert.Equal(result, del.DynamicInvoke());
        }

        private class CustomConversions
        {
            public int Value { get; set; }

            public static int ConvertToInt(CustomConversions cc) => cc.Value;

            public static CustomConversions ConvertFromInt(int x) => new CustomConversions {Value = x};

            public static CustomConversions ConvertFromRefInt(ref int x) => new CustomConversions { Value = x++ };

            public static void DoNothing(CustomConversions cc)
            {
            }

            public static CustomConversions Create() => new CustomConversions();

            public static CustomConversions FromAddition(int x, int y) => new CustomConversions {Value = x + y};
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CustomConversionNotStandardNameTo(CompilationType useInterpreter)
        {
            Expression operand = Expression.Constant(new CustomConversions { Value = 9 });
            MethodInfo method = typeof(CustomConversions).GetMethod(nameof(CustomConversions.ConvertToInt));
            Expression<Func<int>> lambda = Expression.Lambda<Func<int>>(
                Expression.Convert(operand, typeof(int), method));
            Func<int> func = lambda.Compile(useInterpreter);
            Assert.Equal(9, func());
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CustomConversionNotStandardNameFrom(CompilationType useInterpreter)
        {
            Expression operand = Expression.Constant(4);
            MethodInfo method = typeof(CustomConversions).GetMethod(nameof(CustomConversions.ConvertFromInt));
            Expression<Func<CustomConversions>> lambda = Expression.Lambda<Func<CustomConversions>>(
                Expression.Convert(operand, typeof(CustomConversions), method));
            Func<CustomConversions> func = lambda.Compile(useInterpreter);
            Assert.Equal(4, func().Value);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CustomConversionNotStandardNameFromLifted(CompilationType useInterpreter)
        {
            Expression operand = Expression.Constant(4, typeof(int?));
            MethodInfo method = typeof(CustomConversions).GetMethod(nameof(CustomConversions.ConvertFromInt));
            Expression<Func<CustomConversions>> lambda = Expression.Lambda<Func<CustomConversions>>(
                Expression.Convert(operand, typeof(CustomConversions), method));
            Func<CustomConversions> func = lambda.Compile(useInterpreter);
            Assert.Equal(4, func().Value);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CustomConversionNotStandardNameFromLiftedNullOperand(CompilationType useInterpreter)
        {
            Expression operand = Expression.Constant(null, typeof(int?));
            MethodInfo method = typeof(CustomConversions).GetMethod(nameof(CustomConversions.ConvertFromInt));
            Expression<Func<CustomConversions>> lambda = Expression.Lambda<Func<CustomConversions>>(
                Expression.Convert(operand, typeof(CustomConversions), method));
            Func<CustomConversions> func = lambda.Compile(useInterpreter);
            Assert.Throws<InvalidOperationException>(() => func());
        }

        public delegate TResult ByRefFunc<T, TResult>(ref T arg);

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CustomConversionNotStandardNameFromLiftedByRef(CompilationType useInterpreter)
        {
            var param = Expression.Parameter(typeof(int?).MakeByRefType());
            MethodInfo method = typeof(CustomConversions).GetMethod(nameof(CustomConversions.ConvertFromRefInt));
            Expression<ByRefFunc<int?, CustomConversions>> lambda = Expression.Lambda<ByRefFunc<int?, CustomConversions>>(
                Expression.Convert(param, typeof(CustomConversions), method), param);
            ByRefFunc<int?, CustomConversions> func = lambda.Compile(useInterpreter);
            int? x = 5;
            Assert.Equal(5, func(ref x).Value);
            Assert.Equal(5, x); // Refness is lost on lifting.
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CustomConversionNotStandardNameFromByRef(CompilationType useInterpreter)
        {
            var param = Expression.Parameter(typeof(int).MakeByRefType());
            MethodInfo method = typeof(CustomConversions).GetMethod(nameof(CustomConversions.ConvertFromRefInt));
            Expression<ByRefFunc<int, CustomConversions>> lambda = Expression.Lambda<ByRefFunc<int, CustomConversions>>(
                Expression.Convert(param, typeof(CustomConversions), method), param);
            ByRefFunc<int, CustomConversions> func = lambda.Compile(useInterpreter);
            int x = 5;
            Assert.Equal(5, func(ref x).Value);
            Assert.Equal(6, x);
        }

        [Fact]
        public static void CustomConversionNotStandardNameToWrongType()
        {
            Expression operand = Expression.Constant(new CustomConversions { Value = 9 });
            MethodInfo method = typeof(CustomConversions).GetMethod(nameof(CustomConversions.ConvertToInt));
            Assert.Throws<InvalidOperationException>(() => Expression.Convert(operand, typeof(long), method));
        }

        [Fact]
        public static void CustomConversionNotStandardNameFromWrongType()
        {
            Expression operand = Expression.Constant(4L);
            MethodInfo method = typeof(CustomConversions).GetMethod(nameof(CustomConversions.ConvertFromInt));
            Assert.Throws<InvalidOperationException>(() => Expression.Convert(operand, typeof(CustomConversions), method));
        }

        [Fact]
        public static void CustomConversionNotStandardNameToVoidReturn()
        {
            Expression operand = Expression.Constant(new CustomConversions { Value = 9 });
            MethodInfo method = typeof(CustomConversions).GetMethod(nameof(CustomConversions.DoNothing));
            AssertExtensions.Throws<ArgumentException>("method", () => Expression.Convert(operand, typeof(int), method));
        }

        [Fact]
        public static void CustomConversionNotStandardNameToNullary()
        {
            Expression operand = Expression.Constant(new CustomConversions { Value = 9 });
            MethodInfo method = typeof(CustomConversions).GetMethod(nameof(CustomConversions.Create));
            AssertExtensions.Throws<ArgumentException>("method", () => Expression.Convert(operand, typeof(int), method));
        }

        [Fact]
        public static void CustomConversionNotStandardNameToExcessiveArity()
        {
            Expression operand = Expression.Constant(new CustomConversions { Value = 9 });
            MethodInfo method = typeof(CustomConversions).GetMethod(nameof(CustomConversions.FromAddition));
            AssertExtensions.Throws<ArgumentException>("method", () => Expression.Convert(operand, typeof(int), method));
        }

        [Fact]
        public static void CannotConvertNonVoidToVoid()
        {
            Assert.Throws<InvalidOperationException>(() => Expression.Convert(Expression.Constant(1), typeof(void)));
            Assert.Throws<InvalidOperationException>(() => Expression.Convert(Expression.Constant("a"), typeof(void)));
            Assert.Throws<InvalidOperationException>(() => Expression.Convert(Expression.Constant(DateTime.MinValue), typeof(void)));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ConvertVoidToVoid(CompilationType useInterpreter)
        {
            Action act = Expression.Lambda<Action>(Expression.Convert(Expression.Empty(), typeof(void)))
                .Compile(useInterpreter);
            act();
        }

        [Fact]
        public static void ConvertReferenceArrayToValueTypeArray()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.Convert(Expression.Default(typeof(string[])), typeof(int[])));
        }

        [Fact]
        public static void ConvertValueTypeArrayToValueTypeArray()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.Convert(Expression.Default(typeof(long[])), typeof(int[])));
        }

        [Fact]
        public static void ConvertValueTypeArrayToReferenceArray()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.Convert(Expression.Default(typeof(StringComparison[])), typeof(string[])));
        }

        [Fact]
        public static void ConvertSealedTypeArrayToNonImplementedInterfaceArray()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.Convert(Expression.Default(typeof(string[])), typeof(IAsyncResult[])));
        }

        [Fact]
        public static void ConvertNonImplementedInterfaceArrayToSealedTypeArray()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.Convert(Expression.Default(typeof(IAsyncResult[])), typeof(string[])));
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
            Expression<Func<NonSealed[][], IInterface[][]>> e = a => (IInterface[][])a;
            Func<NonSealed[][], IInterface[][]> f = e.Compile(useInterpreter);
            Derived[][] arr = new[]{new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
            Assert.Same(arr, f(arr));
            Assert.Null(f(null));
            Assert.Throws<InvalidCastException>(() => f(Array.Empty<NonSealed[]>()));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void IfaceArrayToNonSealedArray(CompilationType useInterpreter)
        {
            Expression<Func<IInterface[][], NonSealed[][]>> e = a => (NonSealed[][])a;
            Func<IInterface[][], NonSealed[][]> f = e.Compile(useInterpreter);
            Derived[][] arr = new[] {new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
            Assert.Same(arr, f(arr));
            Assert.Null(f(null));
            Assert.Throws<InvalidCastException>(() => f(Array.Empty<IInterface[]>()));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void NonSealedICollectionToIfaceArray(CompilationType useInterpreter)
        {
            Expression<Func<ICollection<NonSealed[]>, IInterface[][]>> e = a => (IInterface[][])a;
            Func<ICollection<NonSealed[]>, IInterface[][]> f = e.Compile(useInterpreter);
            Derived[][] arr = new[] {new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
            Assert.Same(arr, f(arr));
            Assert.Null(f(null));
            Assert.Throws<InvalidCastException>(() => f(Array.Empty<NonSealed[]>()));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void IfaceArrayToNonSealedIList(CompilationType useInterpreter)
        {
            Expression<Func<IInterface[][], IList<NonSealed>[]>> e = a => (IList<NonSealed>[])a;
            Func<IInterface[][], IList<NonSealed>[]> f = e.Compile(useInterpreter);
            Derived[][] arr = new[] {new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
            Assert.Same(arr, f(arr));
            Assert.Null(f(null));
            Assert.Throws<InvalidCastException>(() => f(Array.Empty<IInterface[]>()));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void NonSealedArrayToIfaceIEnumerable(CompilationType useInterpreter)
        {
            Expression<Func<NonSealed[][], IEnumerable<IInterface>[]>> e = a => (IEnumerable<IInterface>[])a;
            Func<NonSealed[][], IEnumerable<IInterface>[]> f = e.Compile(useInterpreter);
            Derived[][] arr = new[] {new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
            Assert.Same(arr, f(arr));
            Assert.Null(f(null));
            Assert.Throws<InvalidCastException>(() => f(Array.Empty<NonSealed[]>()));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void IfaceIReadonlyCollectionToNonSealedArray(CompilationType useInterpreter)
        {
            Expression<Func<IReadOnlyCollection<IInterface>[], NonSealed[][]>> e = a => (NonSealed[][])a;
            Func<IReadOnlyCollection<IInterface>[], NonSealed[][]> f = e.Compile(useInterpreter);
            Derived[][] arr = new[] {new[] {new Derived(), new Derived(), new Derived(), new Derived()}};
            Assert.Same(arr, f(arr));
            Assert.Null(f(null));
            Assert.Throws<InvalidCastException>(() => f(Array.Empty<IInterface[]>()));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void IFaceIListToObjectArray(CompilationType useInterpreter)
        {
            Expression<Func<IList<IInterface[]>, object[][]>> e = a => (object[][])a;
            Func<IList<IInterface[]>, object[][]> f = e.Compile(useInterpreter);
            Derived[][] arr = new[] { new[] { new Derived(), new Derived(), new Derived(), new Derived() } };
            Assert.Same(arr, f(arr));
            Assert.Null(f(null));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void ObjectIListToIFaceArray(CompilationType useInterpreter)
        {
            Expression<Func<IList<object[]>, IInterface[][]>> e = a => (IInterface[][])a;
            Func<IList<object[]>, IInterface[][]> f = e.Compile(useInterpreter);
            Derived[][] arr = new[] { new[] { new Derived(), new Derived(), new Derived(), new Derived() } };
            Assert.Same(arr, f(arr));
            Assert.Null(f(null));
            Assert.Throws<InvalidCastException>(() => f(Array.Empty<string[]>()));
        }

        [Fact]
        public static void IfaceToNonSZArray()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.Convert(Expression.Default(typeof(IList<NonSealed>[])), typeof(NonSealed[,][])));
        }

        [Fact]
        public static void NonSZArrayToIface()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.Convert(Expression.Default(typeof(NonSealed[,][])), typeof(IList<NonSealed>[])));
        }

        [Fact]
        public static void ArrayToNonArrayCompatibleIFace()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.Convert(Expression.Default(typeof(NonSealed[][])), typeof(IEquatable<NonSealed>[])));
            Assert.Throws<InvalidOperationException>(
                () => Expression.Convert(Expression.Default(typeof(NonSealed[][])), typeof(IDictionary<NonSealed, NonSealed>[])));
        }

        [Fact]
        public static void NonArrayCompatibleIFaceToArray()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.Convert(Expression.Default(typeof(IEquatable<NonSealed>[])), typeof(NonSealed[][])));
            Assert.Throws<InvalidOperationException>(
                () => Expression.Convert(Expression.Default(typeof(IDictionary<NonSealed, NonSealed>[])), typeof(NonSealed[][])));
        }

        [Fact]
        public static void ArrayToNotRelated()
        {
            Assert.Throws<InvalidOperationException>(
                () => Expression.Convert(Expression.Default(typeof(NonSealed[][][])), typeof(string[][])));
        }
    }
}
