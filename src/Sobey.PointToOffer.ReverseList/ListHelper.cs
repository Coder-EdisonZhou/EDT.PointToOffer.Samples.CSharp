using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.ReverseList
{
    public static class ListHelper
    {
        /// <summary>
        /// 01.反转给定的链表：借助集合且需要两次遍历链表
        /// </summary>
        /// <param name="head">头结点</param>
        public static Node ReverseList1(Node head)
        {
            if (head == null)
            {
                return null;
            }

            List<Node> nodeList = new List<Node>();
            while (head != null)
            {
                nodeList.Add(head);
                head = head.Next;
            }

            int startIndex = nodeList.Count - 1;
            for (int i = startIndex; i >= 0; i--)
            {
                Node node = nodeList[i];
                if (i == 0)
                {
                    node.Next = null;
                }
                else
                {
                    node.Next = nodeList[i - 1];
                }
            }
            // 现在头结点是原来的尾节点
            head = nodeList[startIndex];
            return head;
        }

        /// <summary>
        /// 02.反转给定的链表：从第2个节点到第n个节点，依次逐节点插入到第1个节点之后，最后将第一个节点挪栋到新链表的尾部
        /// </summary>
        /// <param name="head">头结点</param>
        public static Node ReverseList3(Node head)
        {
            if (head == null)
            {
                return null;
            }

            if (head.Next == null)
            {
                return head;
            }

            Node start = head.Next;
            head.Next = null;
            Node temp = null;
            while (start != null)
            {
                temp = start;
                start = start.Next;
                // 将第2到第N个节点指向头结点
                temp.Next = head;
                // 移动投节点指向下一个节点
                head = temp;
            }
            return head;
        }

        /// <summary>
        /// 03.反转给定的链表：使用三个指针分别指向当前遍历到的结点、它的前一个结点及后一个结点
        /// </summary>
        /// <param name="head">头结点</param>
        public static Node ReverseList2(Node head)
        {
            if (head == null)
            {
                return null;
            }

            Node reverseHead = null;
            // 指针1：当前节点
            Node currentNode = head;
            // 指针2：当前节点的前一个节点
            Node prevNode = null;

            while(currentNode != null)
            {
                // 指针3：当前节点的后一个节点
                Node nextNode = currentNode.Next;
                if(nextNode == null)
                {
                    reverseHead = currentNode;
                }
                // 将当前节点的后一个节点指向前一个节点
                currentNode.Next = prevNode;
                // 将前一个节点指向当前节点
                prevNode = currentNode;
                // 将当前节点指向后一个节点
                currentNode = nextNode;
            }

            return reverseHead;
        }
    }
}
