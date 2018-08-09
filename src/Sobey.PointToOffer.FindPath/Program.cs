using System;
using System.Collections.Generic;
using System.Text;

namespace Sobey.PointToOffer.FindPath
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
            Test6();

            Console.ReadKey();
        }

        #region 01.功能实现
        public static void FindPath(BinaryTreeNode root, int expectedSum)
        {
            if (root == null)
            {
                return;
            }

            int currentSum = 0;
            List<int> path = new List<int>();
            FindPath(root, expectedSum, path, ref currentSum);
        }

        private static void FindPath(BinaryTreeNode root, int expectedSum, List<int> path, ref int currentSum)
        {
            currentSum += root.Data;
            path.Add(root.Data);
            // 如果是叶结点，并且路径上结点的和等于输入的值
            // 打印出这条路径
            bool isLeaf = root.leftChild == null && root.rightChild == null;
            if (isLeaf && currentSum == expectedSum)
            {
                Console.Write("A path is found : ");
                foreach (int data in path)
                {
                    Console.Write("{0}\t", data);
                }
                Console.WriteLine();
            }

            // 如果不是叶结点，则遍历它的子结点
            if (root.leftChild != null)
            {
                FindPath(root.leftChild, expectedSum, path, ref currentSum);
            }

            if (root.rightChild != null)
            {
                FindPath(root.rightChild, expectedSum, path, ref currentSum);
            }

            // 在返回到父结点之前，在路径上删除当前结点，
            // 并在currentSum中减去当前结点的值
            path.Remove(root.Data);
            currentSum -= root.Data;
        }
        #endregion

        #region 02.单元测试
        private static void TestPortal(string testName, BinaryTreeNode root, int expectedSum)
        {
            if (!string.IsNullOrEmpty(testName))
            {
                Console.WriteLine("{0} begins:", testName);
            }

            FindPath(root, expectedSum);

            Console.WriteLine();
        }

        private static void SetSubTreeNode(BinaryTreeNode root, BinaryTreeNode lChild, BinaryTreeNode rChild)
        {
            if (root == null)
            {
                return;
            }

            root.leftChild = lChild;
            root.rightChild = rChild;
        }

        private static void ClearUpTreeNode(BinaryTreeNode root)
        {
            if (root != null)
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
        //        5        12
        //       /\        
        //      4  7     
        // 有两条路径上的结点和为22
        public static void Test1()
        {
            BinaryTreeNode node10 = new BinaryTreeNode(10);
            BinaryTreeNode node5 = new BinaryTreeNode(5);
            BinaryTreeNode node12 = new BinaryTreeNode(12);
            BinaryTreeNode node4 = new BinaryTreeNode(4);
            BinaryTreeNode node7 = new BinaryTreeNode(7);

            SetSubTreeNode(node10, node5, node12);
            SetSubTreeNode(node5, node4, node7);

            Console.WriteLine("Two paths should be found in Test1.");
            TestPortal("Test1", node10, 22);

            ClearUpTreeNode(node10);
        }

        //            10
        //         /      \
        //        5        12
        //       /\        
        //      4  7     
        // 没有路径上的结点和为15
        public static void Test2()
        {
            BinaryTreeNode node10 = new BinaryTreeNode(10);
            BinaryTreeNode node5 = new BinaryTreeNode(5);
            BinaryTreeNode node12 = new BinaryTreeNode(12);
            BinaryTreeNode node4 = new BinaryTreeNode(4);
            BinaryTreeNode node7 = new BinaryTreeNode(7);

            SetSubTreeNode(node10, node5, node12);
            SetSubTreeNode(node5, node4, node7);

            Console.WriteLine("No paths should be found in Test2.");
            TestPortal("Test2", node10, 15);

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
        // 有一条路径上面的结点和为15
        public static void Test3()
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

            Console.WriteLine("One path should be found in Test3.");
            TestPortal("Test3", node5, 15);

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
        // 没有路径上面的结点和为16
        public static void Test4()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(1);
            BinaryTreeNode node2 = new BinaryTreeNode(2);
            BinaryTreeNode node3 = new BinaryTreeNode(3);
            BinaryTreeNode node4 = new BinaryTreeNode(4);
            BinaryTreeNode node5 = new BinaryTreeNode(5);

            node1.leftChild = node2;
            node2.leftChild = node3;
            node3.leftChild = node4;
            node4.leftChild = node5;

            Console.WriteLine("No paths should be found in Test4.");
            TestPortal("Test4", node1, 16);

            ClearUpTreeNode(node1);
        }

        // 树中只有1个结点
        public static void Test5()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(1);

            Console.WriteLine("One paths should be found in Test5.");
            TestPortal("Test5", node1, 1);

            ClearUpTreeNode(node1);
        }

        // 树中没有结点
        public static void Test6()
        {
            Console.WriteLine("No paths should be found in Test6.");
            TestPortal("Test6", null, 0);
        }
        #endregion
    }
}
