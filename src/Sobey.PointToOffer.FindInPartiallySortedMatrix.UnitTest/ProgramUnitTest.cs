using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sobey.PointToOffer.FindInPartiallySortedMatrix;

namespace Sobey.PointToOffer.FindInPartiallySortedMatrix.UnitTest
{
    [TestClass]
    public class ProgramUnitTest
    {
        [TestMethod]
        public void FindTest1()
        {
            //  1   2   8   9
            //  2   4   9   12
            //  4   7   10  13
            //  6   8   11  15
            // 要查找的数在数组中
            int[,] matrix = { { 1, 2, 8, 9 }, { 2, 4, 9, 12 }, { 4, 7, 10, 13 }, { 6, 8, 11, 15 } };
            // 可以通过GetLength()方法获取行数和列数
            //Assert.AreEqual(Program.Find(matrix, matrix.GetLength(0), matrix.GetLength(1), 7), true);
            Assert.AreEqual(Program.Find(matrix, 4, 4, 7), true);
        }

        [TestMethod]
        public void FindTest2()
        {
            //  1   2   8   9
            //  2   4   9   12
            //  4   7   10  13
            //  6   8   11  15
            // 要查找的数不在数组中
            int[,] matrix = {{1, 2, 8, 9}, {2, 4, 9, 12}, {4, 7, 10, 13}, {6, 8, 11, 15}};
            Assert.AreEqual(Program.Find(matrix, 4, 4, 5), false);
        }

        [TestMethod]
        public void FindTest3()
        {
            //  1   2   8   9
            //  2   4   9   12
            //  4   7   10  13
            //  6   8   11  15
            // 要查找的数是数组中最小的数字
            int[,] matrix = { { 1, 2, 8, 9 }, { 2, 4, 9, 12 }, { 4, 7, 10, 13 }, { 6, 8, 11, 15 } };
            Assert.AreEqual(Program.Find(matrix, 4, 4, 1), true);
        }

        [TestMethod]
        public void FindTest4()
        {
            //  1   2   8   9
            //  2   4   9   12
            //  4   7   10  13
            //  6   8   11  15
            // 要查找的数是数组中最大的数字
            int[,] matrix = { { 1, 2, 8, 9 }, { 2, 4, 9, 12 }, { 4, 7, 10, 13 }, { 6, 8, 11, 15 } };
            Assert.AreEqual(Program.Find(matrix, 4, 4, 15), true);
        }

        [TestMethod]
        public void FindTest5()
        {
            //  1   2   8   9
            //  2   4   9   12
            //  4   7   10  13
            //  6   8   11  15
            // 要查找的数比数组中最小的数字还小
            int[,] matrix = { { 1, 2, 8, 9 }, { 2, 4, 9, 12 }, { 4, 7, 10, 13 }, { 6, 8, 11, 15 } };
            Assert.AreEqual(Program.Find(matrix, 4, 4, 0), false);
        }

        [TestMethod]
        public void FindTest6()
        {
            //  1   2   8   9
            //  2   4   9   12
            //  4   7   10  13
            //  6   8   11  15
            // 要查找的数比数组中最大的数字还大
            int[,] matrix = { { 1, 2, 8, 9 }, { 2, 4, 9, 12 }, { 4, 7, 10, 13 }, { 6, 8, 11, 15 } };
            Assert.AreEqual(Program.Find(matrix, 4, 4, 16), false);
        }

        [TestMethod]
        public void FindTest7()
        {
            // 鲁棒性测试，输入空指针
            Assert.AreEqual(Program.Find(null, 0, 0, 16), false);
        }
    }
}
