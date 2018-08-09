using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.NumberOf1InBinary.UnitTest
{
    [TestClass]
    public class BinaryHelperTest
    {
        // 输入0，期待的输出是0
        [TestMethod]
        public void NumberOfOneInBinaryTest1()
        {
            Assert.AreEqual(BinaryHelper.NumberOf1Solution2(0),0);
            Assert.AreEqual(BinaryHelper.NumberOf1Solution3(0),0);
        }

        // 输入1，期待的输出是1
        [TestMethod]
        public void NumberOfOneInBinaryTest2()
        {
            Assert.AreEqual(BinaryHelper.NumberOf1Solution2(1), 1);
            Assert.AreEqual(BinaryHelper.NumberOf1Solution3(1), 1);
        }

        // 输入10，期待的输出是2
        [TestMethod]
        public void NumberOfOneInBinaryTest3()
        {
            Assert.AreEqual(BinaryHelper.NumberOf1Solution2(10), 2);
            Assert.AreEqual(BinaryHelper.NumberOf1Solution3(10), 2);
        }

        // 输入0x7FFFFFFF，期待的输出是31
        [TestMethod]
        public void NumberOfOneInBinaryTest4()
        {
            Assert.AreEqual(BinaryHelper.NumberOf1Solution2(0x7FFFFFFF), 31);
            Assert.AreEqual(BinaryHelper.NumberOf1Solution3(0x7FFFFFFF), 31);
        }

        // 输入0xFFFFFFFF（负数），期待的输出是32
        [TestMethod]
        public void NumberOfOneInBinaryTest5()
        {
            Assert.AreEqual(BinaryHelper.NumberOf1Solution2(0xFFFFFFFF), 32);
            Assert.AreEqual(BinaryHelper.NumberOf1Solution3(0xFFFFFFFF), 32);
        }

        // 输入0x80000000（负数），期待的输出是1
        [TestMethod]
        public void NumberOfOneInBinaryTest6()
        {
            Assert.AreEqual(BinaryHelper.NumberOf1Solution2(0x80000000), 1);
            Assert.AreEqual(BinaryHelper.NumberOf1Solution3(0x80000000), 1);
        }
    }
}
