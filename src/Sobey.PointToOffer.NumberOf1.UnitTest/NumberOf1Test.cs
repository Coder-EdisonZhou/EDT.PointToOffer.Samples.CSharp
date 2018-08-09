using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.NumberOf1.UnitTest
{
    [TestClass]
    public class NumberOf1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            int actual = NumberHelper.NumberOf1Between1AndN(1);
            Assert.AreEqual(actual, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int actual = NumberHelper.NumberOf1Between1AndN(5);
            Assert.AreEqual(actual, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int actual = NumberHelper.NumberOf1Between1AndN(10);
            Assert.AreEqual(actual, 2);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int actual = NumberHelper.NumberOf1Between1AndN(55);
            Assert.AreEqual(actual, 16);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int actual = NumberHelper.NumberOf1Between1AndN(99);
            Assert.AreEqual(actual, 20);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int actual = NumberHelper.NumberOf1Between1AndN(10000);
            Assert.AreEqual(actual, 4001);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int actual = NumberHelper.NumberOf1Between1AndN(21345);
            Assert.AreEqual(actual, 18821);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int actual = NumberHelper.NumberOf1Between1AndN(0);
            Assert.AreEqual(actual, 0);
        }
    }
}
