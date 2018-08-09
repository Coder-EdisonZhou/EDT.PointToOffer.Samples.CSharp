using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sobey.PointToOffer.QueueWithTwoStacks;

namespace Sobey.PointToOffer.QueueWithTwoStacks.UnitTest
{
    [TestClass]
    public class CQueueUnitTest
    {
        [TestMethod]
        public void CQueueTest1()
        {
            CQueue<char> queue = new CQueue<char>();
            queue.AppendTail('a');
            queue.AppendTail('b');
            queue.AppendTail('c');

            char head = queue.DeleteHead();
            Assert.AreEqual(head, 'a');
        }

        [TestMethod]
        public void CQueueTest2()
        {
            CQueue<char> queue = new CQueue<char>();
            queue.AppendTail('a');
            queue.AppendTail('b');
            queue.AppendTail('c');

            char head = queue.DeleteHead();
            head = queue.DeleteHead();

            Assert.AreEqual(head, 'b');
        }

        [TestMethod]
        public void CQueueTest3()
        {
            CQueue<char> queue = new CQueue<char>();
            queue.AppendTail('a');
            queue.AppendTail('b');
            queue.AppendTail('c');

            char head = queue.DeleteHead();
            head = queue.DeleteHead();

            queue.AppendTail('d');
            head = queue.DeleteHead();

            Assert.AreEqual(head, 'c');
        }

        [TestMethod]
        public void CQueueTest4()
        {
            CQueue<char> queue = new CQueue<char>();
            queue.AppendTail('a');
            queue.AppendTail('b');
            queue.AppendTail('c');

            char head = queue.DeleteHead();
            head = queue.DeleteHead();

            queue.AppendTail('d');
            head = queue.DeleteHead();

            queue.AppendTail('e');
            head = queue.DeleteHead();

            Assert.AreEqual(head, 'd');
        }

        [TestMethod]
        public void CQueueTest5()
        {
            CQueue<char> queue = new CQueue<char>();
            queue.AppendTail('a');
            queue.AppendTail('b');
            queue.AppendTail('c');

            char head = queue.DeleteHead();
            head = queue.DeleteHead();

            queue.AppendTail('d');
            head = queue.DeleteHead();

            queue.AppendTail('e');
            head = queue.DeleteHead();
            head = queue.DeleteHead();

            Assert.AreEqual(head, 'e');
        }

        [TestMethod]
        public void CQueueTest6()
        {
            CQueue<char> queue = new CQueue<char>();
            queue.AppendTail('a');
            queue.AppendTail('b');
            queue.AppendTail('c');

            char head = queue.DeleteHead();
            head = queue.DeleteHead();

            queue.AppendTail('d');
            head = queue.DeleteHead();

            queue.AppendTail('e');
            head = queue.DeleteHead();
            head = queue.DeleteHead();
            head = queue.DeleteHead();
        }
    }
}
