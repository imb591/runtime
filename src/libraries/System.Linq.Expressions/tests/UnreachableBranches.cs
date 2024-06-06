// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Linq.Expressions.Tests;
using System.Reflection;
using System.Reflection.Emit;
using Xunit;

namespace CompileToMethod.Tests;

public class UnreachableBranches
{
    [Fact]
    public void UnreachableBranchesInHacks()
    {
        var assemblyTypes = typeof(ExpressionExtensions).Assembly.GetTypes();
        var param = Expression.Parameter(typeof(Expression));

        var assignBinaryExpression = assemblyTypes.First(x => x.Name == "AssignBinaryExpression");
        var convertToAbe = Expression.Lambda<Func<Expression, object>>(Expression.Convert(Expression.Convert(param, assignBinaryExpression), typeof(object)), param).Compile(CompilationType.Compile);
        var e = Assert.Throws<InvalidCastException>(() => convertToAbe(param));
        Assert.Equal($"Unable to cast object of type {param.GetType()} to type {assignBinaryExpression}", e.Message);
        e = Assert.Throws<InvalidCastException>(() => convertToAbe(null!));
        Assert.Equal($"Unable to cast object of type  to type {assignBinaryExpression}", e.Message);

        var blockExpressionExt = assemblyTypes.First(x => x.Name == "BlockExpressionExt");
        var convertToBee = Expression.Lambda<Func<Expression, object>>(Expression.Convert(Expression.Convert(param, blockExpressionExt), typeof(object)), param).Compile(CompilationType.Compile);
        e = Assert.Throws<InvalidCastException>(() => convertToBee(param));
        Assert.Equal($"Unable to cast object of type {param.GetType()} to type {blockExpressionExt}", e.Message);
        e = Assert.Throws<InvalidCastException>(() => convertToBee(null!));
        Assert.Equal($"Unable to cast object of type  to type {blockExpressionExt}", e.Message);

        var byRefAssignBinaryExpression = assemblyTypes.First(x => x.Name == "ByRefAssignBinaryExpression");
        var brabeInstance = (Expression)Activator.CreateInstance(byRefAssignBinaryExpression,
            BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[] { param, param }, null, null);
        Assert.Equal(param.Type, brabeInstance?.Type);

        var parameterExpressionExt = assemblyTypes.First(x => x.Name == "ParameterExpressionExt");
        var convertToPee = Expression.Lambda<Func<Expression, object>>(Expression.Convert(Expression.Convert(param, parameterExpressionExt), typeof(object)), param).Compile(CompilationType.Compile);
        var def = Expression.Default(typeof(int));
        e = Assert.Throws<InvalidCastException>(() => convertToPee(def));
        Assert.Equal($"Unable to cast object of type {def.GetType()} to type {parameterExpressionExt}", e.Message);
        e = Assert.Throws<InvalidCastException>(() => convertToPee(null!));
        Assert.Equal($"Unable to cast object of type  to type {parameterExpressionExt}", e.Message);

        var parameterListWrapper = blockExpressionExt.GetNestedType("ParameterListWrapper", BindingFlags.NonPublic);
        Assert.NotNull(parameterListWrapper);
        var peeArray = Array.CreateInstance(parameterExpressionExt, 1);
        peeArray.SetValue(convertToPee(param), 0);
        var plwInstance = (IEnumerable)Activator.CreateInstance(parameterListWrapper,
            BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[] { peeArray }, null, null);
        Assert.NotNull(plwInstance);
        Assert.Equal(new[] { param }, plwInstance.ToList());

        var parameterProviderExtensions = assemblyTypes.First(x => x.Name == "ParameterProviderExtensions");
        var ppeIndexOfMethod = parameterProviderExtensions.GetMethod("IndexOf");
        var lambda = Expression.Lambda(Expression.Empty(), Enumerable.Repeat(0, 33).Select(_ => Expression.Parameter(typeof(int))).ToArray());
        var ppeInstance = Activator.CreateInstance(parameterProviderExtensions, new object[] { lambda });
        Assert.Equal(-1, ppeIndexOfMethod!.Invoke(ppeInstance, new object[] { null }));

        var arrayBuilder = assemblyTypes.First(x => x.Name == "ArrayBuilder`1").MakeGenericType(typeof(object));
        var arrayBuilderCapacity = arrayBuilder.GetProperty("Capacity");
        var abInstance = Activator.CreateInstance(arrayBuilder, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance,
            null, new object[] { 1 }, null, null);
        Assert.Equal(1, arrayBuilderCapacity!.GetValue(abInstance));
        var abEmptyInstance = Activator.CreateInstance(arrayBuilder);
        Assert.Equal(0, arrayBuilderCapacity!.GetValue(abEmptyInstance));
    }

}
