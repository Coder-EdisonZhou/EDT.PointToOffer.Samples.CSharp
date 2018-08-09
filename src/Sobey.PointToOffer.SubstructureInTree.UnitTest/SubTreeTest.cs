using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.SubstructureInTree.UnitTest
{
    [TestClass]
    public class SubTreeTest
    {
        /// <summary>
        /// 辅助方法：设置root的lChild与rChild
        /// </summary>
        public void SetSubTreeNode(BinaryTreeNode root, BinaryTreeNode lChild, BinaryTreeNode rChild)
        {
            if (root == null)
            {
                return;
            }

            root.leftChild = lChild;
            root.rightChild = rChild;
        }

        // 01.树中结点含有分叉，树B是树A的子结构
        //                  8                8
        //              /       \           / \
        //             8         7         9   2
        //           /   \
        //          9     2
        //               / \
        //              4   7
        [TestMethod]
        public void HasSubTreeTest1()
        {
            BinaryTreeNode nodeA1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA2 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA3 = new BinaryTreeNode(7);
            BinaryTreeNode nodeA4 = new BinaryTreeNode(9);
            BinaryTreeNode nodeA5 = new BinaryTreeNode(2);
            BinaryTreeNode nodeA6 = new BinaryTreeNode(4);
            BinaryTreeNode nodeA7 = new BinaryTreeNode(7);

            SetSubTreeNode(nodeA1, nodeA2, nodeA3);
            SetSubTreeNode(nodeA2, nodeA4, nodeA5);
            SetSubTreeNode(nodeA5, nodeA6, nodeA7);

            BinaryTreeNode nodeB1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeB2 = new BinaryTreeNode(9);
            BinaryTreeNode nodeB3 = new BinaryTreeNode(2);

            SetSubTreeNode(nodeB1, nodeB2, nodeB3);

            Assert.AreEqual(SubTreeHelper.HasSubTree(nodeA1, nodeB1), true);
        }

        // 02.树中结点含有分叉，树B不是树A的子结构
        //                  8                8
        //              /       \           / \
        //             8         7         9   2
        //           /   \
        //          9     3
        //               / \
        //              4   7
        [TestMethod]
        public void HasSubTreeTest2()
        {
            BinaryTreeNode nodeA1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA2 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA3 = new BinaryTreeNode(7);
            BinaryTreeNode nodeA4 = new BinaryTreeNode(9);
            BinaryTreeNode nodeA5 = new BinaryTreeNode(3);
            BinaryTreeNode nodeA6 = new BinaryTreeNode(4);
            BinaryTreeNode nodeA7 = new BinaryTreeNode(7);

            SetSubTreeNode(nodeA1, nodeA2, nodeA3);
            SetSubTreeNode(nodeA2, nodeA4, nodeA5);
            SetSubTreeNode(nodeA5, nodeA6, nodeA7);

            BinaryTreeNode nodeB1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeB2 = new BinaryTreeNode(9);
            BinaryTreeNode nodeB3 = new BinaryTreeNode(2);

            SetSubTreeNode(nodeB1, nodeB2, nodeB3);

            Assert.AreEqual(SubTreeHelper.HasSubTree(nodeA1, nodeB1), false);
        }

        // 03.树中结点只有左子结点，树B是树A的子结构
        //                8                  8
        //              /                   / 
        //             8                   9   
        //           /                    /
        //          9                    2
        //         /      
        //        2        
        //       /
        //      5
        [TestMethod]
        public void HasSubTreeTest3()
        {
            BinaryTreeNode nodeA1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA2 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA3 = new BinaryTreeNode(9);
            BinaryTreeNode nodeA4 = new BinaryTreeNode(2);
            BinaryTreeNode nodeA5 = new BinaryTreeNode(5);

            nodeA1.leftChild = nodeA2;
            nodeA2.leftChild = nodeA3;
            nodeA3.leftChild = nodeA4;
            nodeA4.leftChild = nodeA5;

            BinaryTreeNode nodeB1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeB2 = new BinaryTreeNode(9);
            BinaryTreeNode nodeB3 = new BinaryTreeNode(2);

            nodeB1.leftChild = nodeB2;
            nodeB2.leftChild = nodeB3;

            Assert.AreEqual(SubTreeHelper.HasSubTree(nodeA1, nodeB1), true);
        }

        // 04.树中结点只有左子结点，树B不是树A的子结构
        //                8                  8
        //              /                   / 
        //             8                   9   
        //           /                    /
        //          9                    3
        //         /      
        //        2        
        //       /
        //      5
        [TestMethod]
        public void HasSubTreeTest4()
        {
            BinaryTreeNode nodeA1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA2 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA3 = new BinaryTreeNode(9);
            BinaryTreeNode nodeA4 = new BinaryTreeNode(2);
            BinaryTreeNode nodeA5 = new BinaryTreeNode(5);

            nodeA1.leftChild = nodeA2;
            nodeA2.leftChild = nodeA3;
            nodeA3.leftChild = nodeA4;
            nodeA4.leftChild = nodeA5;

            BinaryTreeNode nodeB1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeB2 = new BinaryTreeNode(9);
            BinaryTreeNode nodeB3 = new BinaryTreeNode(3);

            nodeB1.leftChild = nodeB2;
            nodeB2.leftChild = nodeB3;

            Assert.AreEqual(SubTreeHelper.HasSubTree(nodeA1, nodeB1), false);
        }

        // 05.树中结点只有右子结点，树B是树A的子结构
        //       8                   8
        //        \                   \ 
        //         8                   9   
        //          \                   \
        //           9                   2
        //            \      
        //             2        
        //              \
        //               5
        [TestMethod]
        public void HasSubTreeTest5()
        {
            BinaryTreeNode nodeA1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA2 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA3 = new BinaryTreeNode(9);
            BinaryTreeNode nodeA4 = new BinaryTreeNode(2);
            BinaryTreeNode nodeA5 = new BinaryTreeNode(5);

            nodeA1.rightChild = nodeA2;
            nodeA2.rightChild = nodeA3;
            nodeA3.rightChild = nodeA4;
            nodeA4.rightChild = nodeA5;

            BinaryTreeNode nodeB1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeB2 = new BinaryTreeNode(9);
            BinaryTreeNode nodeB3 = new BinaryTreeNode(2);

            nodeB1.rightChild = nodeB2;
            nodeB2.rightChild = nodeB3;

            Assert.AreEqual(SubTreeHelper.HasSubTree(nodeA1, nodeB1), true);
        }

        // 06.树中结点只有右子结点，树B不是树A的子结构
        //       8                   8
        //        \                   \ 
        //         8                   9   
        //          \                 / \
        //           9               3   2
        //            \      
        //             2        
        //              \
        //               5
        [TestMethod]
        public void HasSubTreeTest6()
        {
            BinaryTreeNode nodeA1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA2 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA3 = new BinaryTreeNode(9);
            BinaryTreeNode nodeA4 = new BinaryTreeNode(2);
            BinaryTreeNode nodeA5 = new BinaryTreeNode(5);

            nodeA1.rightChild = nodeA2;
            nodeA2.rightChild = nodeA3;
            nodeA3.rightChild = nodeA4;
            nodeA4.rightChild = nodeA5;

            BinaryTreeNode nodeB1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeB2 = new BinaryTreeNode(9);
            BinaryTreeNode nodeB3 = new BinaryTreeNode(3);
            BinaryTreeNode nodeB4 = new BinaryTreeNode(2);

            nodeB1.rightChild = nodeB2;
            SetSubTreeNode(nodeB2, nodeB3, nodeB4);

            Assert.AreEqual(SubTreeHelper.HasSubTree(nodeA1, nodeB1), false);
        }

        // 07.树A为空树
        [TestMethod]
        public void HasSubTreeTest7()
        {
            BinaryTreeNode nodeB1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeB2 = new BinaryTreeNode(9);
            BinaryTreeNode nodeB3 = new BinaryTreeNode(3);
            BinaryTreeNode nodeB4 = new BinaryTreeNode(2);

            nodeB1.rightChild = nodeB2;
            SetSubTreeNode(nodeB2, nodeB3, nodeB4);

            Assert.AreEqual(SubTreeHelper.HasSubTree(null, nodeB1), false);
        }

        // 08.树B为空树
        [TestMethod]
        public void HasSubTreeTest8()
        {
            BinaryTreeNode nodeA1 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA2 = new BinaryTreeNode(8);
            BinaryTreeNode nodeA3 = new BinaryTreeNode(9);
            BinaryTreeNode nodeA4 = new BinaryTreeNode(2);
            BinaryTreeNode nodeA5 = new BinaryTreeNode(5);

            nodeA1.rightChild = nodeA2;
            nodeA2.rightChild = nodeA3;
            nodeA3.rightChild = nodeA4;
            nodeA4.rightChild = nodeA5;

            Assert.AreEqual(SubTreeHelper.HasSubTree(nodeA1, null), false);
        }

        // 09.树A和树B都为空树
        [TestMethod]
        public void HasSubTreeTest9()
        {
            Assert.AreEqual(SubTreeHelper.HasSubTree(null, null), false);
        }
    }
}
