using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.PrintFromTopToBottom
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();

            Console.ReadKey();
        }

        #region 单元测试
        static void TestPortal(string testName, BinaryTreeNode root)
        {
            if (!string.IsNullOrEmpty(testName))
            {
                Console.WriteLine("{0} begins:", testName);
            }

            Console.WriteLine("The nodes from top to bottom, from left to right are:");
            PrintFromTopToBottom(root);
            Console.WriteLine("\n");
        }

        static void SetSubTreeNode(BinaryTreeNode root, BinaryTreeNode lChild, BinaryTreeNode rChild)
        {
            if (root == null)
            {
                return;
            }

            root.leftChild = lChild;
            root.rightChild = rChild;
        }

        static void ClearUpTreeNode(BinaryTreeNode root)
        {
            if(root != null)
            {
                BinaryTreeNode left = root.leftChild;
                BinaryTreeNode right = root.rightChild;

                root = null;

                ClearUpTreeNode(left);
                ClearUpTreeNode(right);
            }
        }

        //            10
        //         /      \
        //        6        14
        //       /\        /\
        //      4  8     12  16
        static void Test1()
        {
            BinaryTreeNode node10 = new BinaryTreeNode(10);
            BinaryTreeNode node6 = new BinaryTreeNode(6);
            BinaryTreeNode node14 = new BinaryTreeNode(14);
            BinaryTreeNode node4 = new BinaryTreeNode(4);
            BinaryTreeNode node8 = new BinaryTreeNode(8);
            BinaryTreeNode node12 = new BinaryTreeNode(12);
            BinaryTreeNode node16 = new BinaryTreeNode(16);

            SetSubTreeNode(node10, node6, node14);
            SetSubTreeNode(node6, node4, node8);
            SetSubTreeNode(node14, node12, node16);

            TestPortal("Test1", node10);

            ClearUpTreeNode(node10);
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
        static void Test2()
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

            TestPortal("Test2", node5);

            ClearUpTreeNode(node5);
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
        static void Test3()
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

            TestPortal("Test3", node1);

            ClearUpTreeNode(node5);
        }

        // 树中只有1个结点
        static void Test4()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(1);

            TestPortal("Test4", node1);

            ClearUpTreeNode(node1);
        }

        // 树中木有结点
        static void Test5()
        {
            TestPortal("Test5", null);
        }
        #endregion

        #region 功能实现
        static void PrintFromTopToBottom(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                BinaryTreeNode printNode = queue.Dequeue();
                Console.Write("{0}\t", printNode.Data);

                if (printNode.leftChild != null)
                {
                    queue.Enqueue(printNode.leftChild);
                }

                if (printNode.rightChild != null)
                {
                    queue.Enqueue(printNode.rightChild);
                }
            }
        }
        #endregion
    }
}
