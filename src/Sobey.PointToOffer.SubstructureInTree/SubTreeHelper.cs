using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.SubstructureInTree
{
    public static class SubTreeHelper
    {
        public static bool HasSubTree(BinaryTreeNode root1, BinaryTreeNode root2)
        {
            bool result = false;

            if (root1 != null && root2 != null)
            {
                if (root1.Data == root2.Data)
                {
                    result = DoesTree1HasTree2(root1, root2);
                }
                // 从根节点的左子树开始匹配Tree2
                if (!result)
                {
                    result = HasSubTree(root1.leftChild, root2);
                }
                // 如果左子树没有匹配成功则继续在右子树中继续匹配Tree2
                if (!result)
                {
                    result = HasSubTree(root1.rightChild, root2);
                }
            }

            return result;
        }

        private static bool DoesTree1HasTree2(BinaryTreeNode root1, BinaryTreeNode root2)
        {
            if (root2 == null)
            {
                // 证明Tree2已经遍历结束，匹配成功
                return true;
            }

            if (root1 == null)
            {
                // 证明Tree1已经遍历结束，匹配失败
                return false;
            }

            if (root1.Data != root2.Data)
            {
                return false;
            }
            // 递归验证左子树和右子树是否包含Tree2
            return DoesTree1HasTree2(root1.leftChild, root2.leftChild) && DoesTree1HasTree2(root1.rightChild, root2.rightChild);
        }
    }
}
