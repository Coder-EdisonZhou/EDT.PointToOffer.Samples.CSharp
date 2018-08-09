using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.NumberOf1
{
    public static class NumberHelper
    {
        #region 不考虑时间效率的蛮力解法:O(n*logn)
        /// <summary>
        /// 缺点：对每个数字都要做除法和求余运算以求出该数字中1出现的次数
        /// </summary>
        public static int NumberOf1Between1AndN(uint n)
        {
            int number = 0;
            for (uint i = 1; i <= n; i++)
            {
                number += NumberOf1(i);
            }
            return number;
        }

        private static int NumberOf1(uint num)
        {
            int number = 0;
            while (num != 0)
            {
                if (num % 10 == 1)
                {
                    number++;
                }
                num /= 10;
            }
            return number;
        }
        #endregion
    }
}
