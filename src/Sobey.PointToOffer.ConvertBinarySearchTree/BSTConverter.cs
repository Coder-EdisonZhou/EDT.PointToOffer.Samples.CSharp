using System;
using System.Collections.Generic;
using System.Text;

namespace Sobey.PointToOffer.ConvertBinarySearchTree
{
    public class BSTConverter
    {
        /// <summary>
        /// 将二叉查找树转换为双向链表
        /// </summary>
        public BinaryTreeNode Convert(BinaryTreeNode root)
        {
            BinaryTreeNode lastNodeInList = null;
            ConvertNode(root, ref lastNodeInList);

            // lastNodeInList指向双向链表的尾结点，
            // 我们需要返回头结点
            BinaryTreeNode headInList = lastNodeInList;
            while (headInList != null && headInList.leftChild != null)
            {
                headInList = headInList.leftChild;
            }

            return headInList;
        }

        private void ConvertNode(BinaryTreeNode node, ref BinaryTreeNode lastNodeInList)
        {
            if (node == null)
            {
                return;
            }

            BinaryTreeNode currentNode = node;
            // 转换左子树
            if (currentNode.leftChild != null)
            {
                ConvertNode(currentNode.leftChild, ref lastNodeInList);
            }
            // 左子树与根节点的衔接
            currentNode.leftChild = lastNodeInList;
            if (lastNodeInList != null)
            {
                lastNodeInList.rightChild = currentNode;
            }
            lastNodeInList = currentNode;
            // 转换右子树
            if (currentNode.rightChild != null)
            {
                ConvertNode(currentNode.rightChild, ref lastNodeInList);
            }
        }
    }
}
