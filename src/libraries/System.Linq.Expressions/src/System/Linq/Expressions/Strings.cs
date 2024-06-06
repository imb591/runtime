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
        /// A string like "Operation is not supported when dynamic code generation is not available."
        /// </summary>
        internal static string LiftingInExpressionRequiresDynamicCode(Type type) => $"Operation is not supported when dynamic code generation is not available. {type.FullName}";

        /// <summary>
        /// A string like "reducible nodes must override Expression.Reduce()"
        /// </summary>
        internal static string ReducibleMustOverrideReduce => "Reducible nodes must override Expression.Reduce()";

        /// <summary>
        /// A string like "node cannot reduce to itself or null"
        /// </summary>
        internal static string MustReduceToDifferent => "Node cannot reduce to itself or null";

        /// <summary>
        /// A string like "cannot assign from the reduced node type to the original node type"
        /// </summary>
        internal static string ReducedNotCompatible => "Cannot assign from the reduced node type to the original node type";

        /// <summary>
        /// A string like "Setter must have parameters."
        /// </summary>
        internal static string SetterHasNoParams => "Setter must have parameters.";

        /// <summary>
        /// A string like "Property cannot have a managed pointer type."
        /// </summary>
        internal static string PropertyCannotHaveRefType => "Property cannot have a managed pointer type.";

        /// <summary>
        /// A string like "Indexing parameters of getter and setter must match."
        /// </summary>
        internal static string IndexesOfSetGetMustMatch => "Indexing parameters of getter and setter must match.";

        /// <summary>
        /// A string like "Accessor method should not have VarArgs."
        /// </summary>
        internal static string AccessorsCannotHaveVarArgs => "Accessor method should not have VarArgs.";

        /// <summary>
        /// A string like "Accessor indexes cannot be passed ByRef."
        /// </summary>
        internal static string AccessorsCannotHaveByRefArgs => "Accessor indexes cannot be passed ByRef.";

        /// <summary>
        /// A string like "Bounds count cannot be less than 1"
        /// </summary>
        internal static string BoundsCannotBeLessThanOne => "Bounds count cannot be less than 1";

        /// <summary>
        /// A string like "Type must not be ByRef"
        /// </summary>
        internal static string TypeMustNotBeByRef => "Type must not be ByRef";

        /// <summary>
        /// A string like "Type must not be a pointer type"
        /// </summary>
        internal static string TypeMustNotBePointer => "Type must not be a pointer type";

        /// <summary>
        /// A string like "Setter should have void type."
        /// </summary>
        internal static string SetterMustBeVoid => "Setter should have void type.";

        /// <summary>
        /// A string like "Property type must match the value type of getter"
        /// </summary>
        internal static string PropertyTypeMustMatchGetter => "Property type must match the value type of getter";

        /// <summary>
        /// A string like "Property type must match the value type of setter"
        /// </summary>
        internal static string PropertyTypeMustMatchSetter => "Property type must match the value type of setter";

        /// <summary>
        /// A string like "Both accessors must be static."
        /// </summary>
        internal static string BothAccessorsMustBeStatic => "Both accessors must be static.";

        /// <summary>
        /// A string like "Static field requires null instance, non-static field requires non-null instance."
        /// </summary>
        internal static string OnlyStaticFieldsHaveNullInstance => "Static field requires null instance, non-static field requires non-null instance.";

        /// <summary>
        /// A string like "Static property requires null instance, non-static property requires non-null instance."
        /// </summary>
        internal static string OnlyStaticPropertiesHaveNullInstance => "Static property requires null instance, non-static property requires non-null instance.";

        /// <summary>
        /// A string like "Static method requires null instance, non-static method requires non-null instance."
        /// </summary>
        internal static string OnlyStaticMethodsHaveNullInstance => "Static method requires null instance, non-static method requires non-null instance.";

        /// <summary>
        /// A string like "Property cannot have a void type."
        /// </summary>
        internal static string PropertyTypeCannotBeVoid => "Property cannot have a void type.";

        /// <summary>
        /// A string like "Can only unbox from an object or interface type to a value type."
        /// </summary>
        internal static string InvalidUnboxType => "Can only unbox from an object or interface type to a value type.";

        /// <summary>
        /// A string like "Expression must be writeable"
        /// </summary>
        internal static string ExpressionMustBeWriteable => "Expression must be writeable";

        /// <summary>
        /// A string like "Argument must not have a value type."
        /// </summary>
        internal static string ArgumentMustNotHaveValueType => "Argument must not have a value type.";

        /// <summary>
        /// A string like "must be reducible node"
        /// </summary>
        internal static string MustBeReducible => "Must be reducible node";

        /// <summary>
        /// A string like "All test values must have the same type."
        /// </summary>
        internal static string AllTestValuesMustHaveSameType => "All test values must have the same type.";

        /// <summary>
        /// A string like "All case bodies and the default body must have the same type."
        /// </summary>
        internal static string AllCaseBodiesMustHaveSameType => "All case bodies and the default body must have the same type.";

        /// <summary>
        /// A string like "Default body must be supplied if case bodies are not System.Void."
        /// </summary>
        internal static string DefaultBodyMustBeSupplied => "Default body must be supplied if case bodies are not System.Void.";

        /// <summary>
        /// A string like "Label type must be System.Void if an expression is not supplied"
        /// </summary>
        internal static string LabelMustBeVoidOrHaveExpression => "Label type must be System.Void if an expression is not supplied";

        /// <summary>
        /// A string like "Type must be System.Void for this label argument"
        /// </summary>
        internal static string LabelTypeMustBeVoid => "Type must be System.Void for this label argument";

        /// <summary>
        /// A string like "Quoted expression must be a lambda"
        /// </summary>
        internal static string QuotedExpressionMustBeLambda => "Quoted expression must be a lambda";

        /// <summary>
        /// A string like "Collection was modified; enumeration operation may not execute."
        /// </summary>
        internal static string CollectionModifiedWhileEnumerating => "Collection was modified; enumeration operation may not execute.";

        /// <summary>
        /// A string like "Variable '{0}' uses unsupported type '{1}'. Reference types are not supported for variables."
        /// </summary>
        internal static string VariableMustNotBeByRef(object? p0, object? p1) => $"Variable '{p0}' uses unsupported type '{p1}'. Reference types are not supported for variables.";

        /// <summary>
        /// A string like "Collection is read-only."
        /// </summary>
        internal static string CollectionReadOnly => "Collection is read-only.";

        /// <summary>
        /// A string like "More than one key matching '{0}' was found in the ExpandoObject."
        /// </summary>
        internal static string AmbiguousMatchInExpandoObject(object? p0) => $"More than one key matching '{p0}' was found in the ExpandoObject.";

        /// <summary>
        /// A string like "An element with the same key '{0}' already exists in the ExpandoObject."
        /// </summary>
        internal static string SameKeyExistsInExpando(object? p0) => $"An element with the same key '{p0}' already exists in the ExpandoObject.";

        /// <summary>
        /// A string like "The specified key '{0}' does not exist in the ExpandoObject."
        /// </summary>
        internal static string KeyDoesNotExistInExpando(object? p0) => $"The specified key '{p0}' does not exist in the ExpandoObject.";

        /// <summary>
        /// A string like "Argument count must be greater than number of named arguments."
        /// </summary>
        internal static string ArgCntMustBeGreaterThanNameCnt => "Argument count must be greater than number of named arguments.";

        /// <summary>
        /// A string like "An IDynamicMetaObjectProvider {0} created an invalid DynamicMetaObject instance."
        /// </summary>
        internal static string InvalidMetaObjectCreated(object? p0) => $"An IDynamicMetaObjectProvider {p0} created an invalid DynamicMetaObject instance.";

        /// <summary>
        /// A string like "The result type '{0}' of the binder '{1}' is not compatible with the result type '{2}' expected by the call site."
        /// </summary>
        internal static string BinderNotCompatibleWithCallSite(object? p0, object? p1, object? p2) => $"The result type '{p0}' of the binder '{p1}' is not compatible with the result type '{p2}' expected by the call site.";

        /// <summary>
        /// A string like "The result of the dynamic binding produced by the object with type '{0}' for the binder '{1}' needs at least one restriction."
        /// </summary>
        internal static string DynamicBindingNeedsRestrictions(object? p0, object? p1) => $"The result of the dynamic binding produced by the object with type '{p0}' for the binder '{p1}' needs at least one restriction.";

        /// <summary>
        /// A string like "The result type '{0}' of the dynamic binding produced by the object with type '{1}' for the binder '{2}' is not compatible with the result type '{3}' expected by the call site."
        /// </summary>
        internal static string DynamicObjectResultNotAssignable(object? p0, object? p1, object? p2, object? p3) => $"The result type '{p0}' of the dynamic binding produced by the object with type '{p1}' for the binder '{p2}' is not compatible with the result type '{p3}' expected by the call site.";

        /// <summary>
        /// A string like "The result type '{0}' of the dynamic binding produced by binder '{1}' is not compatible with the result type '{2}' expected by the call site."
        /// </summary>
        internal static string DynamicBinderResultNotAssignable(object? p0, object? p1, object? p2) => $"The result type '{p0}' of the dynamic binding produced by binder '{p1}' is not compatible with the result type '{p2}' expected by the call site.";

        /// <summary>
        /// A string like "Bind cannot return null."
        /// </summary>
        internal static string BindingCannotBeNull => "Bind cannot return null.";

        /// <summary>
        /// A string like "Found duplicate parameter '{0}'. Each ParameterExpression in the list must be a unique object."
        /// </summary>
        internal static string DuplicateVariable(object? p0) => $"Found duplicate parameter '{p0}'. Each ParameterExpression in the list must be a unique object.";

        /// <summary>
        /// A string like "Argument type cannot be void"
        /// </summary>
        internal static string ArgumentTypeCannotBeVoid => "Argument type cannot be void";

        /// <summary>
        /// A string like "Type parameter is {0}. Expected a delegate."
        /// </summary>
        internal static string TypeParameterIsNotDelegate(object? p0) => $"Type parameter is {p0}. Expected a delegate.";

        /// <summary>
        /// A string like "No or Invalid rule produced"
        /// </summary>
        internal static string NoOrInvalidRuleProduced => "No or Invalid rule produced";

        /// <summary>
        /// A string like "Type must be derived from System.Delegate"
        /// </summary>
        internal static string TypeMustBeDerivedFromSystemDelegate => "Type must be derived from System.Delegate";

        /// <summary>
        /// A string like "First argument of delegate must be CallSite"
        /// </summary>
        internal static string FirstArgumentMustBeCallSite => "First argument of delegate must be CallSite";

        /// <summary>
        /// A string like "Start and End must be well ordered"
        /// </summary>
        internal static string StartEndMustBeOrdered => "Start and End must be well ordered";

        /// <summary>
        /// A string like "fault cannot be used with catch or finally clauses"
        /// </summary>
        internal static string FaultCannotHaveCatchOrFinally => "fault cannot be used with catch or finally clauses";

        /// <summary>
        /// A string like "try must have at least one catch, finally, or fault clause"
        /// </summary>
        internal static string TryMustHaveCatchFinallyOrFault => "try must have at least one catch, finally, or fault clause";

        /// <summary>
        /// A string like "Body of catch must have the same type as body of try."
        /// </summary>
        internal static string BodyOfCatchMustHaveSameTypeAsBodyOfTry => "Body of catch must have the same type as body of try.";

        /// <summary>
        /// A string like "Extension node must override the property {0}."
        /// </summary>
        internal static string ExtensionNodeMustOverrideProperty(object? p0) => $"Extension node must override the property {p0}.";

        /// <summary>
        /// A string like "User-defined operator method '{0}' must be static."
        /// </summary>
        internal static string UserDefinedOperatorMustBeStatic(object? p0) => $"User-defined operator method '{p0}' must be static.";

        /// <summary>
        /// A string like "User-defined operator method '{0}' must not be void."
        /// </summary>
        internal static string UserDefinedOperatorMustNotBeVoid(object? p0) => $"User-defined operator method '{p0}' must not be void.";

        /// <summary>
        /// A string like "No coercion operator is defined between types '{0}' and '{1}'."
        /// </summary>
        internal static string CoercionOperatorNotDefined(object? p0, object? p1) => $"No coercion operator is defined between types '{p0}' and '{p1}'.";

        /// <summary>
        /// A string like "The unary operator {0} is not defined for the type '{1}'."
        /// </summary>
        internal static string UnaryOperatorNotDefined(object? p0, object? p1) => $"The unary operator {p0} is not defined for the type '{p1}'.";

        /// <summary>
        /// A string like "The binary operator {0} is not defined for the types '{1}' and '{2}'."
        /// </summary>
        internal static string BinaryOperatorNotDefined(object? p0, object? p1, object? p2) => $"The binary operator {p0} is not defined for the types '{p1}' and '{p2}'.";

        /// <summary>
        /// A string like "Reference equality is not defined for the types '{0}' and '{1}'."
        /// </summary>
        internal static string ReferenceEqualityNotDefined(object? p0, object? p1) => $"Reference equality is not defined for the types '{p0}' and '{p1}'.";

        /// <summary>
        /// A string like "The operands for operator '{0}' do not match the parameters of method '{1}'."
        /// </summary>
        internal static string OperandTypesDoNotMatchParameters(object? p0, object? p1) => $"The operands for operator '{p0}' do not match the parameters of method '{p1}'.";

        /// <summary>
        /// A string like "The return type of overload method for operator '{0}' does not match the parameter type of conversion method '{1}'."
        /// </summary>
        internal static string OverloadOperatorTypeDoesNotMatchConversionType(object? p0, object? p1) => $"The return type of overload method for operator '{p0}' does not match the parameter type of conversion method '{p1}'.";

        /// <summary>
        /// A string like "Conversion is not supported for arithmetic types without operator overloading."
        /// </summary>
        internal static string ConversionIsNotSupportedForArithmeticTypes => "Conversion is not supported for arithmetic types without operator overloading.";

        /// <summary>
        /// A string like "Argument must be array"
        /// </summary>
        internal static string ArgumentMustBeArray => "Argument must be array";

        /// <summary>
        /// A string like "Argument must be boolean"
        /// </summary>
        internal static string ArgumentMustBeBoolean => "Argument must be boolean";

        /// <summary>
        /// A string like "The user-defined equality method '{0}' must return a boolean value."
        /// </summary>
        internal static string EqualityMustReturnBoolean(object? p0) => $"The user-defined equality method '{p0}' must return a boolean value.";

        /// <summary>
        /// A string like "Argument must be either a FieldInfo or PropertyInfo"
        /// </summary>
        internal static string ArgumentMustBeFieldInfoOrPropertyInfo => "Argument must be either a FieldInfo or PropertyInfo";

        /// <summary>
        /// A string like "Argument must be either a FieldInfo, PropertyInfo or MethodInfo"
        /// </summary>
        internal static string ArgumentMustBeFieldInfoOrPropertyInfoOrMethod => "Argument must be either a FieldInfo, PropertyInfo or MethodInfo";

        /// <summary>
        /// A string like "Argument must be an instance member"
        /// </summary>
        internal static string ArgumentMustBeInstanceMember => "Argument must be an instance member";

        /// <summary>
        /// A string like "Argument must be of an integer type"
        /// </summary>
        internal static string ArgumentMustBeInteger => "Argument must be of an integer type";

        /// <summary>
        /// A string like "Argument for array index must be of type Int32"
        /// </summary>
        internal static string ArgumentMustBeArrayIndexType => "Argument for array index must be of type Int32";

        /// <summary>
        /// A string like "Argument must be single-dimensional, zero-based array type"
        /// </summary>
        internal static string ArgumentMustBeSingleDimensionalArrayType => "Argument must be single-dimensional, zero-based array type";

        /// <summary>
        /// A string like "Argument types do not match"
        /// </summary>
        internal static string ArgumentTypesMustMatch => "Argument types do not match";

        /// <summary>
        /// A string like "Cannot auto initialize elements of value type through property '{0}', use assignment instead"
        /// </summary>
        internal static string CannotAutoInitializeValueTypeElementThroughProperty(object? p0) => $"Cannot auto initialize elements of value type through property '{p0}', use assignment instead";

        /// <summary>
        /// A string like "Cannot auto initialize members of value type through property '{0}', use assignment instead"
        /// </summary>
        internal static string CannotAutoInitializeValueTypeMemberThroughProperty(object? p0) => $"Cannot auto initialize members of value type through property '{p0}', use assignment instead";

        /// <summary>
        /// A string like "The type used in TypeAs Expression must be of reference or nullable type, {0} is neither"
        /// </summary>
        internal static string IncorrectTypeForTypeAs(object? p0) => $"The type used in TypeAs Expression must be of reference or nullable type, {p0} is neither";

        /// <summary>
        /// A string like "Coalesce used with type that cannot be null"
        /// </summary>
        internal static string CoalesceUsedOnNonNullType => "Coalesce used with type that cannot be null";

        /// <summary>
        /// A string like "An expression of type '{0}' cannot be used to initialize an array of type '{1}'"
        /// </summary>
        internal static string ExpressionTypeCannotInitializeArrayType(object? p0, object? p1) => $"An expression of type '{p0}' cannot be used to initialize an array of type '{p1}'";

        /// <summary>
        /// A string like " Argument type '{0}' does not match the corresponding member type '{1}'"
        /// </summary>
        internal static string ArgumentTypeDoesNotMatchMember(object? p0, object? p1) => $"Argument type '{p0}' does not match the corresponding member type '{p1}'";

        /// <summary>
        /// A string like " The member '{0}' is not declared on type '{1}' being created"
        /// </summary>
        internal static string ArgumentMemberNotDeclOnType(object? p0, object? p1) => $"The member '{p0}' is not declared on type '{p1}' being created";

        /// <summary>
        /// A string like "Expression of type '{0}' cannot be used for return type '{1}'"
        /// </summary>
        internal static string ExpressionTypeDoesNotMatchReturn(object? p0, object? p1) => $"Expression of type '{p0}' cannot be used for return type '{p1}'";

        /// <summary>
        /// A string like "Expression of type '{0}' cannot be used for assignment to type '{1}'"
        /// </summary>
        internal static string ExpressionTypeDoesNotMatchAssignment(object? p0, object? p1) => $"Expression of type '{p0}' cannot be used for assignment to type '{p1}'";

        /// <summary>
        /// A string like "Expression of type '{0}' cannot be used for label of type '{1}'"
        /// </summary>
        internal static string ExpressionTypeDoesNotMatchLabel(object? p0, object? p1) => $"Expression of type '{p0}' cannot be used for label of type '{p1}'";

        /// <summary>
        /// A string like "Expression of type '{0}' cannot be invoked"
        /// </summary>
        internal static string ExpressionTypeNotInvocable(object? p0) => $"Expression of type '{p0}' cannot be invoked";

        /// <summary>
        /// A string like "Field '{0}' is not defined for type '{1}'"
        /// </summary>
        internal static string FieldNotDefinedForType(object? p0, object? p1) => $"Field '{p0}' is not defined for type '{p1}'";

        /// <summary>
        /// A string like "Instance field '{0}' is not defined for type '{1}'"
        /// </summary>
        internal static string InstanceFieldNotDefinedForType(object? p0, object? p1) => $"Instance field '{p0}' is not defined for type '{p1}'";

        /// <summary>
        /// A string like "Field '{0}.{1}' is not defined for type '{2}'"
        /// </summary>
        internal static string FieldInfoNotDefinedForType(object? p0, object? p1, object? p2) => $"Field '{p0}.{p1}' is not defined for type '{p2}'";

        /// <summary>
        /// A string like "Incorrect number of indexes"
        /// </summary>
        internal static string IncorrectNumberOfIndexes => "Incorrect number of indexes";

        /// <summary>
        /// A string like "Incorrect number of parameters supplied for lambda declaration"
        /// </summary>
        internal static string IncorrectNumberOfLambdaDeclarationParameters => "Incorrect number of parameters supplied for lambda declaration";

        /// <summary>
        /// A string like " Incorrect number of members for constructor"
        /// </summary>
        internal static string IncorrectNumberOfMembersForGivenConstructor => "Incorrect number of members for constructor";

        /// <summary>
        /// A string like "Incorrect number of arguments for the given members "
        /// </summary>
        internal static string IncorrectNumberOfArgumentsForMembers => "Incorrect number of arguments for the given members";

        /// <summary>
        /// A string like "Lambda type parameter must be derived from System.MulticastDelegate"
        /// </summary>
        internal static string LambdaTypeMustBeDerivedFromSystemDelegate => "Lambda type parameter must be derived from System.MulticastDelegate";

        /// <summary>
        /// A string like "Member '{0}' not field or property"
        /// </summary>
        internal static string MemberNotFieldOrProperty(object? p0) => $"Member '{p0}' not field or property";

        /// <summary>
        /// A string like "Method {0} contains generic parameters"
        /// </summary>
        internal static string MethodContainsGenericParameters(object? p0) => $"Method {p0} contains generic parameters";

        /// <summary>
        /// A string like "Method {0} is a generic method definition"
        /// </summary>
        internal static string MethodIsGeneric(object? p0) => $"Method {p0} is a generic method definition";

        /// <summary>
        /// A string like "The method '{0}.{1}' is not a property accessor"
        /// </summary>
        internal static string MethodNotPropertyAccessor(object? p0, object? p1) => $"The method '{p0}.{p1}' is not a property accessor";

        /// <summary>
        /// A string like "The property '{0}' has no 'get' accessor"
        /// </summary>
        internal static string PropertyDoesNotHaveGetter(object? p0) => $"The property '{p0}' has no 'get' accessor";

        /// <summary>
        /// A string like "The property '{0}' has no 'set' accessor"
        /// </summary>
        internal static string PropertyDoesNotHaveSetter(object? p0) => $"The property '{p0}' has no 'set' accessor";

        /// <summary>
        /// A string like "The property '{0}' has no 'get' or 'set' accessors"
        /// </summary>
        internal static string PropertyDoesNotHaveAccessor(object? p0) => $"The property '{p0}' has no 'get' or 'set' accessors";

        /// <summary>
        /// A string like "'{0}' is not a member of type '{1}'"
        /// </summary>
        internal static string NotAMemberOfType(object? p0, object? p1) => $"'{p0}' is not a member of type '{p1}'";

        /// <summary>
        /// A string like "'{0}' is not a member of any type"
        /// </summary>
        internal static string NotAMemberOfAnyType(object? p0) => $"'{p0}' is not a member of any type";

        /// <summary>
        /// A string like "ParameterExpression of type '{0}' cannot be used for delegate parameter of type '{1}'"
        /// </summary>
        internal static string ParameterExpressionNotValidAsDelegate(object? p0, object? p1) => $"ParameterExpression of type '{p0}' cannot be used for delegate parameter of type '{p1}'";

        /// <summary>
        /// A string like "Property '{0}' is not defined for type '{1}'"
        /// </summary>
        internal static string PropertyNotDefinedForType(object? p0, object? p1) => $"Property '{p0}' is not defined for type '{p1}'";

        /// <summary>
        /// A string like "Instance property '{0}' is not defined for type '{1}'"
        /// </summary>
        internal static string InstancePropertyNotDefinedForType(object? p0, object? p1) => $"Instance property '{p0}' is not defined for type '{p1}'";

        /// <summary>
        /// A string like "Instance property '{0}' that takes no argument is not defined for type '{1}'"
        /// </summary>
        internal static string InstancePropertyWithoutParameterNotDefinedForType(object? p0, object? p1) => $"Instance property '{p0}' that takes no argument is not defined for type '{p1}'";

        /// <summary>
        /// A string like "Instance property '{0}{1}' is not defined for type '{2}'"
        /// </summary>
        internal static string InstancePropertyWithSpecifiedParametersNotDefinedForType(object? p0, object? p1, object? p2) => $"Instance property '{p0}{p1}' is not defined for type '{p2}'";

        /// <summary>
        /// A string like "Method '{0}' declared on type '{1}' cannot be called with instance of type '{2}'"
        /// </summary>
        internal static string InstanceAndMethodTypeMismatch(object? p0, object? p1, object? p2) => $"Method '{p0}' declared on type '{p1}' cannot be called with instance of type '{p2}'";

        /// <summary>
        /// A string like "Type '{0}' does not have a default constructor"
        /// </summary>
        internal static string TypeMissingDefaultConstructor(object? p0) => $"Type '{p0}' does not have a default constructor";

        /// <summary>
        /// A string like "Element initializer method must be named 'Add'"
        /// </summary>
        internal static string ElementInitializerMethodNotAdd => "Element initializer method must be named 'Add'";

        /// <summary>
        /// A string like "Parameter '{0}' of element initializer method '{1}' must not be a pass by reference parameter"
        /// </summary>
        internal static string ElementInitializerMethodNoRefOutParam(object? p0, object? p1) => $"Parameter '{p0}' of element initializer method '{p1}' must not be a pass by reference parameter";

        /// <summary>
        /// A string like "Element initializer method must have at least 1 parameter"
        /// </summary>
        internal static string ElementInitializerMethodWithZeroArgs => "Element initializer method must have at least 1 parameter";

        /// <summary>
        /// A string like "Element initializer method must be an instance method"
        /// </summary>
        internal static string ElementInitializerMethodStatic => "Element initializer method must be an instance method";

        /// <summary>
        /// A string like "Type '{0}' is not IEnumerable"
        /// </summary>
        internal static string TypeNotIEnumerable(object? p0) => $"Type '{p0}' is not IEnumerable";

        /// <summary>
        /// A string like "Unhandled binary: {0}"
        /// </summary>
        internal static string UnhandledBinary(object? p0) => $"Unhandled binary: {p0}";

        /// <summary>
        /// A string like "Unhandled binding "
        /// </summary>
        internal static string UnhandledBinding => "Unhandled binding";

        /// <summary>
        /// A string like "Unhandled Binding Type: {0}"
        /// </summary>
        internal static string UnhandledBindingType(object? p0) => $"Unhandled Binding Type: {p0}";

        /// <summary>
        /// A string like "Unhandled unary: {0}"
        /// </summary>
        internal static string UnhandledUnary(object? p0) => $"Unhandled unary: {p0}";

        /// <summary>
        /// A string like "Unknown binding type"
        /// </summary>
        internal static string UnknownBindingType => "Unknown binding type";

        /// <summary>
        /// A string like "The user-defined operator method '{1}' for operator '{0}' must have identical parameter and return types."
        /// </summary>
        internal static string UserDefinedOpMustHaveConsistentTypes(object? p0, object? p1) => $"The user-defined operator method '{p1}' for operator '{p0}' must have identical parameter and return types.";

        /// <summary>
        /// A string like "The user-defined operator method '{1}' for operator '{0}' must return the same type as its parameter or a derived type."
        /// </summary>
        internal static string UserDefinedOpMustHaveValidReturnType(object? p0, object? p1) => $"The user-defined operator method '{p1}' for operator '{p0}' must return the same type as its parameter or a derived type.";

        /// <summary>
        /// A string like "The user-defined operator method '{1}' for operator '{0}' must have associated boolean True and False operators."
        /// </summary>
        internal static string LogicalOperatorMustHaveBooleanOperators(object? p0, object? p1) => $"The user-defined operator method '{p1}' for operator '{p0}' must have associated boolean True and False operators.";

        /// <summary>
        /// A string like "No method '{0}' on type '{1}' is compatible with the supplied arguments."
        /// </summary>
        internal static string MethodWithArgsDoesNotExistOnType(object? p0, object? p1) => $"No method '{p0}' on type '{p1}' is compatible with the supplied arguments.";

        /// <summary>
        /// A string like "No generic method '{0}' on type '{1}' is compatible with the supplied type arguments and arguments. No type arguments should be provided if the method is non-generic. "
        /// </summary>
        internal static string GenericMethodWithArgsDoesNotExistOnType(object? p0, object? p1) => $"No generic method '{p0}' on type '{p1}' is compatible with the supplied type arguments and arguments. No type arguments should be provided if the method is non-generic. ";

        /// <summary>
        /// A string like "More than one method '{0}' on type '{1}' is compatible with the supplied arguments."
        /// </summary>
        internal static string MethodWithMoreThanOneMatch(object? p0, object? p1) => $"More than one method '{p0}' on type '{p1}' is compatible with the supplied arguments.";

        /// <summary>
        /// A string like "More than one property '{0}' on type '{1}' is compatible with the supplied arguments."
        /// </summary>
        internal static string PropertyWithMoreThanOneMatch(object? p0, object? p1) => $"More than one property '{p0}' on type '{p1}' is compatible with the supplied arguments.";

        /// <summary>
        /// A string like "An incorrect number of type arguments were specified for the declaration of a Func type."
        /// </summary>
        internal static string IncorrectNumberOfTypeArgsForFunc => "An incorrect number of type arguments were specified for the declaration of a Func type.";

        /// <summary>
        /// A string like "An incorrect number of type arguments were specified for the declaration of an Action type."
        /// </summary>
        internal static string IncorrectNumberOfTypeArgsForAction => "An incorrect number of type arguments were specified for the declaration of an Action type.";

        /// <summary>
        /// A string like "Argument type cannot be System.Void."
        /// </summary>
        internal static string ArgumentCannotBeOfTypeVoid => "Argument type cannot be System.Void.";

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
        /// A string like "When called from '{0}', rewriting a node of type '{1}' must return a non-null value of the same type. Alternatively, override '{2}' and change it to not visit children of this type."
        /// </summary>
        internal static string MustRewriteToSameNode(object? p0, object? p1, object? p2) => $"When called from '{p0}', rewriting a node of type '{p1}' must return a non-null value of the same type. Alternatively, override '{p2}' and change it to not visit children of this type.";

        /// <summary>
        /// A string like "Rewriting child expression from type '{0}' to type '{1}' is not allowed, because it would change the meaning of the operation. If this is intentional, override '{2}' and change it to allow this rewrite."
        /// </summary>
        internal static string MustRewriteChildToSameType(object? p0, object? p1, object? p2) => $"Rewriting child expression from type '{p0}' to type '{p1}' is not allowed, because it would change the meaning of the operation. If this is intentional, override '{p2}' and change it to allow this rewrite.";

        /// <summary>
        /// A string like "Rewritten expression calls operator method '{0}', but the original node had no operator method. If this is intentional, override '{1}' and change it to allow this rewrite."
        /// </summary>
        internal static string MustRewriteWithoutMethod(object? p0, object? p1) => $"Rewritten expression calls operator method '{p0}', but the original node had no operator method. If this is intentional, override '{p1}' and change it to allow this rewrite.";

        /// <summary>
        /// A string like "TryExpression is not supported as an argument to method '{0}' because it has an argument with by-ref type. Construct the tree so the TryExpression is not nested inside of this expression."
        /// </summary>
        internal static string TryNotSupportedForMethodsWithRefArgs(object? p0) => $"TryExpression is not supported as an argument to method '{p0}' because it has an argument with by-ref type. Construct the tree so the TryExpression is not nested inside of this expression.";

        /// <summary>
        /// A string like "TryExpression is not supported as a child expression when accessing a member on type '{0}' because it is a value type. Construct the tree so the TryExpression is not nested inside of this expression."
        /// </summary>
        internal static string TryNotSupportedForValueTypeInstances(object? p0) => $"TryExpression is not supported as a child expression when accessing a member on type '{p0}' because it is a value type. Construct the tree so the TryExpression is not nested inside of this expression.";

        /// <summary>
        /// A string like "Test value of type '{0}' cannot be used for the comparison method parameter of type '{1}'"
        /// </summary>
        internal static string TestValueTypeDoesNotMatchComparisonMethodParameter(object? p0, object? p1) => $"Test value of type '{p0}' cannot be used for the comparison method parameter of type '{p1}'";

        /// <summary>
        /// A string like "Switch value of type '{0}' cannot be used for the comparison method parameter of type '{1}'"
        /// </summary>
        internal static string SwitchValueTypeDoesNotMatchComparisonMethodParameter(object? p0, object? p1) => $"Switch value of type '{p0}' cannot be used for the comparison method parameter of type '{p1}'";

#if FEATURE_COMPILE_TO_METHODBUILDER && FEATURE_PDB_GENERATOR
        /// <summary>
        /// A string like "DebugInfoGenerator created by CreatePdbGenerator can only be used with LambdaExpression.CompileToMethod."
        /// </summary>
        internal static string PdbGeneratorNeedsExpressionCompiler => "DebugInfoGenerator created by CreatePdbGenerator can only be used with LambdaExpression.CompileToMethod.";
#endif

        /// <summary>
        /// A string like "The constructor should not be static"
        /// </summary>
        internal static string NonStaticConstructorRequired => "The constructor should not be static";

        /// <summary>
        /// A string like "The constructor should not be declared on an abstract class"
        /// </summary>
        internal static string NonAbstractConstructorRequired =>  "The constructor should not be declared on an abstract class";

        /// <summary>
        /// A string like "Expression must be readable"
        /// </summary>
        internal static string ExpressionMustBeReadable => "Expression must be readable";

        /// <summary>
        /// A string like "Expression of type '{0}' cannot be used for constructor parameter of type '{1}'"
        /// </summary>
        internal static string ExpressionTypeDoesNotMatchConstructorParameter(object? p0, object? p1) => $"Expression of type '{p0}' cannot be used for constructor parameter of type '{p1}'";

        /// <summary>
        /// A string like "Enumeration has either not started or has already finished."
        /// </summary>
        internal static string EnumerationIsDone => "Enumeration has either not started or has already finished.";

        /// <summary>
        /// A string like "Type {0} contains generic parameters"
        /// </summary>
        internal static string TypeContainsGenericParameters(object? p0) => $"Type {p0} contains generic parameters";

        /// <summary>
        /// A string like "Type {0} is a generic type definition"
        /// </summary>
        internal static string TypeIsGeneric(object? p0) => $"Type {p0} is a generic type definition";
        /// <summary>
        /// A string like "Invalid argument value"
        /// </summary>
        internal static string InvalidArgumentValue_ParamName => "Invalid argument value";

        /// <summary>
        /// A string like "Non-empty collection required"
        /// </summary>
        internal static string NonEmptyCollectionRequired => "Non-empty collection required";

        /// <summary>
        /// A string like "The value null is not of type '{0}' and cannot be used in this collection."
        /// </summary>
        internal static string InvalidNullValue(object? p0) => $"The value null is not of type '{p0}' and cannot be used in this collection.";

        /// <summary>
        /// A string like "The value '{0}' is not of type '{1}' and cannot be used in this collection."
        /// </summary>
        internal static string InvalidObjectType(object? p0, object? p1) => $"The value '{p0}' is not of type '{p1}' and cannot be used in this collection.";

        /// <summary>
        /// A string like "Expression of type '{0}' cannot be used for parameter of type '{1}' of method '{2}'"
        /// </summary>
        internal static string ExpressionTypeDoesNotMatchMethodParameter(object? p0, object? p1, object? p2) => $"Expression of type '{p0}' cannot be used for parameter of type '{p1}' of method '{p2}'";

        /// <summary>
        /// A string like "Expression of type '{0}' cannot be used for parameter of type '{1}'"
        /// </summary>
        internal static string ExpressionTypeDoesNotMatchParameter(object? p0, object? p1) => $"Expression of type '{p0}' cannot be used for parameter of type '{p1}'";

        /// <summary>
        /// A string like "Incorrect number of arguments supplied for call to method '{0}'"
        /// </summary>
        internal static string IncorrectNumberOfMethodCallArguments(object? p0) => $"Incorrect number of arguments supplied for call to method '{p0}'";

        /// <summary>
        /// A string like "Incorrect number of arguments supplied for lambda invocation"
        /// </summary>
        internal static string IncorrectNumberOfLambdaArguments => "Incorrect number of arguments supplied for lambda invocation";

        /// <summary>
        /// A string like "Incorrect number of arguments for constructor"
        /// </summary>
        internal static string IncorrectNumberOfConstructorArguments => "Incorrect number of arguments for constructor";
    }
}
