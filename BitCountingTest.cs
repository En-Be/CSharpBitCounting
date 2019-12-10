using NUnit.Framework;
using System;

public class Tests
{
    [Test]
    public void OnlyAcceptsPositiveIntegerInput()
    {
        string input1 = "a";
        Assert.Throws<ArgumentException>(() => new BCounting(input1));
        string input2 = "1";
        Assert.DoesNotThrow(() => new BCounting(input2), "Input must be a positive integer");
        string input3 = "!";
        Assert.Throws<ArgumentException>(() => new BCounting(input3));
        string input4 = "1999292343";
        Assert.DoesNotThrow(() => new BCounting(input4), "Input must be a positive integer");
    }

    [Test]
    public void ReturnsAPositiveInteger()
    {
        string input1 = "89";
        BCounting bCounting = new BCounting(input1);
        Assert.IsInstanceOf<Int32>(bCounting.Result());
    }

    [Test]
    public void ResultsAreBinary()
    {
        string input1 = "89";
        BCounting bCounting = new BCounting(input1);
        Boolean result = ChecksIfBinary(bCounting.ToBinary());
        Assert.AreEqual(true, result);
    }

    public Boolean ChecksIfBinary(string arg)
    {
        string allowed = "01";
        foreach(char c in arg)
        {
            if(!allowed.Contains(c.ToString()))
            {
                return false;
            }
        }

        return true;
    }

    [Test]
    public void ConvertsInputToBinary()
    {
        string input1 = "6";
        BCounting bCounting1 = new BCounting(input1);
        Assert.AreEqual("110", bCounting1.ToBinary());

        string input2 = "93";
        BCounting bCounting2 = new BCounting(input2);
        Assert.AreEqual("1011101", bCounting2.ToBinary());

        string input3 = "198";
        BCounting bCounting3 = new BCounting(input3);
        Assert.AreEqual("11000110", bCounting3.ToBinary());

        string input4 = "375";
        BCounting bCounting4 = new BCounting(input4);
        Assert.AreEqual("101110111", bCounting4.ToBinary());
    }

    [Test]
    public void CountsTheOnes()
    {
        string input1 = "6";
        BCounting bCounting1 = new BCounting(input1);
        Assert.AreEqual(2, bCounting1.CountTheOnes());

        string input2 = "93";
        BCounting bCounting2 = new BCounting(input2);
        Assert.AreEqual(5, bCounting2.CountTheOnes());

        string input3 = "198";
        BCounting bCounting3 = new BCounting(input3);
        Assert.AreEqual(4, bCounting3.CountTheOnes());
    }

    
}
