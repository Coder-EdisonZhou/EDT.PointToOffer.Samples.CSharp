using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.MinNumberInRotatedArray.UnitTest
{
    [TestClass]
    public class MinNumUnitTest
    {
        // 典型输入，单调升序的数组的一个旋转
        [TestMethod]
        public void GetMinNumTest1()
        {
            int[] array = {3, 4, 5, 1, 2};
            Assert.AreEqual(Program.GetMin(array),1);
        }

        // 有重复数字，并且重复的数字刚好的最小的数字
        [TestMethod]
        public void GetMinNumTest2()
        {
            int[] array = { 3, 4, 5, 1, 1, 2 };
            Assert.AreEqual(Program.GetMin(array), 1);
        }

        // 有重复数字，但重复的数字不是第一个数字和最后一个数字
        [TestMethod]
        public void GetMinNumTest3()
        {
            int[] array = { 3, 4, 5, 1, 2, 2 };
            Assert.AreEqual(Program.GetMin(array), 1);
        }

        // 有重复的数字，并且重复的数字刚好是第一个数字和最后一个数字
        [TestMethod]
        public void GetMinNumTest4()
        {
            int[] array = { 1, 0, 1, 1, 1 };
            Assert.AreEqual(Program.GetMin(array), 0);
        }

        // 单调升序数组，旋转0个元素，也就是单调升序数组本身
        [TestMethod]
        public void GetMinNumTest5()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(Program.GetMin(array), 1);
        }

        // 数组中只有一个数字
        [TestMethod]
        public void GetMinNumTest6()
        {
            int[] array = { 2 };
            Assert.AreEqual(Program.GetMin(array), 2);
        }

        // 鲁棒性测试：输入NULL
        [TestMethod]
        public void GetMinNumTest7()
        {
            Assert.AreEqual(Program.GetMin(null), int.MinValue);
        }
    }
}
