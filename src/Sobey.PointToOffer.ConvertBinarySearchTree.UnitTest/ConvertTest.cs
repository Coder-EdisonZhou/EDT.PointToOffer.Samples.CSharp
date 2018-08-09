using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.ConvertBinarySearchTree.UnitTest
{
    [TestClass]
    public class ConvertTest
    {
        #region 辅助方法
        private void SetSubTreeNode(BinaryTreeNode root, BinaryTreeNode lChild, BinaryTreeNode rChild)
        {
            if (root == null)
            {
                return;
            }

            root.leftChild = lChild;
            root.rightChild = rChild;
        }

        private BSTConverter converter;

        [TestInitialize]
        public void Initialize()
        {
            converter = new BSTConverter();
        }

        [TestCleanup]
        public void CleanUp()
        {
            converter = null;
        }
        #endregion

        #region 测试用例
        //            10
        //         /      \
        //        6        14
        //       /\        /\
        //      4  8     12  16
        [TestMethod]
        public void ConvertTest1()
        {
            BinaryTreeNode node10 = new BinaryTreeNode(10);
            BinaryTreeNode node6 = new BinaryTreeNode(6);
            BinaryTreeNode node4 = new BinaryTreeNode(4);
            BinaryTreeNode node8 = new BinaryTreeNode(8);
            BinaryTreeNode node14 = new BinaryTreeNode(14);
            BinaryTreeNode node12 = new BinaryTreeNode(12);
            BinaryTreeNode node16 = new BinaryTreeNode(16);

            SetSubTreeNode(node10, node6, node14);
            SetSubTreeNode(node6, node4, node8);
            SetSubTreeNode(node14, node12, node16);

            BinaryTreeNode result = converter.Convert(node10);
            Assert.AreEqual(result, node4);
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
        public void ConvertTest2()
        {
            BinaryTreeNode node5 = new BinaryTreeNode(5);
            BinaryTreeNode node4 = new BinaryTreeNode(4);
            BinaryTreeNode node3 = new BinaryTreeNode(3);
            BinaryTreeNode node2 = new BinaryTreeNode(2);
            BinaryTreeNode node1 = new BinaryTreeNode(1);

            node5.leftChild = node4;
            node4.leftChild = node3;
            node3.leftChild = node2;
            node2.leftChild = node1;

            BinaryTreeNode result = converter.Convert(node5);
            Assert.AreEqual(result, node1);
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
        public void ConvertTest3()
        {
            BinaryTreeNode node5 = new BinaryTreeNode(5);
            BinaryTreeNode node4 = new BinaryTreeNode(4);
            BinaryTreeNode node3 = new BinaryTreeNode(3);
            BinaryTreeNode node2 = new BinaryTreeNode(2);
            BinaryTreeNode node1 = new BinaryTreeNode(1);

            node1.rightChild = node2;
            node2.rightChild = node3;
            node3.rightChild = node4;
            node4.rightChild = node5;

            BinaryTreeNode result = converter.Convert(node1);
            Assert.AreEqual(result, node1);
        }

        // 树中只有1个结点
        [TestMethod]
        public void ConvertTest4()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(1);

            BinaryTreeNode result = converter.Convert(node1);
            Assert.AreEqual(result, node1);
        }

        // 空指针
        [TestMethod]
        public void ConvertTest5()
        {
            BinaryTreeNode result = converter.Convert(null);
            Assert.AreEqual(result, null);
        } 
        #endregion
    }
}
