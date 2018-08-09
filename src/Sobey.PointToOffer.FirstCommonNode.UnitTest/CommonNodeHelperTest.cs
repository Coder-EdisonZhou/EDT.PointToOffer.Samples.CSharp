using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.FirstCommonNode.UnitTest
{
    [TestClass]
    public class CommonNodeHelperTest
    {
        private void DestoryNode(Node node)
        {
            if (node != null)
            {
                node = null;
            }
        }

        // 第一个公共结点在链表中间
        // 1 - 2 - 3 \
        //            6 - 7
        //     4 - 5 /
        [TestMethod]
        public void FindTest1()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            Node node7 = new Node(7);

            // first
            node1.nextNode = node2;
            node2.nextNode = node3;
            node3.nextNode = node6;
            node6.nextNode = node7;
            // second
            node4.nextNode = node5;
            node5.nextNode = node6;

            Node actual = CommonNodeHelper.FindFirstCommonNode(node1, node4);
            Assert.AreEqual(actual.key, 6);

            DestoryNode(node1);
            DestoryNode(node2);
            DestoryNode(node3);
            DestoryNode(node4);
            DestoryNode(node5);
            DestoryNode(node6);
            DestoryNode(node7);
        }

        // 没有公共结点
        // 1 - 2 - 3 - 4
        //            
        // 5 - 6 - 7
        [TestMethod]
        public void FindTest2()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            Node node7 = new Node(7);

            // first
            node1.nextNode = node2;
            node2.nextNode = node3;
            node3.nextNode = node4;
            
            // second
            node5.nextNode = node6;
            node6.nextNode = node7;

            Node actual = CommonNodeHelper.FindFirstCommonNode(node1, node5);
            Assert.AreEqual(actual, null);

            DestoryNode(node1);
            DestoryNode(node2);
            DestoryNode(node3);
            DestoryNode(node4);
            DestoryNode(node5);
            DestoryNode(node6);
            DestoryNode(node7);
        }

        // 公共结点是最后一个结点
        //         5 - 6 \
        //                7
        // 1 - 2 - 3 - 4 /
        [TestMethod]
        public void FindTest3()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            Node node7 = new Node(7);

            // first
            node1.nextNode = node2;
            node2.nextNode = node3;
            node3.nextNode = node4;
            node4.nextNode = node7;
            // second
            node5.nextNode = node6;
            node6.nextNode = node7;

            Node actual = CommonNodeHelper.FindFirstCommonNode(node5, node1);
            Assert.AreEqual(actual.key, 7);

            DestoryNode(node1);
            DestoryNode(node2);
            DestoryNode(node3);
            DestoryNode(node4);
            DestoryNode(node5);
            DestoryNode(node6);
            DestoryNode(node7);
        }

        // 公共结点是第一个结点
        // 1 - 2 - 3 - 4 - 5
        // 两个链表完全重合   
        [TestMethod]
        public void FindTest4()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            Node node7 = new Node(7);

            // first & second
            node1.nextNode = node2;
            node2.nextNode = node3;
            node3.nextNode = node4;
            node4.nextNode = node5;

            Node actual = CommonNodeHelper.FindFirstCommonNode(node1, node1);
            Assert.AreEqual(actual.key, 1);

            DestoryNode(node1);
            DestoryNode(node2);
            DestoryNode(node3);
            DestoryNode(node4);
            DestoryNode(node5);
            DestoryNode(node6);
            DestoryNode(node7);
        }

        // 输入的两个链表有一个空链表
        [TestMethod]
        public void FindTest5()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            // first & second
            node1.nextNode = node2;
            node2.nextNode = node3;
            node3.nextNode = node4;
            node4.nextNode = node5;

            Node actual = CommonNodeHelper.FindFirstCommonNode(node1, null);
            Assert.AreEqual(actual, null);

            DestoryNode(node1);
            DestoryNode(node2);
            DestoryNode(node3);
            DestoryNode(node4);
            DestoryNode(node5);
        }

        // 输入的两个链表均为空链表
        [TestMethod]
        public void FindTest6()
        {
            Node actual = CommonNodeHelper.FindFirstCommonNode(null, null);
            Assert.AreEqual(actual, null);
        }
    }
}
