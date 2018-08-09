using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.DeleteNodeInList.UnitTest
{
    [TestClass]
    public class DeleteNodeTest
    {
        // 链表中有多个结点，删除中间的结点
        [TestMethod]
        public void DeleteNodeTest1()
        {
            Node<int> head1 = new Node<int>(1);
            Node<int> head2 = new Node<int>(2);
            Node<int> head3 = new Node<int>(3);
            Node<int> head4 = new Node<int>(4);
            Node<int> head5 = new Node<int>(5);

            head1.Next = head2;
            head2.Next = head3;
            head3.Next = head4;
            head4.Next = head5;

            Program.DeleteNode(head1, head3);
            Assert.AreEqual(Program.GetPrintNodes(head1),"1245");
        }

        // 链表中有多个结点，删除尾结点
        [TestMethod]
        public void DeleteNodeTest2()
        {
            Node<int> head1 = new Node<int>(1);
            Node<int> head2 = new Node<int>(2);
            Node<int> head3 = new Node<int>(3);
            Node<int> head4 = new Node<int>(4);
            Node<int> head5 = new Node<int>(5);

            head1.Next = head2;
            head2.Next = head3;
            head3.Next = head4;
            head4.Next = head5;

            Program.DeleteNode(head1, head5);
            Assert.AreEqual(Program.GetPrintNodes(head1), "1234");
        }

        // 链表中有多个结点，删除头结点
        [TestMethod]
        public void DeleteNodeTest3()
        {
            Node<int> head1 = new Node<int>(1);
            Node<int> head2 = new Node<int>(2);
            Node<int> head3 = new Node<int>(3);
            Node<int> head4 = new Node<int>(4);
            Node<int> head5 = new Node<int>(5);

            head1.Next = head2;
            head2.Next = head3;
            head3.Next = head4;
            head4.Next = head5;

            Program.DeleteNode(head1, head1);
            Assert.AreEqual(Program.GetPrintNodes(head1), "2345");
        }

        // 链表中只有一个结点，删除头结点
        [TestMethod]
        public void DeleteNodeTest4()
        {
            Node<int> head1 = new Node<int>(1);

            Program.DeleteNode(head1, head1);
            Assert.AreEqual(Program.GetPrintNodes(head1), "");
        }

        // 链表为空
        [TestMethod]
        public void DeleteNodeTest5()
        {
            Program.DeleteNode(null, null);
            Assert.AreEqual(Program.GetPrintNodes(null), "");
        }
    }
}
