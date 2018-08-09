using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.Fibonacci
{
    public static class FibonaaciHelper
    {
        /// <summary>
        /// 递归版：效率低下
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long FibonacciRecursively(uint n)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            return FibonacciRecursively(n - 1) + FibonacciRecursively(n - 2);
        }

        /// <summary>
        /// 循环版：较为实用
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long FibonacciIteratively(uint n)
        {
            int[] result = { 0, 1 };
            if (n < 2)
            {
                return result[n];
            }

            long fibNMinusOne = 1;
            long fibNMinusTwo = 0;
            long fibN = 0;

            for (uint i = 2; i <= n; i++)
            {
                fibN = fibNMinusOne + fibNMinusTwo;

                fibNMinusTwo = fibNMinusOne;
                fibNMinusOne = fibN;
            }

            return fibN;
        }
    }
}
