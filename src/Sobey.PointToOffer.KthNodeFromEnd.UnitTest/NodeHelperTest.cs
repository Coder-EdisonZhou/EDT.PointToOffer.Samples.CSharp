using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.KthNodeFromEnd.UnitTest
{
    [TestClass]
    public class NodeHelperTest
    {
        // 01.测试要找的结点在链表中间
        [TestMethod]
        public void FindKthNodeTest1()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;

            Assert.AreEqual(NodeHelper.FindKthToTail(node1, 4), node2);
        }

        // 02.测试要找的结点是链表的尾结点
        [TestMethod]
        public void FindKthNodeTest2()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;

            Assert.AreEqual(NodeHelper.FindKthToTail(node1, 1), node5);
        }

        // 03.测试要找的结点是链表的头结点
        [TestMethod]
        public void FindKthNodeTest3()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;

            Assert.AreEqual(NodeHelper.FindKthToTail(node1, 5), node1);
        }

        // 04.测试空链表
        [TestMethod]
        public void FindKthNodeTest4()
        {
            Assert.AreEqual(NodeHelper.FindKthToTail(null, 100), null);
        }

        // 05.测试输入的第二个参数大于链表的结点总数
        [TestMethod]
        public void FindKthNodeTest5()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;

            Assert.AreEqual(NodeHelper.FindKthToTail(node1, 6), null);
        }

        // 06.测试输入的第二个参数等于0
        [TestMethod]
        public void FindKthNodeTest6()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;

            Assert.AreEqual(NodeHelper.FindKthToTail(node1, 0), null);
        }
    }
}
