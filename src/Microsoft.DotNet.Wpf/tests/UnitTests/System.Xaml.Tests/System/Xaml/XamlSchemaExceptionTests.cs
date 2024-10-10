// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Xunit;

namespace System.Xaml.Tests;

public class XamlSchemaExceptionTests
{
    [Fact]
    public void Ctor_Default()
    {
        var exception = new XamlSchemaException();
        Assert.NotEmpty(exception.Message);
        Assert.Null(exception.InnerException);
        Assert.Equal(0, exception.LineNumber);
        Assert.Equal(0, exception.LinePosition);
    }

    [Fact]
    public void Ctor_String()
    {
        var exception = new XamlSchemaException("message");
        Assert.Equal("message", exception.Message);
        Assert.Null(exception.InnerException);
        Assert.Equal(0, exception.LineNumber);
        Assert.Equal(0, exception.LinePosition);
    }

    public static IEnumerable<object?[]> Ctor_String_Exception_TestData()
    {
        yield return new object?[] { "message", null, 0, 0 };
        yield return new object?[] { "message", new DivideByZeroException(), 0, 0 };
        yield return new object?[] { "message", new XamlException("message", null, 1, 2), 1, 2 };
    }

    [Theory]
    [MemberData(nameof(Ctor_String_Exception_TestData))]
    public void Ctor_String_Exception(string message, Exception innerException, int expectedLineNumber, int expectedLinePosition)
    {
        var exception = new XamlSchemaException(message, innerException);
        Assert.Contains(message, exception.Message);
        Assert.Equal(innerException, exception.InnerException);
        Assert.Equal(expectedLineNumber, exception.LineNumber);
        Assert.Equal(expectedLinePosition, exception.LinePosition);
    }

#pragma warning disable SYSLIB0011, SYSLIB0051 // Type or member is obsolete
    [Fact]
    public void Ctor_NullSerializationInfo_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>("info", () => new SubXamlSchemaException(null!, new StreamingContext()));
    }

    [Fact]
    public void GetObjectData_NullInfo_ThrowsArgumentNullException()
    {
        var exception = new XamlSchemaException();
        Assert.Throws<ArgumentNullException>("info", () => exception.GetObjectData(null, new StreamingContext()));
    }
#pragma warning restore SYSLIB0011, SYSLIB0051 // Type or member is obsolete

    private class SubXamlSchemaException : XamlSchemaException
    {
        public SubXamlSchemaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
