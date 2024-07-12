// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using static System.Linq.Expressions.CachedReflectionInfo;

namespace System.Linq.Expressions.Compiler
{
    /// <summary>
    /// Dynamic Language Runtime Compiler.
    /// This part compiles lambdas.
    /// </summary>
    internal sealed partial class LambdaCompiler
    {
#if FEATURE_COMPILE_TO_METHODBUILDER
        private static int s_counter;
#endif

        internal void EmitConstantArray<T>(T[] array)
        {
#if FEATURE_COMPILE_TO_METHODBUILDER
            {
                // store into field in our type builder, we will initialize
                // the value only once.
                FieldBuilder fb = CreateStaticField("ConstantArray", typeof(T[]));
                Label l = _ilg.DefineLabel();
                _ilg.Emit(OpCodes.Ldsfld, fb);
                _ilg.Emit(OpCodes.Ldnull);
                _ilg.Emit(OpCodes.Bne_Un, l);
                _ilg.EmitArray(array, this);
                _ilg.Emit(OpCodes.Stsfld, fb);
                _ilg.MarkLabel(l);
                _ilg.Emit(OpCodes.Ldsfld, fb);
            }
#endif
        }

        private void EmitClosureCreation(LambdaCompiler inner)
        {
            bool closure = inner._scope.NeedsClosure;

            if (!closure)
            {
                _ilg.EmitNull();
                return;
            }

            // new Closure(constantPool, currentHoistedLocals)
            {
                _scope.EmitGet(_scope.NearestHoistedLocals!.SelfVariable);
            }
            _ilg.EmitNew(Closure_ObjectArray);
        }

        /// <summary>
        /// Emits code which creates new instance of the delegateType delegate.
        ///
        /// Since the delegate is getting closed over the "Closure" argument, this
        /// cannot be used with virtual/instance methods (inner must be static method)
        /// </summary>
        private void EmitDelegateConstruction(LambdaCompiler inner)
        {
            Type delegateType = inner._lambda.Type;
#if FEATURE_COMPILE_TO_METHODBUILDER
            {
                // new DelegateType(closure)
                EmitClosureCreation(inner);
                _ilg.Emit(OpCodes.Ldftn, inner._method);
                _ilg.Emit(OpCodes.Newobj, (ConstructorInfo)(delegateType.GetMember(".ctor")[0]));
            }
#endif
        }

        /// <summary>
        /// Emits a delegate to the method generated for the LambdaExpression.
        /// May end up creating a wrapper to match the requested delegate type.
        /// </summary>
        /// <param name="lambda">Lambda for which to generate a delegate</param>
        ///
        private void EmitDelegateConstruction(LambdaExpression lambda)
        {
            // 1. Create the new compiler
            LambdaCompiler impl;
#if FEATURE_COMPILE_TO_METHODBUILDER
            {
                // When the lambda does not have a name or the name is empty, generate a unique name for it.
                string name = String.IsNullOrEmpty(lambda.Name) ? GetUniqueMethodName() : lambda.Name;
                MethodBuilder mb = _typeBuilder.DefineMethod(name, MethodAttributes.Private | MethodAttributes.Static);
                impl = new LambdaCompiler(_tree, lambda, mb);
            }
#endif

            // 2. emit the lambda
            // Since additional ILs are always emitted after the lambda's body, should not emit with tail call optimization.
            impl.EmitLambdaBody(_scope, false, CompilationFlags.EmitAsNoTail);

            // 3. emit the delegate creation in the outer lambda
            EmitDelegateConstruction(impl);
        }

        private static Type[] GetParameterTypes(LambdaExpression lambda, Type? firstType)
        {
            int count = lambda.ParameterCount();

            Type[] result;
            int i;

            if (firstType != null)
            {
                result = new Type[count + 1];
                result[0] = firstType;
                i = 1;
            }
            else
            {
                result = new Type[count];
                i = 0;
            }

            for (var j = 0; j < count; j++, i++)
            {
                ParameterExpression p = lambda.GetParameter(j);
                result[i] = p.IsByRef ? p.Type.MakeByRefType() : p.Type;
            }

            return result;
        }

#if FEATURE_COMPILE_TO_METHODBUILDER
        private static string GetUniqueMethodName()
        {
            return "<ExpressionCompilerImplementationDetails>{" + System.Threading.Interlocked.Increment(ref s_counter) + "}lambda_method";
        }
#endif

        private void EmitLambdaBody()
        {
            // The lambda body is the "last" expression of the lambda
            CompilationFlags tailCallFlag = _lambda.TailCall ? CompilationFlags.EmitAsTail : CompilationFlags.EmitAsNoTail;
            EmitLambdaBody(null, false, tailCallFlag);
        }

        /// <summary>
        /// Emits the lambda body. If inlined, the parameters should already be
        /// pushed onto the IL stack.
        /// </summary>
        /// <param name="parent">The parent scope.</param>
        /// <param name="inlined">true if the lambda is inlined; false otherwise.</param>
        /// <param name="flags">
        /// The enum to specify if the lambda is compiled with the tail call optimization.
        /// </param>
        private void EmitLambdaBody(CompilerScope? parent, bool inlined, CompilationFlags flags)
        {
            _scope.Enter(this, parent);

            if (inlined)
            {
                // The arguments were already pushed onto the IL stack.
                // Store them into locals, popping in reverse order.
                //
                // If any arguments were ByRef, the address is on the stack and
                // we'll be storing it into the variable, which has a ref type.
                for (int i = _lambda.ParameterCount() - 1; i >= 0; i--)
                {
                    _scope.EmitSet(_lambda.GetParameter(i));
                }
            }

            // Need to emit the expression start for the lambda body
            flags = UpdateEmitExpressionStartFlag(flags, CompilationFlags.EmitExpressionStart);
            if (_lambda.ReturnType == typeof(void))
            {
                EmitExpressionAsVoid(_lambda.Body, flags);
            }
            else
            {
                EmitExpression(_lambda.Body, flags);
            }

            // Return must be the last instruction in a CLI method.
            // But if we're inlining the lambda, we want to leave the return
            // value on the IL stack.
            if (!inlined)
            {
                _ilg.Emit(OpCodes.Ret);
            }

            _scope.Exit();

            // Validate labels
            Debug.Assert(_labelBlock.Parent == null && _labelBlock.Kind == LabelScopeKind.Lambda);
            foreach (LabelInfo label in _labelInfo.Values)
            {
                label.ValidateFinish();
            }
        }
    }
}
