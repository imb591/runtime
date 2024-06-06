// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;

namespace System.Collections.Generic
{
    /// <summary>
    /// Helper type for avoiding allocations while building arrays.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    internal struct ArrayBuilder<T>
    {
        private T[]? _array; // Starts out null, initialized on first Add.
        private int _count; // Number of items into _array we're using.

        /// <summary>
        /// Initializes the <see cref="ArrayBuilder{T}"/> with a specified capacity.
        /// </summary>
        /// <param name="capacity">The capacity of the array to allocate.</param>
        public ArrayBuilder(int capacity) : this()
        {
            Debug.Assert(capacity >= 0);
            {
                _array = new T[capacity];
            }
        }

        /// <summary>
        /// Gets the number of items this instance can store without re-allocating,
        /// or 0 if the backing array is <c>null</c>.
        /// </summary>
        public int Capacity => _array?.Length ?? 0;

        /// <summary>
        /// Creates an array from the contents of this builder.
        /// </summary>
        /// <remarks>
        /// Do not call this method twice on the same builder.
        /// </remarks>
        public T[] ToArray()
        {
            Debug.Assert(_array != null); // Nonzero _count should imply this

            T[] result = _array;
            Debug.Assert(_count == result.Length);

#if DEBUG
            // Try to prevent callers from using the ArrayBuilder after ToArray, if _count != 0.
            _count = -1;
            _array = null;
#endif

            return result;
        }

        /// <summary>
        /// Adds an item to the backing array, without checking if there is room.
        /// </summary>
        /// <param name="item">The item to add.</param>
        /// <remarks>
        /// Use this method if you know there is enough space in the <see cref="ArrayBuilder{T}"/>
        /// for another item, and you are writing performance-sensitive code.
        /// </remarks>
        public void UncheckedAdd(T item)
        {
            Debug.Assert(_count < Capacity);

            _array![_count++] = item;
        }
    }
}
