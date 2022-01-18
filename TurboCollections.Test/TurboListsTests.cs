using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TurboCollections.Test;

public class TurboListsTests
{
    public class CountTests
    {
        [Test]
        public void NewListIsEmpty()
        {
            var list = new TurboList<int>();
            Assert.Zero(list.Count);
        }
    }
    public class AddTests
    {
         [Test]
            public void AddingAnElementIncreasingCountToOne()
            {
                var list = new TurboList<int>();
                list.Add(5);
                Assert.AreEqual(1, list.Count);
            }
            [Test]
             public void DoubleListSizeAfterItGetsFull()
             {
                 var list = new TurboList<int>();
                 list.Add(1);
                 Console.WriteLine(list.Lenght);
                 Assert.AreEqual(1,list.Lenght);
                 list.Add(1);
                 Console.WriteLine(list.Lenght);
                 Assert.AreEqual(2,list.Lenght);
                 list.Add(1);
                 Console.WriteLine(list.Lenght);
                 Assert.AreEqual(4,list.Lenght);
                 list.Add(1);
                 Assert.AreEqual(4,list.Lenght);
                 list.Add(1);
                 Console.WriteLine(list.Lenght);
                 Assert.AreEqual(8,list.Lenght);
             }
    }

    public class GetTests
    {
        [Test]
        public void GetValueFiveAtIndex2()
        {
            var list = new TurboList<int>();
            list.Add(10);
            list.Add(2);
            list.Add(5);
            Assert.AreEqual(5,list.Get(2));
        }
    }

    public class SetTests
    {
        [Test]
            public void ExistingItemCanBeOverwrittenBySetting()
            {
                var list = new TurboList<int>();
                list.Add(10);
                list.Add(2);
                list.Add(5);
                list.Set(1, 6);
                Assert.AreEqual(6,list.Get(1));
        
            }
            [Test]
             public void ListExtendsWhenSetting()
             {
                 var list = new TurboList<int>();
                 list.Add(10);
                 list.Add(2);
                 list.Set(13,5);
                 Assert.AreEqual(14,list.Count);
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
    }

    public class ClearTests
    {
         [Test]
           public void ListIsEmptyAfterClear()
           {
               var list = new TurboList<int>();
               list.Add(10);
               list.Add(20);
               list.Clear();
               Assert.AreEqual(0,list.Count);
           }
           
    }

    public class RemoveAtTests
    {
        [Test]
            public void RemoveLetterTAtIndex1()
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
    }

    public class ContainsTests
    {
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

    public class IndexOfTests
    {
        [Test]
            public void IndexOf5Is3()
            {
                var list = new TurboList<int>();
                list.Add(100);
                list.Add(2);
                list.Add(1);
                list.Add(5);
                Assert.AreEqual(3, list.IndexOf(5));
            }
    }

    public class IndicesOfTests
    {
        [Test]
            public void AllIndicesOf5Is1And3()
            {
                var list = new TurboList<int>();
                list.Add(2);
                list.Add(5);
                list.Add(1);
                list.Add(5);
               // Assert.AreEqual(1, list.AllIndicesOf(5)[0]);
            }
    }

    public class RemoveTests
    {
        [Test]
            public void RemoveNumber1FromList()
            {
                var list = new TurboList<int>();
                list.Add(2);
                list.Add(5);
                list.Add(1);
                list.Add(5);
                list.Remove(1);
                Assert.AreEqual(false, list.Contains(1));
            }
    }

    public class AddRangeTests
    {
        [Test]
            public void SizeIncreasesByThree()
            {
                var list = new TurboList<int>();
                list.Add(100);
               // list.AddRange(100,20,500,30);
            }
    }

   

   

    
    

    

    

    

    

    

    
    
    

    

    

    
    
    

    


}