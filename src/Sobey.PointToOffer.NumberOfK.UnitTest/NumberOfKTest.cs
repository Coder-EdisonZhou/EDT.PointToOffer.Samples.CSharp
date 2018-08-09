using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.NumberOfK.UnitTest
{
    [TestClass]
    public class NumberOfKTest
    {
        // 查找的数字出现在数组的中间
        [TestMethod]
        public void GetNumberTest1()
        {
            int[] data = { 1, 2, 3, 3, 3, 3, 4, 5 };
            int actual = NumberOfKHelper.GetNumberOfK(data, 3);
            Assert.AreEqual(actual, 4);
        }

        // 查找的数组出现在数组的开头
        [TestMethod]
        public void GetNumberTest2()
        {
            int[] data = { 3, 3, 3, 3, 4, 5 };
            int actual = NumberOfKHelper.GetNumberOfK(data, 3);
            Assert.AreEqual(actual, 4);
        }

        // 查找的数组出现在数组的结尾
        [TestMethod]
        public void GetNumberTest3()
        {
            int[] data = { 1, 2, 3, 3, 3, 3 };
            int actual = NumberOfKHelper.GetNumberOfK(data, 3);
            Assert.AreEqual(actual, 4);
        }

        // 查找的数字不存在
        [TestMethod]
        public void GetNumberTest4()
        {
            int[] data = { 1, 3, 3, 3, 3, 4, 5 };
            int actual = NumberOfKHelper.GetNumberOfK(data, 2);
            Assert.AreEqual(actual, 0);
        }

        // 查找的数字比第一个数字还小，不存在
        [TestMethod]
        public void GetNumberTest5()
        {
            int[] data = { 1, 3, 3, 3, 3, 4, 5 };
            int actual = NumberOfKHelper.GetNumberOfK(data, 0);
            Assert.AreEqual(actual, 0);
        }

        // 查找的数字比最后一个数字还大，不存在
        [TestMethod]
        public void GetNumberTest6()
        {
            int[] data = { 1, 3, 3, 3, 3, 4, 5 };
            int actual = NumberOfKHelper.GetNumberOfK(data, 6);
            Assert.AreEqual(actual, 0);
        }

        // 数组中的数字从头到尾都是查找的数字
        [TestMethod]
        public void GetNumberTest7()
        {
            int[] data = { 3, 3, 3, 3 };
            int actual = NumberOfKHelper.GetNumberOfK(data, 3);
            Assert.AreEqual(actual, 4);
        }

        // 数组中的数字从头到尾只有一个重复的数字，不是查找的数字
        [TestMethod]
        public void GetNumberTest8()
        {
            int[] data = { 3, 3, 3, 3 };
            int actual = NumberOfKHelper.GetNumberOfK(data, 4);
            Assert.AreEqual(actual, 0);
        }

        // 数组中只有一个数字，是查找的数字
        [TestMethod]
        public void GetNumberTest9()
        {
            int[] data = { 3 };
            int actual = NumberOfKHelper.GetNumberOfK(data, 3);
            Assert.AreEqual(actual, 1);
        }

        // 数组中只有一个数字，不是查找的数字
        [TestMethod]
        public void GetNumberTest10()
        {
            int[] data = { 3 };
            int actual = NumberOfKHelper.GetNumberOfK(data, 2);
            Assert.AreEqual(actual, 0);
        }

        // 鲁棒性测试，数组空指针
        [TestMethod]
        public void GetNumberTest11()
        {
            int actual = NumberOfKHelper.GetNumberOfK(null, 0);
            Assert.AreEqual(actual, 0);
        }
    }
}
