using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.MirrorOfBinaryTree.UnitTest
{
    [TestClass]
    public class SetMirrorTest
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

        /// <summary>
        /// 辅助方法：生成二叉树元素的字符串用于对比
        /// </summary>
        public string GetNodeString(BinaryTreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            StringBuilder sbResult = new StringBuilder();

            Queue<BinaryTreeNode> queueNodes = new Queue<BinaryTreeNode>();
            queueNodes.Enqueue(root);
            BinaryTreeNode tempNode = null;
            // 利用队列先进先出的特性存储节点并输出
            while (queueNodes.Count > 0)
            {
                tempNode = queueNodes.Dequeue();
                sbResult.Append(tempNode.Data);

                if (tempNode.leftChild != null)
                {
                    queueNodes.Enqueue(tempNode.leftChild);
                }

                if (tempNode.rightChild != null)
                {
                    queueNodes.Enqueue(tempNode.rightChild);
                }
            }

            return sbResult.ToString();
        } 

        // 01.测试完全二叉树：除了叶子节点，其他节点都有两个子节点
        //            8
        //        6      10
        //       5 7    9  11
        [TestMethod]
        public void MirrorTest1()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(8);
            BinaryTreeNode node2 = new BinaryTreeNode(6);
            BinaryTreeNode node3 = new BinaryTreeNode(10);
            BinaryTreeNode node4 = new BinaryTreeNode(5);
            BinaryTreeNode node5 = new BinaryTreeNode(7);
            BinaryTreeNode node6 = new BinaryTreeNode(9);
            BinaryTreeNode node7 = new BinaryTreeNode(11);

            SetSubTreeNode(node1, node2, node3);
            SetSubTreeNode(node2, node4, node5);
            SetSubTreeNode(node3, node6, node7);

            BinaryTreeHelper.SetMirrorIteratively(node1);
            string completed = GetNodeString(node1);
            Assert.AreEqual(completed,"810611975");
        }

        // 02.测试二叉树：出叶子结点之外，左右的结点都有且只有一个左子结点
        //            8
        //          7   
        //        6 
        //      5
        //    4
        [TestMethod]
        public void MirrorTest2()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(8);
            BinaryTreeNode node2 = new BinaryTreeNode(7);
            BinaryTreeNode node3 = new BinaryTreeNode(6);
            BinaryTreeNode node4 = new BinaryTreeNode(5);
            BinaryTreeNode node5 = new BinaryTreeNode(4);

            node1.leftChild = node2;
            node2.leftChild = node3;
            node3.leftChild = node4;
            node4.leftChild = node5;

            BinaryTreeHelper.SetMirrorIteratively(node1);
            string completed = GetNodeString(node1);
            Assert.AreEqual(completed, "87654");
        }

        // 03.测试二叉树：出叶子结点之外，左右的结点都有且只有一个右子结点
        //            8
        //             7   
        //              6 
        //               5
        //                4
        [TestMethod]
        public void MirrorTest3()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(8);
            BinaryTreeNode node2 = new BinaryTreeNode(7);
            BinaryTreeNode node3 = new BinaryTreeNode(6);
            BinaryTreeNode node4 = new BinaryTreeNode(5);
            BinaryTreeNode node5 = new BinaryTreeNode(4);

            node1.rightChild = node2;
            node2.rightChild = node3;
            node3.rightChild = node4;
            node4.rightChild = node5;

            BinaryTreeHelper.SetMirrorIteratively(node1);
            string completed = GetNodeString(node1);
            Assert.AreEqual(completed, "87654");
        }

        // 04.测试只有一个结点的二叉树
        //    8
        [TestMethod]
        public void MirrorTest4()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(8);

            BinaryTreeHelper.SetMirrorIteratively(node1);
            string completed = GetNodeString(node1);
            Assert.AreEqual(completed, "8");
        }

        // 05.测试空二叉树：根结点为空指针
        [TestMethod]
        public void MirrorTest5()
        {
            BinaryTreeNode node1 = null;
            BinaryTreeHelper.SetMirrorIteratively(node1);
            string completed = GetNodeString(node1);
            Assert.AreEqual(completed, null);
        }
    }
}
