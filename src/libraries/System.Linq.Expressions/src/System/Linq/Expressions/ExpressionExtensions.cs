
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Reflection;
using static System.Linq.Expressions.Expression;

namespace System.Linq.Expressions;

/// <summary>Expression.CompileToMethod</summary>
public static class ExpressionExtensions
{
    /// <summary>
    /// Compiles the lambda into a method definition.
    /// </summary>
    /// <param name="this">The lambda</param>
    /// <param name="method">A <see cref="System.Reflection.Emit.MethodBuilder"/> which will be used to hold the lambda's IL.</param>
    public static void CompileToMethod(this LambdaExpression @this, System.Reflection.Emit.MethodBuilder method)
    {
        ArgumentNullException.ThrowIfNull(method);
        ContractUtils.Requires(method.IsStatic, nameof(method));
        var type = method.DeclaringType as System.Reflection.Emit.TypeBuilder;
        if (type == null) throw Error.MethodBuilderDoesNotHaveTypeBuilder();

        Compiler.LambdaCompiler.Compile(@this, method);
    }

    internal static readonly string s_specialLambdaName = new string(' ', 1);

    internal static LambdaExpression Accept(this LambdaExpression @this, Compiler.StackSpiller spiller)
    {
        return (LambdaExpression)new StackSpillerVisitor(spiller).Visit(@this);
    }

    private class StackSpillerVisitor : ExpressionVisitor
    {
        private readonly Compiler.StackSpiller _spiller;
        internal StackSpillerVisitor(Compiler.StackSpiller spiller) => _spiller = spiller;
        protected override Expression VisitLambda<T>(Expression<T> node) => _spiller.Rewrite(node);
    }

    internal static int ParameterCount(this LambdaExpression @this) => @this.Parameters.Count;
    internal static ParameterExpression GetParameter(this LambdaExpression @this, int i) => @this.Parameters[i];

    internal static LambdaExpression? LambdaOperand(this InvocationExpression @this)
    {
        return (@this.Expression.NodeType == ExpressionType.Quote)
            ? (LambdaExpression)((UnaryExpression)@this.Expression).Operand
            : (@this.Expression as LambdaExpression);
    }

    internal static int ArgumentCount(this IArgumentProvider @this) => @this.ArgumentCount;
    internal static Expression GetArgument(this IArgumentProvider @this, int i) => @this.GetArgument(i);

    internal static int ExpressionCount(this BlockExpression @this) => @this.Expressions.Count;
    internal static Expression GetExpression(this BlockExpression @this, int i) => @this.Expressions[i];


    internal static Expression ReduceTypeEqual(this TypeBinaryExpression @this)
    {
        Type cType = @this.Expression.Type;

        if (cType.IsValueType || @this.TypeOperand.IsPointer)
        {
            if (cType.IsNullableType())
            {
                // If the expression type is a nullable type, it will match if
                // the value is not null and the type operand
                // either matches or is its type argument (T to its T?).
                if (cType.GetNonNullableType() != @this.TypeOperand.GetNonNullableType())
                {
                    return Expression.Block(@this.Expression, Utils.Constant(value: false));
                }
                else
                {
                    return Expression.NotEqual(@this.Expression, Expression.Constant(null, @this.Expression.Type));
                }
            }
            else
            {
                // For other value types (including Void), we can
                // determine the result now
                return Expression.Block(@this.Expression, Utils.Constant(cType == @this.TypeOperand.GetNonNullableType()));
            }
        }

        Debug.Assert(TypeUtils.AreReferenceAssignable(typeof(object), @this.Expression.Type), "Expecting reference types only after this point.");

        // Can check the value right now for constants.
        if (@this.Expression.NodeType == ExpressionType.Constant)
        {
            return @this.ReduceConstantTypeEqual();
        }

        // expression is a ByVal parameter. Can safely reevaluate.
        var parameter = @this.Expression as ParameterExpression;
        if (parameter != null && !parameter.IsByRef)
        {
            return @this.ByValParameterTypeEqual(parameter);
        }

        // Create a temp so we only evaluate the left side once
        parameter = Expression.Parameter(typeof(object));

        return Expression.Block(
            new[] { parameter },
            new Expression[]
            {
                Expression.Assign(parameter, @this.Expression),
                @this.ByValParameterTypeEqual(parameter)
            }
        );
    }
    private static Expression ReduceConstantTypeEqual(this TypeBinaryExpression @this)
    {
        ConstantExpression? ce = @this.Expression as ConstantExpression;
        //TypeEqual(null, T) always returns false.
        if (ce!.Value == null)
        {
            return Utils.Constant(value: false);
        }
        else
        {
            return Utils.Constant(@this.TypeOperand.GetNonNullableType() == ce.Value.GetType());
        }
    }
    // Helper that is used when re-eval of LHS is safe.
    private static Expression ByValParameterTypeEqual(this TypeBinaryExpression @this, ParameterExpression value)
    {
        Expression getType = Expression.Call(value, CachedReflectionInfo.Object_GetType);

        // In remoting scenarios, obj.GetType() can return an interface.
        // But JIT32's optimized "obj.GetType() == typeof(ISomething)" codegen,
        // causing it to always return false.
        // We workaround this optimization by generating different, less optimal IL
        // if TypeOperand is an interface.
        if (@this.TypeOperand.IsInterface)
        {
            ParameterExpression temp = Expression.Parameter(typeof(Type));
            getType = Expression.Block(
                new[] { temp },
                new Expression[] {
                    Expression.Assign(temp, getType),
                    temp
                }
            );
        }

        // We use reference equality when comparing to null for correctness
        // (don't invoke a user defined operator), and reference equality
        // on types for performance (so the JIT can optimize the IL).
        return Expression.AndAlso(
            Expression.ReferenceNotEqual(value, Utils.Null),
            Expression.ReferenceEqual(
                getType,
                Expression.Constant(@this.TypeOperand.GetNonNullableType(), typeof(Type))
            )
        );
    }

    internal static bool IsLifted(this SwitchExpression @this)
    {
        if (@this.SwitchValue.Type.IsNullableType())
        {
            return (@this.Comparison == null) ||
                   !TypeUtils.AreEquivalent(@this.SwitchValue.Type, @this.Comparison.GetParametersCached()[0].ParameterType.GetNonRefType());
        }
        return false;
    }

    internal static bool IsLiftedLogical(this BinaryExpression @this)
    {
        Type left = @this.Left.Type;
        Type right = @this.Right.Type;
        MethodInfo? method = @this.Method;
        ExpressionType kind = @this.NodeType;

        return
            (kind == ExpressionType.AndAlso || kind == ExpressionType.OrElse) &&
            TypeUtils.AreEquivalent(right, left) &&
            left.IsNullableType() &&
            method != null &&
            TypeUtils.AreEquivalent(method.ReturnType, left.GetNonNullableType());
    }

    internal static Expression ReduceUserdefinedLifted(this BinaryExpression @this)
    {
        ParameterExpression left = Parameter(@this.Left.Type, "left");
        ParameterExpression right = Parameter(@this.Right.Type, "right");
        string opName = @this.NodeType == ExpressionType.AndAlso ? "op_False" : "op_True";
        MethodInfo? opTrueFalse = TypeUtils.GetBooleanOperator(@this.Method!.DeclaringType!, opName);
        Debug.Assert(opTrueFalse != null);

        return Block(
            new[] { left },
            new Expression[] {
                Assign(left, @this.Left),
                Condition(
                    Property(left, "HasValue"),
                    Condition(
                        Call(opTrueFalse, Call(left, "GetValueOrDefault", null)),
                        left,
                        Block(
                            new[] { right },
                            new Expression[] {
                                Assign(right, @this.Right),
                                Condition(
                                    Property(right, "HasValue"),
                                    Convert(
                                        Call(
                                            @this.Method,
                                            Call(left, "GetValueOrDefault", null),
                                            Call(right, "GetValueOrDefault", null)
                                        ),
                                        @this.Type
                                    ),
                                    Constant(null, @this.Type)
                                )
                            }
                        )
                    ),
                    Constant(null, @this.Type)
                )
            }
        );
    }

    /// <summary>
    /// Gets the delegate's Invoke method; used by InvocationExpression.
    /// </summary>
    /// <param name="expression">The expression to be invoked.</param>
    internal static MethodInfo GetInvokeMethod(Expression expression)
    {
        Type delegateType = expression.Type;
        if (!expression.Type.IsSubclassOf(typeof(MulticastDelegate)))
        {
            Type? exprType = TypeUtils.FindGenericType(typeof(Expression<>), expression.Type);
            if (exprType == null)
            {
                throw Error.ExpressionTypeNotInvocable(expression.Type, nameof(expression));
            }
            delegateType = exprType.GetGenericArguments()[0];
        }

        return delegateType.GetInvokeMethod();
    }

    internal static ParameterExpressionExt MakeParameterExt(Type type, string name)
    {
        if (type.IsByRef)
        {
            var expr = new ParameterWithByRefTypeExpression(type, name);
            return ParameterExpressionExt.Create(expr);
        }
        else
        {
            var expr = Parameter(type, name);
            return ParameterExpressionExt.Create(expr);
        }
    }

    internal static T[] ToReadOnly<T>(this ArrayBuilder<T> builder) => builder.ToArray();

    internal static MethodInfo GetCompileMethod(Type lambdaExpressionType)
    {
        Debug.Assert(lambdaExpressionType.IsAssignableTo(typeof(LambdaExpression)));

        if (lambdaExpressionType == typeof(LambdaExpression))
        {
            // use a hard-coded type directly so the method doesn't get trimmed
            return typeof(LambdaExpression).GetMethod("Compile", Type.EmptyTypes)!;
        }

        return (MethodInfo)lambdaExpressionType.GetMemberWithSameMetadataDefinitionAs(s_expressionCompileMethodInfo);
    }
    private static readonly MethodInfo s_expressionCompileMethodInfo = typeof(Expression<>).GetMethod("Compile", Type.EmptyTypes)!;

    internal static void ValidateArgumentCount(this LambdaExpression lambda)
    {
        if (lambda.ParameterCount() >= ushort.MaxValue)
        {
            throw Error.InvalidProgram();
        }
    }

    internal const string StrongBoxRequiresDynamicCode = "Creating a StrongBox requires dynamic code generation.";
    internal const string LambdaCompilerRequiresDynamicCode = "Compiling a lambda expression requires dynamic code generation.";
}

internal readonly struct AssignBinaryExpression
{
    internal AssignBinaryExpression(BinaryExpression inner, bool byRef)
    {
        Inner = inner;
        IsByRef = byRef;
    }

    internal static Expression Make(Expression left, Expression right, bool byRef)
    {
        if (byRef)
        {
            return new ByRefAssignBinaryExpression(left, right);
        }
        return Expression.Assign(left, right);
    }

    internal readonly BinaryExpression Inner;
    internal Expression Left => Inner.Left;
    internal Expression Right => Inner.Right;
    internal readonly bool IsByRef;

    internal Type Type => Left.Type;

    public static explicit operator AssignBinaryExpression(Expression node)
    {
        return node switch
        {
            BinaryExpression e => new AssignBinaryExpression(e, false),
            ByRefAssignBinaryExpression re => new AssignBinaryExpression(re.Inner, true),
            _ => throw new InvalidCastException($"Unable to cast object of type {node?.GetType()} to type {typeof(AssignBinaryExpression)}")
        };
    }
}

internal class ByRefAssignBinaryExpression : Expression
{
    internal BinaryExpression Inner { get; }

    internal ByRefAssignBinaryExpression(Expression left, Expression right)
    {
        Inner = Assign(left, right);
    }

    protected override Expression Accept(ExpressionVisitor visitor)
    {
        visitor.Visit(Inner);
        return this;
    }

    public override Type Type => Inner.Type;
    public override ExpressionType NodeType => ExpressionType.Assign;
}

internal readonly struct ParameterExpressionExt
{
    internal ParameterExpression Parameter { get; }
    internal Expression TypedParameter { get; }
    internal bool IsByRef => Parameter.IsByRef;
    internal Type Type { get; }

    internal ParameterExpressionExt(ParameterExpression parameter, Expression typedParameter, Type type)
    {
        Parameter = parameter;
        TypedParameter = typedParameter;
        Type = type;
    }

    internal static ParameterExpressionExt Create(ParameterExpression p) => new ParameterExpressionExt(p, p, p.Type);
    internal static ParameterExpressionExt Create(ParameterWithByRefTypeExpression pbr) => new ParameterExpressionExt(pbr.Inner, pbr, pbr.ParamType);

    public static explicit operator ParameterExpressionExt(Expression ex)
    {
        return ex switch
        {
            ParameterExpression p => Create(p),
            ParameterWithByRefTypeExpression pbr => Create(pbr),
            _ => throw new InvalidCastException($"Unable to cast object of type {ex?.GetType()} to type {typeof(ParameterExpressionExt)}")
        };
    }
}

internal class ParameterWithByRefTypeExpression : Expression
{
    internal ParameterExpression Inner { get; }

    internal ParameterWithByRefTypeExpression(Type type, string name)
    {
        ParamType = type;
        Inner = Parameter(type.GetElementType()!, name);
    }

    protected override Expression Accept(ExpressionVisitor visitor)
    {
        visitor.Visit(Inner);
        return this;
    }

    internal Type ParamType { get; }

    public override Type Type => Inner.Type;
    public override ExpressionType NodeType => ExpressionType.Parameter;
}

internal class BlockWithByRefParametersExpression : Expression
{
    internal IReadOnlyList<ParameterExpressionExt> Variables { get; }
    internal ReadOnlyCollection<Expression> Expressions => Statements.Expressions;
    internal BlockExpression Statements { get; }

    internal BlockWithByRefParametersExpression(IReadOnlyList<ParameterExpressionExt> variables, Expression body)
    {
        Variables = variables;
        Statements = Block(body);
    }

    public override ExpressionType NodeType => ExpressionType.Block;
    public override Type Type => Statements.Type;
}

internal readonly struct BlockExpressionExt
{
    internal Expression Block { get; }
    internal IReadOnlyCollection<ParameterExpression> Variables { get; }
    internal ReadOnlyCollection<Expression> Expressions { get; }

    internal BlockExpressionExt(BlockExpression block)
    {
        Block = block;
        Variables = block.Variables;
        Expressions = block.Expressions;
    }

    internal BlockExpressionExt(Compiler.SpilledExpressionBlock block)
    {
        Block = block;
        Variables = block.InnerBlock.Variables;
        Expressions = block.InnerBlock.Expressions;
    }

    internal BlockExpressionExt(BlockWithByRefParametersExpression block)
    {
        Block = block;
        Variables = new ParameterListWrapper(block.Variables);
        Expressions = block.Expressions;
    }

    public static explicit operator BlockExpressionExt(Expression ex)
    {
        return ex switch
        {
            BlockExpression b => new BlockExpressionExt(b),
            BlockWithByRefParametersExpression bbr => new BlockExpressionExt(bbr),
            Compiler.SpilledExpressionBlock seb => new BlockExpressionExt(seb),
            _ => throw new InvalidCastException($"Unable to cast object of type {ex?.GetType()} to type {typeof(BlockExpressionExt)}"),
        };
    }

    public static implicit operator Expression(BlockExpressionExt block) => block.Block;

    private class ParameterListWrapper : IReadOnlyCollection<ParameterExpression>
    {
        private readonly IReadOnlyList<ParameterExpressionExt> _parameters;

        internal ParameterListWrapper(IReadOnlyList<ParameterExpressionExt> parameters) => _parameters = parameters;

        public IEnumerator<ParameterExpression> GetEnumerator()
        {
            foreach (var parameter in _parameters)
            {
                yield return parameter.Parameter;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        int IReadOnlyCollection<ParameterExpression>.Count => _parameters.Count;
    }
}

