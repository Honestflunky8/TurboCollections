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
    public void ContainsNumberThree()
    {
        var list = new TurboList<int>();
        list.Add(20);
        list.Add(111);
        list.Add(3);
        Assert.AreEqual(true,list.Contains(3));
    }

    
}