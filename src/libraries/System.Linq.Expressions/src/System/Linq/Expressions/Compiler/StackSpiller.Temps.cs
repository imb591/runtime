// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Linq.Expressions.Compiler
{
    internal sealed partial class StackSpiller
    {
        /// <summary>
        /// The source of temporary variables introduced during stack spilling.
        /// </summary>
        private readonly TempMaker _tm = new TempMaker();

        /// <summary>
        /// Creates a temporary variable of the specified <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type for the temporary variable to create.</param>
        /// <returns>
        /// A temporary variable of the specified <paramref name="type"/>.
        /// </returns>
        private ParameterExpression MakeTemp(Type type) => _tm.Temp(type);

        /// <summary>
        /// Creates and returns a temporary variable to store the result of evaluating
        /// the specified <paramref name="expression"/>.
        /// </summary>
        /// <param name="expression">The expression to store in a temporary variable.</param>
        /// <param name="save">An expression that assigns the <paramref name="expression"/> to the created temporary variable.</param>
        /// <param name="byRef">Indicates whether the <paramref name="expression"/> represents a ByRef value.</param>
        /// <returns>The temporary variable holding the result of evaluating <paramref name="expression"/>.</returns>
        private ParameterExpression ToTemp(Expression expression, out Expression save, bool byRef)
        {
            Type tempType = byRef ? expression.Type.MakeByRefType() : expression.Type;
            ParameterExpression temp = MakeTemp(tempType);
            save = AssignBinaryExpression.Make(temp, expression, byRef);
            return temp;
        }

        /// <summary>
        /// Utility to create and recycle temporary variables.
        /// </summary>
        private sealed class TempMaker
        {
            /// <summary>
            /// Index of the next temporary variable to create.
            /// This value is used for naming temporary variables using an increasing index.
            /// </summary>
            private int _temp;

            /// <summary>
            /// Stack of temporary variables that are currently in use.
            /// </summary>
            private Stack<ParameterExpression>? _usedTemps;

            /// <summary>
            /// List of all temporary variables created by the stack spiller instance.
            /// </summary>
            internal List<ParameterExpression> Temps { get; } = new List<ParameterExpression>();

            /// <summary>
            /// Creates a temporary variable of the specified <paramref name="type"/>.
            /// </summary>
            /// <param name="type">The type for the temporary variable to create.</param>
            /// <returns>
            /// A temporary variable of the specified <paramref name="type"/>.
            /// </returns>
            internal ParameterExpression Temp(Type type)
            {
                ParameterExpression temp = ParameterExpression.Make(type, "$temp$" + _temp++, isByRef: false);
                Temps.Add(temp);

                return UseTemp(temp);
            }

            /// <summary>
            /// Registers the temporary variable in the stack of used temporary variables.
            /// </summary>
            /// <param name="temp">The temporary variable to mark as used.</param>
            /// <returns>The original temporary variable.</returns>
            private ParameterExpression UseTemp(ParameterExpression temp)
            {
                Debug.Assert(_usedTemps == null || !_usedTemps.Contains(temp));

                _usedTemps ??= new Stack<ParameterExpression>();

                _usedTemps.Push(temp);

                return temp;
            }
        }
    }
}
