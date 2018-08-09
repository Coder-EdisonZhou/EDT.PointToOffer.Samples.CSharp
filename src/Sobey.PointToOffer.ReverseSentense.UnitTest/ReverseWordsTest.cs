using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.ReverseWords.UnitTest
{
    [TestClass]
    public class ReverseWordsTest
    {
        // 功能测试，句子中有多个单词
        [TestCategory("ReverseWords")]
        [TestMethod]
        public void ReverseTest1()
        {
            string input = "I am a student.";
            string actual = ReverseWordsHelper.ReverseSentense(input);
            string expected = "student. a am I";

            Assert.AreEqual(actual, expected);
        }

        // 功能测试，句子中只有一个单词
        [TestCategory("ReverseWords")]
        [TestMethod]
        public void ReverseTest2()
        {
            string input = "Wonderful";
            string actual = ReverseWordsHelper.ReverseSentense(input);
            string expected = "Wonderful";

            Assert.AreEqual(actual, expected);
        }

        // 边界值测试，测试空字符串
        [TestCategory("ReverseWords")]
        [TestMethod]
        public void ReverseTest3()
        {
            string input = "";
            string actual = ReverseWordsHelper.ReverseSentense(input);

            Assert.AreEqual(actual, null);
        }

        // 边界值测试，字符串中只有空格
        [TestCategory("ReverseWords")]
        [TestMethod]
        public void ReverseTest4()
        {
            string input = "   ";
            string actual = ReverseWordsHelper.ReverseSentense(input);
            string expected = "   ";

            Assert.AreEqual(actual, expected);
        }

        // 鲁棒性测试
        [TestCategory("ReverseWords")]
        [TestMethod]
        public void ReverseTest5()
        {
            string actual = ReverseWordsHelper.ReverseSentense(null);

            Assert.AreEqual(actual, null);
        }
    }
}
