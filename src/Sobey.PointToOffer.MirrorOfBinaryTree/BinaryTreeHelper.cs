using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.MirrorOfBinaryTree
{
    public static class BinaryTreeHelper
    {
        /// <summary>
        /// 递归版
        /// </summary>
        public static void SetMirrorRecursively(BinaryTreeNode root)
        {
            if (root == null || (root.leftChild == null && root.rightChild == null))
            {
                return;
            }

            BinaryTreeNode tempNode = root.leftChild;
            root.leftChild = root.rightChild;
            root.rightChild = tempNode;

            if (root.leftChild != null)
            {
                // 递归调整左子树为镜像
                SetMirrorRecursively(root.leftChild);
            }

            if (root.rightChild != null)
            {
                // 递归调整右子树为镜像
                SetMirrorRecursively(root.rightChild);
            }
        }

        /// <summary>
        /// 非递归版
        /// </summary>
        public static void SetMirrorIteratively(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                BinaryTreeNode node = stack.Pop();

                BinaryTreeNode temp = node.leftChild;
                node.leftChild = node.rightChild;
                node.rightChild = temp;

                if (node.leftChild != null)
                {
                    stack.Push(node.leftChild);
                }

                if (node.rightChild != null)
                {
                    stack.Push(node.rightChild);
                }
            }
        }
    }
}
