// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace System.Linq.Expressions.Tests
{
    public static class AsTests
    {
        #region Test methods

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomAsCustom2Test(CompilationType useInterpreter)
        {
            C[] array = new C[] { null, new C(), new D(), new D(0), new D(5) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomAsCustom2(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomAsInterfaceTest(CompilationType useInterpreter)
        {
            C[] array = new C[] { null, new C(), new D(), new D(0), new D(5) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomAsInterface(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomAsIEquatableOfCustomTest(CompilationType useInterpreter)
        {
            C[] array = new C[] { null, new C(), new D(), new D(0), new D(5) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomAsIEquatableOfCustom(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomAsIEquatableOfCustom2Test(CompilationType useInterpreter)
        {
            C[] array = new C[] { null, new C(), new D(), new D(0), new D(5) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomAsIEquatableOfCustom2(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomAsObjectTest(CompilationType useInterpreter)
        {
            C[] array = new C[] { null, new C(), new D(), new D(0), new D(5) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomAsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomArrayAsCustom2ArrayTest(CompilationType useInterpreter)
        {
            C[][] array = new C[][] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomArrayAsCustom2Array(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomArrayAsIEnumerableOfCustomTest(CompilationType useInterpreter)
        {
            C[][] array = new C[][] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomArrayAsIEnumerableOfCustom(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomArrayAsIEnumerableOfCustom2Test(CompilationType useInterpreter)
        {
            C[][] array = new C[][] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomArrayAsIEnumerableOfCustom2(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomArrayAsIEnumerableOfInterfaceTest(CompilationType useInterpreter)
        {
            C[][] array = new C[][] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomArrayAsIEnumerableOfInterface(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomArrayAsIEnumerableOfObjectTest(CompilationType useInterpreter)
        {
            C[][] array = new C[][] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomArrayAsIEnumerableOfObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomArrayAsIListOfCustomTest(CompilationType useInterpreter)
        {
            C[][] array = new C[][] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomArrayAsIListOfCustom(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomArrayAsIListOfCustom2Test(CompilationType useInterpreter)
        {
            C[][] array = new C[][] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomArrayAsIListOfCustom2(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomArrayAsIListOfInterfaceTest(CompilationType useInterpreter)
        {
            C[][] array = new C[][] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomArrayAsIListOfInterface(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomArrayAsIListOfObjectTest(CompilationType useInterpreter)
        {
            C[][] array = new C[][] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomArrayAsIListOfObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustomArrayAsObjectArrayTest(CompilationType useInterpreter)
        {
            C[][] array = new C[][] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustomArrayAsObjectArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustom2AsCustomTest(CompilationType useInterpreter)
        {
            D[] array = new D[] { null, new D(), new D(0), new D(5) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustom2AsCustom(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustom2AsInterfaceTest(CompilationType useInterpreter)
        {
            D[] array = new D[] { null, new D(), new D(0), new D(5) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustom2AsInterface(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustom2AsIEquatableOfCustomTest(CompilationType useInterpreter)
        {
            D[] array = new D[] { null, new D(), new D(0), new D(5) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustom2AsIEquatableOfCustom(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustom2AsIEquatableOfCustom2Test(CompilationType useInterpreter)
        {
            D[] array = new D[] { null, new D(), new D(0), new D(5) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustom2AsIEquatableOfCustom2(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustom2AsObjectTest(CompilationType useInterpreter)
        {
            D[] array = new D[] { null, new D(), new D(0), new D(5) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustom2AsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckCustom2ArrayAsCustomArrayTest(CompilationType useInterpreter)
        {
            D[][] array = new D[][] { null, new D[] { null, new D(), new D(0), new D(5) }, new D[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyCustom2ArrayAsCustomArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckDelegateAsFuncOfObjectTest(CompilationType useInterpreter)
        {
            Delegate[] array = new Delegate[] { null, (Func<object>)delegate () { return null; }, (Func<int, int>)delegate (int i) { return i + 1; }, (Action<object>)delegate { } };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyDelegateAsFuncOfObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckDelegateAsObjectTest(CompilationType useInterpreter)
        {
            Delegate[] array = new Delegate[] { null, (Func<object>)delegate () { return null; }, (Func<int, int>)delegate (int i) { return i + 1; }, (Action<object>)delegate { } };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyDelegateAsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckEnumAsEnumTypeTest(CompilationType useInterpreter)
        {
            E[] array = new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyEnumAsEnumType(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckEnumAsObjectTest(CompilationType useInterpreter)
        {
            E[] array = new E[] { (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyEnumAsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckEnumTypeAsObjectTest(CompilationType useInterpreter)
        {
            Enum[] array = new Enum[] { null, (E)0, E.A, E.B, (E)int.MaxValue, (E)int.MinValue, (El)0, El.A, El.B, (El)long.MaxValue, (El)long.MinValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyEnumTypeAsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckFuncOfObjectAsDelegateTest(CompilationType useInterpreter)
        {
            Func<object>[] array = new Func<object>[] { null, (Func<object>)delegate () { return null; } };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyFuncOfObjectAsDelegate(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckInterfaceAsCustomTest(CompilationType useInterpreter)
        {
            I[] array = new I[] { null, new C(), new D(), new D(0), new D(5) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyInterfaceAsCustom(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckInterfaceAsCustom2Test(CompilationType useInterpreter)
        {
            I[] array = new I[] { null, new C(), new D(), new D(0), new D(5) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyInterfaceAsCustom2(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckInterfaceAsObjectTest(CompilationType useInterpreter)
        {
            I[] array = new I[] { null, new C(), new D(), new D(0), new D(5) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyInterfaceAsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfCustomAsCustomArrayTest(CompilationType useInterpreter)
        {
            IEnumerable<C>[] array = new IEnumerable<C>[] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10], new List<C>(), new List<C>(new C[] { null, new C(), new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfCustomAsCustomArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfCustomAsObjectArrayTest(CompilationType useInterpreter)
        {
            IEnumerable<C>[] array = new IEnumerable<C>[] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10], new List<C>(), new List<C>(new C[] { null, new C(), new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfCustomAsObjectArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfCustomAsCustomTest(CompilationType useInterpreter)
        {
            IEnumerable<C>[] array = new IEnumerable<C>[] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10], new List<C>(), new List<C>(new C[] { null, new C(), new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfCustomAsCustom(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfCustomAsCustom2Test(CompilationType useInterpreter)
        {
            IEnumerable<C>[] array = new IEnumerable<C>[] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10], new List<C>(), new List<C>(new C[] { null, new C(), new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfCustomAsCustom2(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfCustomAsObjectTest(CompilationType useInterpreter)
        {
            IEnumerable<C>[] array = new IEnumerable<C>[] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10], new List<C>(), new List<C>(new C[] { null, new C(), new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfCustomAsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfCustom2AsCustomArrayTest(CompilationType useInterpreter)
        {
            IEnumerable<D>[] array = new IEnumerable<D>[] { null, new D[] { null, new D(), new D(0), new D(5) }, new D[10], new List<D>(), new List<D>(new D[] { null, new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfCustom2AsCustomArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfCustom2AsCustomTest(CompilationType useInterpreter)
        {
            IEnumerable<D>[] array = new IEnumerable<D>[] { null, new D[] { null, new D(), new D(0), new D(5) }, new D[10], new List<D>(), new List<D>(new D[] { null, new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfCustom2AsCustom(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfCustom2AsCustom2Test(CompilationType useInterpreter)
        {
            IEnumerable<D>[] array = new IEnumerable<D>[] { null, new D[] { null, new D(), new D(0), new D(5) }, new D[10], new List<D>(), new List<D>(new D[] { null, new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfCustom2AsCustom2(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfCustom2AsObjectTest(CompilationType useInterpreter)
        {
            IEnumerable<D>[] array = new IEnumerable<D>[] { null, new D[] { null, new D(), new D(0), new D(5) }, new D[10], new List<D>(), new List<D>(new D[] { null, new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfCustom2AsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfInterfaceAsCustomArrayTest(CompilationType useInterpreter)
        {
            IEnumerable<I>[] array = new IEnumerable<I>[] { null, new I[] { null, new C(), new D(), new D(0), new D(5) }, new I[10], new List<I>(), new List<I>(new I[] { null, new C(), new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfInterfaceAsCustomArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfInterfaceAsObjectArrayTest(CompilationType useInterpreter)
        {
            IEnumerable<I>[] array = new IEnumerable<I>[] { null, new I[] { null, new C(), new D(), new D(0), new D(5) }, new I[10], new List<I>(), new List<I>(new I[] { null, new C(), new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfInterfaceAsObjectArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfObjectAsCustomArrayTest(CompilationType useInterpreter)
        {
            IEnumerable<object>[] array = new IEnumerable<object>[] { null, new object[] { null, new object(), new C(), new D(3) }, new object[10], new List<object>(), new List<object>(new object[] { null, new object(), new C(), new D(3) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfObjectAsCustomArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfObjectAsObjectArrayTest(CompilationType useInterpreter)
        {
            IEnumerable<object>[] array = new IEnumerable<object>[] { null, new object[] { null, new object(), new C(), new D(3) }, new object[10], new List<object>(), new List<object>(new object[] { null, new object(), new C(), new D(3) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfObjectAsObjectArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIEnumerableOfStructAsStructArrayTest(CompilationType useInterpreter)
        {
            IEnumerable<S>[] array = new IEnumerable<S>[] { null, new S[] { default(S), new S() }, new S[10], new List<S>(), new List<S>(new S[] { default(S), new S() }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIEnumerableOfStructAsStructArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIListOfCustomAsCustomArrayTest(CompilationType useInterpreter)
        {
            IList<C>[] array = new IList<C>[] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10], new List<C>(), new List<C>(new C[] { null, new C(), new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIListOfCustomAsCustomArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIListOfCustomAsObjectArrayTest(CompilationType useInterpreter)
        {
            IList<C>[] array = new IList<C>[] { null, new C[] { null, new C(), new D(), new D(0), new D(5) }, new C[10], new List<C>(), new List<C>(new C[] { null, new C(), new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIListOfCustomAsObjectArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIListOfCustom2AsCustomArrayTest(CompilationType useInterpreter)
        {
            IList<D>[] array = new IList<D>[] { null, new D[] { null, new D(), new D(0), new D(5) }, new D[10], new List<D>(), new List<D>(new D[] { null, new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIListOfCustom2AsCustomArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIListOfInterfaceAsCustomArrayTest(CompilationType useInterpreter)
        {
            IList<I>[] array = new IList<I>[] { null, new I[] { null, new C(), new D(), new D(0), new D(5) }, new I[10], new List<I>(), new List<I>(new I[] { null, new C(), new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIListOfInterfaceAsCustomArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIListOfInterfaceAsObjectArrayTest(CompilationType useInterpreter)
        {
            IList<I>[] array = new IList<I>[] { null, new I[] { null, new C(), new D(), new D(0), new D(5) }, new I[10], new List<I>(), new List<I>(new I[] { null, new C(), new D(), new D(0), new D(5) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIListOfInterfaceAsObjectArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIListOfObjectAsCustomArrayTest(CompilationType useInterpreter)
        {
            IList<object>[] array = new IList<object>[] { null, new object[] { null, new object(), new C(), new D(3) }, new object[10], new List<object>(), new List<object>(new object[] { null, new object(), new C(), new D(3) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIListOfObjectAsCustomArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIListOfObjectAsObjectArrayTest(CompilationType useInterpreter)
        {
            IList<object>[] array = new IList<object>[] { null, new object[] { null, new object(), new C(), new D(3) }, new object[10], new List<object>(), new List<object>(new object[] { null, new object(), new C(), new D(3) }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIListOfObjectAsObjectArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIListOfStructAsStructArrayTest(CompilationType useInterpreter)
        {
            IList<S>[] array = new IList<S>[] { null, new S[] { default(S), new S() }, new S[10], new List<S>(), new List<S>(new S[] { default(S), new S() }) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIListOfStructAsStructArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIntAsObjectTest(CompilationType useInterpreter)
        {
            int[] array = new int[] { 0, 1, -1, int.MinValue, int.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIntAsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckIntAsValueTypeTest(CompilationType useInterpreter)
        {
            int[] array = new int[] { 0, 1, -1, int.MinValue, int.MaxValue };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyIntAsValueType(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectAsCustomTest(CompilationType useInterpreter)
        {
            object[] array = new object[] { null, new object(), new C(), new D(3) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectAsCustom(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectAsCustom2Test(CompilationType useInterpreter)
        {
            object[] array = new object[] { null, new object(), new C(), new D(3) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectAsCustom2(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectAsDelegateTest(CompilationType useInterpreter)
        {
            object[] array = new object[] { null, new object(), new C(), new D(3) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectAsDelegate(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectAsEnumTypeTest(CompilationType useInterpreter)
        {
            object[] array = new object[] { null, new object(), new C(), new D(3) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectAsEnumType(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectAsInterfaceTest(CompilationType useInterpreter)
        {
            object[] array = new object[] { null, new object(), new C(), new D(3) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectAsInterface(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectAsIEquatableOfCustomTest(CompilationType useInterpreter)
        {
            object[] array = new object[] { null, new object(), new C(), new D(3) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectAsIEquatableOfCustom(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectAsIEquatableOfCustom2Test(CompilationType useInterpreter)
        {
            object[] array = new object[] { null, new object(), new C(), new D(3) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectAsIEquatableOfCustom2(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectAsValueTypeTest(CompilationType useInterpreter)
        {
            object[] array = new object[] { null, new object(), new C(), new D(3) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectAsValueType(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectArrayAsCustomArrayTest(CompilationType useInterpreter)
        {
            object[][] array = new object[][] { null, new object[] { null, new object(), new C(), new D(3) }, new object[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectArrayAsCustomArray(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectArrayAsIEnumerableOfCustomTest(CompilationType useInterpreter)
        {
            object[][] array = new object[][] { null, new object[] { null, new object(), new C(), new D(3) }, new object[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectArrayAsIEnumerableOfCustom(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectArrayAsIEnumerableOfInterfaceTest(CompilationType useInterpreter)
        {
            object[][] array = new object[][] { null, new object[] { null, new object(), new C(), new D(3) }, new object[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectArrayAsIEnumerableOfInterface(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectArrayAsIEnumerableOfObjectTest(CompilationType useInterpreter)
        {
            object[][] array = new object[][] { null, new object[] { null, new object(), new C(), new D(3) }, new object[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectArrayAsIEnumerableOfObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectArrayAsIListOfCustomTest(CompilationType useInterpreter)
        {
            object[][] array = new object[][] { null, new object[] { null, new object(), new C(), new D(3) }, new object[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectArrayAsIListOfCustom(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectArrayAsIListOfInterfaceTest(CompilationType useInterpreter)
        {
            object[][] array = new object[][] { null, new object[] { null, new object(), new C(), new D(3) }, new object[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectArrayAsIListOfInterface(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckObjectArrayAsIListOfObjectTest(CompilationType useInterpreter)
        {
            object[][] array = new object[][] { null, new object[] { null, new object(), new C(), new D(3) }, new object[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyObjectArrayAsIListOfObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckStructAsIEquatableOfStructTest(CompilationType useInterpreter)
        {
            S[] array = new S[] { default(S), new S() };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyStructAsIEquatableOfStruct(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckStructAsObjectTest(CompilationType useInterpreter)
        {
            S[] array = new S[] { default(S), new S() };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyStructAsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckStructAsValueTypeTest(CompilationType useInterpreter)
        {
            S[] array = new S[] { default(S), new S() };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyStructAsValueType(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckStructArrayAsIEnumerableOfStructTest(CompilationType useInterpreter)
        {
            S[][] array = new S[][] { null, new S[] { default(S), new S() }, new S[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyStructArrayAsIEnumerableOfStruct(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckStructArrayAsIListOfStructTest(CompilationType useInterpreter)
        {
            S[][] array = new S[][] { null, new S[] { default(S), new S() }, new S[10] };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyStructArrayAsIListOfStruct(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckValueTypeAsObjectTest(CompilationType useInterpreter)
        {
            ValueType[] array = new ValueType[] { null, default(S), new Scs(null, new S()), E.A, El.B };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyValueTypeAsObject(array[i], useInterpreter);
            }
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckGenericAsObjectCustomTest(CompilationType useInterpreter)
        {
            CheckGenericAsObjectHelper<C>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckGenericAsObjectEnumTest(CompilationType useInterpreter)
        {
            CheckGenericAsObjectHelper<E>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckGenericAsObjectObjectTest(CompilationType useInterpreter)
        {
            CheckGenericAsObjectHelper<object>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckGenericAsObjectStructTest(CompilationType useInterpreter)
        {
            CheckGenericAsObjectHelper<S>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckGenericAsObjectStructWithStringAndValueTest(CompilationType useInterpreter)
        {
            CheckGenericAsObjectHelper<Scs>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckGenericWithClassRestrictionAsCustomTest(CompilationType useInterpreter)
        {
            CheckGenericWithClassRestrictionAsObjectHelper<C>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckGenericWithClassRestrictionAsObjectTest(CompilationType useInterpreter)
        {
            CheckGenericWithClassRestrictionAsObjectHelper<object>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckGenericWithStructRestrictionAsEnumTest(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionAsObjectHelper<E>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckGenericWithStructRestrictionAsStructTest(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionAsObjectHelper<S>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckGenericWithStructRestrictionAsStructWithStringAndValueTest(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionAsObjectHelper<Scs>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckGenericWithStructRestrictionAsValueTypeAsEnumTest(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionAsValueTypeHelper<E>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckGenericWithStructRestrictionAsValueTypeAsStructTest(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionAsValueTypeHelper<S>(useInterpreter);
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public static void CheckGenericWithStructRestrictionAsValueTypeAsStructWithStringAndValueTest(CompilationType useInterpreter)
        {
            CheckGenericWithStructRestrictionAsValueTypeHelper<Scs>(useInterpreter);
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public static void ToStringTest()
        {
            UnaryExpression e = Expression.TypeAs(Expression.Parameter(typeof(object), "o"), typeof(string));
            Assert.Equal("(o As String)", e.ToString());
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public static void NonNullableValueType()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.TypeAs(Expression.Constant(0), typeof(int)));
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.TypeAs(Expression.Constant(null), typeof(DateTime)));
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.TypeAs(Expression.Constant(DateTime.MinValue), typeof(DateTime)));
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public static void NullType() =>
            AssertExtensions.Throws<ArgumentNullException>("type", () => Expression.TypeAs(Expression.Constant(""), null));

        [Fact(Skip = "no call to CompileToMethod")]
        public static void NullExpression() =>
            AssertExtensions.Throws<ArgumentNullException>("expression", () => Expression.TypeAs(null, typeof(string)));

        [Fact(Skip = "no call to CompileToMethod")]
        public static void AsOpenGeneric()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.TypeAs(Expression.Constant(""), typeof(List<>)));
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.TypeAs(Expression.Constant(""), typeof(List<>).MakeGenericType(typeof(List<>))));
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public static void PointerType()
        {
            AssertExtensions.Throws<ArgumentException>(
                "type", () => Expression.TypeAs(Expression.Constant(""), typeof(int).MakePointerType()));
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public static void ByRefType()
        {
            AssertExtensions.Throws<ArgumentException>(
                "type", () => Expression.TypeAs(Expression.Constant(""), typeof(string).MakeByRefType()));
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public static void UnreadableTypeAs()
        {
            MemberExpression unreadable = Expression.Property(
                null, typeof(Unreadable<string>), nameof(Unreadable<string>.WriteOnly));
            AssertExtensions.Throws<ArgumentException>("expression", () => Expression.TypeAs(unreadable, typeof(string)));
        }

        #endregion

        #region Generic helpers

        private static void CheckGenericAsObjectHelper<T>(CompilationType useInterpreter)
        {
            T[] array = new T[] { default(T) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyGenericAsObject<T>(array[i], useInterpreter);
            }
        }

        private static void CheckGenericWithClassRestrictionAsObjectHelper<Tc>(CompilationType useInterpreter) where Tc : class
        {
            Tc[] array = new Tc[] { null, default(Tc) };
            for (int i = 0; i < array.Length; i++)
            {
                VerifyGenericWithClassRestrictionAsObject<Tc>(array[i], useInterpreter);
            }
        }

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

        private static void VerifyCustomAsCustom2(C value, CompilationType useInterpreter)
        {
            Expression<Func<D>> e =
                Expression.Lambda<Func<D>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C)), typeof(D)),
                    Enumerable.Empty<ParameterExpression>());
            Func<D> f = e.Compile(useInterpreter);

            Assert.Equal(value as D, f());
        }

        private static void VerifyCustomAsInterface(C value, CompilationType useInterpreter)
        {
            Expression<Func<I>> e =
                Expression.Lambda<Func<I>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C)), typeof(I)),
                    Enumerable.Empty<ParameterExpression>());
            Func<I> f = e.Compile(useInterpreter);

            Assert.Equal(value as I, f());
        }

        private static void VerifyCustomAsIEquatableOfCustom(C value, CompilationType useInterpreter)
        {
            Expression<Func<IEquatable<C>>> e =
                Expression.Lambda<Func<IEquatable<C>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C)), typeof(IEquatable<C>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEquatable<C>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEquatable<C>, f());
        }

        private static void VerifyCustomAsIEquatableOfCustom2(C value, CompilationType useInterpreter)
        {
            Expression<Func<IEquatable<D>>> e =
                Expression.Lambda<Func<IEquatable<D>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C)), typeof(IEquatable<D>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEquatable<D>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEquatable<D>, f());
        }

        private static void VerifyCustomAsObject(C value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyCustomArrayAsCustom2Array(C[] value, CompilationType useInterpreter)
        {
            Expression<Func<D[]>> e =
                Expression.Lambda<Func<D[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C[])), typeof(D[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<D[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as D[], f());
        }

        private static void VerifyCustomArrayAsIEnumerableOfCustom(C[] value, CompilationType useInterpreter)
        {
            Expression<Func<IEnumerable<C>>> e =
                Expression.Lambda<Func<IEnumerable<C>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C[])), typeof(IEnumerable<C>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEnumerable<C>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEnumerable<C>, f());
        }

        private static void VerifyCustomArrayAsIEnumerableOfCustom2(C[] value, CompilationType useInterpreter)
        {
            Expression<Func<IEnumerable<D>>> e =
                Expression.Lambda<Func<IEnumerable<D>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C[])), typeof(IEnumerable<D>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEnumerable<D>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEnumerable<D>, f());
        }

        private static void VerifyCustomArrayAsIEnumerableOfInterface(C[] value, CompilationType useInterpreter)
        {
            Expression<Func<IEnumerable<I>>> e =
                Expression.Lambda<Func<IEnumerable<I>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C[])), typeof(IEnumerable<I>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEnumerable<I>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEnumerable<I>, f());
        }

        private static void VerifyCustomArrayAsIEnumerableOfObject(C[] value, CompilationType useInterpreter)
        {
            Expression<Func<IEnumerable<object>>> e =
                Expression.Lambda<Func<IEnumerable<object>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C[])), typeof(IEnumerable<object>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEnumerable<object>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEnumerable<object>, f());
        }

        private static void VerifyCustomArrayAsIListOfCustom(C[] value, CompilationType useInterpreter)
        {
            Expression<Func<IList<C>>> e =
                Expression.Lambda<Func<IList<C>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C[])), typeof(IList<C>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IList<C>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IList<C>, f());
        }

        private static void VerifyCustomArrayAsIListOfCustom2(C[] value, CompilationType useInterpreter)
        {
            Expression<Func<IList<D>>> e =
                Expression.Lambda<Func<IList<D>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C[])), typeof(IList<D>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IList<D>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IList<D>, f());

        }

        private static void VerifyCustomArrayAsIListOfInterface(C[] value, CompilationType useInterpreter)
        {
            Expression<Func<IList<I>>> e =
                Expression.Lambda<Func<IList<I>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C[])), typeof(IList<I>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IList<I>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IList<I>, f());
        }

        private static void VerifyCustomArrayAsIListOfObject(C[] value, CompilationType useInterpreter)
        {
            Expression<Func<IList<object>>> e =
                Expression.Lambda<Func<IList<object>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C[])), typeof(IList<object>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IList<object>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IList<object>, f());
        }

        private static void VerifyCustomArrayAsObjectArray(C[] value, CompilationType useInterpreter)
        {
            Expression<Func<object[]>> e =
                Expression.Lambda<Func<object[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(C[])), typeof(object[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<object[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as object[], f());
        }

        private static void VerifyCustom2AsCustom(D value, CompilationType useInterpreter)
        {
            Expression<Func<C>> e =
                Expression.Lambda<Func<C>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(D)), typeof(C)),
                    Enumerable.Empty<ParameterExpression>());
            Func<C> f = e.Compile(useInterpreter);

            Assert.Equal(value as C, f());

        }

        private static void VerifyCustom2AsInterface(D value, CompilationType useInterpreter)
        {
            Expression<Func<I>> e =
                Expression.Lambda<Func<I>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(D)), typeof(I)),
                    Enumerable.Empty<ParameterExpression>());
            Func<I> f = e.Compile(useInterpreter);

            Assert.Equal(value as I, f());
        }

        private static void VerifyCustom2AsIEquatableOfCustom(D value, CompilationType useInterpreter)
        {
            Expression<Func<IEquatable<C>>> e =
                Expression.Lambda<Func<IEquatable<C>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(D)), typeof(IEquatable<C>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEquatable<C>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEquatable<C>, f());
        }

        private static void VerifyCustom2AsIEquatableOfCustom2(D value, CompilationType useInterpreter)
        {
            Expression<Func<IEquatable<D>>> e =
                Expression.Lambda<Func<IEquatable<D>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(D)), typeof(IEquatable<D>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEquatable<D>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEquatable<D>, f());
        }

        private static void VerifyCustom2AsObject(D value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(D)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyCustom2ArrayAsCustomArray(D[] value, CompilationType useInterpreter)
        {
            Expression<Func<C[]>> e =
                Expression.Lambda<Func<C[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(D[])), typeof(C[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<C[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as C[], f());
        }

        private static void VerifyDelegateAsFuncOfObject(Delegate value, CompilationType useInterpreter)
        {
            Expression<Func<Func<object>>> e =
                Expression.Lambda<Func<Func<object>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(Delegate)), typeof(Func<object>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<Func<object>> f = e.Compile(useInterpreter);

            Assert.Equal(value as Func<object>, f());
        }

        private static void VerifyDelegateAsObject(Delegate value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(Delegate)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyEnumAsEnumType(E value, CompilationType useInterpreter)
        {
            Expression<Func<Enum>> e =
                Expression.Lambda<Func<Enum>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(E)), typeof(Enum)),
                    Enumerable.Empty<ParameterExpression>());
            Func<Enum> f = e.Compile(useInterpreter);

            Assert.Equal(value as Enum, f());
        }

        private static void VerifyEnumAsObject(E value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(E)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyEnumTypeAsObject(Enum value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(Enum)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyFuncOfObjectAsDelegate(Func<object> value, CompilationType useInterpreter)
        {
            Expression<Func<Delegate>> e =
                Expression.Lambda<Func<Delegate>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(Func<object>)), typeof(Delegate)),
                    Enumerable.Empty<ParameterExpression>());
            Func<Delegate> f = e.Compile(useInterpreter);

            Assert.Equal(value as Delegate, f());
        }

        private static void VerifyInterfaceAsCustom(I value, CompilationType useInterpreter)
        {
            Expression<Func<C>> e =
                Expression.Lambda<Func<C>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(I)), typeof(C)),
                    Enumerable.Empty<ParameterExpression>());
            Func<C> f = e.Compile(useInterpreter);

            Assert.Equal(value as C, f());
        }

        private static void VerifyInterfaceAsCustom2(I value, CompilationType useInterpreter)
        {
            Expression<Func<D>> e =
                Expression.Lambda<Func<D>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(I)), typeof(D)),
                    Enumerable.Empty<ParameterExpression>());
            Func<D> f = e.Compile(useInterpreter);

            Assert.Equal(value as D, f());
        }

        private static void VerifyInterfaceAsObject(I value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(I)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyIEnumerableOfCustomAsCustomArray(IEnumerable<C> value, CompilationType useInterpreter)
        {
            Expression<Func<C[]>> e =
                Expression.Lambda<Func<C[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<C>)), typeof(C[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<C[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as C[], f());
        }

        private static void VerifyIEnumerableOfCustomAsObjectArray(IEnumerable<C> value, CompilationType useInterpreter)
        {
            Expression<Func<object[]>> e =
                Expression.Lambda<Func<object[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<C>)), typeof(object[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<object[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as object[], f());
        }

        private static void VerifyIEnumerableOfCustomAsCustom(IEnumerable<C> value, CompilationType useInterpreter)
        {
            Expression<Func<C>> e =
                Expression.Lambda<Func<C>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<C>)), typeof(C)),
                    Enumerable.Empty<ParameterExpression>());
            Func<C> f = e.Compile(useInterpreter);

            Assert.Equal(value as C, f());
        }

        private static void VerifyIEnumerableOfCustomAsCustom2(IEnumerable<C> value, CompilationType useInterpreter)
        {
            Expression<Func<D>> e =
                Expression.Lambda<Func<D>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<C>)), typeof(D)),
                    Enumerable.Empty<ParameterExpression>());
            Func<D> f = e.Compile(useInterpreter);

            Assert.Equal(value as D, f());
        }

        private static void VerifyIEnumerableOfCustomAsObject(IEnumerable<C> value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<C>)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyIEnumerableOfCustom2AsCustomArray(IEnumerable<D> value, CompilationType useInterpreter)
        {
            Expression<Func<C[]>> e =
                Expression.Lambda<Func<C[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<D>)), typeof(C[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<C[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as C[], f());
        }

        private static void VerifyIEnumerableOfCustom2AsCustom(IEnumerable<D> value, CompilationType useInterpreter)
        {
            Expression<Func<C>> e =
                Expression.Lambda<Func<C>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<D>)), typeof(C)),
                    Enumerable.Empty<ParameterExpression>());
            Func<C> f = e.Compile(useInterpreter);

            Assert.Equal(value as C, f());
        }

        private static void VerifyIEnumerableOfCustom2AsCustom2(IEnumerable<D> value, CompilationType useInterpreter)
        {
            Expression<Func<D>> e =
                Expression.Lambda<Func<D>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<D>)), typeof(D)),
                    Enumerable.Empty<ParameterExpression>());
            Func<D> f = e.Compile(useInterpreter);

            Assert.Equal(value as D, f());
        }

        private static void VerifyIEnumerableOfCustom2AsObject(IEnumerable<D> value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<D>)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyIEnumerableOfInterfaceAsCustomArray(IEnumerable<I> value, CompilationType useInterpreter)
        {
            Expression<Func<C[]>> e =
                Expression.Lambda<Func<C[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<I>)), typeof(C[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<C[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as C[], f());
        }

        private static void VerifyIEnumerableOfInterfaceAsObjectArray(IEnumerable<I> value, CompilationType useInterpreter)
        {
            Expression<Func<object[]>> e =
                Expression.Lambda<Func<object[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<I>)), typeof(object[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<object[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as object[], f());
        }

        private static void VerifyIEnumerableOfObjectAsCustomArray(IEnumerable<object> value, CompilationType useInterpreter)
        {
            Expression<Func<C[]>> e =
                Expression.Lambda<Func<C[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<object>)), typeof(C[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<C[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as C[], f());
        }

        private static void VerifyIEnumerableOfObjectAsObjectArray(IEnumerable<object> value, CompilationType useInterpreter)
        {
            Expression<Func<object[]>> e =
                Expression.Lambda<Func<object[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<object>)), typeof(object[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<object[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as object[], f());
        }

        private static void VerifyIEnumerableOfStructAsStructArray(IEnumerable<S> value, CompilationType useInterpreter)
        {
            Expression<Func<S[]>> e =
                Expression.Lambda<Func<S[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IEnumerable<S>)), typeof(S[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<S[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as S[], f());
        }

        private static void VerifyIListOfCustomAsCustomArray(IList<C> value, CompilationType useInterpreter)
        {
            Expression<Func<C[]>> e =
                Expression.Lambda<Func<C[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IList<C>)), typeof(C[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<C[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as C[], f());
        }

        private static void VerifyIListOfCustomAsObjectArray(IList<C> value, CompilationType useInterpreter)
        {
            Expression<Func<object[]>> e =
                Expression.Lambda<Func<object[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IList<C>)), typeof(object[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<object[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as object[], f());
        }

        private static void VerifyIListOfCustom2AsCustomArray(IList<D> value, CompilationType useInterpreter)
        {
            Expression<Func<C[]>> e =
                Expression.Lambda<Func<C[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IList<D>)), typeof(C[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<C[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as C[], f());
        }

        private static void VerifyIListOfInterfaceAsCustomArray(IList<I> value, CompilationType useInterpreter)
        {
            Expression<Func<C[]>> e =
                Expression.Lambda<Func<C[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IList<I>)), typeof(C[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<C[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as C[], f());
        }

        private static void VerifyIListOfInterfaceAsObjectArray(IList<I> value, CompilationType useInterpreter)
        {
            Expression<Func<object[]>> e =
                Expression.Lambda<Func<object[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IList<I>)), typeof(object[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<object[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as object[], f());
        }

        private static void VerifyIListOfObjectAsCustomArray(IList<object> value, CompilationType useInterpreter)
        {
            Expression<Func<C[]>> e =
                Expression.Lambda<Func<C[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IList<object>)), typeof(C[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<C[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as C[], f());
        }

        private static void VerifyIListOfObjectAsObjectArray(IList<object> value, CompilationType useInterpreter)
        {
            Expression<Func<object[]>> e =
                Expression.Lambda<Func<object[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IList<object>)), typeof(object[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<object[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as object[], f());
        }

        private static void VerifyIListOfStructAsStructArray(IList<S> value, CompilationType useInterpreter)
        {
            Expression<Func<S[]>> e =
                Expression.Lambda<Func<S[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(IList<S>)), typeof(S[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<S[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as S[], f());
        }

        private static void VerifyIntAsObject(int value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(int)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyIntAsValueType(int value, CompilationType useInterpreter)
        {
            Expression<Func<ValueType>> e =
                Expression.Lambda<Func<ValueType>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(int)), typeof(ValueType)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ValueType> f = e.Compile(useInterpreter);

            Assert.Equal(value as ValueType, f());
        }

        private static void VerifyObjectAsCustom(object value, CompilationType useInterpreter)
        {
            Expression<Func<C>> e =
                Expression.Lambda<Func<C>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object)), typeof(C)),
                    Enumerable.Empty<ParameterExpression>());
            Func<C> f = e.Compile(useInterpreter);

            Assert.Equal(value as C, f());
        }

        private static void VerifyObjectAsCustom2(object value, CompilationType useInterpreter)
        {
            Expression<Func<D>> e =
                Expression.Lambda<Func<D>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object)), typeof(D)),
                    Enumerable.Empty<ParameterExpression>());
            Func<D> f = e.Compile(useInterpreter);

            Assert.Equal(value as D, f());
        }

        private static void VerifyObjectAsDelegate(object value, CompilationType useInterpreter)
        {
            Expression<Func<Delegate>> e =
                Expression.Lambda<Func<Delegate>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object)), typeof(Delegate)),
                    Enumerable.Empty<ParameterExpression>());
            Func<Delegate> f = e.Compile(useInterpreter);

            Assert.Equal(value as Delegate, f());
        }

        private static void VerifyObjectAsEnumType(object value, CompilationType useInterpreter)
        {
            Expression<Func<Enum>> e =
                Expression.Lambda<Func<Enum>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object)), typeof(Enum)),
                    Enumerable.Empty<ParameterExpression>());
            Func<Enum> f = e.Compile(useInterpreter);

            Assert.Equal(value as Enum, f());
        }

        private static void VerifyObjectAsInterface(object value, CompilationType useInterpreter)
        {
            Expression<Func<I>> e =
                Expression.Lambda<Func<I>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object)), typeof(I)),
                    Enumerable.Empty<ParameterExpression>());
            Func<I> f = e.Compile(useInterpreter);

            Assert.Equal(value as I, f());
        }

        private static void VerifyObjectAsIEquatableOfCustom(object value, CompilationType useInterpreter)
        {
            Expression<Func<IEquatable<C>>> e =
                Expression.Lambda<Func<IEquatable<C>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object)), typeof(IEquatable<C>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEquatable<C>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEquatable<C>, f());
        }

        private static void VerifyObjectAsIEquatableOfCustom2(object value, CompilationType useInterpreter)
        {
            Expression<Func<IEquatable<D>>> e =
                Expression.Lambda<Func<IEquatable<D>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object)), typeof(IEquatable<D>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEquatable<D>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEquatable<D>, f());
        }

        private static void VerifyObjectAsValueType(object value, CompilationType useInterpreter)
        {
            Expression<Func<ValueType>> e =
                Expression.Lambda<Func<ValueType>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object)), typeof(ValueType)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ValueType> f = e.Compile(useInterpreter);

            Assert.Equal(value as ValueType, f());
        }

        private static void VerifyObjectArrayAsCustomArray(object[] value, CompilationType useInterpreter)
        {
            Expression<Func<C[]>> e =
                Expression.Lambda<Func<C[]>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object[])), typeof(C[])),
                    Enumerable.Empty<ParameterExpression>());
            Func<C[]> f = e.Compile(useInterpreter);

            Assert.Equal(value as C[], f());
        }

        private static void VerifyObjectArrayAsIEnumerableOfCustom(object[] value, CompilationType useInterpreter)
        {
            Expression<Func<IEnumerable<C>>> e =
                Expression.Lambda<Func<IEnumerable<C>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object[])), typeof(IEnumerable<C>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEnumerable<C>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEnumerable<C>, f());
        }

        private static void VerifyObjectArrayAsIEnumerableOfInterface(object[] value, CompilationType useInterpreter)
        {
            Expression<Func<IEnumerable<I>>> e =
                Expression.Lambda<Func<IEnumerable<I>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object[])), typeof(IEnumerable<I>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEnumerable<I>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEnumerable<I>, f());
        }

        private static void VerifyObjectArrayAsIEnumerableOfObject(object[] value, CompilationType useInterpreter)
        {
            Expression<Func<IEnumerable<object>>> e =
                Expression.Lambda<Func<IEnumerable<object>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object[])), typeof(IEnumerable<object>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEnumerable<object>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEnumerable<object>, f());
        }

        private static void VerifyObjectArrayAsIListOfCustom(object[] value, CompilationType useInterpreter)
        {
            Expression<Func<IList<C>>> e =
                Expression.Lambda<Func<IList<C>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object[])), typeof(IList<C>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IList<C>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IList<C>, f());
        }

        private static void VerifyObjectArrayAsIListOfInterface(object[] value, CompilationType useInterpreter)
        {
            Expression<Func<IList<I>>> e =
                Expression.Lambda<Func<IList<I>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object[])), typeof(IList<I>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IList<I>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IList<I>, f());
        }

        private static void VerifyObjectArrayAsIListOfObject(object[] value, CompilationType useInterpreter)
        {
            Expression<Func<IList<object>>> e =
                Expression.Lambda<Func<IList<object>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(object[])), typeof(IList<object>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IList<object>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IList<object>, f());
        }

        private static void VerifyStructAsIEquatableOfStruct(S value, CompilationType useInterpreter)
        {
            Expression<Func<IEquatable<S>>> e =
                Expression.Lambda<Func<IEquatable<S>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(S)), typeof(IEquatable<S>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEquatable<S>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEquatable<S>, f());
        }

        private static void VerifyStructAsObject(S value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(S)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyStructAsValueType(S value, CompilationType useInterpreter)
        {
            Expression<Func<ValueType>> e =
                Expression.Lambda<Func<ValueType>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(S)), typeof(ValueType)),
                    Enumerable.Empty<ParameterExpression>());
            Func<ValueType> f = e.Compile(useInterpreter);

            Assert.Equal(value as ValueType, f());
        }

        private static void VerifyStructArrayAsIEnumerableOfStruct(S[] value, CompilationType useInterpreter)
        {
            Expression<Func<IEnumerable<S>>> e =
                Expression.Lambda<Func<IEnumerable<S>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(S[])), typeof(IEnumerable<S>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IEnumerable<S>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IEnumerable<S>, f());
        }

        private static void VerifyStructArrayAsIListOfStruct(S[] value, CompilationType useInterpreter)
        {
            Expression<Func<IList<S>>> e =
                Expression.Lambda<Func<IList<S>>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(S[])), typeof(IList<S>)),
                    Enumerable.Empty<ParameterExpression>());
            Func<IList<S>> f = e.Compile(useInterpreter);

            Assert.Equal(value as IList<S>, f());
        }

        private static void VerifyValueTypeAsObject(ValueType value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(ValueType)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyGenericAsObject<T>(T value, CompilationType useInterpreter)
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(T)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
        }

        private static void VerifyGenericWithClassRestrictionAsObject<Tc>(Tc value, CompilationType useInterpreter) where Tc : class
        {
            Expression<Func<object>> e =
                Expression.Lambda<Func<object>>(
                    Expression.TypeAs(Expression.Constant(value, typeof(Tc)), typeof(object)),
                    Enumerable.Empty<ParameterExpression>());
            Func<object> f = e.Compile(useInterpreter);

            Assert.Equal(value as object, f());
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

        public static IEnumerable<object[]> ObjectsAndTypes()
        {
            yield return new object[] { 3, typeof(int), typeof(int?) };
            yield return new object[] { 3, typeof(int), typeof(long?) };
            yield return new object[] { "3", typeof(IEnumerable<char>), typeof(string) };
            yield return new object[] { Expression.Constant(3), typeof(Expression), typeof(ConstantExpression) };
            yield return new object[] { Expression.Constant(3), typeof(Expression), typeof(BlockExpression) };
        }

        [Theory, PerCompilationType(nameof(ObjectsAndTypes))]
        public static void MakeUnaryTypeAs(object value, Type sourceType, Type resultType, CompilationType useInterpreter)
        {
            var instance = Expression.Constant(value, sourceType);
            var lambda = Expression.Lambda<Func<object>>(
                Expression.Convert(
                    Expression.MakeUnary(ExpressionType.TypeAs, instance, resultType),
                    typeof(object))
                );
            var func = lambda.Compile(useInterpreter);
            if (resultType.IsInstanceOfType(value))
            {
                Assert.Equal(value, func());
            }
            else
            {
                Assert.Null(func());
            }
        }
    }
}
