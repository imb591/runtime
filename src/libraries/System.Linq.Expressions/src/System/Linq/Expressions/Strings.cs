// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
    /// <summary>
    ///    Strongly-typed and parameterized string resources.
    /// </summary>
    internal static class Strings
    {
        /// <summary>
        /// A string like "Cannot auto initialize elements of value type through property '{0}', use assignment instead"
        /// </summary>
        internal static string CannotAutoInitializeValueTypeElementThroughProperty(object? p0) => $"Cannot auto initialize elements of value type through property '{p0}', use assignment instead";

        /// <summary>
        /// A string like "Cannot auto initialize members of value type through property '{0}', use assignment instead"
        /// </summary>
        internal static string CannotAutoInitializeValueTypeMemberThroughProperty(object? p0) => $"Cannot auto initialize members of value type through property '{p0}', use assignment instead";

        /// <summary>
        /// A string like "Expression of type '{0}' cannot be invoked"
        /// </summary>
        internal static string ExpressionTypeNotInvocable(object? p0) => $"Expression of type '{p0}' cannot be invoked";

        /// <summary>
        /// A string like "Unhandled binding "
        /// </summary>
        internal static string UnhandledBinding => "Unhandled binding";

        /// <summary>
        /// A string like "Cannot redefine label '{0}' in an inner block."
        /// </summary>
        internal static string LabelTargetAlreadyDefined(object? p0) => $"Cannot redefine label '{p0}' in an inner block.";

        /// <summary>
        /// A string like "Cannot jump to undefined label '{0}'."
        /// </summary>
        internal static string LabelTargetUndefined(object? p0) => $"Cannot jump to undefined label '{p0}'.";

        /// <summary>
        /// A string like "Control cannot leave a finally block."
        /// </summary>
        internal static string ControlCannotLeaveFinally => "Control cannot leave a finally block.";

        /// <summary>
        /// A string like "Control cannot leave a filter test."
        /// </summary>
        internal static string ControlCannotLeaveFilterTest => "Control cannot leave a filter test.";

        /// <summary>
        /// A string like "Cannot jump to ambiguous label '{0}'."
        /// </summary>
        internal static string AmbiguousJump(object? p0) => $"Cannot jump to ambiguous label '{p0}'.";

        /// <summary>
        /// A string like "Control cannot enter a try block."
        /// </summary>
        internal static string ControlCannotEnterTry => "Control cannot enter a try block.";

        /// <summary>
        /// A string like "Control cannot enter an expression--only statements can be jumped into."
        /// </summary>
        internal static string ControlCannotEnterExpression => "Control cannot enter an expression--only statements can be jumped into.";

        /// <summary>
        /// A string like "Cannot jump to non-local label '{0}' with a value. Only jumps to labels defined in outer blocks can pass values."
        /// </summary>
        internal static string NonLocalJumpWithValue(object? p0) => $"Cannot jump to non-local label '{p0}' with a value. Only jumps to labels defined in outer blocks can pass values.";

#if FEATURE_COMPILE_TO_METHODBUILDER
        /// <summary>
        /// A string like "CompileToMethod cannot compile constant '{0}' because it is a non-trivial value, such as a live object. Instead, create an expression tree that can construct this value."
        /// </summary>
        internal static string CannotCompileConstant(object? p0) => $"CompileToMethod cannot compile constant '{p0}' because it is a non-trivial value, such as a live object. Instead, create an expression tree that can construct this value.";

        /// <summary>
        /// A string like "Dynamic expressions are not supported by CompileToMethod. Instead, create an expression tree that uses System.Runtime.CompilerServices.CallSite."
        /// </summary>
        internal static string CannotCompileDynamic => "Dynamic expressions are not supported by CompileToMethod. Instead, create an expression tree that uses System.Runtime.CompilerServices.CallSite.";

        /// <summary>
        /// A string like "MethodBuilder does not have a valid TypeBuilder"
        /// </summary>
        internal static string MethodBuilderDoesNotHaveTypeBuilder => "MethodBuilder does not have a valid TypeBuilder";
#endif

        /// <summary>
        /// A string like "Invalid lvalue for assignment: {0}."
        /// </summary>
        internal static string InvalidLvalue(object? p0) => $"Invalid lvalue for assignment: {p0}.";

        /// <summary>
        /// A string like "variable '{0}' of type '{1}' referenced from scope '{2}', but it is not defined"
        /// </summary>
        internal static string UndefinedVariable(object? p0, object? p1, object? p2) => $"Variable '{p0}' of type '{p1}' referenced from scope '{p2}', but it is not defined";

        /// <summary>
        /// A string like "Cannot close over byref parameter '{0}' referenced in lambda '{1}'"
        /// </summary>
        internal static string CannotCloseOverByRef(object? p0, object? p1) => $"Cannot close over byref parameter '{p0}' referenced in lambda '{p1}'";

        /// <summary>
        /// A string like "Unexpected VarArgs call to method '{0}'"
        /// </summary>
        internal static string UnexpectedVarArgsCall(object? p0) => $"Unexpected VarArgs call to method '{p0}'";

        /// <summary>
        /// A string like "Rethrow statement is valid only inside a Catch block."
        /// </summary>
        internal static string RethrowRequiresCatch => "Rethrow statement is valid only inside a Catch block.";

        /// <summary>
        /// A string like "Try expression is not allowed inside a filter body."
        /// </summary>
        internal static string TryNotAllowedInFilter => "Try expression is not allowed inside a filter body.";

        /// <summary>
        /// A string like "TryExpression is not supported as an argument to method '{0}' because it has an argument with by-ref type. Construct the tree so the TryExpression is not nested inside of this expression."
        /// </summary>
        internal static string TryNotSupportedForMethodsWithRefArgs(object? p0) => $"TryExpression is not supported as an argument to method '{p0}' because it has an argument with by-ref type. Construct the tree so the TryExpression is not nested inside of this expression.";

        /// <summary>
        /// A string like "TryExpression is not supported as a child expression when accessing a member on type '{0}' because it is a value type. Construct the tree so the TryExpression is not nested inside of this expression."
        /// </summary>
        internal static string TryNotSupportedForValueTypeInstances(object? p0) => $"TryExpression is not supported as a child expression when accessing a member on type '{p0}' because it is a value type. Construct the tree so the TryExpression is not nested inside of this expression.";

#if FEATURE_COMPILE_TO_METHODBUILDER && FEATURE_PDB_GENERATOR
        /// <summary>
        /// A string like "DebugInfoGenerator created by CreatePdbGenerator can only be used with LambdaExpression.CompileToMethod."
        /// </summary>
        internal static string PdbGeneratorNeedsExpressionCompiler => "DebugInfoGenerator created by CreatePdbGenerator can only be used with LambdaExpression.CompileToMethod.";
#endif

        /// <summary>
        /// A string like "The constructor should not be declared on an abstract class"
        /// </summary>
        internal static string NonAbstractConstructorRequired =>  "The constructor should not be declared on an abstract class";

        /// <summary>
        /// A string like "Invalid argument value"
        /// </summary>
        internal static string InvalidArgumentValue_ParamName => "Invalid argument value";
    }
}
