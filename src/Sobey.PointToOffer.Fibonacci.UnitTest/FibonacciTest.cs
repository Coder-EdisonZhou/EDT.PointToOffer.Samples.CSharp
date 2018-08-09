using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.Fibonacci.UnitTest
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void FibonacciTest1()
        {
            Assert.AreEqual(FibonaaciHelper.FibonacciIteratively(0),0);
        }

        [TestMethod]
        public void FibonacciTest2()
        {
            Assert.AreEqual(FibonaaciHelper.FibonacciIteratively(1), 1);
        }

        [TestMethod]
        public void FibonacciTest3()
        {
            Assert.AreEqual(FibonaaciHelper.FibonacciIteratively(2), 1);
        }

        [TestMethod]
        public void FibonacciTest4()
        {
            Assert.AreEqual(FibonaaciHelper.FibonacciIteratively(3), 2);
        }

        [TestMethod]
        public void FibonacciTest5()
        {
            Assert.AreEqual(FibonaaciHelper.FibonacciIteratively(4), 3);
        }

        [TestMethod]
        public void FibonacciTest6()
        {
            Assert.AreEqual(FibonaaciHelper.FibonacciIteratively(5), 5);
        }

        [TestMethod]
        public void FibonacciTest7()
        {
            Assert.AreEqual(FibonaaciHelper.FibonacciIteratively(6), 8);
        }

        [TestMethod]
        public void FibonacciTest8()
        {
            Assert.AreEqual(FibonaaciHelper.FibonacciIteratively(7), 13);
        }

        [TestMethod]
        public void FibonacciTest9()
        {
            Assert.AreEqual(FibonaaciHelper.FibonacciIteratively(8), 21);
        }

        [TestMethod]
        public void FibonacciTest10()
        {
            Assert.AreEqual(FibonaaciHelper.FibonacciIteratively(9), 34);
        }

        [TestMethod]
        public void FibonacciTest11()
        {
            Assert.AreEqual(FibonaaciHelper.FibonacciIteratively(10), 55);
        }

        [TestMethod]
        public void FibonacciTest12()
        {
            Assert.AreEqual(FibonaaciHelper.FibonacciIteratively(40), 102334155);
        }
    }
}
