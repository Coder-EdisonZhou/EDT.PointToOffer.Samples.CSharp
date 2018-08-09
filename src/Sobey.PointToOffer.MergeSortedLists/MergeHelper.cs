using System;
using System.Collections.Generic;
using System.Text;

namespace Sobey.PointToOffer.MergeSortedLists
{
    public class MergeHelper
    {
        /// <summary>
        /// 合并两个排序的链表 v1.0
        /// </summary>
        /// <param name="head1">第一个链表的头结点</param>
        /// <param name="head2">第二个链表的头结点</param>
        public Node Merge(Node head1, Node head2)
        {
            if (head1 == null)
            {
                return head2;
            }
            else if (head2 == null)
            {
                return head1;
            }

            Node newHead = null;

            if (head1.Data <= head2.Data)
            {
                newHead = head1;
                newHead.Next = Merge(head1.Next, head2);
            }
            else
            {
                newHead = head2;
                newHead.Next = Merge(head1, head2.Next);
            }

            return newHead;
        }
    }
}
