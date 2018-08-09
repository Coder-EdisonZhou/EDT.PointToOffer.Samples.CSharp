using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.ReverseList
{
    /// <summary>
    /// 单链表节点定义
    /// </summary>
    /// <typeparam name="T">元素类型</typeparam>
    public class Node
    {
        public int Data { get; set; }
        // 指向后一个节点
        public Node Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }

        public Node(int data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
    }
}
