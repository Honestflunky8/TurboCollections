using NUnit.Framework;

namespace TurboStack.Test;

public class Tests
{
    public class WhenUsingCountTests
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
    }

    public class WhenUsingPeekTests
    {
        [Test]
            public void PeekingTwiceReturnsSameValue()
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
    }

    public class WhenUsingPopTests
    {
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
    }

    public class WhenUsingClearTests
    {
        [Test]
            public void StackBecomesEmpty()
            {
                var stack = new TurboStack<int>();
                stack.Push(10);
                stack.Push(20);
                stack.Clear();
                Assert.AreEqual(0,stack.Count);
            }
    }
}