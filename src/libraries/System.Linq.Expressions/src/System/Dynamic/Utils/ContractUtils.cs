// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Threading;

namespace System.Dynamic.Utils
{
    internal static class ContractUtils
    {
        /// <summary>
        /// Returns an exception object to be thrown when code is supposed to be unreachable.
        /// </summary>
        [ExcludeFromCodeCoverage(Justification = "Unreachable")]
        public static Exception Unreachable
        {
            get
            {
                Debug.Fail("Unreachable");
                return new UnreachableException();
            }
        }

        /// <summary>
        /// Requires the <paramref name="precondition"/> to be <c>true</c>.
        /// </summary>
        /// <param name="precondition">
        /// The precondition to check for being <c>true</c>.
        /// </param>
        /// <param name="paramName">
        /// The parameter name to use in the <see cref="ArgumentException.ParamName"/> property when an exception is thrown.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Thrown if <paramref name="precondition"/> is <c>false</c>.
        /// </exception>
        public static void Requires([DoesNotReturnIf(false)] bool precondition, string paramName)
        {
            Debug.Assert(!string.IsNullOrEmpty(paramName));

            if (!precondition)
            {
                throw Error.InvalidArgumentValue(paramName);
            }
        }

        /// <summary>
        /// Requires the range [offset, offset + count] to be a subset of [0, array.Count].
        /// </summary>
        /// <exception cref="ArgumentNullException">Array is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Offset or count are out of range.</exception>
        public static void RequiresArrayRange<T>(IList<T> array, int offset, int count, string offsetName, string countName)
        {
            Debug.Assert(!string.IsNullOrEmpty(offsetName));
            Debug.Assert(!string.IsNullOrEmpty(countName));
            Debug.Assert(array != null);

            ArgumentOutOfRangeException.ThrowIfNegative(count, countName);
            ArgumentOutOfRangeException.ThrowIfNegative(offset, offsetName);
            ArgumentOutOfRangeException.ThrowIfLessThan(array.Count - offset, count, offsetName);
        }
    }
}
