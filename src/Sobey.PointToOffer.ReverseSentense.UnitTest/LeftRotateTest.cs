using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.ReverseWords.UnitTest
{
    /// <summary>
    /// LeftRotateTest 的摘要说明
    /// </summary>
    [TestClass]
    public class LeftRotateTest
    {
        // 功能测试
        [TestCategory("LeftRotate")]
        [TestMethod]
        public void RotateTest1()
        {
            string input = "abcdefg";
            string actual = ReverseWordsHelper.LeftRotateString(input, 2
                );
            string expected = "cdefgab";

            Assert.AreEqual(actual, expected);
        }

        // 边界值测试
        [TestCategory("LeftRotate")]
        [TestMethod]
        public void RotateTest2()
        {
            string input = "abcdefg";
            string actual = ReverseWordsHelper.LeftRotateString(input, 1
                );
            string expected = "bcdefga";

            Assert.AreEqual(actual, expected);
        }

        // 边界值测试
        [TestCategory("LeftRotate")]
        [TestMethod]
        public void RotateTest3()
        {
            string input = "abcdefg";
            string actual = ReverseWordsHelper.LeftRotateString(input, 6
                );
            string expected = "gabcdef";

            Assert.AreEqual(actual, expected);
        }

        // 鲁棒性测试
        [TestCategory("LeftRotate")]
        [TestMethod]
        public void RotateTest4()
        {
            string actual = ReverseWordsHelper.LeftRotateString(null, 6
                );

            Assert.AreEqual(actual, null);
        }

        // 鲁棒性测试
        [TestCategory("LeftRotate")]
        [TestMethod]
        public void RotateTest5()
        {
            string input = "abcdefg";
            string actual = ReverseWordsHelper.LeftRotateString(input, 0
                );
            string expected = "abcdefg";

            Assert.AreEqual(actual, expected);
        }

        // 鲁棒性测试
        [TestCategory("LeftRotate")]
        [TestMethod]
        public void RotateTest6()
        {
            string input = "abcdefg";
            string actual = ReverseWordsHelper.LeftRotateString(input, 7
                );
            string expected = "abcdefg";

            Assert.AreEqual(actual, expected);
        }
    }
}
