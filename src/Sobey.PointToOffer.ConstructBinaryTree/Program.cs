using System;
using System.Collections.Generic;

namespace Sobey.PointToOffer.ConstructBinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConstructTest1();
            ConstructTest2();
            ConstructTest3();
            ConstructTest4();
            ConstructTest5();
            ConstructTest6();
            ConstructTest7();

            Console.ReadKey();
        }

        #region 功能实现代码
        public static Node<int> Construct(int[] preOrder, int[] inOrder, int length)
        {
            // 空指针判断
            if (preOrder == null || inOrder == null || length <= 0)
            {
                return null;
            }

            return ConstructCore(preOrder, 0, preOrder.Length - 1, inOrder, 0, inOrder.Length - 1);
        }

        public static Node<int> ConstructCore(int[] preOrder, int startPreOrder, int endPreOrder, int[] inOrder, int startInOrder, int endInOrder)
        {
            // 前序遍历序列的第一个数字是根结点的值
            int rootValue = preOrder[startPreOrder];
            Node<int> root = new Node<int>();
            root.data = rootValue;
            root.lchild = root.rchild = null;

            if (startPreOrder == endPreOrder)
            {
                if (startInOrder == endInOrder && 
                    preOrder[startPreOrder] == inOrder[startInOrder])
                {
                    return root;
                }
                else
                {
                    throw new Exception("Invalid input!");
                }
            }

            // 在中序遍历中找到根结点的值
            int rootInOrder = startInOrder;
            while (rootInOrder <= endInOrder && inOrder[rootInOrder] != rootValue)
            {
                rootInOrder++;
            }

            // 输入的两个序列不匹配的情况
            if (rootInOrder == endInOrder && inOrder[rootInOrder] != rootValue)
            {
                throw new Exception("Invalid input!");
            }

            int leftLength = rootInOrder - startInOrder;
            int leftPreOrderEnd = startPreOrder + leftLength;
            if (leftLength > 0)
            {
                // 构建左子树
                root.lchild = ConstructCore(preOrder, startPreOrder + 1, leftPreOrderEnd, inOrder, startInOrder, rootInOrder - 1);
            }
            if (leftLength < endPreOrder - startPreOrder)
            {
                // 构建右子树
                root.rchild = ConstructCore(preOrder, leftPreOrderEnd + 1, endPreOrder, inOrder, rootInOrder + 1, endInOrder);
            }

            return root;
        }
        #endregion

        #region 单元测试代码
        // 单元测试主入口
        public static void ConstructTestPortal(string testName, int[] preOrder, int[] inOrder, int length)
        {
            if (!string.IsNullOrEmpty(testName))
            {
                Console.WriteLine("{0} begins:", testName);
            }
            // 打印先序遍历
            Console.Write("The preorder sequence is : ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(preOrder[i]);
            }
            Console.Write("\n");
            // 打印中序遍历
            Console.Write("The inorder sequence is : ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(inOrder[i]);
            }
            Console.Write("\n");

            try
            {
                Node<int> root = Construct(preOrder, inOrder, length);
                BinaryTree<int> bTree = new BinaryTree<int>();
                bTree.Root = root;
                Console.Write("The binary tree is : ");
                // 重建的二叉树层次遍历
                bTree.LevelOrder(bTree.Root);
                if (!string.IsNullOrEmpty(testName))
                {
                    Console.Write("\n{0} end\n\n", testName);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }

        // 普通二叉树
        //              1
        //           /     \
        //          2       3  
        //         /       / \
        //        4       5   6
        //         \         /
        //          7       8
        public static void ConstructTest1()
        {
            int[] preorder = { 1, 2, 4, 7, 3, 5, 6, 8 };
            int[] inorder = { 4, 7, 2, 1, 5, 3, 8, 6 };

            ConstructTestPortal("ConstructTest1", preorder, inorder, 8);
        }

        // 所有结点都没有右子结点
        //            1
        //           / 
        //          2   
        //         / 
        //        3 
        //       /
        //      4
        //     /
        //    5
        public static void ConstructTest2()
        {
            int[] preorder = { 1, 2, 3, 4, 5 };
            int[] inorder = { 5, 4, 3, 2, 1 };

            ConstructTestPortal("ConstructTest2", preorder, inorder, 5);
        }

        // 所有结点都没有左子结点
        //            1
        //             \ 
        //              2   
        //               \ 
        //                3 
        //                 \
        //                  4
        //                   \
        //                    5
        public static void ConstructTest3()
        {
            int[] preorder = {1, 2, 3, 4, 5};
            int[] inorder = {1, 2, 3, 4, 5};

            ConstructTestPortal("ConstructTest3", preorder, inorder, 5);
        }

        // 树中只有一个结点
        public static void ConstructTest4()
        {
            int[] preorder = { 1 };
            int[] inorder = { 1 };

            ConstructTestPortal("ConstructTest4", preorder, inorder, 1);
        }

        // 完全二叉树
        //              1
        //           /     \
        //          2       3  
        //         / \     / \
        //        4   5   6   7
        public static void ConstructTest5()
        {
            int[] preorder = {1, 2, 4, 5, 3, 6, 7};
            int[] inorder = {4, 2, 5, 1, 6, 3, 7};

            ConstructTestPortal("ConstructTest5", preorder, inorder, 7);
        }

        // 输入空指针
        public static void ConstructTest6()
        {
            ConstructTestPortal("ConstructTest6", null, null, 0);
        }

        // 输入的两个序列不匹配
        public static void ConstructTest7()
        {
            int[] preorder = {1, 2, 4, 5, 3, 6, 7};
            int[] inorder = {4, 2, 8, 1, 6, 3, 7};

            ConstructTestPortal("ConstructTest7", preorder, inorder, 7);
        }

        #endregion
    }
}
