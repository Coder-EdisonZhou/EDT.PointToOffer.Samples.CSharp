using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.SequenceOfBST
{
    public static class SequenceHelper
    {
        public static bool VerifySquenceOfBST(int[] sequence, int length)
        {
            if (sequence == null || length <= 0)
            {
                return false;
            }

            int root = sequence[length - 1];

            int i = 0;
            // 在二叉搜索树中左子树的结点小于根结点
            for (; i < length - 1; i++)
            {
                if (sequence[i] > root)
                {
                    break;
                }
            }
            // 在二叉搜索树中右子树的结点大于根结点
            int j = i;
            for (; j < length - 1; j++)
            {
                if (sequence[j] < root)
                {
                    // 如果找到小于根节点直接返回false
                    return false;
                }
            }
            // 判断左子树是不是二叉搜索树
            bool leftIsBST = true;
            if (i > 0)
            {
                leftIsBST = VerifySquenceOfBST(sequence, i);
            }
            // 判断右子树是不是二叉搜索树
            bool rightIsBST = true;
            if (j < length - 1)
            {
                // C#中无法直接操作指针，在C/C++可以直接传递sequence+i
                int[] newSequence = sequence.Skip(i).ToArray();
                rightIsBST = VerifySquenceOfBST(newSequence, length - i - 1);
            }

            return leftIsBST && rightIsBST;
        }
    }
}
