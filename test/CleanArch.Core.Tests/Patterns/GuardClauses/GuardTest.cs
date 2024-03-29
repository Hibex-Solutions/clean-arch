// Copyright (c) Hibex Solutions. All rights reserved.
// This file is a part of CleanArch.
// Licensed under the Apache version 2.0: LICENSE file.

using System.Linq;

using CleanArch.Core.Patterns.GuardClauses;

namespace CleanArch.Core.Tests.Patterns.GuardClauses;

[Trait("target", nameof(Guard))]
public class GuardTest
{
    [Fact(DisplayName = "NotNullArgument() reject null values")]
    public void NotNullArgument_RejectNull()
    {
        var exception = Assert.Throws<ArgumentNullException>(
            () => _ = Guard.NotNullArgument<object>(null, "value"));

        Assert.Equal("value", exception.ParamName);
    }

    [Fact(DisplayName = "NotNullArgument() accept not null values")]
    public void NotNullArgument_AcceptNotNull()
    {
        var value = Guard.NotNullArgument(new string("Initial value"), "value");

        Assert.IsType<string>(value);
    }

    [Fact(DisplayName = "NotNullArgument() returns same value")]
    public void NotNullArgument_ReturnsSameValue()
    {
        var value1 = Guard.NotNullArgument(new string("Initial value"), "value");
        var value2 = new object();
        var value2Copy = Guard.NotNullArgument(value2, "value2");

        Assert.Equal("Initial value", value1);
        Assert.Equal(value2.GetHashCode(), value2Copy.GetHashCode());
    }

    [Fact(DisplayName = "NotEmptyArgument() reject null value")]
    public void NotEmptyArgument_RejectNull()
    {
        var exception = Assert.Throws<ArgumentNullException>(
            () => _ = Guard.NotEmptyArgument<object[]>(null, "value"));

        Assert.Equal("value", exception.ParamName);
    }

    [Fact(DisplayName = "NotEmptyArgument() reject empty value collection")]
    public void NotEmptyArgument_RejectEmptyCollection()
    {
        var exception1 = Assert.Throws<ArgumentOutOfRangeException>(
            () => _ = Guard.NotEmptyArgument(Array.Empty<object>(), "value1"));

        var exception2 = Assert.Throws<ArgumentOutOfRangeException>(
            () => _ = Guard.NotEmptyArgument(Array.Empty<object>(), "value2"));

        var exception3 = Assert.Throws<ArgumentOutOfRangeException>(
            () => _ = Guard.NotEmptyArgument(Enumerable.Empty<string>(), "value3"));

        var exception4 = Assert.Throws<ArgumentOutOfRangeException>(
            () => _ = Guard.NotEmptyArgument(Enumerable.Empty<int>(), "value4"));

        Assert.Equal("value1", exception1.ParamName);
        Assert.Equal("value2", exception2.ParamName);
        Assert.Equal("value3", exception3.ParamName);
        Assert.Equal("value4", exception4.ParamName);
    }

    [Fact(DisplayName = "NotEmptyArgument() returns same value")]
    public void NotEmptyArgument_ReturnsSameValue()
    {
        var value1 = Guard.NotEmptyArgument(new string("Initial value"), "value");
        var value2 = new int[] { 1, 2, 3 };
        var value2Copy = Guard.NotEmptyArgument(value2, "value2");

        Assert.Equal("Initial value", value1);
        Assert.Equal(value2.GetHashCode(), value2Copy.GetHashCode());
    }
}