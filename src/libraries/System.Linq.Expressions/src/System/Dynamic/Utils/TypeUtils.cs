// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Dynamic.Utils
{
    internal static class TypeUtils
    {
        private static readonly Type[] s_arrayAssignableInterfaces = typeof(int[]).GetInterfaces()
            .Where(i => i.IsGenericType)
            .Select(i => i.GetGenericTypeDefinition())
            .ToArray();

        private static readonly ConstructorInfo s_nullableConstructor = typeof(Nullable<>).GetConstructor(typeof(Nullable<>).GetGenericArguments())!;

        public static Type GetNonNullableType(this Type type) => IsNullableType(type) ? type.GetGenericArguments()[0] : type;

        [RequiresDynamicCode("Creating nullable types requires dynamic code.")]
        public static Type GetNullableType(this Type type)
        {
            Debug.Assert(type != null, "type cannot be null");
            if (type.IsValueType && !IsNullableType(type))
            {
                return typeof(Nullable<>).MakeGenericType(type);
            }

            return type;
        }

        /// <summary>
        /// This is an alternative to <see cref="GetNullableType" /> that will throw
        /// if dynamic code is required. Some common primitive types are special-cased.
        /// </summary>
        public static Type LiftPrimitiveOrThrow(this Type type)
        {
            {
                return GetNullableType(type);
            }
        }

        public static ConstructorInfo GetNullableConstructor(Type nullableType)
        {
            Debug.Assert(nullableType.IsNullableType());

            return (ConstructorInfo)nullableType.GetMemberWithSameMetadataDefinitionAs(s_nullableConstructor);
        }

        public static bool IsNullableType(this Type type) => type.IsConstructedGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);

        public static bool IsNullableOrReferenceType(this Type type) => !type.IsValueType || IsNullableType(type);

        public static bool IsInteger(this Type type)
        {
            type = GetNonNullableType(type);
            if (!type.IsEnum)
            {
                switch (type.GetTypeCode())
                {
                    case TypeCode.Byte:
                    case TypeCode.SByte:
                    case TypeCode.Int16:
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.UInt16:
                    case TypeCode.UInt32:
                    case TypeCode.UInt64:
                        return true;
                }
            }

            return false;
        }

        public static bool IsInteger64(this Type type)
        {
            type = GetNonNullableType(type);
            if (!type.IsEnum)
            {
                switch (type.GetTypeCode())
                {
                    case TypeCode.Int64:
                    case TypeCode.UInt64:
                        return true;
                }
            }

            return false;
        }

        public static bool HasReferenceConversionTo(this Type source, Type dest)
        {
            Debug.Assert(source != null && dest != null);

            // void -> void conversion is handled elsewhere
            // (it's an identity conversion)
            // All other void conversions are disallowed.
            if (source == typeof(void) || dest == typeof(void))
            {
                return false;
            }

            Type nnSourceType = GetNonNullableType(source);
            Type nnDestType = GetNonNullableType(dest);

            // Down conversion
            if (nnSourceType.IsAssignableFrom(nnDestType))
            {
                return true;
            }

            // Up conversion
            if (nnDestType.IsAssignableFrom(nnSourceType))
            {
                return true;
            }

            // Interface conversion
            if (source.IsInterface || dest.IsInterface)
            {
                return true;
            }

            // Variant delegate conversion
            if (IsLegalExplicitVariantDelegateConversion(source, dest))
            {
                return true;
            }

            // Object conversion handled by assignable above.
            Debug.Assert(source != typeof(object) && dest != typeof(object));

            return (source.IsArray || dest.IsArray) && StrictHasReferenceConversionTo(source, dest, true);
        }

        private static bool StrictHasReferenceConversionTo(this Type source, Type dest, bool skipNonArray)
        {
            // HasReferenceConversionTo was both too strict and too lax. It was too strict in prohibiting
            // some valid conversions involving arrays, and too lax in allowing casts between interfaces
            // and sealed classes that don't implement them. Unfortunately fixing the lax cases would be
            // a breaking change, especially since such expressions will even work if only given null
            // arguments.
            // This method catches the cases that were incorrectly disallowed, but when it needs to
            // examine possible conversions of element or type parameters it applies stricter rules.

            while (true)
            {
                if (!skipNonArray) // Skip if we just came from HasReferenceConversionTo and have just tested these
                {
                    if (source.IsValueType | dest.IsValueType)
                    {
                        return false;
                    }

                    // Includes to case of either being typeof(object)
                    if (source.IsAssignableFrom(dest) || dest.IsAssignableFrom(source))
                    {
                        return true;
                    }

                    if (source.IsInterface)
                    {
                        if (dest.IsInterface || dest.IsClass && !dest.IsSealed)
                        {
                            return true;
                        }
                    }
                    else if (dest.IsInterface)
                    {
                        if (source.IsClass && !source.IsSealed)
                        {
                            return true;
                        }
                    }
                }

                if (source.IsArray)
                {
                    if (dest.IsArray)
                    {
                        if (source.GetArrayRank() != dest.GetArrayRank() || source.IsSZArray != dest.IsSZArray)
                        {
                            return false;
                        }

                        source = source.GetElementType()!;
                        dest = dest.GetElementType()!;
                        skipNonArray = false;
                    }
                    else
                    {
                        return HasArrayToInterfaceConversion(source, dest);
                    }
                }
                else if (dest.IsArray)
                {
                    if (HasInterfaceToArrayConversion(source, dest))
                    {
                        return true;
                    }

                    return IsImplicitReferenceConversion(typeof(Array), source);
                }
                else
                {
                    return IsLegalExplicitVariantDelegateConversion(source, dest);
                }
            }
        }

        private static bool HasArrayToInterfaceConversion(Type source, Type dest)
        {
            Debug.Assert(source.IsArray);
            if (!source.IsSZArray || !dest.IsInterface || !dest.IsGenericType)
            {
                return false;
            }

            Type[] destParams = dest.GetGenericArguments();
            if (destParams.Length != 1)
            {
                return false;
            }

            Type destGen = dest.GetGenericTypeDefinition();

            foreach (Type iface in s_arrayAssignableInterfaces)
            {
                if (AreEquivalent(destGen, iface))
                {
                    return StrictHasReferenceConversionTo(source.GetElementType()!, destParams[0], false);
                }
            }

            return false;
        }

        private static bool HasInterfaceToArrayConversion(Type source, Type dest)
        {
            Debug.Assert(dest.IsSZArray);
            if (!dest.IsSZArray || !source.IsInterface || !source.IsGenericType)
            {
                return false;
            }

            Type[] sourceParams = source.GetGenericArguments();
            if (sourceParams.Length != 1)
            {
                return false;
            }

            Type sourceGen = source.GetGenericTypeDefinition();

            foreach (Type iface in s_arrayAssignableInterfaces)
            {
                if (AreEquivalent(sourceGen, iface))
                {
                    return StrictHasReferenceConversionTo(sourceParams[0], dest.GetElementType()!, false);
                }
            }

            return false;
        }

        private static bool IsCovariant(Type t)
        {
            Debug.Assert(t != null);
            return 0 != (t.GenericParameterAttributes & GenericParameterAttributes.Covariant);
        }

        private static bool IsContravariant(Type t)
        {
            Debug.Assert(t != null);
            return 0 != (t.GenericParameterAttributes & GenericParameterAttributes.Contravariant);
        }

        private static bool IsInvariant(Type t)
        {
            Debug.Assert(t != null);
            return 0 == (t.GenericParameterAttributes & GenericParameterAttributes.VarianceMask);
        }

        private static bool IsDelegate(Type t)
        {
            Debug.Assert(t != null);
            return t.IsSubclassOf(typeof(MulticastDelegate));
        }

        public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest)
        {
            Debug.Assert(source != null && dest != null);

            // There *might* be a legal conversion from a generic delegate type S to generic delegate type  T,
            // provided all of the follow are true:
            //   o Both types are constructed generic types of the same generic delegate type, D<X1,... Xk>.
            //     That is, S = D<S1...>, T = D<T1...>.
            //   o If type parameter Xi is declared to be invariant then Si must be identical to Ti.
            //   o If type parameter Xi is declared to be covariant ("out") then Si must be convertible
            //     to Ti via an identify conversion,  implicit reference conversion, or explicit reference conversion.
            //   o If type parameter Xi is declared to be contravariant ("in") then either Si must be identical to Ti,
            //     or Si and Ti must both be reference types.

            if (!IsDelegate(source) || !IsDelegate(dest) || !source.IsGenericType || !dest.IsGenericType)
            {
                return false;
            }

            Type genericDelegate = source.GetGenericTypeDefinition();

            if (dest.GetGenericTypeDefinition() != genericDelegate)
            {
                return false;
            }

            Type[] genericParameters = genericDelegate.GetGenericArguments();
            Type[] sourceArguments = source.GetGenericArguments();
            Type[] destArguments = dest.GetGenericArguments();

            Debug.Assert(genericParameters != null);
            Debug.Assert(sourceArguments != null);
            Debug.Assert(destArguments != null);
            Debug.Assert(genericParameters.Length == sourceArguments.Length);
            Debug.Assert(genericParameters.Length == destArguments.Length);

            for (int iParam = 0; iParam < genericParameters.Length; ++iParam)
            {
                Type sourceArgument = sourceArguments[iParam];
                Type destArgument = destArguments[iParam];

                Debug.Assert(sourceArgument != null && destArgument != null);

                // If the arguments are identical then this one is automatically good, so skip it.
                if (AreEquivalent(sourceArgument, destArgument))
                {
                    continue;
                }

                Type genericParameter = genericParameters[iParam];

                Debug.Assert(genericParameter != null);

                if (IsInvariant(genericParameter))
                {
                    return false;
                }

                if (IsCovariant(genericParameter))
                {
                    if (!sourceArgument.HasReferenceConversionTo(destArgument))
                    {
                        return false;
                    }
                }
                else if (IsContravariant(genericParameter) && (sourceArgument.IsValueType || destArgument.IsValueType))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsConvertible(this Type type)
        {
            type = GetNonNullableType(type);
            if (type.IsEnum)
            {
                return true;
            }

            switch (type.GetTypeCode())
            {
                case TypeCode.Boolean:
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Char:
                    return true;

                default:
                    return false;
            }
        }

        private static bool IsImplicitReferenceConversion(Type source, Type destination) =>
            destination.IsAssignableFrom(source);

        public static Type? FindGenericType(Type definition, Type? type)
        {
            // For now this helper doesn't support interfaces
            Debug.Assert(!definition.IsInterface);

            while (type is not null && type != typeof(object))
            {
                if (type.IsConstructedGenericType && AreEquivalent(type.GetGenericTypeDefinition(), definition))
                {
                    return type;
                }

                type = type.BaseType;
            }

            return null;
        }

        /// <summary>
        /// Searches for an operator method on the type. The method must have
        /// the specified signature, no generic arguments, and have the
        /// SpecialName bit set. Also searches inherited operator methods.
        ///
        /// NOTE: This was designed to satisfy the needs of op_True and
        /// op_False, because we have to do runtime lookup for those. It may
        /// not work right for unary operators in general.
        /// </summary>
        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2067:UnrecognizedReflectionPattern",
            Justification = "The trimmer doesn't remove operators when System.Linq.Expressions is used. See https://github.com/mono/linker/pull/2125.")]
        public static MethodInfo? GetBooleanOperator(Type type, string name)
        {
            Debug.Assert(name == "op_False" || name == "op_True");

            do
            {
                MethodInfo? result = type.GetAnyStaticMethodValidated(name, new[] { type });
                if (result != null && result.IsSpecialName && !result.ContainsGenericParameters)
                {
                    return result;
                }

                type = type.BaseType!;
            } while (type != null);

            return null;
        }

        public static Type GetNonRefType(this Type type) => type.IsByRef ? type.GetElementType()! : type;

        public static bool AreEquivalent(Type? t1, Type? t2) => t1 != null && t1.IsEquivalentTo(t2);

        public static bool AreReferenceAssignable(Type dest, Type src)
        {
            // This actually implements "Is this identity assignable and/or reference assignable?"
            if (AreEquivalent(dest, src))
            {
                return true;
            }

            return !dest.IsValueType && !src.IsValueType && dest.IsAssignableFrom(src);
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern",
            Justification = "The trimmer will never remove the Invoke method from delegates.")]
        public static MethodInfo GetInvokeMethod(this Type delegateType)
        {
            Debug.Assert(typeof(Delegate).IsAssignableFrom(delegateType));
            return delegateType.GetMethod("Invoke", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)!;
        }

        internal static bool IsUnsigned(this Type type) => IsUnsigned(GetNonNullableType(type).GetTypeCode());

        internal static bool IsUnsigned(this TypeCode typeCode)
        {
            switch (typeCode)
            {
                case TypeCode.Byte:
                case TypeCode.UInt16:
                case TypeCode.Char:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return true;

                default:
                    return false;
            }
        }

        internal static bool IsFloatingPoint(this Type type) => IsFloatingPoint(GetNonNullableType(type).GetTypeCode());

        internal static bool IsFloatingPoint(this TypeCode typeCode)
        {
            switch (typeCode)
            {
                case TypeCode.Single:
                case TypeCode.Double:
                    return true;

                default:
                    return false;
            }
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern",
            Justification = "The Array 'Get' method is dynamically constructed and is not included in IL. It is not subject to trimming.")]
        public static MethodInfo GetArrayGetMethod(Type arrayType)
        {
            Debug.Assert(arrayType.IsArray);
            return arrayType.GetMethod("Get", BindingFlags.Public | BindingFlags.Instance)!;
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern",
            Justification = "The Array 'Set' method is dynamically constructed and is not included in IL. It is not subject to trimming.")]
        public static MethodInfo GetArraySetMethod(Type arrayType)
        {
            Debug.Assert(arrayType.IsArray);
            return arrayType.GetMethod("Set", BindingFlags.Public | BindingFlags.Instance)!;
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern",
            Justification = "The Array 'Address' method is dynamically constructed and is not included in IL. It is not subject to trimming.")]
        public static MethodInfo GetArrayAddressMethod(Type arrayType)
        {
            Debug.Assert(arrayType.IsArray);
            return arrayType.GetMethod("Address", BindingFlags.Public | BindingFlags.Instance)!;
        }
    }
}
