using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.BalancedBinaryTree.UnitTest
{
    [TestClass]
    public class BalancedTest
    {
        #region 单元测试辅助方法
        private void SetSubTreeNode(BinaryTreeNode root, BinaryTreeNode lChild, BinaryTreeNode rChild)
        {
            if (root == null)
            {
                return;
            }

            root.LeftChild = lChild;
            root.RightChild = rChild;
        }

        private void ClearUpTreeNode(BinaryTreeNode root)
        {
            if (root != null)
            {
                BinaryTreeNode left = root.LeftChild;
                BinaryTreeNode right = root.RightChild;

                root = null;

                ClearUpTreeNode(left);
                ClearUpTreeNode(right);
            }
        }
        #endregion

        // 完全二叉树
        //             1
        //         /      \
        //        2        3
        //       /\       / \
        //      4  5     6   7
        [TestMethod]
        public void IsBalancedTest1()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(1);
            BinaryTreeNode node2 = new BinaryTreeNode(2);
            BinaryTreeNode node3 = new BinaryTreeNode(3);
            BinaryTreeNode node4 = new BinaryTreeNode(4);
            BinaryTreeNode node5 = new BinaryTreeNode(5);
            BinaryTreeNode node6 = new BinaryTreeNode(6);
            BinaryTreeNode node7 = new BinaryTreeNode(7);

            SetSubTreeNode(node1, node2, node3);
            SetSubTreeNode(node2, node4, node5);
            SetSubTreeNode(node3, node6, node7);

            bool actual = BinaryTreeHelper.IsBalancedBinaryTree(node1);
            Assert.AreEqual(actual, true);

            ClearUpTreeNode(node1);
        }

        // 不是完全二叉树，但是平衡二叉树
        //             1
        //         /      \
        //        2        3
        //       /\         \
        //      4  5         6
        //        /
        //       7
        [TestMethod]
        public void IsBalancedTest2()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(1);
            BinaryTreeNode node2 = new BinaryTreeNode(2);
            BinaryTreeNode node3 = new BinaryTreeNode(3);
            BinaryTreeNode node4 = new BinaryTreeNode(4);
            BinaryTreeNode node5 = new BinaryTreeNode(5);
            BinaryTreeNode node6 = new BinaryTreeNode(6);
            BinaryTreeNode node7 = new BinaryTreeNode(7);

            SetSubTreeNode(node1, node2, node3);
            SetSubTreeNode(node2, node4, node5);
            SetSubTreeNode(node3, null, node6);
            SetSubTreeNode(node5, node7, null);

            bool actual = BinaryTreeHelper.IsBalancedBinaryTree(node1);
            Assert.AreEqual(actual, true);

            ClearUpTreeNode(node1);
        }

        // 不是平衡二叉树
        //             1
        //         /      \
        //        2        3
        //       /\         
        //      4  5        
        //        /
        //       6
        [TestMethod]
        public void IsBalancedTest3()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(1);
            BinaryTreeNode node2 = new BinaryTreeNode(2);
            BinaryTreeNode node3 = new BinaryTreeNode(3);
            BinaryTreeNode node4 = new BinaryTreeNode(4);
            BinaryTreeNode node5 = new BinaryTreeNode(5);
            BinaryTreeNode node6 = new BinaryTreeNode(6);

            SetSubTreeNode(node1, node2, node3);
            SetSubTreeNode(node2, node4, node5);
            SetSubTreeNode(node5, node6, null);

            bool actual = BinaryTreeHelper.IsBalancedBinaryTree(node1);
            Assert.AreEqual(actual, false);

            ClearUpTreeNode(node1);
        }

        //               1
        //              /
        //             2
        //            /
        //           3
        //          /
        //         4
        //        /
        //       5
        [TestMethod]
        public void IsBalancedTest4()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(1);
            BinaryTreeNode node2 = new BinaryTreeNode(2);
            BinaryTreeNode node3 = new BinaryTreeNode(3);
            BinaryTreeNode node4 = new BinaryTreeNode(4);
            BinaryTreeNode node5 = new BinaryTreeNode(5);

            SetSubTreeNode(node1, node2, null);
            SetSubTreeNode(node2, node3, null);
            SetSubTreeNode(node3, node4, null);
            SetSubTreeNode(node4, node5, null);

            bool actual = BinaryTreeHelper.IsBalancedBinaryTree(node1);
            Assert.AreEqual(actual, false);

            ClearUpTreeNode(node1);
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
        public void IsBalancedTest5()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(1);
            BinaryTreeNode node2 = new BinaryTreeNode(2);
            BinaryTreeNode node3 = new BinaryTreeNode(3);
            BinaryTreeNode node4 = new BinaryTreeNode(4);
            BinaryTreeNode node5 = new BinaryTreeNode(5);

            SetSubTreeNode(node1, null, node2);
            SetSubTreeNode(node2, null, node3);
            SetSubTreeNode(node3, null, node4);
            SetSubTreeNode(node4, null, node5);

            bool actual = BinaryTreeHelper.IsBalancedBinaryTree(node1);
            Assert.AreEqual(actual, false);

            ClearUpTreeNode(node1);
        }

        // 树中只有1个结点
        [TestMethod]
        public void IsBalancedTest6()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(1);

            bool actual = BinaryTreeHelper.IsBalancedBinaryTree(node1);
            Assert.AreEqual(actual, true);

            ClearUpTreeNode(node1);
        }

        // 树中没有结点
        [TestMethod]
        public void IsBalancedTest7()
        {
            bool actual = BinaryTreeHelper.IsBalancedBinaryTree(null);
            Assert.AreEqual(actual, true);
        }
    }
}
