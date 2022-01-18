using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TurboCollections.Test;

public class TurboListsTests
{

    [Test]
    public void NewListIsEmpty()
    {
        var list = new TurboList<int>();
        Assert.Zero(list.Count);
    }

    [Test]
    public void AddingAnElementIncreasingCountToOne()
    {
        var list = new TurboList<int>();
        list.Add(5);
        Assert.AreEqual(1, list.Count);
    }

    [Test]
    public void GetValueFiveAtIndex2()
    {
        var list = new TurboList<int>();
        list.Add(10);
        list.Add(2);
        list.Add(5);
        Assert.AreEqual(5,list.Get(2));

    }

    [Test]
    public void ListIsEmptyAfterClear()
    {
        var list = new TurboList<int>();
        list.Add(10);
        list.Add(20);
        list.Clear();
        Assert.AreEqual(0,list.Count);
    }

    [Test]
    public void ContainsNumberFive()
    {
        var list = new TurboList<int>();
        list.Add(20);
        list.Add(111);
        list.Add(3);
        Assert.AreEqual(false,list.Contains(5));
    }

    [Test]
    public void RemoveLetterT()
    {
        var list = new TurboList<string>();
        list.Add("A");
        list.Add("T");
        list.Add("F");
        list.Add("C");
        list.RemoveAt(1);
        for (var i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list.Get(i));
        }
        Assert.AreEqual(false,list.Contains("T"));
    }

    [Test]
    public void MakeArraySmaller()
    {
        var list = new TurboList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.RemoveAt(1);
        for (var i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list.Get(i));
        }
        Assert.AreEqual(3,list.Count);
    }
    
    [Test]
    public void ContainsNumberThree()
    {
        var list = new TurboList<int>();
        list.Add(20);
        list.Add(111);
        list.Add(3);
        Assert.AreEqual(true,list.Contains(3));
    }

    [Test]
    public void CanReplaceValueThreeAtIndexFourWithEight()
    {
        var list = new TurboList<int>();
        list.Add(20);
        list.Add(111);
        list.Add(1);
        list.Add(3);
        list.Add(111);
        list.Add(2);
        list.Set(4, 8);
        Assert.AreEqual(8,list.Get(4));
    }

    [Test]
    public void SizeIncreasesByThree()
    {
        var list = new TurboList<int>();
        list.Add(100);
       /// list.AddRange(100,20,500,30);
    }


}