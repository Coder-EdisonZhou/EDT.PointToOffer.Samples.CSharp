using System;
using System.Text;

namespace Sobey.PointToOffer.ConvertBinarySearchTree
{
    /// <summary>
    /// 二叉树节点定义
    /// </summary>
    public class BinaryTreeNode
    {
        public int Data { get; set; }
        public BinaryTreeNode leftChild { get; set; }
        public BinaryTreeNode rightChild { get; set; }

        public BinaryTreeNode(int data)
        {
            this.Data = data;
        }

        public BinaryTreeNode(int data, BinaryTreeNode left, BinaryTreeNode right)
        {
            this.Data = data;
            this.leftChild = left;
            this.rightChild = right;
        }
    }
}
