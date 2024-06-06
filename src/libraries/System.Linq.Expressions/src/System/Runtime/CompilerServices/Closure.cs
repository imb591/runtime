// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;
using System.Diagnostics;

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.
    /// Represents the runtime state of a dynamically generated method.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never), DebuggerStepThrough]
    public sealed class CTM_Closure
    {
        /// <summary>
        /// Represents the hoisted local variables from the parent context.
        /// </summary>
        public readonly object[]? Locals;

        /// <summary>
        /// Creates an object to hold state of a dynamically generated method.
        /// </summary>
        /// <param name="locals">The hoisted local variables from the parent context.</param>
        public CTM_Closure(object[]? locals)
        {
            Locals = locals;
        }
    }
}
