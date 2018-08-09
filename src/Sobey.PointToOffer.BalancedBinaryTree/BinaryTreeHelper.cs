using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.BalancedBinaryTree
{
    public static class BinaryTreeHelper
    {
        //public static int GetTreeDepth(BinaryTreeNode root)
        //{
        //    if (root == null)
        //    {
        //        return 0;
        //    }

        //    int left = GetTreeDepth(root.LeftChild);
        //    int right = GetTreeDepth(root.RightChild);

        //    return left >= right ? left + 1 : right + 1;
        //}

        //public static bool IsBalancedBinaryTree(BinaryTreeNode root)
        //{
        //    if (root == null)
        //    {
        //        return true;
        //    }

        //    int left = GetTreeDepth(root.LeftChild);
        //    int right = GetTreeDepth(root.RightChild);
        //    int diff = left - right;

        //    if (diff > 1 || diff < -1)
        //    {
        //        return false;
        //    }

        //    return IsBalancedBinaryTree(root.LeftChild) && IsBalancedBinaryTree(root.RightChild);
        //}

        public static bool IsBalancedBinaryTree(BinaryTreeNode root)
        {
            int depth = 0;
            return IsBalancedBinaryTreeCore(root, ref depth);
        }

        private static bool IsBalancedBinaryTreeCore(BinaryTreeNode root, ref int depth)
        {
            if (root == null)
            {
                depth = 0;
                return true;
            }

            int left = 0;
            int right = 0;
            if (IsBalancedBinaryTreeCore(root.LeftChild, ref left) && IsBalancedBinaryTreeCore(root.RightChild, ref right))
            {
                int diff = left - right;
                if (diff >= -1 && diff <= 1)
                {
                    depth = left >= right ? left + 1 : right + 1;
                    return true;
                }
            }

            return false;
        }
    }
}
