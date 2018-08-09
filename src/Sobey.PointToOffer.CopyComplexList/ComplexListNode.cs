using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.CopyComplexList
{
    public class ComplexListNode
    {
        public int Data { get; set; }
        public ComplexListNode Next { get; set; }
        public ComplexListNode Sibling { get; set; }

        public ComplexListNode()
        {
        }

        public ComplexListNode(int data)
        {
            this.Data = data;
        }

        public ComplexListNode(int data, ComplexListNode next, ComplexListNode sibling = null)
        {
            this.Data = data;
            this.Next = next;
            this.Sibling = sibling;
        }
    }
}
