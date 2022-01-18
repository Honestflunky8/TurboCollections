using NUnit.Framework;

namespace TurboStack.Test;

public class Tests
{
   

    [Test]
    public void CountOfStackIsFive()
    {
        var stack = new TurboStack<int>();
        stack.Push(1);
        stack.Push(1);
        stack.Push(1);
        stack.Push(1);
        stack.Push(1);
        
        
        Assert.AreEqual(5, stack.Count);
    }

    [Test]
    public void CanPeekTheSameValueTwice()
    {
        var stack = new TurboStack<int>();
        stack.Push(2);
        stack.Push(1);
        stack.Push(3);
        stack.Push(5);
        stack.Push(6);
        stack.Push(7);
        stack.Peek();
        stack.Peek();
        Assert.AreEqual(7,stack.Peek());
    }

    [Test]
    public void PoppingReturns3Then1()
    {
        var stack = new TurboStack<int>();
        stack.Push(2);
        stack.Push(1);
        stack.Push(3);
        Assert.AreEqual(3, stack.Pop());
        Assert.AreEqual(1,stack.Pop());
    }
    
    [Test]
    public void StackIsEmptyAfterClear()
    {
        var stack = new TurboStack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Clear();
        Assert.AreEqual(0,stack.Count);
    }
}