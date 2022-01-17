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

    
}