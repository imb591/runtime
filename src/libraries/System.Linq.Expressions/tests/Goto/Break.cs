// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace System.Linq.Expressions.Tests
{
    public class Break : GotoExpressionTests
    {
        [Theory]
        [PerCompilationType(nameof(ConstantValueData))]
        public void JustBreakValue(object value, CompilationType useInterpreter)
        {
            Type type = value.GetType();
            LabelTarget target = Expression.Label(type);
            Expression block = Expression.Block(
                Expression.Break(target, Expression.Constant(value)),
                Expression.Label(target, Expression.Default(type))
                );
            Expression equals = Expression.Equal(Expression.Constant(value), block);
            Assert.True(Expression.Lambda<Func<bool>>(equals).Compile(useInterpreter)());
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public void BreakToMiddle(CompilationType useInterpreter)
        {
            // The behaviour is that return jumps to a label, but does not necessarily leave a block.
            LabelTarget target = Expression.Label(typeof(int));
            Expression block = Expression.Block(
                Expression.Break(target, Expression.Constant(1)),
                Expression.Label(target, Expression.Constant(2)),
                Expression.Constant(3)
                );
            Assert.Equal(3, Expression.Lambda<Func<int>>(block).Compile(useInterpreter)());
        }

        [Theory]
        [PerCompilationType(nameof(ConstantValueData))]
        public void BreakJumps(object value, CompilationType useInterpreter)
        {
            Type type = value.GetType();
            LabelTarget target = Expression.Label(type);
            Expression block = Expression.Block(
                Expression.Break(target, Expression.Constant(value)),
                Expression.Throw(Expression.Constant(new InvalidOperationException())),
                Expression.Label(target, Expression.Default(type))
                );
            Assert.True(Expression.Lambda<Func<bool>>(Expression.Equal(Expression.Constant(value), block)).Compile(useInterpreter)());
        }

        [Theory(Skip = "no call to CompileToMethod")]
        [MemberData(nameof(TypesData))]
        public void NonVoidTargetBreakHasNoValue(Type type)
        {
            LabelTarget target = Expression.Label(type);
            AssertExtensions.Throws<ArgumentException>("target", () => Expression.Break(target));
        }

        [Theory(Skip = "no call to CompileToMethod")]
        [MemberData(nameof(TypesData))]
        public void NonVoidTargetBreakHasNoValueTypeExplicit(Type type)
        {
            LabelTarget target = Expression.Label(type);
            AssertExtensions.Throws<ArgumentException>("target", () => Expression.Break(target, type));
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public void BreakVoidNoValue(CompilationType useInterpreter)
        {
            LabelTarget target = Expression.Label();
            Expression block = Expression.Block(
                Expression.Break(target),
                Expression.Throw(Expression.Constant(new InvalidOperationException())),
                Expression.Label(target)
                );
            Expression.Lambda<Action>(block).Compile(useInterpreter)();
        }

        [Theory]
        [ClassData(typeof(CompilationTypes))]
        public void BreakExplicitVoidNoValue(CompilationType useInterpreter)
        {
            LabelTarget target = Expression.Label();
            Expression block = Expression.Block(
                Expression.Break(target, typeof(void)),
                Expression.Throw(Expression.Constant(new InvalidOperationException())),
                Expression.Label(target)
                );
            Expression.Lambda<Action>(block).Compile(useInterpreter)();
        }

        [Theory(Skip = "no call to CompileToMethod")]
        [MemberData(nameof(TypesData))]
        public void NullValueOnNonVoidBreak(Type type)
        {
            AssertExtensions.Throws<ArgumentException>("target", () => Expression.Break(Expression.Label(type)));
            AssertExtensions.Throws<ArgumentException>("target", () => Expression.Break(Expression.Label(type), default(Expression)));
            AssertExtensions.Throws<ArgumentException>("target", () => Expression.Break(Expression.Label(type), null, type));
        }

        [Theory(Skip = "no call to CompileToMethod")]
        [MemberData(nameof(ConstantValueData))]
        public void ExplicitNullTypeWithValue(object value)
        {
            AssertExtensions.Throws<ArgumentException>("target", () => Expression.Break(Expression.Label(value.GetType()), default(Type)));
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public void UnreadableLabel()
        {
            Expression value = Expression.Property(null, typeof(Unreadable<string>), "WriteOnly");
            LabelTarget target = Expression.Label(typeof(string));
            AssertExtensions.Throws<ArgumentException>("value", () => Expression.Break(target, value));
            AssertExtensions.Throws<ArgumentException>("value", () => Expression.Break(target, value, typeof(string)));
        }

        [Theory]
        [PerCompilationType(nameof(ConstantValueData))]
        public void CanAssignAnythingToVoid(object value, CompilationType useInterpreter)
        {
            LabelTarget target = Expression.Label();
            BlockExpression block = Expression.Block(
                Expression.Break(target, Expression.Constant(value)),
                Expression.Label(target)
                );
            Assert.Equal(typeof(void), block.Type);
            Expression.Lambda<Action>(block).Compile(useInterpreter)();
        }

        [Theory(Skip = "no call to CompileToMethod")]
        [MemberData(nameof(NonObjectAssignableConstantValueData))]
        public void CannotAssignValueTypesToObject(object value)
        {
            AssertExtensions.Throws<ArgumentException>(null, () => Expression.Break(Expression.Label(typeof(object)), Expression.Constant(value)));
        }

        [Theory]
        [PerCompilationType(nameof(ObjectAssignableConstantValueData))]
        public void ExplicitTypeAssigned(object value, CompilationType useInterpreter)
        {
            LabelTarget target = Expression.Label(typeof(object));
            BlockExpression block = Expression.Block(
                Expression.Break(target, Expression.Constant(value), typeof(object)),
                Expression.Label(target, Expression.Default(typeof(object)))
                );
            Assert.Equal(typeof(object), block.Type);
            Assert.Equal(value, Expression.Lambda<Func<object>>(block).Compile(useInterpreter)());
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public void BreakQuotesIfNecessary()
        {
            LabelTarget target = Expression.Label(typeof(Expression<Func<int>>));
            BlockExpression block = Expression.Block(
                Expression.Break(target, Expression.Lambda<Func<int>>(Expression.Constant(0))),
                Expression.Label(target, Expression.Default(typeof(Expression<Func<int>>)))
                );
            Assert.Equal(typeof(Expression<Func<int>>), block.Type);
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public void UpdateSameIsSame()
        {
            LabelTarget target = Expression.Label(typeof(int));
            Expression value = Expression.Constant(0);
            GotoExpression ret = Expression.Break(target, value);
            Assert.Same(ret, ret.Update(target, value));
            Assert.Same(ret, NoOpVisitor.Instance.Visit(ret));
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public void UpdateDifferentValueIsDifferent()
        {
            LabelTarget target = Expression.Label(typeof(int));
            GotoExpression ret = Expression.Break(target, Expression.Constant(0));
            Assert.NotSame(ret, ret.Update(target, Expression.Constant(0)));
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public void UpdateDifferentTargetIsDifferent()
        {
            Expression value = Expression.Constant(0);
            GotoExpression ret = Expression.Break(Expression.Label(typeof(int)), value);
            Assert.NotSame(ret, ret.Update(Expression.Label(typeof(int)), value));
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public void OpenGenericType()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.Break(Expression.Label(typeof(void)), typeof(List<>)));
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public static void TypeContainsGenericParameters()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.Break(Expression.Label(typeof(void)), typeof(List<>.Enumerator)));
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.Break(Expression.Label(typeof(void)), typeof(List<>).MakeGenericType(typeof(List<>))));
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public void PointerType()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.Break(Expression.Label(typeof(void)), typeof(int).MakePointerType()));
        }

        [Fact(Skip = "no call to CompileToMethod")]
        public void ByRefType()
        {
            AssertExtensions.Throws<ArgumentException>("type", () => Expression.Break(Expression.Label(typeof(void)), typeof(int).MakeByRefType()));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public void UndefinedLabel(CompilationType useInterpreter)
        {
            Expression<Action> breakNowhere = Expression.Lambda<Action>(Expression.Break(Expression.Label()));
            Assert.Throws<InvalidOperationException>(() => breakNowhere.Compile(useInterpreter));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public void AmbiguousJump(CompilationType useInterpreter)
        {
            LabelTarget target = Expression.Label();
            Expression<Action> exp = Expression.Lambda<Action>(
                Expression.Block(
                    Expression.Break(target),
                    Expression.Block(Expression.Label(target)),
                    Expression.Block(Expression.Label(target))
                    )
                );
            Assert.Throws<InvalidOperationException>(() => exp.Compile(useInterpreter));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public void MultipleDefinitionsInSeparateBlocks(CompilationType useInterpreter)
        {
            LabelTarget target = Expression.Label(typeof(int));
            Func<int> add = Expression.Lambda<Func<int>>(
                Expression.Add(
                    Expression.Add(
                        Expression.Block(
                            Expression.Break(target, Expression.Constant(6)),
                            Expression.Throw(Expression.Constant(new Exception())),
                            Expression.Label(target, Expression.Constant(0))
                        ),
                        Expression.Block(
                            Expression.Break(target, Expression.Constant(4)),
                            Expression.Throw(Expression.Constant(new Exception())),
                            Expression.Label(target, Expression.Constant(0))
                        )
                    ),
                    Expression.Block(
                        Expression.Break(target, Expression.Constant(5)),
                        Expression.Throw(Expression.Constant(new Exception())),
                        Expression.Label(target, Expression.Constant(0))
                    )
                )
            ).Compile(useInterpreter);
            Assert.Equal(15, add());
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public void JumpIntoExpression(CompilationType useInterpreter)
        {
            LabelTarget target = Expression.Label();
            Expression<Func<bool>> isInt = Expression.Lambda<Func<bool>>(
                Expression.Block(
                    Expression.Break(target),
                    Expression.TypeIs(Expression.Label(target), typeof(int))
                )
            );
            Assert.Throws<InvalidOperationException>(() => isInt.Compile(useInterpreter));
        }

        [Theory, ClassData(typeof(CompilationTypes))]
        public void JumpInWithValue(CompilationType useInterpreter)
        {
            LabelTarget target = Expression.Label(typeof(int));
            Expression<Func<int>> exp = Expression.Lambda<Func<int>>(
                Expression.Block(
                Expression.Break(target, Expression.Constant(2)),
                Expression.Block(
                    Expression.Label(target, Expression.Constant(3)))
                )
            );
            Assert.Throws<InvalidOperationException>(() => exp.Compile(useInterpreter));
        }
    }
}
