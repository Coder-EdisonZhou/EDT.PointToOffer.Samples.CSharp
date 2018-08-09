using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.FirstNotRepeatingChar.UnitTest
{
    [TestClass]
    public class CharHelperTest
    {
        // 常规输入测试，存在只出现一次的字符
        [TestMethod]
        public void FirstCharTest1()
        {
            char actual = CharHelper.FirstNotRepeatingChar("google");
            Assert.AreEqual(actual, 'l');
        }

        // 常规输入测试，不存在只出现一次的字符
        [TestMethod]
        public void FirstCharTest2()
        {
            char actual = CharHelper.FirstNotRepeatingChar("aabccdbd");
            Assert.AreEqual(actual, '\0');
        }

        // 常规输入测试，所有字符都只出现一次
        [TestMethod]
        public void FirstCharTest3()
        {
            char actual = CharHelper.FirstNotRepeatingChar("abcdefg");
            Assert.AreEqual(actual, 'a');
        }

        // 鲁棒性测试，输入NULL
        [TestMethod]
        public void FirstCharTest4()
        {
            char actual = CharHelper.FirstNotRepeatingChar(null);
            Assert.AreEqual(actual, '\0');
        }
    }
}
