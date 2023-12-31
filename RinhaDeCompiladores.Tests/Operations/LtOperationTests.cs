﻿using RinhaDeCompiladores.Operations;

namespace RinhaDeCompiladores.Tests.Operations;

public class LtOperationTests
{
    [Fact]
    public void Lt_FirstNumberLessThanSecondNumber()
    {
        var operation = new LtOperation();

        var result = operation.Execute("1", "5");

        Assert.True(result);
    }

    [Fact]
    public void Lt_FirstNumberIsEqualThanSecondNumber()
    {
        var operation = new LtOperation();

        var result = operation.Execute("5", "5");

        Assert.False(result);
    }

    [Fact]
    public void Lt_SecondNumberLessThanFirstNumber()
    {
        var operation = new LtOperation();

        var result = operation.Execute("5", "1");

        Assert.False(result);
    }
    [Fact]
    public void Lt_OneNumberAndOneLetter()
    {
        var operation = new LtOperation();

        Assert.Throws<InvalidOperationException>(() => operation.Execute("1", "a"));
    }
}
