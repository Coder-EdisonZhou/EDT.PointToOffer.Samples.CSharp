using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.GreatestSumOfSubarrays.UnitTest
{
    [TestClass]
    public class GreatestNumTest
    {
        // 1, -2, 3, 10, -4, 7, 2, -5
        [TestMethod]
        public void GetGreatestNumTest1()
        {
            int[] data = { 1, -2, 3, 10, -4, 7, 2, -5 };
            bool isValid = true;
            int actual = SubArrayHelper.FindGreatestSumOfSubArray(data, out isValid);
            if (isValid)
            {
                Assert.AreEqual(actual, 18);
            }
            else
            {
                Assert.AreEqual(isValid, false);
            }
        }

        // 所有数字都是负数
        // -2, -8, -1, -5, -9
        [TestMethod]
        public void GetGreatestNumTest2()
        {
            int[] data = { -2, -8, -1, -5, -9 };
            bool isValid = true;
            int actual = SubArrayHelper.FindGreatestSumOfSubArray(data, out isValid);
            if (isValid)
            {
                Assert.AreEqual(actual, -1);
            }
            else
            {
                Assert.AreEqual(isValid, false);
            }
        }

        // 所有数字都是正数
        // 2, 8, 1, 5, 9
        [TestMethod]
        public void GetGreatestNumTest3()
        {
            int[] data = { 2, 8, 1, 5, 9 };
            bool isValid = true;
            int actual = SubArrayHelper.FindGreatestSumOfSubArray(data, out isValid);
            if (isValid)
            {
                Assert.AreEqual(actual, 25);
            }
            else
            {
                Assert.AreEqual(isValid, false);
            }
        }

        // 无效输入
        [TestMethod]
        public void GetGreatestNumTest4()
        {
            bool isValid = true;
            int actual = SubArrayHelper.FindGreatestSumOfSubArray(null, out isValid);
            if (isValid)
            {
                Assert.AreEqual(actual, 0);
            }
            else
            {
                Assert.AreEqual(isValid, false);
            }
        }
    }
}
