// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace System.Linq.Expressions.Tests
{
    public static class UnaryIsFalseTests
    {
        #region Test methods

        [Theory, ClassData(typeof(CompilationTypes))] //[WorkItem(3196, "https://github.com/dotnet/runtime/issues/15182")]
        public static void CheckUnaryIsFalseBoolTest(CompilationType useInterpreter)
        {
            bool[] values = new bool[] { false, true };
            for (int i = 0; i < values.Length; i++)
            {
                VerifyIsFalseBool(values[i], useInterpreter);
            }
        }

        [Fact]
        public static void ToStringTest()
        {
            UnaryExpression e = Expression.IsFalse(Expression.Parameter(typeof(bool), "x"));
            Assert.Equal("IsFalse(x)", e.ToString());
        }

        #endregion

        #region Test verifiers

        private static void VerifyIsFalseBool(bool value, CompilationType useInterpreter)
        {
            Expression<Func<bool>> e =
                Expression.Lambda<Func<bool>>(
                    Expression.IsFalse(Expression.Constant(value, typeof(bool))),
                    Enumerable.Empty<ParameterExpression>());
            Func<bool> f = e.Compile(useInterpreter);
            Assert.Equal((bool)(value == false), f());
        }

        #endregion

        public static IEnumerable<object[]> Truthinesses()
        {
            yield return new object[] { new Truthiness(true), false };
            yield return new object[] { new Truthiness(false), true };
        }

        [Theory, PerCompilationType(nameof(Truthinesses))]
        public static void VerifyMakeUnaryExplicitMethodIsFalseBool(Truthiness argument, bool expected, CompilationType useInterpreter)
        {
            Expression<Func<bool>> e =
                Expression.Lambda<Func<bool>>(
                    Expression.MakeUnary(
                        ExpressionType.IsFalse, Expression.Constant(argument), null, typeof(Truthiness).GetMethod("op_False")));
            Func<bool> f = e.Compile(useInterpreter);
            Assert.Equal(expected, f());
        }

        [Theory, PerCompilationType(nameof(Truthinesses))]
        public static void VerifyMakeUnaryDeduceMethodIsFalseBool(Truthiness argument, bool expected, CompilationType useInterpreter)
        {
            Expression<Func<bool>> e =
                Expression.Lambda<Func<bool>>(
                    Expression.MakeUnary(
                        ExpressionType.IsFalse, Expression.Constant(argument), null, null));
            Func<bool> f = e.Compile(useInterpreter);
            Assert.Equal(expected, f());
        }
    }
}
