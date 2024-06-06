using System;
using System.Collections.Generic;
using System.Linq.Expressions.Tests;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using Xunit;

namespace System.Linq.Expressions
{
    static class TestCompiler
    {
        public static T Compile<T>(this Expression<T> expression, CompilationType compilationType, bool withoutVisitor = false)
            where T : class, Delegate
        {
            return compilationType switch
            {
                CompilationType.Interpret => expression.Compile(preferInterpretation: true),
                CompilationType.Compile => expression.Compile(preferInterpretation: false),
                CompilationType.WithoutPreference => expression.Compile(),
                _ => throw new ArgumentOutOfRangeException(nameof(compilationType), compilationType, null),
            };
        }

        public static Delegate Compile(this LambdaExpression expression, CompilationType compilationType, bool withoutVisitor = false)
        {
            return compilationType switch
            {
                CompilationType.Interpret => expression.Compile(preferInterpretation: true),
                CompilationType.Compile => expression.Compile(preferInterpretation: false),
                CompilationType.WithoutPreference => expression.Compile(),
                _ => throw new ArgumentOutOfRangeException(nameof(compilationType), compilationType, null),
            };
        }
    }
}
