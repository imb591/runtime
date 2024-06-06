// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Reflection;

namespace System.Linq.Expressions
{
    /// <summary>
    ///    Strongly-typed and parameterized exception factory.
    /// </summary>
    internal static class Error
    {
        /// <summary>
        /// InvalidOperationException with message like "Cannot auto initialize elements of value type through property '{0}', use assignment instead"
        /// </summary>
        internal static InvalidOperationException CannotAutoInitializeValueTypeElementThroughProperty(object? p0)
        {
            return new InvalidOperationException(Strings.CannotAutoInitializeValueTypeElementThroughProperty(p0));
        }

        /// <summary>
        /// InvalidOperationException with message like "Cannot auto initialize members of value type through property '{0}', use assignment instead"
        /// </summary>
        internal static InvalidOperationException CannotAutoInitializeValueTypeMemberThroughProperty(object? p0)
        {
            return new InvalidOperationException(Strings.CannotAutoInitializeValueTypeMemberThroughProperty(p0));
        }

        /// <summary>
        /// ArgumentException with message like "Expression of type '{0}' cannot be invoked"
        /// </summary>
        internal static ArgumentException ExpressionTypeNotInvocable(object? p0, string? paramName)
        {
            return new ArgumentException(Strings.ExpressionTypeNotInvocable(p0), paramName);
        }

        /// <summary>
        /// ArgumentException with message like "Unhandled binding "
        /// </summary>
        internal static ArgumentException UnhandledBinding()
        {
            return new ArgumentException(Strings.UnhandledBinding);
        }

        /// <summary>
        /// InvalidOperationException with message like "Cannot redefine label '{0}' in an inner block."
        /// </summary>
        internal static InvalidOperationException LabelTargetAlreadyDefined(object? p0)
        {
            return new InvalidOperationException(Strings.LabelTargetAlreadyDefined(p0));
        }
        /// <summary>
        /// InvalidOperationException with message like "Cannot jump to undefined label '{0}'."
        /// </summary>
        internal static InvalidOperationException LabelTargetUndefined(object? p0)
        {
            return new InvalidOperationException(Strings.LabelTargetUndefined(p0));
        }
        /// <summary>
        /// InvalidOperationException with message like "Control cannot leave a finally block."
        /// </summary>
        internal static InvalidOperationException ControlCannotLeaveFinally()
        {
            return new InvalidOperationException(Strings.ControlCannotLeaveFinally);
        }
        /// <summary>
        /// InvalidOperationException with message like "Control cannot leave a filter test."
        /// </summary>
        internal static InvalidOperationException ControlCannotLeaveFilterTest()
        {
            return new InvalidOperationException(Strings.ControlCannotLeaveFilterTest);
        }
        /// <summary>
        /// InvalidOperationException with message like "Cannot jump to ambiguous label '{0}'."
        /// </summary>
        internal static InvalidOperationException AmbiguousJump(object? p0)
        {
            return new InvalidOperationException(Strings.AmbiguousJump(p0));
        }
        /// <summary>
        /// InvalidOperationException with message like "Control cannot enter a try block."
        /// </summary>
        internal static InvalidOperationException ControlCannotEnterTry()
        {
            return new InvalidOperationException(Strings.ControlCannotEnterTry);
        }
        /// <summary>
        /// InvalidOperationException with message like "Control cannot enter an expression--only statements can be jumped into."
        /// </summary>
        internal static InvalidOperationException ControlCannotEnterExpression()
        {
            return new InvalidOperationException(Strings.ControlCannotEnterExpression);
        }
        /// <summary>
        /// InvalidOperationException with message like "Cannot jump to non-local label '{0}' with a value. Only jumps to labels defined in outer blocks can pass values."
        /// </summary>
        internal static InvalidOperationException NonLocalJumpWithValue(object? p0)
        {
            return new InvalidOperationException(Strings.NonLocalJumpWithValue(p0));
        }

#if FEATURE_COMPILE_TO_METHODBUILDER
        /// <summary>
        /// InvalidOperationException with message like "CompileToMethod cannot compile constant '{0}' because it is a non-trivial value, such as a live object. Instead, create an expression tree that can construct this value."
        /// </summary>
        internal static InvalidOperationException CannotCompileConstant(object? p0)
        {
            return new InvalidOperationException(Strings.CannotCompileConstant(p0));
        }
        /// <summary>
        /// NotSupportedException with message like "Dynamic expressions are not supported by CompileToMethod. Instead, create an expression tree that uses System.Runtime.CompilerServices.CallSite."
        /// </summary>
        internal static NotSupportedException CannotCompileDynamic()
        {
            return new NotSupportedException(Strings.CannotCompileDynamic);
        }
        /// <summary>
        /// ArgumentException with message like "MethodBuilder does not have a valid TypeBuilder"
        /// </summary>
        internal static ArgumentException MethodBuilderDoesNotHaveTypeBuilder()
        {
            return new ArgumentException(Strings.MethodBuilderDoesNotHaveTypeBuilder);
        }
#endif
        /// <summary>
        /// InvalidOperationException with message like "Invalid lvalue for assignment: {0}."
        /// </summary>
        internal static InvalidOperationException InvalidLvalue(ExpressionType p0)
        {
            return new InvalidOperationException(Strings.InvalidLvalue(p0));
        }

        /// <summary>
        /// InvalidOperationException with message like "variable '{0}' of type '{1}' referenced from scope '{2}', but it is not defined"
        /// </summary>
        internal static InvalidOperationException UndefinedVariable(object? p0, object? p1, object? p2)
        {
            return new InvalidOperationException(Strings.UndefinedVariable(p0, p1, p2));
        }
        /// <summary>
        /// InvalidOperationException with message like "Cannot close over byref parameter '{0}' referenced in lambda '{1}'"
        /// </summary>
        internal static InvalidOperationException CannotCloseOverByRef(object? p0, object? p1)
        {
            return new InvalidOperationException(Strings.CannotCloseOverByRef(p0, p1));
        }
        /// <summary>
        /// InvalidOperationException with message like "Unexpected VarArgs call to method '{0}'"
        /// </summary>
        internal static InvalidOperationException UnexpectedVarArgsCall(object? p0)
        {
            return new InvalidOperationException(Strings.UnexpectedVarArgsCall(p0));
        }
        /// <summary>
        /// InvalidOperationException with message like "Rethrow statement is valid only inside a Catch block."
        /// </summary>
        internal static InvalidOperationException RethrowRequiresCatch()
        {
            return new InvalidOperationException(Strings.RethrowRequiresCatch);
        }
        /// <summary>
        /// InvalidOperationException with message like "Try expression is not allowed inside a filter body."
        /// </summary>
        internal static InvalidOperationException TryNotAllowedInFilter()
        {
            return new InvalidOperationException(Strings.TryNotAllowedInFilter);
        }
        /// <summary>
        /// NotSupportedException with message like "TryExpression is not supported as an argument to method '{0}' because it has an argument with by-ref type. Construct the tree so the TryExpression is not nested inside of this expression."
        /// </summary>
        internal static NotSupportedException TryNotSupportedForMethodsWithRefArgs(object? p0)
        {
            return new NotSupportedException(Strings.TryNotSupportedForMethodsWithRefArgs(p0));
        }
        /// <summary>
        /// NotSupportedException with message like "TryExpression is not supported as a child expression when accessing a member on type '{0}' because it is a value type. Construct the tree so the TryExpression is not nested inside of this expression."
        /// </summary>
        internal static NotSupportedException TryNotSupportedForValueTypeInstances(object? p0)
        {
            return new NotSupportedException(Strings.TryNotSupportedForValueTypeInstances(p0));
        }

        /// <summary>
        /// The exception that is thrown when an invoked method is not supported, or when there is an attempt to read, seek, or write to a stream that does not support the invoked functionality.
        /// </summary>
        internal static NotSupportedException NotSupported()
        {
            return new NotSupportedException();
        }

        /// <summary>
        /// InvalidOperationException with message like "Can't compile a NewExpression with a constructor declared on an abstract class"
        /// </summary>
        internal static InvalidOperationException NonAbstractConstructorRequired()
        {
            return new InvalidOperationException(Strings.NonAbstractConstructorRequired);
        }

        internal static Exception InvalidProgram(FormattableString s)
        {
            return new InvalidProgramException(s.ToString());
        }

        internal static ArgumentException InvalidArgumentValue(string? paramName)
        {
            return new ArgumentException(Strings.InvalidArgumentValue_ParamName, paramName);
        }
    }
}
