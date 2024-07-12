// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Linq.Expressions.Compiler
{
    internal interface ILocalCache
    {
        LocalBuilder GetLocal(Type type);

        void FreeLocal(LocalBuilder local);
    }

    /// <summary>
    /// LambdaCompiler is responsible for compiling individual lambda (LambdaExpression). The complete tree may
    /// contain multiple lambdas, the Compiler class is responsible for compiling the whole tree, individual
    /// lambdas are then compiled by the LambdaCompiler.
    /// </summary>
    [RequiresDynamicCode(ExpressionExtensions.LambdaCompilerRequiresDynamicCode)]
    internal sealed partial class LambdaCompiler : ILocalCache
    {
        private delegate void WriteBack(LambdaCompiler compiler);

        // Information on the entire lambda tree currently being compiled
        private readonly AnalyzedTree _tree;

        private readonly ILGenerator _ilg;

#if FEATURE_COMPILE_TO_METHODBUILDER
        // The TypeBuilder backing this method, if any
        private readonly TypeBuilder _typeBuilder;
#endif

        private readonly MethodInfo _method;

        // Currently active LabelTargets and their mapping to IL labels
        private LabelScopeInfo _labelBlock = new LabelScopeInfo(null, LabelScopeKind.Lambda);
        // Mapping of labels used for "long" jumps (jumping out and into blocks)
        private readonly Dictionary<LabelTarget, LabelInfo> _labelInfo = new Dictionary<LabelTarget, LabelInfo>();

        // The currently active variable scope
        private CompilerScope _scope;

        // The lambda we are compiling
        private readonly LambdaExpression _lambda;

        // True if the method's first argument is of type Closure
        private readonly bool _hasClosureArgument;

        // Free list of locals, so we reuse them rather than creating new ones
        private readonly KeyedStack<Type, LocalBuilder> _freeLocals = new KeyedStack<Type, LocalBuilder>();

        /// <summary>
        /// The value is true if a clearance was emitted and no new sequence point
        /// has been emitted since that.
        /// </summary>
        bool _sequencePointCleared;

#if FEATURE_COMPILE_TO_METHODBUILDER
        /// <summary>
        /// Creates a lambda compiler that will compile into the provided MethodBuilder
        /// </summary>
        private LambdaCompiler(AnalyzedTree tree, LambdaExpression lambda, MethodBuilder method)
        {
            var scope = tree.Scopes[lambda];
            var hasClosureArgument = scope.NeedsClosure;

            Type[] paramTypes = GetParameterTypes(lambda, hasClosureArgument ? typeof(CTM_Closure) : null);

            method.SetReturnType(lambda.ReturnType);
            method.SetParameters(paramTypes);
            var parameters = lambda.Parameters;
            // parameters are index from 1, with closure argument we need to skip the first arg
            int startIndex = hasClosureArgument ? 2 : 1;
            for (int i = 0, n = parameters.Count; i < n; i++)
            {
                method.DefineParameter(i + startIndex, ParameterAttributes.None, parameters[i].Name);
            }

            _tree = tree;
            _lambda = lambda;
            _typeBuilder = (TypeBuilder)method.DeclaringType!;
            _method = method;
            _hasClosureArgument = hasClosureArgument;

            _ilg = method.GetILGenerator();

            // These are populated by AnalyzeTree/VariableBinder
            _scope = scope;

            InitializeMethod();
        }
#endif

        /// <summary>
        /// Creates a lambda compiler for an inlined lambda
        /// </summary>
        private LambdaCompiler(
            LambdaCompiler parent,
            LambdaExpression lambda,
            InvocationExpression invocation)
        {
            _tree = parent._tree;
            _lambda = lambda;
            _method = parent._method;
            _ilg = parent._ilg;
            _hasClosureArgument = parent._hasClosureArgument;
#if FEATURE_COMPILE_TO_METHODBUILDER
            _typeBuilder = parent._typeBuilder;
#endif
            // inlined scopes are associated with invocation, not with the lambda
            _scope = _tree.Scopes[invocation];
        }

        private void InitializeMethod()
        {
            // See if we can find a return label, so we can emit better IL
            AddReturnLabel(_lambda);
        }

        internal ILGenerator IL => _ilg;

        private ParameterProviderExtensions? _parameters;
        internal ParameterProviderExtensions Parameters => _parameters ??= new ParameterProviderExtensions(_lambda);

        #region Compiler entry points

#if FEATURE_COMPILE_TO_METHODBUILDER
        /// <summary>
        /// Mutates the MethodBuilder parameter, filling in IL, parameters,
        /// and return type.
        ///
        /// (probably shouldn't be modifying parameters/return type...)
        /// </summary>
        internal static void Compile(LambdaExpression lambda, MethodBuilder method, IExpressionDebugInfoGenerator? debugInfoGenerator)
        {
            // 1. Bind lambda
            AnalyzedTree tree = AnalyzeLambda(ref lambda);

            tree.DebugInfoGenerator = debugInfoGenerator;

            // 2. Create lambda compiler
            LambdaCompiler c = new LambdaCompiler(tree, lambda, method);

            // 3. Emit
            c.EmitLambdaBody();
        }
#endif

        #endregion

        private static AnalyzedTree AnalyzeLambda(ref LambdaExpression lambda)
        {
            // Spill the stack for any exception handling blocks or other
            // constructs which require entering with an empty stack
            lambda = StackSpiller.AnalyzeLambda(lambda);

            // Bind any variable references in this lambda
            return VariableBinder.Bind(lambda);
        }

        public LocalBuilder GetLocal(Type type) => _freeLocals.TryPop(type) ?? _ilg.DeclareLocal(type);

        public void FreeLocal(LocalBuilder local)
        {
            Debug.Assert(local != null);
            _freeLocals.Push(local.LocalType, local);
        }

        internal LocalBuilder GetNamedLocal(Type type, ParameterExpression variable)
        {
            Debug.Assert(type != null && variable != null);

            if (_tree.DebugInfoGenerator is null || variable.Name is null)
            {
                return GetLocal(type);
            }

            LocalBuilder lb = _ilg.DeclareLocal(type);
            _tree.DebugInfoGenerator.SetLocalName(lb, variable.Name);
            return lb;
        }

        /// <summary>
        /// Gets the argument slot corresponding to the parameter at the given
        /// index. Assumes that the method takes a certain number of prefix
        /// arguments, followed by the real parameters stored in Parameters
        /// </summary>
        internal int GetLambdaArgument(int index)
        {
            // _method.IsStatic == false is unreachable for CompileToMethod
            return index + (_hasClosureArgument ? 1 : 0) + (_method.IsStatic ? 0 : 1);
        }

        /// <summary>
        /// Returns the index-th argument. This method provides access to the actual arguments
        /// defined on the lambda itself, and excludes the possible 0-th closure argument.
        /// </summary>
        internal void EmitLambdaArgument(int index)
        {
            _ilg.EmitLoadArg(GetLambdaArgument(index));
        }

        internal void EmitClosureArgument()
        {
            Debug.Assert(_hasClosureArgument, "must have a Closure argument");
            Debug.Assert(_method.IsStatic, "must be a static method");
            _ilg.EmitLoadArg(0);
        }

#if FEATURE_COMPILE_TO_METHODBUILDER
        private FieldBuilder CreateStaticField(string name, Type type)
        {
            // We are emitting into someone else's type. We don't want name
            // conflicts, so choose a long name that is unlikely to conflict.
            // Naming scheme chosen here is similar to what the C# compiler
            // uses.
            return _typeBuilder.DefineField("<ExpressionCompilerImplementationDetails>{" + System.Threading.Interlocked.Increment(ref s_counter) + "}" + name, type, FieldAttributes.Static | FieldAttributes.Private);
        }
#endif

        /// <summary>
        /// Creates an uninitialized field suitable for private implementation details
        /// Works with DynamicMethods or TypeBuilders.
        /// </summary>
        private MemberExpression CreateLazyInitializedField<T>(string name)
        {
#if FEATURE_COMPILE_TO_METHODBUILDER
            {
                return Expression.Field(null, CreateStaticField(name, typeof(T)));
            }
#endif
        }
    }
}
