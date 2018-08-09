using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.FirstCommonNode
{
    public static class CommonNodeHelper
    {
        // V1.0 使用栈找到第一个公共节点
        //public static Node FindFirstCommonNode(Node head1, Node head2)
        //{
        //    if(head1 == null || head2 == null)
        //    {
        //        return null;
        //    }

        //    Stack<Node> stack1 = new Stack<Node>();
        //    Stack<Node> stack2 = new Stack<Node>();

        //    while(head1 != null)
        //    {
        //        stack1.Push(head1);
        //        head1 = head1.nextNode;
        //    }

        //    while(head2 != null)
        //    {
        //        stack2.Push(head2);
        //        head2 = head2.nextNode;
        //    }

        //    Node node1 = null;
        //    Node node2 = null;
        //    Node common = null;

        //    while(stack1.Count > 0 && stack2.Count > 0)
        //    {
        //        node1 = stack1.Peek();
        //        node2 = stack2.Peek();

        //        if (node1.key == node2.key)
        //        {
        //            common = node1;
        //            stack1.Pop();
        //            stack2.Pop();
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }

        //    return common;
        //}

        public static Node FindFirstCommonNode(Node head1, Node head2)
        {
            // 得到两个链表的长度
            int length1 = GetListLength(head1);
            int length2 = GetListLength(head2);
            int diff = length1 - length2;

            Node headLong = head1;
            Node headShort = head2;
            if (diff < 0)
            {
                headLong = head2;
                headShort = head1;
                diff = length2 - length1;
            }

            // 先在长链表上走几步
            for (int i = 0; i < diff; i++)
            {
                headLong = headLong.nextNode;
            }
            // 再同时在两个链表上遍历
            while (headLong != null && headShort != null && headLong != headShort)
            {
                headLong = headLong.nextNode;
                headShort = headShort.nextNode;
            }

            Node commonNode = headLong;
            return commonNode;
        }

        private static int GetListLength(Node head)
        {
            int length = 0;
            Node tempNode = head;
            while (tempNode != null)
            {
                tempNode = tempNode.nextNode;
                length++;
            }

            return length;
        }
    }
}
