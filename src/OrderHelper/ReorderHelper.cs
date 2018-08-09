using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.ReorderArray
{
    public static class ReorderHelper
    {
        /// <summary>
        /// 调整数组使得奇数在前偶数在后 v1.0
        /// </summary>
        /// <param name="datas">整数数组</param>
        public static void ReorderOddEven(int[] datas)
        {
            if (datas == null || datas.Length <= 0)
            {
                return;
            }

            int begin = 0;
            int end = datas.Length - 1;
            int temp = -1;

            while (begin < end)
            {
                // 向后移动begin，直到它指向偶数
                while (begin < end && datas[begin] % 2 != 0)
                {
                    begin++;
                }
                // 向前移动pEnd，直到它指向奇数
                while (begin < end && datas[end] % 2 == 0)
                {
                    end--;
                }

                if (begin < end)
                {
                    // 交换偶数和奇数
                    temp = datas[begin];
                    datas[begin] = datas[end];
                    datas[end] = temp;
                }
            }
        }

        /// <summary>
        /// 调整数组使得奇数在前偶数在后 v2.0
        /// </summary>
        /// <param name="datas">整数数组</param>
        public static void ReorderOddEven(int[] datas, Predicate<int> func)
        {
            if (datas == null || datas.Length <= 0)
            {
                return;
            }

            int begin = 0;
            int end = datas.Length - 1;
            int temp = -1;

            while (begin < end)
            {
                // 向后移动begin，直到它指向偶数
                while (begin < end && !func(datas[begin]))
                {
                    begin++;
                }
                // 向前移动pEnd，直到它指向奇数
                while (begin < end && func(datas[end]))
                {
                    end--;
                }

                if (begin < end)
                {
                    // 交换偶数和奇数
                    temp = datas[begin];
                    datas[begin] = datas[end];
                    datas[end] = temp;
                }
            }
        }
    }
}
