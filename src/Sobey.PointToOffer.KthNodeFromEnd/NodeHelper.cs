using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.KthNodeFromEnd
{
    public static class NodeHelper
    {
        /// <summary>
        /// 获取链表中倒数第k个节点
        /// </summary>
        public static Node FindKthToTail(Node head, uint k)
        {
            // 提高鲁棒性：空指针和0的处理
            if(head == null || k == 0)
            {
                return null;
            }

            Node ahead = head;
            Node behind = null;

            for (int i = 0; i < k - 1; i++)
            {
                if(ahead.Next != null)
                {
                    ahead = ahead.Next;
                }
                else
                {
                    return null;
                }
            }

            behind = head;

            while (ahead.Next != null)
            {
                ahead = ahead.Next;
                behind = behind.Next;
            }

            return behind;
        }
    }
}
