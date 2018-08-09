using System;
using System.Collections;
using System.Collections.Generic;

namespace Sobey.PointToOffer.PrintListInReversedOrder
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintTest1();
            PrintTest2();
            PrintTest3();

            Console.ReadKey();
        }

        #region 功能实现代码
        /// <summary>
        /// 非递归版
        /// </summary>
        /// <param name="linkedList"></param>
        public static void PrintListReversinglyIteratively(Node<int> head)
        {
            Stack<Node<int>> stackNodes = new Stack<Node<int>>();
            Node<int> node = head;
            // 单链表元素依次入栈
            while (node != null)
            {
                stackNodes.Push(node);
                node = node.Next;
            }
            // 栈中的单链表元素依次出栈
            while (stackNodes.Count > 0)
            {
                Node<int> top = stackNodes.Pop();
                Console.Write("{0}", top.Item);
            }
        }

        /// <summary>
        /// 递归版
        /// 基于递归的代码看起来很简洁，但有个问题：
        /// 当链表非常长的时候，就会导致函数调用的层级很深，从而有可能导致函数调用栈溢出。
        /// </summary>
        public static void PrintListReversinglyRecursively(Node<int> head)
        {
            if (head != null)
            {
                if (head.Next != null)
                {
                    PrintListReversinglyRecursively(head.Next);
                }

                Console.Write("{0}", head.Item);
            }
        } 
        #endregion

        #region 单元测试代码
        // 测试主入口
        static void PrintTestPortal(Node<int> head)
        {
            Console.WriteLine("-------Begin--------");
            NormalPrint(head);
            Console.WriteLine();
            PrintListReversinglyIteratively(head);
            Console.WriteLine();
            PrintListReversinglyRecursively(head);
            Console.WriteLine("\n-------End--------");
        }
        // 辅助方法：正序打印链表
        static void NormalPrint(Node<int> head)
        {
            Node<int> temp = head;
            while(temp != null)
            {
                Console.Write("{0}",temp.Item);
                temp = temp.Next;
            }
        }

        // 1->2->3->4->5
        static void PrintTest1()
        {
            Console.WriteLine("TestCase1:");
            SingleLinkedList<int> linkedList = new SingleLinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);

            PrintTestPortal(linkedList.Head);
        }

        // 只有一个节点的链表
        static void PrintTest2()
        {
            Console.WriteLine("TestCase2:");
            SingleLinkedList<int> linkedList = new SingleLinkedList<int>();
            linkedList.Add(1);

            PrintTestPortal(linkedList.Head);
        }

        // 空链表
        static void PrintTest3()
        {
            Console.WriteLine("TestCase3:");

            PrintTestPortal(null);
        } 
        #endregion
    }
}
