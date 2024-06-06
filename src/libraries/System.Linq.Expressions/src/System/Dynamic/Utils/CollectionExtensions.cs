// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace System.Dynamic.Utils
{
    internal static class CollectionExtensions
    {
        public static TrueReadOnlyCollection<T> AddFirst<T>(this ReadOnlyCollection<T> list, T item)
        {
            T[] res = new T[list.Count + 1];
            res[0] = item;
            list.CopyTo(res, 1);
            return new TrueReadOnlyCollection<T>(res);
        }

        /// <summary>
        /// Wraps the provided enumerable into a ReadOnlyCollection{T}
        ///
        /// Copies all of the data into a new array, so the data can't be
        /// changed after creation. The exception is if the enumerable is
        /// already a ReadOnlyCollection{T}, in which case we just return it.
        /// </summary>
        public static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> enumerable)
        {
            T[] array = enumerable.ToArray();
            return array.Length == 0 ?
                ReadOnlyCollection<T>.Empty :
                new TrueReadOnlyCollection<T>(array);
        }
    }
}
