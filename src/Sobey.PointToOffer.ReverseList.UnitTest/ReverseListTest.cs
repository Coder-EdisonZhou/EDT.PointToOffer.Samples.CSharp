using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.ReverseList.UnitTest
{
    [TestClass]
    public class ReverseListTest
    {
        #region 01.辅助方法
        // 辅助方法：生成链表元素的字符串用于对比
        public string GetNodeString(Node head)
        {
            if (head == null)
            {
                return null;
            }

            StringBuilder sbResult = new StringBuilder();
            Node temp = head;
            while (temp != null)
            {
                sbResult.Append(temp.Data.ToString());
                temp = temp.Next;
            }

            return sbResult.ToString();
        } 
        #endregion

        #region 02.功能测试
        // 01.输入的链表有多个结点
        [TestMethod]
        public void ReverseTest1()
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

            Node newHead = ListHelper.ReverseList2(node1);
            Assert.AreEqual(GetNodeString(newHead), "54321");
        }

        // 02.输入的链表只有一个结点
        [TestMethod]
        public void ReverseTest2()
        {
            Node node1 = new Node(1);

            Node newHead = ListHelper.ReverseList2(node1);
            Assert.AreEqual(GetNodeString(newHead), "1");
        }

        // 03.输入NULL
        [TestMethod]
        public void ReverseTest3()
        {
            Node newHead = ListHelper.ReverseList2(null);
            Assert.AreEqual(GetNodeString(newHead), null);
        } 
        #endregion
    }
}
