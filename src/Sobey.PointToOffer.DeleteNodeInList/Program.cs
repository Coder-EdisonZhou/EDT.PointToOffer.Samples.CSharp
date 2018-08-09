using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.DeleteNodeInList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node<int> head1 = new Node<int>(1);

            DeleteNode(head1, head1);
            Console.WriteLine(GetPrintNodes(head1));

            Console.ReadKey();
        }

        /// <summary>
        /// O(1)时间内删除链表节点
        /// </summary>
        /// <param name="headNode">头结点</param>
        /// <param name="deleteNode">待删除节点</param>
        public static void DeleteNode(Node<int> headNode, Node<int> deleteNode)
        {
            if (headNode == null || deleteNode == null)
            {
                return;
            }

            if (deleteNode.Next != null) // 链表有多个节点，要删除的不是尾节点:O(1)时间
            {
                Node<int> tempNode = deleteNode.Next;
                deleteNode.Item = tempNode.Item;
                deleteNode.Next = tempNode.Next;

                tempNode = null;
            }
            else if (headNode == deleteNode) // 链表只有一个结点，删除头结点（也是尾结点）:O(1)时间
            {
                deleteNode = headNode = null;
            }
            else // 链表有多个节点，要删除的是尾节点:O(n)时间
            {
                Node<int> tempNode = headNode;
                while(tempNode.Next != deleteNode)
                {
                    tempNode = tempNode.Next;
                }

                tempNode.Next = null;
                deleteNode = null;
            }
        }

        public static string GetPrintNodes(Node<int> headNode)
        {
            if (headNode == null)
            {
                return string.Empty;
            }

            StringBuilder sbNodes = new StringBuilder();
            while(headNode != null)
            {
                sbNodes.Append(headNode.Item);
                headNode = headNode.Next;
            }

            return sbNodes.ToString();
        }
    }
}
