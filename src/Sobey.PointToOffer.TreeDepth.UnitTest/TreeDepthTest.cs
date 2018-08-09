using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.TreeDepth.UnitTest
{
    [TestClass]
    public class TreeDepthTest
    {
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

        //            1
        //         /      \
        //        2        3
        //       /\         \
        //      4  5         6
        //        /
        //       7
        [TestMethod]
        public void GetDepthTest1()
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

            int actual = TreeDepthHelper.GetTreeDepth(node1);
            Assert.AreEqual(actual, 4);

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
        public void GetDepthTest2()
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

            int actual = TreeDepthHelper.GetTreeDepth(node1);
            Assert.AreEqual(actual, 5);

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
        public void GetDepthTest3()
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

            int actual = TreeDepthHelper.GetTreeDepth(node1);
            Assert.AreEqual(actual, 5);

            ClearUpTreeNode(node1);
        }

        // 树中只有1个结点
        [TestMethod]
        public void GetDepthTest4()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(1);

            int actual = TreeDepthHelper.GetTreeDepth(node1);
            Assert.AreEqual(actual, 1);

            ClearUpTreeNode(node1);
        }

        // 树中没有结点
        [TestMethod]
        public void GetDepthTest5()
        {
            int actual = TreeDepthHelper.GetTreeDepth(null);
            Assert.AreEqual(actual, 0);
        }
    }
}
