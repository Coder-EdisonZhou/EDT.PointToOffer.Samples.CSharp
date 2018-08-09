using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.SequenceOfBST.UnitTest
{
    [TestClass]
    public class SequenceOfBSTTest
    {
        //            10
        //         /      \
        //        6        14
        //       /\        /\
        //      4  8     12  16
        [TestMethod]
        public void SequenceTest1()
        {
            int[] data = { 4, 8, 6, 12, 16, 14, 10 };
            bool result = SequenceHelper.VerifySquenceOfBST(data, data.Length);
            Assert.AreEqual(result, true);
        }

        //           5
        //          / \
        //         4   7
        //            /
        //           6
        [TestMethod]
        public void SequenceTest2()
        {
            int[] data = { 4, 6, 7, 5 };
            bool result = SequenceHelper.VerifySquenceOfBST(data, data.Length);
            Assert.AreEqual(result, true);
        }

        //               5
        //              /
        //             4
        //            /
        //           3
        //          /
        //         2
        //        /
        //       1
        [TestMethod]
        public void SequenceTest3()
        {
            int[] data = { 1, 2, 3, 4, 5 };
            bool result = SequenceHelper.VerifySquenceOfBST(data, data.Length);
            Assert.AreEqual(result, true);
        }

        // 1
        //  \
        //   2
        //    \
        //     3
        //      \
        //       4
        //        \
        //         5
        [TestMethod]
        public void SequenceTest4()
        {
            int[] data = { 5, 4, 3, 2, 1 };
            bool result = SequenceHelper.VerifySquenceOfBST(data, data.Length);
            Assert.AreEqual(result, true);
        }

        // 树中只有1个结点
        [TestMethod]
        public void SequenceTest5()
        {
            int[] data = { 5 };
            bool result = SequenceHelper.VerifySquenceOfBST(data, data.Length);
            Assert.AreEqual(result, true);
        }

        // 错误序列
        [TestMethod]
        public void SequenceTest6()
        {
            int[] data = { 7, 4, 6, 5 };
            bool result = SequenceHelper.VerifySquenceOfBST(data, data.Length);
            Assert.AreEqual(result, false);
        }

        // 错误序列
        [TestMethod]
        public void SequenceTest7()
        {
            int[] data = { 4, 6, 12, 8, 16, 14, 10 };
            bool result = SequenceHelper.VerifySquenceOfBST(data, data.Length);
            Assert.AreEqual(result, false);
        }

        // 错误序列
        [TestMethod]
        public void SequenceTest8()
        {
            bool result = SequenceHelper.VerifySquenceOfBST(null, 0);
            Assert.AreEqual(result, false);
        }
    }
}
