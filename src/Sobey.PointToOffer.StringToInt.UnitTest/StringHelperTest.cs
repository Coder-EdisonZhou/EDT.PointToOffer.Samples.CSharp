using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.StringToInt.UnitTest
{
    [TestClass]
    public class StringHelperTest
    {
        // 鲁棒性测试：NULL指针
        [TestMethod]
        public void StringToIntTest1()
        {
            ConvertResult actual = StringHelper.StrToInt(null);
            Assert.AreEqual(actual.State, ConvertState.InValid);
        }

        // 鲁棒性测试：空字符串
        [TestMethod]
        public void StringToIntTest2()
        {
            ConvertResult actual = StringHelper.StrToInt("");
            Assert.AreEqual(actual.State, ConvertState.InValid);
        }

        // 功能测试：普通的数字字符串
        [TestMethod]
        public void StringToIntTest3()
        {
            ConvertResult actual = StringHelper.StrToInt("123");
            Assert.AreEqual(actual.State, ConvertState.Valid);
            Assert.AreEqual(actual.Number, 123);
        }

        // 功能测试：带正负号的数字字符串
        [TestMethod]
        public void StringToIntTest4()
        {
            ConvertResult actual = StringHelper.StrToInt("+123");
            Assert.AreEqual(actual.State, ConvertState.Valid);
            Assert.AreEqual(actual.Number, 123);
        }

        // 功能测试：带正负号的数字字符串
        [TestMethod]
        public void StringToIntTest5()
        {
            ConvertResult actual = StringHelper.StrToInt("-123");
            Assert.AreEqual(actual.State, ConvertState.Valid);
            Assert.AreEqual(actual.Number, -123);
        }

        // 功能测试：带正负号的字符串0
        [TestMethod]
        public void StringToIntTest6()
        {
            ConvertResult actual = StringHelper.StrToInt("+0");
            Assert.AreEqual(actual.State, ConvertState.Valid);
            Assert.AreEqual(actual.Number, 0);
        }

        // 功能测试：带正负号的字符串0
        [TestMethod]
        public void StringToIntTest7()
        {
            ConvertResult actual = StringHelper.StrToInt("-0");
            Assert.AreEqual(actual.State, ConvertState.Valid);
            Assert.AreEqual(actual.Number, 0);
        }

        // 特殊输入测试：非数字字符串
        [TestMethod]
        public void StringToIntTest8()
        {
            ConvertResult actual = StringHelper.StrToInt("1a33");
            Assert.AreEqual(actual.State, ConvertState.InValid);
            Assert.AreEqual(actual.Number, 0);
        }

        // 特殊输入测试：有效的最大正整数 0x7FFFFFFF
        [TestMethod]
        public void StringToIntTest9()
        {
            ConvertResult actual = StringHelper.StrToInt("+2147483647");
            Assert.AreEqual(actual.State, ConvertState.Valid);
            Assert.AreEqual(actual.Number, 2147483647);
        }

        [TestMethod]
        public void StringToIntTest10()
        {
            ConvertResult actual = StringHelper.StrToInt("-2147483647");
            Assert.AreEqual(actual.State, ConvertState.Valid);
            Assert.AreEqual(actual.Number, -2147483647);
        }

        [TestMethod]
        public void StringToIntTest11()
        {
            ConvertResult actual = StringHelper.StrToInt("+2147483648");
            Assert.AreEqual(actual.State, ConvertState.InValid);
            Assert.AreEqual(actual.Number, 0);
        }

        // 特殊输入测试：有效的最小负整数 0x80000000
        [TestMethod]
        public void StringToIntTest12()
        {
            ConvertResult actual = StringHelper.StrToInt("-2147483648");
            Assert.AreEqual(actual.State, ConvertState.Valid);
            Assert.AreEqual(actual.Number, -2147483648);
        }

        [TestMethod]
        public void StringToIntTest13()
        {
            ConvertResult actual = StringHelper.StrToInt("+2147483649");
            Assert.AreEqual(actual.State, ConvertState.InValid);
            Assert.AreEqual(actual.Number, 0);
        }

        [TestMethod]
        public void StringToIntTest14()
        {
            ConvertResult actual = StringHelper.StrToInt("-2147483649");
            Assert.AreEqual(actual.State, ConvertState.InValid);
            Assert.AreEqual(actual.Number, 0);
        }

        // 特殊输入测试：只有一个正号
        [TestMethod]
        public void StringToIntTest15()
        {
            ConvertResult actual = StringHelper.StrToInt("+");
            Assert.AreEqual(actual.State, ConvertState.InValid);
            Assert.AreEqual(actual.Number, 0);
        }

        // 特殊输入测试：只有一个负号
        [TestMethod]
        public void StringToIntTest16()
        {
            ConvertResult actual = StringHelper.StrToInt("-");
            Assert.AreEqual(actual.State, ConvertState.InValid);
            Assert.AreEqual(actual.Number, 0);
        }
    }
}
