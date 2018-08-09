using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.MinInStack
{
    public class MinInStack<T> where T : IComparable
    {
        private Stack<T> dataStack;
        private Stack<T> minStack;

        public MinInStack()
        {
            this.dataStack = new Stack<T>();
            this.minStack = new Stack<T>();
        }

        public bool IsEmpty()
        {
            return this.dataStack.Count == 0;
        }

        public T Top()
        {
            return this.dataStack.Peek();
        }

        public void Push(T item)
        {
            // 把新元素添加到数据栈
            dataStack.Push(item);
            // 当新元素比之前的最小元素小时，把新元素插入辅助栈里；
            // 否则把之前的最小元素重复插入辅助栈里
            if (minStack.Count == 0 || item.CompareTo(minStack.Peek()) < 0)
            {
                minStack.Push(item);
            }
            else
            {
                minStack.Push(minStack.Peek());
            }
        }

        public T Pop()
        {
            T item = dataStack.Pop();
            if(minStack.Count > 0)
            {
                minStack.Pop();
            }

            return item;
        }

        public T Min()
        {
            return minStack.Peek();
        }
    }
}
