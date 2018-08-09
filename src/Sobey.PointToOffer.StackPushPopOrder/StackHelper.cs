using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.StackPushPopOrder
{
    public static class StackHelper
    {
        public static bool IsPopOrder(int[] pushOrder, int[] popOrder, int length)
        {
            bool possible = false;

            if (pushOrder != null && popOrder != null && length > 0)
            {
                int nextPush = 0; // 指向下一个要push的元素的index
                int nextPop = 0;  // 指向下一个要pop的元素的index
                int pop = 0;      // 指向popOrder的首个元素的index
                int push = 0;     // 指向pushOrder的首个元素的index

                Stack<int> stackData = new Stack<int>();
                while (nextPop - pop < length)
                {
                    // 当辅助栈的栈顶元素不是要弹出的元素
                    // 先压入一些数字入栈
                    while (stackData.Count == 0 || stackData.Peek() != popOrder[nextPop])
                    {
                        // 如果所有数字都压入辅助栈了，退出循环
                        if (nextPush - push == length)
                        {
                            break;
                        }

                        stackData.Push(pushOrder[nextPush]);
                        nextPush++;
                    }

                    // 说明没有匹配成功
                    if (stackData.Peek() != popOrder[nextPop])
                    {
                        break;
                    }

                    stackData.Pop();
                    nextPop++;
                }

                if (stackData.Count == 0 && nextPop - pop == length)
                {
                    possible = true;
                }
            }

            return possible;
        }
    }
}
