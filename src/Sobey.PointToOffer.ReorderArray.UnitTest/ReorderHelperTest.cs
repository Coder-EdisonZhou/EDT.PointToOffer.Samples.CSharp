using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.ReorderArray.UnitTest
{
    [TestClass]
    public class ReorderHelperTest
    {
        #region 辅助方法
        // 辅助方法：对比两个数组是否一致
        public bool ArrayEqual(int[] ordered, int[] expected)
        {
            if (ordered.Length != expected.Length)
            {
                return false;
            }

            bool result = true;
            for (int i = 0; i < ordered.Length; i++)
            {
                if (ordered[i] != expected[i])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
        #endregion

        #region 功能测试
        // Test1:输入数组中的奇数、偶数交替出现
        [TestMethod]
        public void ReorderTest1()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int[] expected = { 1, 7, 3, 5, 4, 6, 2 };
            ReorderHelper.ReorderOddEven(numbers);
            //ReorderHelper.ReorderOddEven(numbers, new Predicate<int>((num) => num % 2 == 0));
            Assert.AreEqual(ArrayEqual(numbers, expected), true);
        }

        // Test2:输入数组中的所有偶数都出现在奇数的前面
        [TestMethod]
        public void ReorderTest2()
        {
            int[] numbers = { 2, 4, 6, 1, 3, 5, 7 };
            int[] expected = { 7, 5, 3, 1, 6, 4, 2 };
            ReorderHelper.ReorderOddEven(numbers);
            Assert.AreEqual(ArrayEqual(numbers, expected), true);
        }

        // Test3:输入数组中的所有奇数都出现在偶数的前面
        [TestMethod]
        public void ReorderTest3()
        {
            int[] numbers = { 1, 3, 5, 7, 2, 4, 6 };
            int[] expected = { 1, 3, 5, 7, 2, 4, 6 };
            ReorderHelper.ReorderOddEven(numbers);
            Assert.AreEqual(ArrayEqual(numbers, expected), true);
        }
        #endregion

        #region 特殊输入测试
        // Test4:输入的数组只包含一个数字-奇数
        [TestMethod]
        public void ReorderTest4()
        {
            int[] numbers = { 1 };
            int[] expected = { 1 };
            ReorderHelper.ReorderOddEven(numbers);
            Assert.AreEqual(ArrayEqual(numbers, expected), true);
        }

        // Test5:输入的数组只包含一个数字-偶数
        [TestMethod]
        public void ReorderTest5()
        {
            int[] numbers = { 2 };
            int[] expected = { 2 };
            ReorderHelper.ReorderOddEven(numbers);
            Assert.AreEqual(ArrayEqual(numbers, expected), true);
        }

        // Test6:NULL指针
        [TestMethod]
        public void ReorderTest6()
        {
            int[] numbers = null;
            int[] expected = null;
            ReorderHelper.ReorderOddEven(numbers);
            Assert.AreEqual(numbers, expected);
        }
        #endregion
    }
}
