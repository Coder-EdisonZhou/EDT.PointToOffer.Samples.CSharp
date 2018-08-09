using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.QueueWithTwoStacks
{
    public class CQueue<T>
    {
        private Stack<T> stack1;
        private Stack<T> stack2;

        public CQueue()
        {
            this.stack1 = new Stack<T>();
            this.stack2 = new Stack<T>();
        }

        public void AppendTail(T item)
        {
            stack1.Push(item);
        }

        public T DeleteHead()
        {
            if(stack2.Count <= 0)
            {
                while(stack1.Count > 0)
                {
                    T item = stack1.Pop();
                    stack2.Push(item);
                }
            }

            if(stack2.Count == 0)
            {
                throw new Exception("The queue is empty!");
            }

            T head = stack2.Pop();
            return head;
        }
    }
}
