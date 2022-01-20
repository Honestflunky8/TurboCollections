using NUnit.Framework;

namespace TurboCollections.Test;

[TestFixture]
public class TurboQueueTests
{
    public class WhenUsingCountTests
    {
        [Test]
        public void CountIs0WhenNewListIsMade()
        {
            var queue = new TurboQueue<int>();
            Assert.Zero(queue.Count);
        }
    }
    public class WhenUsingEnqueueTests
    {
        [Test]
        public void Adds5ToTheBackOfTheList()
        {
            var queue = new TurboQueue<int>();
            queue.Enqueue(5);
           // Assert.AreEqual(5,queue[]);
        }
    }
    public class WhenUsingPeekTests
    {
        [Test]
        public void ShowsButDoesNotRemoveThePeekedItem()
        {
            var queue = new TurboQueue<int>();
            queue.Enqueue(5);
            Assert.AreEqual(5,queue.Peek());
            Assert.AreEqual(5,queue.Peek());
        }
    }
    public class WhenUsingDequeueTests
    {
        [Test]
        public void ReturnsTheFirstItemOfTheQueue()
        {
            var queue = new TurboQueue<int>();
        }
    }
    public class WhenUsingClearTests
    {
        [Test]
        public void QueueBecomesEmpty()
        {
            var queue = new TurboQueue<int>();
        }
    }
}