// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Microsoft.DotNet.RemoteExecutor;
using Xunit;

namespace System.Linq.Expressions.Tests
{
    public static class CompilerTests
    {
        [Theory]
        [ClassData(typeof(CompilationTypes))]
        [OuterLoop("Takes over a minute to complete")]
        public static void CompileDeepTree_NoStackOverflow(CompilationType useInterpreter)
        {
            var e = (Expression)Expression.Constant(0);

            int n = 10000;

            for (var i = 0; i < n; i++)
                e = Expression.Add(e, Expression.Constant(1));

            Func<int> f = Expression.Lambda<Func<int>>(e).Compile(useInterpreter, withoutVisitor: true);

            Assert.Equal(n, f());
        }

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        public static void EmitConstantsToIL_NonNullableValueTypes()
        {
            VerifyEmitConstantsToIL((bool)true);

            VerifyEmitConstantsToIL((char)'a');

            VerifyEmitConstantsToIL((sbyte)42);
            VerifyEmitConstantsToIL((byte)42);
            VerifyEmitConstantsToIL((short)42);
            VerifyEmitConstantsToIL((ushort)42);
            VerifyEmitConstantsToIL((int)42);
            VerifyEmitConstantsToIL((uint)42);
            VerifyEmitConstantsToIL((long)42);
            VerifyEmitConstantsToIL((ulong)42);

            VerifyEmitConstantsToIL((float)3.14);
            VerifyEmitConstantsToIL((double)3.14);
            VerifyEmitConstantsToIL((decimal)49.95m);
        }

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        public static void EmitConstantsToIL_NullableValueTypes()
        {
            VerifyEmitConstantsToIL((bool?)null);
            VerifyEmitConstantsToIL((bool?)true);

            VerifyEmitConstantsToIL((char?)null);
            VerifyEmitConstantsToIL((char?)'a');

            VerifyEmitConstantsToIL((sbyte?)null);
            VerifyEmitConstantsToIL((sbyte?)42);
            VerifyEmitConstantsToIL((byte?)null);
            VerifyEmitConstantsToIL((byte?)42);
            VerifyEmitConstantsToIL((short?)null);
            VerifyEmitConstantsToIL((short?)42);
            VerifyEmitConstantsToIL((ushort?)null);
            VerifyEmitConstantsToIL((ushort?)42);
            VerifyEmitConstantsToIL((int?)null);
            VerifyEmitConstantsToIL((int?)42);
            VerifyEmitConstantsToIL((uint?)null);
            VerifyEmitConstantsToIL((uint?)42);
            VerifyEmitConstantsToIL((long?)null);
            VerifyEmitConstantsToIL((long?)42);
            VerifyEmitConstantsToIL((ulong?)null);
            VerifyEmitConstantsToIL((ulong?)42);

            VerifyEmitConstantsToIL((float?)null);
            VerifyEmitConstantsToIL((float?)3.14);
            VerifyEmitConstantsToIL((double?)null);
            VerifyEmitConstantsToIL((double?)3.14);
            VerifyEmitConstantsToIL((decimal?)null);
            VerifyEmitConstantsToIL((decimal?)49.95m);

            VerifyEmitConstantsToIL((DateTime?)null);
        }

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        public static void EmitConstantsToIL_ReferenceTypes()
        {
            VerifyEmitConstantsToIL((string)null);
            VerifyEmitConstantsToIL((string)"bar");
        }

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        public static void EmitConstantsToIL_Enums()
        {
            VerifyEmitConstantsToIL(ConstantsEnum.A);
            VerifyEmitConstantsToIL((ConstantsEnum?)null);
            VerifyEmitConstantsToIL((ConstantsEnum?)ConstantsEnum.A);
        }

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        public static void EmitConstantsToIL_ShareReferences()
        {
            var o = new object();
            VerifyEmitConstantsToIL(Expression.Equal(Expression.Constant(o), Expression.Constant(o)), 1, true);
        }

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        public static void EmitConstantsToIL_LiftedToClosure()
        {
            VerifyEmitConstantsToIL(DateTime.Now, 1);
            VerifyEmitConstantsToIL((DateTime?)DateTime.Now, 1);
        }

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        public static void VariableBinder_CatchBlock_Filter1()
        {
            // See https://github.com/dotnet/runtime/issues/18676 for reported issue

            Verify_VariableBinder_CatchBlock_Filter(
                Expression.Catch(
                    Expression.Parameter(typeof(Exception), "ex"),
                    Expression.Empty(),
                    Expression.Parameter(typeof(bool), "???")
                )
            );
        }

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        public static void VariableBinder_CatchBlock_Filter2()
        {
            // See https://github.com/dotnet/runtime/issues/18676 for reported issue

            Verify_VariableBinder_CatchBlock_Filter(
                Expression.Catch(
                    typeof(Exception),
                    Expression.Empty(),
                    Expression.Parameter(typeof(bool), "???")
                )
            );
        }

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        [ActiveIssue("https://github.com/mono/mono/issues/14919", TestRuntimes.Mono)]
        public static void VerifyIL_Simple()
        {
            Expression<Func<int>> f = () => Math.Abs(42);

            f.VerifyIL(
                @".method int32 ::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure)
                  {
                    .maxstack 1

                    IL_0000: ldc.i4.s   42
                    IL_0002: call       int32 class [System.Private.CoreLib]System.Math::Abs(int32)
                    IL_0007: ret
                  }");
        }

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        [ActiveIssue("https://github.com/mono/mono/issues/14919", TestRuntimes.Mono)]
        public static void VerifyIL_Exceptions()
        {
            ParameterExpression x = Expression.Parameter(typeof(int), "x");
            Expression<Func<int, int>> f =
                Expression.Lambda<Func<int, int>>(
                    Expression.TryCatchFinally(
                        Expression.Call(
                            typeof(Math).GetMethod(nameof(Math.Abs), new[] { typeof(int) }),
                            Expression.Divide(
                                Expression.Constant(42),
                                x
                            )
                        ),
                        Expression.Empty(),
                        Expression.Catch(
                            typeof(DivideByZeroException),
                            Expression.Constant(-1)
                        )
                    ),
                    x
                );

            f.VerifyIL(
                @".method int32 ::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure,int32)
                  {
                    .maxstack 2
                    .locals init (
                      [0] int32
                    )

                    .try
                    {
                      .try
                      {
                        IL_0000: ldc.i4.s   42
                        IL_0002: ldarg.1
                        IL_0003: div
                        IL_0004: call       int32 class [System.Private.CoreLib]System.Math::Abs(int32)
                        IL_0009: stloc.0
                        IL_000a: leave      IL_0017
                      }
                      catch (class [System.Private.CoreLib]System.DivideByZeroException)
                      {
                        IL_000f: pop
                        IL_0010: ldc.i4.m1
                        IL_0011: stloc.0
                        IL_0012: leave      IL_0017
                      }
                      IL_0017: leave      IL_001d
                    }
                    finally
                    {
                      IL_001c: endfinally
                    }
                    IL_001d: ldloc.0
                    IL_001e: ret
                  }");
        }

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        [ActiveIssue("https://github.com/mono/mono/issues/14919", TestRuntimes.Mono)]
        public static void VerifyIL_Closure1()
        {
            Expression<Func<Func<int>>> f = () => () => 42;

            f.VerifyIL(
                @".method class [System.Private.CoreLib]System.Func`1<int32> ::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure)
                  {
                    .maxstack 3

                    IL_0000: ldarg.0
                    IL_0001: ldfld      class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure::Constants
                    IL_0006: ldc.i4.0
                    IL_0007: ldelem.ref
                    IL_0008: castclass  class [System.Private.CoreLib]System.Reflection.MethodInfo
                    IL_000d: ldtoken    class [System.Private.CoreLib]System.Func`1<int32>
                    IL_0012: call       class [System.Private.CoreLib]System.Type class [System.Private.CoreLib]System.Type::GetTypeFromHandle(valuetype [System.Private.CoreLib]System.RuntimeTypeHandle)
                    IL_0017: ldnull
                    IL_0018: callvirt   instance class [System.Private.CoreLib]System.Delegate class [System.Private.CoreLib]System.Reflection.MethodInfo::CreateDelegate(class [System.Private.CoreLib]System.Type,object)
                    IL_001d: castclass  class [System.Private.CoreLib]System.Func`1<int32>
                    IL_0022: ret
                  }

                  // closure.Constants[0]
                  .method int32 ::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure)
                  {
                    .maxstack 1

                    IL_0000: ldc.i4.s   42
                    IL_0002: ret
                  }",
                methodBuilderExpected: @".method class [System.Private.CoreLib]System.Func`1<int32> ::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure)
                  {
                      .maxstack 3

                      IL_0000: ldnull
                      IL_0001: ldftn      int32 class [CompiledExpressionsVerifyIL_Closure1]VerifyIL_Closure1::lambda_method()
                      IL_0007: newobj     instance void class [System.Private.CoreLib]System.Func`1<int32>::.ctor(object,native int)
                      IL_000c: ret
                  }

                  .method int32 class [CompiledExpressionsVerifyIL_Closure1]VerifyIL_Closure1::lambda_method()
                  {
                      .maxstack 1

                      IL_0000: ldc.i4.s   42
                      IL_0002: ret
                  }",
                appendInnerLambdas: true);
        }

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        [ActiveIssue("https://github.com/mono/mono/issues/14919", TestRuntimes.Mono)]
        public static void VerifyIL_Closure2()
        {
            Expression<Func<int, Func<int>>> f = x => () => x;

            f.VerifyIL(
                @".method class [System.Private.CoreLib]System.Func`1<int32> ::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure,int32)
                  {
                    .maxstack 8
                    .locals init (
                      [0] object[]
                    )

                    IL_0000: ldc.i4.1
                    IL_0001: newarr     object
                    IL_0006: dup
                    IL_0007: ldc.i4.0
                    IL_0008: ldarg.1
                    IL_0009: newobj     instance void class [System.Private.CoreLib]System.Runtime.CompilerServices.StrongBox`1<int32>::.ctor(int32)
                    IL_000e: stelem.ref
                    IL_000f: stloc.0
                    IL_0010: ldarg.0
                    IL_0011: ldfld      class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure::Constants
                    IL_0016: ldc.i4.0
                    IL_0017: ldelem.ref
                    IL_0018: castclass  class [System.Private.CoreLib]System.Reflection.MethodInfo
                    IL_001d: ldtoken    class [System.Private.CoreLib]System.Func`1<int32>
                    IL_0022: call       class [System.Private.CoreLib]System.Type class [System.Private.CoreLib]System.Type::GetTypeFromHandle(valuetype [System.Private.CoreLib]System.RuntimeTypeHandle)
                    IL_0027: ldnull
                    IL_0028: ldloc.0
                    IL_0029: newobj     instance void class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure::.ctor(object[],object[])
                    IL_002e: callvirt   instance class [System.Private.CoreLib]System.Delegate class [System.Private.CoreLib]System.Reflection.MethodInfo::CreateDelegate(class [System.Private.CoreLib]System.Type,object)
                    IL_0033: castclass  class [System.Private.CoreLib]System.Func`1<int32>
                    IL_0038: ret
                  }

                  // closure.Constants[0]
                  .method int32 ::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure)
                  {
                    .maxstack 2
                    .locals init (
                      [0] object[]
                    )

                    IL_0000: ldarg.0
                    IL_0001: ldfld      class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure::Locals
                    IL_0006: stloc.0
                    IL_0007: ldloc.0
                    IL_0008: ldc.i4.0
                    IL_0009: ldelem.ref
                    IL_000a: castclass  class [System.Private.CoreLib]System.Runtime.CompilerServices.StrongBox`1<int32>
                    IL_000f: ldfld      class [System.Private.CoreLib]System.Runtime.CompilerServices.StrongBox`1<int32>::Value
                    IL_0014: ret
                  }",
                methodBuilderExpected: @".method class [System.Private.CoreLib]System.Func`1<int32> ::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure,int32)
                  {
                      .maxstack 5
                      .locals init (
                        [0] object[]
                      )

                      IL_0000: ldc.i4.1
                      IL_0001: newarr     object
                      IL_0006: dup
                      IL_0007: ldc.i4.0
                      IL_0008: ldarg.0
                      IL_0009: newobj     instance void class [System.Private.CoreLib]System.Runtime.CompilerServices.StrongBox`1<int32>::.ctor(int32)
                      IL_000e: stelem.ref
                      IL_000f: stloc.0
                      IL_0010: ldloc.0
                      IL_0011: newobj     instance void class [CompileToMethod]System.Runtime.CompilerServices.CTM_Closure::.ctor(object[])
                      IL_0016: ldftn      int32 class [CompiledExpressionsVerifyIL_Closure2]VerifyIL_Closure2::lambda_method(class [CompileToMethod]System.Runtime.CompilerServices.CTM_Closure)
                      IL_001c: newobj     instance void class [System.Private.CoreLib]System.Func`1<int32>::.ctor(object,native int)
                      IL_0021: ret
                  }

                  .method int32 class [CompiledExpressionsVerifyIL_Closure2]VerifyIL_Closure2::lambda_method(class [CompileToMethod]System.Runtime.CompilerServices.CTM_Closure)
                  {
                      .maxstack 2
                      .locals init (
                        [0] object[]
                      )

                      IL_0000: ldarg.0
                      IL_0001: ldfld      class [CompileToMethod]System.Runtime.CompilerServices.CTM_Closure::Locals
                      IL_0006: stloc.0
                      IL_0007: ldloc.0
                      IL_0008: ldc.i4.0
                      IL_0009: ldelem.ref
                      IL_000a: castclass  class [System.Private.CoreLib]System.Runtime.CompilerServices.StrongBox`1<int32>
                      IL_000f: ldfld      class [System.Private.CoreLib]System.Runtime.CompilerServices.StrongBox`1<int32>::Value
                      IL_0014: ret
                  }",
                appendInnerLambdas: true);
        }

        [ConditionalFact(typeof(PlatformDetection), nameof(PlatformDetection.IsNotLinqExpressionsBuiltWithIsInterpretingOnly))]
        [ActiveIssue("https://github.com/mono/mono/issues/14919", TestRuntimes.Mono)]
        public static void VerifyIL_Closure3()
        {
            // Using an unchecked addition to ensure that an add instruction is emitted (and not add.ovf)
            Expression<Func<int, Func<int, int>>> f = x => y => unchecked(x + y);

            f.VerifyIL(
                @".method class [System.Private.CoreLib]System.Func`2<int32,int32> ::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure,int32)
                  {
                    .maxstack 8
                    .locals init (
                      [0] object[]
                    )

                    IL_0000: ldc.i4.1
                    IL_0001: newarr     object
                    IL_0006: dup
                    IL_0007: ldc.i4.0
                    IL_0008: ldarg.1
                    IL_0009: newobj     instance void class [System.Private.CoreLib]System.Runtime.CompilerServices.StrongBox`1<int32>::.ctor(int32)
                    IL_000e: stelem.ref
                    IL_000f: stloc.0
                    IL_0010: ldarg.0
                    IL_0011: ldfld      class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure::Constants
                    IL_0016: ldc.i4.0
                    IL_0017: ldelem.ref
                    IL_0018: castclass  class [System.Private.CoreLib]System.Reflection.MethodInfo
                    IL_001d: ldtoken    class [System.Private.CoreLib]System.Func`2<int32,int32>
                    IL_0022: call       class [System.Private.CoreLib]System.Type class [System.Private.CoreLib]System.Type::GetTypeFromHandle(valuetype [System.Private.CoreLib]System.RuntimeTypeHandle)
                    IL_0027: ldnull
                    IL_0028: ldloc.0
                    IL_0029: newobj     instance void class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure::.ctor(object[],object[])
                    IL_002e: callvirt   instance class [System.Private.CoreLib]System.Delegate class [System.Private.CoreLib]System.Reflection.MethodInfo::CreateDelegate(class [System.Private.CoreLib]System.Type,object)
                    IL_0033: castclass  class [System.Private.CoreLib]System.Func`2<int32,int32>
                    IL_0038: ret
                  }

                  // closure.Constants[0]
                  .method int32 ::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure,int32)
                  {
                    .maxstack 2
                    .locals init (
                      [0] object[]
                    )

                    IL_0000: ldarg.0
                    IL_0001: ldfld      class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure::Locals
                    IL_0006: stloc.0
                    IL_0007: ldloc.0
                    IL_0008: ldc.i4.0
                    IL_0009: ldelem.ref
                    IL_000a: castclass  class [System.Private.CoreLib]System.Runtime.CompilerServices.StrongBox`1<int32>
                    IL_000f: ldfld      class [System.Private.CoreLib]System.Runtime.CompilerServices.StrongBox`1<int32>::Value
                    IL_0014: ldarg.1
                    IL_0015: add
                    IL_0016: ret
                  }",
                methodBuilderExpected: @".method class [System.Private.CoreLib]System.Func`2<int32,int32> ::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure,int32)
                  {
                      .maxstack 5
                      .locals init (
                        [0] object[]
                      )

                      IL_0000: ldc.i4.1
                      IL_0001: newarr     object
                      IL_0006: dup
                      IL_0007: ldc.i4.0
                      IL_0008: ldarg.0
                      IL_0009: newobj     instance void class [System.Private.CoreLib]System.Runtime.CompilerServices.StrongBox`1<int32>::.ctor(int32)
                      IL_000e: stelem.ref
                      IL_000f: stloc.0
                      IL_0010: ldloc.0
                      IL_0011: newobj     instance void class [CompileToMethod]System.Runtime.CompilerServices.CTM_Closure::.ctor(object[])
                      IL_0016: ldftn      int32 class [CompiledExpressionsVerifyIL_Closure3]VerifyIL_Closure3::lambda_method(class [CompileToMethod]System.Runtime.CompilerServices.CTM_Closure,int32)
                      IL_001c: newobj     instance void class [System.Private.CoreLib]System.Func`2<int32,int32>::.ctor(object,native int)
                      IL_0021: ret
                  }

                  .method int32 class [CompiledExpressionsVerifyIL_Closure3]VerifyIL_Closure3::lambda_method(class [CompileToMethod]System.Runtime.CompilerServices.CTM_Closure,int32)
                  {
                      .maxstack 2
                      .locals init (
                        [0] object[]
                      )

                      IL_0000: ldarg.0
                      IL_0001: ldfld      class [CompileToMethod]System.Runtime.CompilerServices.CTM_Closure::Locals
                      IL_0006: stloc.0
                      IL_0007: ldloc.0
                      IL_0008: ldc.i4.0
                      IL_0009: ldelem.ref
                      IL_000a: castclass  class [System.Private.CoreLib]System.Runtime.CompilerServices.StrongBox`1<int32>
                      IL_000f: ldfld      class [System.Private.CoreLib]System.Runtime.CompilerServices.StrongBox`1<int32>::Value
                      IL_0014: ldarg.1
                      IL_0015: add
                      IL_0016: ret
                  }",
                appendInnerLambdas: true);
        }

        internal static void VerifyIL(this LambdaExpression expression, string expected, bool appendInnerLambdas = false, string methodBuilderExpected = null, [CallerMemberName]string className = null)
        {
            VerifyDynamicMethodIL(expression, expected, appendInnerLambdas);
            VerifyMethodBuilderIL(expression, methodBuilderExpected ?? expected, appendInnerLambdas, className);
        }

        internal static void VerifyDynamicMethodIL(this LambdaExpression expression, string expected, bool appendInnerLambdas = false)
        {
            string actual = expression.GetIL(appendInnerLambdas);

            string nExpected = Normalize(expected);
            string nActual = Normalize(actual);

            Assert.Equal(nExpected, nActual);
        }

        internal static void VerifyMethodBuilderIL(this LambdaExpression expression, string expected, bool appendInnerLambdas = false, [CallerMemberName]string className = null)
        {
            string actual = expression.GetMethodBuilderIL(className, appendInnerLambdas);

            string nExpected = Normalize(expected);
            nExpected = TransformToMethodBuilder(nExpected, className);
            string nActual = Normalize(actual);
            nExpected = Regex.Replace(nExpected, @"<ExpressionCompilerImplementationDetails>\{\d+\}", "");
            nActual = Regex.Replace(nActual, @"<ExpressionCompilerImplementationDetails>\{\d+\}", "");
            nExpected = Regex.Replace(nExpected, @"\.maxstack \d+", "");
            nActual = Regex.Replace(nActual, @"\.maxstack \d+", "");

            try
            {
                Assert.Equal(nExpected, nActual);
            }
            catch (Exception xunit)
            {
                throw new Exception($"IL assertion failed. Expected (normalized):\n{nExpected}\n\nActual:\n{actual}", xunit);
            }
        }

        private static readonly Regex s_instruction = new Regex(@"IL_([0-9a-f]{4}): (\S+(?:\s+V_(\d+))?)", RegexOptions.Compiled);
        private static readonly Regex s_instructionSecondPass = new Regex(@"IL_(?:[0-9a-f]{4}): (?:\S+)(?:\s+IL_([0-9a-f]{4}))?", RegexOptions.Compiled);

        private static string TransformToMethodBuilder(string nExpected, string className)
        {
            nExpected = nExpected
                .Replace(
                    "::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure,",
                    "class [" + TestCompiler.AssemblyName(className) + "]" + className + "::M(");
            nExpected = nExpected
                .Replace(
                    "::lambda_method(class [System.Linq.Expressions]System.Runtime.CompilerServices.Closure",
                    "class [" + TestCompiler.AssemblyName(className) + "]" + className + "::M(");
            nExpected = nExpected
                .Replace(
                    "class [System.Linq.Expressions]System.Runtime.CompilerServices.RuntimeOps",
                    $"class [CompileToMethod]{typeof(CTM_RuntimeOps).FullName}");
            int currentOffset = 0;
            bool innerMethod = false;
            var addressChanges = new Dictionary<int, int>();
            nExpected = s_instruction.Replace(nExpected, match =>
            {
                string result = match.Groups[0].Value;
                if (innerMethod)
                {
                    return result;
                }
                int address = int.Parse(match.Groups[1].Value, NumberStyles.HexNumber);
                string instruction = match.Groups[2].Value;
                if (instruction.StartsWith("ldarg "))
                {
                    int argumentIndex = int.Parse(match.Groups[3].Value);
                    result = $"IL_{IlOffset()}: ldarg      V_{argumentIndex - 1}";
                }
                else if (instruction.StartsWith("ldarga "))
                {
                    int argumentIndex = int.Parse(match.Groups[3].Value);
                    result = $"IL_{IlOffset()}: ldarga     V_{argumentIndex - 1}";
                }
                else if (instruction.StartsWith("ldarg.s"))
                {
                    int argumentIndex = int.Parse(match.Groups[3].Value);
                    if (argumentIndex == 4)
                    {
                        result = $"IL_{IlOffset()}: ldarg.3";
                        currentOffset -= 1;
                    }
                    else
                    {
                        result = $"IL_{IlOffset()}: ldarg.s    V_{argumentIndex - 1}";
                    }
                }
                else if (instruction.StartsWith("ldarga.s"))
                {
                    int argumentIndex = int.Parse(match.Groups[3].Value);
                    if (argumentIndex == 4)
                    {
                        result = $"IL_{IlOffset()}: ldarga.3";
                        currentOffset -= 1;
                    }
                    else
                    {
                        result = $"IL_{IlOffset()}: ldarga.s   V_{argumentIndex - 1}";
                    }
                }
                else if (instruction.StartsWith("ldarg."))
                {
                    int argumentIndex = int.Parse(instruction.Substring("ldarg.".Length));
                    if (argumentIndex > 0)
                    {
                        result = $"IL_{IlOffset()}: ldarg.{argumentIndex - 1}";
                    }
                    else
                    {
                        innerMethod = true;
                    }
                }
                else if (instruction.StartsWith("ldarga."))
                {
                    int argumentIndex = int.Parse(instruction.Substring("ldarga.".Length));
                    result = $"IL_{IlOffset()}: ldarga.{argumentIndex - 1}";
                }
                else if (currentOffset != 0)
                {
                    result = $"IL_{(IlOffset())}: {instruction}";
                }

                if (currentOffset != 0)
                {
                    addressChanges[address] = address + currentOffset;
                }
                return result;

                string IlOffset() => (address + currentOffset).ToString("x4");
            });
            nExpected = s_instructionSecondPass.Replace(nExpected, match =>
            {
                string result = match.Groups[0].Value;
                if (match.Groups[1].Value != string.Empty)
                {
                    int jumpAddress = int.Parse(match.Groups[1].Value, NumberStyles.HexNumber);
                    if (addressChanges.TryGetValue(jumpAddress, out int newJumpAddress))
                    {
                        result = result.Replace(" IL_" + match.Groups[1].Value, " IL_" + newJumpAddress.ToString("x4"));
                    }
                }
                return result;
            });

            return nExpected;
        }

        private static string Normalize(string s)
        {
            var normalizeRegex = new Regex(@"lambda_method[0-9]*");

            Collections.Generic.IEnumerable<string> lines =
                s
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .Where(line => !line.StartsWith("//"))
                .Select(beforeLambdaUniquifierRemoval => normalizeRegex.Replace(beforeLambdaUniquifierRemoval, "lambda_method"));

            return string.Join("\n", lines);
        }

        private static void VerifyEmitConstantsToIL<T>(T value)
        {
            VerifyEmitConstantsToIL<T>(value, 0);
        }

        private static void VerifyEmitConstantsToIL<T>(T value, int expectedCount)
        {
            VerifyEmitConstantsToIL(Expression.Constant(value, typeof(T)), expectedCount, value);
        }

        private static void VerifyEmitConstantsToIL(Expression e, int expectedCount, object expectedValue)
        {
            Delegate f = Expression.Lambda(e).Compile(CompilationType.Compile);

            var c = f.Target;
            Assert.NotNull(c);
            Assert.Equal(expectedCount, ((dynamic)c).Constants.Length);

            object o = f.DynamicInvoke();
            Assert.Equal(expectedValue, o);

            f = Expression.Lambda(e).Compile(CompilationType.CompileToMethod);

            o = f.DynamicInvoke();
            Assert.Equal(expectedValue, o);
        }

        private static void Verify_VariableBinder_CatchBlock_Filter(CatchBlock @catch)
        {
            Expression<Action> e =
                Expression.Lambda<Action>(
                    Expression.TryCatch(
                        Expression.Empty(),
                        @catch
                    )
                );

            Assert.Throws<InvalidOperationException>(() => e.Compile(CompilationType.Compile));
            Assert.Throws<InvalidOperationException>(() => e.Compile(CompilationType.CompileToMethod));
        }

        /// <summary>
        /// Verifies that compiling and executing a lambda method works when IsDynamicCodeSupported == false.
        /// </summary>
        [ConditionalFact(typeof(RemoteExecutor), nameof(RemoteExecutor.IsSupported), Skip = "no call to CompileToMethod")]
        public static void CompileWorksWhenDynamicCodeNotSupported()
        {
            RemoteInvokeOptions options = new RemoteInvokeOptions();
            options.RuntimeConfigurationOptions.Add("System.Runtime.CompilerServices.RuntimeFeature.IsDynamicCodeSupported", false.ToString());

            using RemoteInvokeHandle remoteHandle = RemoteExecutor.Invoke(static () =>
            {
                CompileWorksWhenDynamicCodeNotSupportedInner();
            }, options);
        }

        // run the same test code as the above CompileWorksWhenDynamicCodeNotSupported test
        // to ensure this test works correctly on all platforms - even if RemoteExecutor is not supported
        [Fact(Skip = "no call to CompileToMethod")]
        public static void CompileWorksWhenDynamicCodeNotSupportedInner()
        {
            ParameterExpression param = Expression.Parameter(typeof(int));

            Func<int, int> typedDel =
                Expression.Lambda<Func<int, int>>(Expression.Add(param, Expression.Constant(4)), param).Compile(CompilationType.WithoutPreference);
            Assert.Equal(304, typedDel(300));

            Delegate del =
                Expression.Lambda(Expression.Add(param, Expression.Constant(5)), param).Compile(CompilationType.WithoutPreference);
            Assert.Equal(305, del.DynamicInvoke(300));

            // testing more than 2 parameters is important because because it follows a different code path in Compile.
            Expression<Func<int, int, int, int, int, int>> fiveParameterExpression = (a, b, c, d, e) => a + b + c + d + e;
            Func<int, int, int, int, int, int> fiveParameterFunc = fiveParameterExpression.Compile(CompilationType.WithoutPreference);
            Assert.Equal(6, fiveParameterFunc(2, 2, 1, 1, 0));

            Expression<Func<int, int, int>> callExpression = (a, b) => Add(a, b);
            Func<int, int, int> callFunc = callExpression.Compile(CompilationType.WithoutPreference);
            Assert.Equal(29, callFunc(20, 9));

            MethodCallExpression methodCallExpression = Expression.Call(
                instance: null,
                typeof(CompilerTests).GetMethod("Add4", BindingFlags.NonPublic | BindingFlags.Static),
                Expression.Constant(5), Expression.Constant(6), Expression.Constant(7), Expression.Constant(8));

            Func<int> methodCallDelegate = Expression.Lambda<Func<int>>(methodCallExpression).Compile(CompilationType.WithoutPreference);
            Assert.Equal(26, methodCallDelegate());
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static int Add4(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }

    public enum ConstantsEnum
    {
        A
    }
}
