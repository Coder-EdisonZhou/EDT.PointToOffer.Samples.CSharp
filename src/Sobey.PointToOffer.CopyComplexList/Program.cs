using System;
using System.Collections.Generic;
using System.Text;

namespace Sobey.PointToOffer.CopyComplexList
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Test1();
            //Test2();
            //Test3();
            //Test4();
            Test5();

            Console.ReadKey();
        }

        #region 01.功能实现
        public static ComplexListNode Clone(ComplexListNode head)
        {
            CloneNodes(head);
            ConnectSiblingNodes(head);
            return ReconnectNodes(head);
        }

        // 第一步是根据原始链表的每个结点N创建对应的N'。
        private static void CloneNodes(ComplexListNode head)
        {
            ComplexListNode node = head;
            while (node != null)
            {
                ComplexListNode cloned = new ComplexListNode();
                cloned.Data = node.Data;
                cloned.Next = node.Next;
                cloned.Sibling = null;

                node.Next = cloned;
                node = cloned.Next;
            }
        }

        // 第二步设置复制出来的结点的Sibling。
        private static void ConnectSiblingNodes(ComplexListNode head)
        {
            ComplexListNode node = head;
            while (node != null)
            {
                ComplexListNode cloned = node.Next;
                if (node.Sibling != null)
                {
                    cloned.Sibling = node.Sibling;
                }
                node = cloned.Next;
            }
        }

        // 第三步把这个长链表拆分成两个链表。
        private static ComplexListNode ReconnectNodes(ComplexListNode head)
        {
            ComplexListNode node = head;
            ComplexListNode clonedHead = null;
            ComplexListNode clonedNode = null;

            if (node != null)
            {
                clonedHead = clonedNode = node.Next;
                node.Next = clonedNode.Next;
                node = node.Next;
            }

            while (node != null)
            {
                // 复制链表的连接
                clonedNode.Next = node.Next;
                clonedNode = clonedNode.Next;
                // 原始链表的连接
                node.Next = clonedNode.Next;
                node = node.Next;
            }

            return clonedHead;
        }
        #endregion

        #region 02.单元测试
        public static void TestPortal(string testName, ComplexListNode head)
        {
            if (!string.IsNullOrEmpty(testName))
            {
                Console.WriteLine("{0} begins:", testName);
            }

            Console.WriteLine("The original list is:");
            PrintList(head);

            ComplexListNode clonedHead = Clone(head);
            Console.WriteLine("The cloned list is:");
            PrintList(clonedHead);
        }

        private static void PrintList(ComplexListNode head)
        {
            ComplexListNode node = head;
            while (node != null)
            {
                Console.WriteLine("The value of this node is: {0}.", node.Data);
                if (node.Sibling != null)
                {
                    Console.WriteLine("The value of its sibling is: {0}.", node.Sibling.Data);
                }
                else
                {
                    Console.WriteLine("This node does not have a sibling.");
                }

                Console.WriteLine();

                node = node.Next;
            }
        }

        private static void BuildNodes(ComplexListNode node, ComplexListNode next, ComplexListNode sibling)
        {
            if (node != null)
            {
                node.Next = next;
                node.Sibling = sibling;
            }
        }

    //          -----------------
    //         \|/              |
    //  1-------2-------3-------4-------5
    //  |       |      /|\             /|\
    //  --------+--------               |
    //          -------------------------
    public static void Test1()
    {
        ComplexListNode node1 = new ComplexListNode(1);
        ComplexListNode node2 = new ComplexListNode(2);
        ComplexListNode node3 = new ComplexListNode(3);
        ComplexListNode node4 = new ComplexListNode(4);
        ComplexListNode node5 = new ComplexListNode(5);

        BuildNodes(node1, node2, node3);
        BuildNodes(node2, node3, node5);
        BuildNodes(node3, node4, null);
        BuildNodes(node4, node5, node2);

        TestPortal("Test1", node1);
    }

    // Sibling指向结点自身
    //          -----------------
    //         \|/              |
    //  1-------2-------3-------4-------5
    //         |       | /|\           /|\
    //         |       | --             |
    //         |------------------------|
    public static void Test2()
    {
        ComplexListNode node1 = new ComplexListNode(1);
        ComplexListNode node2 = new ComplexListNode(2);
        ComplexListNode node3 = new ComplexListNode(3);
        ComplexListNode node4 = new ComplexListNode(4);
        ComplexListNode node5 = new ComplexListNode(5);

        BuildNodes(node1, node2, null);
        BuildNodes(node2, node3, node5);
        BuildNodes(node3, node4, node3);
        BuildNodes(node4, node5, node2);

        TestPortal("Test2", node1);
    }

    // Sibling形成环
    //          -----------------
    //         \|/              |
    //  1-------2-------3-------4-------5
    //          |              /|\
    //          |               |
    //          |---------------|
    public static void Test3()
    {
        ComplexListNode node1 = new ComplexListNode(1);
        ComplexListNode node2 = new ComplexListNode(2);
        ComplexListNode node3 = new ComplexListNode(3);
        ComplexListNode node4 = new ComplexListNode(4);
        ComplexListNode node5 = new ComplexListNode(5);

        BuildNodes(node1, node2, null);
        BuildNodes(node2, node3, node4);
        BuildNodes(node3, node4, null);
        BuildNodes(node4, node5, node2);

        TestPortal("Test3", node1);
    }

    // 只有一个结点
    public static void Test4()
    {
        ComplexListNode node1 = new ComplexListNode(1);
        node1.Sibling = node1;

        TestPortal("Test4", node1);
    }

    // 鲁棒性测试
    public static void Test5()
    {
        TestPortal("Test5", null);
    }

        #endregion
    }
}
