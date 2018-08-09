using System;
using System.Text;

namespace Sobey.PointToOffer.TreeDepth
{
    /// <summary>
    /// 二叉树节点定义
    /// </summary>
    public class BinaryTreeNode
    {
        public int Data { get; set; }
        public BinaryTreeNode LeftChild { get; set; }
        public BinaryTreeNode RightChild { get; set; }

        public BinaryTreeNode(int data)
        {
            this.Data = data;
        }

        public BinaryTreeNode(int data, BinaryTreeNode left, BinaryTreeNode right)
        {
            this.Data = data;
            this.LeftChild = left;
            this.RightChild = right;
        }
    }
}
