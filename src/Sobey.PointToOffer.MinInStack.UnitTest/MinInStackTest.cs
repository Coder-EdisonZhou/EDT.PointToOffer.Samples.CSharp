using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.MinInStack.UnitTest
{
    [TestClass]
    public class MinInStackTest
    {
        [TestMethod]
        public void MinTest1()
        {
            MinInStack<int> stack = new MinInStack<int>();
            stack.Push(3);
            Assert.AreEqual(stack.Min(),3);
        }

        [TestMethod]
        public void MinTest2()
        {
            MinInStack<int> stack = new MinInStack<int>();
            stack.Push(3);
            stack.Push(4);
            Assert.AreEqual(stack.Min(), 3);
        }

        [TestMethod]
        public void MinTest3()
        {
            MinInStack<int> stack = new MinInStack<int>();
            stack.Push(3);
            stack.Push(4);
            stack.Push(2);
            Assert.AreEqual(stack.Min(), 2);
        }

        [TestMethod]
        public void MinTest4()
        {
            MinInStack<int> stack = new MinInStack<int>();
            stack.Push(3);
            stack.Push(4);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(stack.Min(), 2);
        }

        [TestMethod]
        public void MinTest5()
        {
            MinInStack<int> stack = new MinInStack<int>();
            stack.Push(3);
            stack.Push(4);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            Assert.AreEqual(stack.Min(), 2);
        }

        [TestMethod]
        public void MinTest6()
        {
            MinInStack<int> stack = new MinInStack<int>();
            stack.Push(3);
            stack.Push(4);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Pop();
            Assert.AreEqual(stack.Min(), 3);
        }

        [TestMethod]
        public void MinTest7()
        {
            MinInStack<int> stack = new MinInStack<int>();
            stack.Push(3);
            stack.Push(4);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Assert.AreEqual(stack.Min(), 3);
        }

        [TestMethod]
        public void MinTest8()
        {
            MinInStack<int> stack = new MinInStack<int>();
            stack.Push(3);
            stack.Push(4);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Push(0);
            Assert.AreEqual(stack.Min(), 0);
        }
    }
}
