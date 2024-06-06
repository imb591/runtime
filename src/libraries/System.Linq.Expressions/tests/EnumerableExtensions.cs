// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Collections.Generic;

namespace CompileToMethod.Tests;

public static class EnumerableExtensions
{
    public static List<object> ToList(this IEnumerable enumerable)
    {
        var result = new List<object>();
        var enumerator = enumerable.GetEnumerator();
        while (enumerator.MoveNext())
        {
            result.Add(enumerator.Current);
        }
        return result;
    }
}
