using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.MergeSortedLists.UnitTest
{
    [TestClass]
    public class MergeTest
    {
        #region 测试对象初始化与清理
        private MergeHelper mergeHelper;

        [TestInitialize]
        public void Initialize()
        {
            // 实例化
            mergeHelper = new MergeHelper();
        }

        [TestCleanup]
        public void CleanUp()
        {
            // 不用TA了
            mergeHelper = null;
        } 
        #endregion

        #region 功能测试
        // list1: 1->3->5
        // list2: 2->4->6
        [TestMethod]
        public void MergeTest1()
        {
            Node node1 = new Node(1);
            Node node3 = new Node(3);
            Node node5 = new Node(5);

            node1.Next = node3;
            node3.Next = node5;

            Node node2 = new Node(2);
            Node node4 = new Node(4);
            Node node6 = new Node(6);

            node2.Next = node4;
            node4.Next = node6;

            Node newHead = mergeHelper.Merge(node1, node2);
            Assert.AreEqual(GetListString(newHead), "123456");
        }

        // 两个链表中有重复的数字
        // list1: 1->3->5
        // list2: 1->3->5
        [TestMethod]
        public void MergeTest2()
        {
            Node node1 = new Node(1);
            Node node3 = new Node(3);
            Node node5 = new Node(5);

            node1.Next = node3;
            node3.Next = node5;

            Node node2 = new Node(1);
            Node node4 = new Node(3);
            Node node6 = new Node(5);

            node2.Next = node4;
            node4.Next = node6;

            Node newHead = mergeHelper.Merge(node1, node2);
            Assert.AreEqual(GetListString(newHead), "113355");
        } 
        #endregion

        #region 特殊输入测试
        // 两个链表都只有一个数字
        // list1: 1
        // list2: 2
        [TestMethod]
        public void MergeTest3()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);

            Node newHead = mergeHelper.Merge(node1, node2);
            Assert.AreEqual(GetListString(newHead), "12");
        }

        // 两个链表中有一个空链表
        // list1: 1->3->5
        // list2: null
        [TestMethod]
        public void MergeTest4()
        {
            Node node1 = new Node(1);
            Node node3 = new Node(3);
            Node node5 = new Node(5);

            node1.Next = node3;
            node3.Next = node5;

            Node newHead = mergeHelper.Merge(node1, null);
            Assert.AreEqual(GetListString(newHead), "135");
        }

        // 两个链表都是空链表
        // list1: null
        // list2: null
        [TestMethod]
        public void MergeTest5()
        {
            Node newHead = mergeHelper.Merge(null, null);
            Assert.AreEqual(GetListString(newHead), null);
        } 
        #endregion

        #region 测试辅助方法
        // 测试辅助方法
        public string GetListString(Node head)
        {
            if (head == null)
            {
                return null;
            }

            StringBuilder sbList = new StringBuilder();
            while (head != null)
            {
                sbList.Append(head.Data.ToString());
                head = head.Next;
            }

            return sbList.ToString();
        } 
        #endregion
    }
}
