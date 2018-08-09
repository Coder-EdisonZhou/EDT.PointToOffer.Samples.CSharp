using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.StackPushPopOrder.UnitTest
{
    [TestClass]
    public class StackOrderTest
    {
        [TestMethod]
        public void OrderTest1()
        {
            int length = 5;
            int[] push = { 1, 2, 3, 4, 5 };
            int[] pop = { 4, 5, 3, 2, 1 };

            Assert.AreEqual(StackHelper.IsPopOrder(push, pop, length), true);
        }

        [TestMethod]
        public void OrderTest2()
        {
            int length = 5;
            int[] push = { 1, 2, 3, 4, 5 };
            int[] pop = { 3, 5, 4, 2, 1 };

            Assert.AreEqual(StackHelper.IsPopOrder(push, pop, length), true);
        }

        [TestMethod]
        public void OrderTest3()
        {
            int length = 5;
            int[] push = { 1, 2, 3, 4, 5 };
            int[] pop = { 4, 3, 5, 1, 2 };

            Assert.AreEqual(StackHelper.IsPopOrder(push, pop, length), false);
        }

        [TestMethod]
        public void OrderTest4()
        {
            int length = 5;
            int[] push = { 1, 2, 3, 4, 5 };
            int[] pop = { 3, 5, 4, 1, 2 };

            Assert.AreEqual(StackHelper.IsPopOrder(push, pop, length), false);
        }

        // push和pop序列只有一个数字且不同
        [TestMethod]
        public void OrderTest5()
        {
            int length = 1;
            int[] push = { 1 };
            int[] pop = { 2 };

            Assert.AreEqual(StackHelper.IsPopOrder(push, pop, length), false);
        }

        // push和pop序列只有一个数字且相同
        [TestMethod]
        public void OrderTest6()
        {
            int length = 1;
            int[] push = { 1 };
            int[] pop = { 1 };

            Assert.AreEqual(StackHelper.IsPopOrder(push, pop, length), true);
        }

        // NULL指针
        [TestMethod]
        public void OrderTest7()
        {
            Assert.AreEqual(StackHelper.IsPopOrder(null, null, 0), false);
        }
    }
}
