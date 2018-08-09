using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.NumberOf1InBinary
{
    public static class BinaryHelper
    {
        /// <summary>
        /// v1:可能引起死循环的解法
        /// </summary>
        public static int NumberOf1Solution1(int n)
        {
            int count = 0;

            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    count++;
                }

                n = n >> 1;
            }

            return count;
        }

        /// <summary>
        /// v2:避免死循环的常规解法
        /// </summary>
        public static int NumberOf1Solution2(long n)
        {
            int count = 0;
            uint flag = 1;
            while (flag >= 1)
            {
                if ((n & flag) > 0)
                {
                    count++;
                }

                flag = flag << 1;
            }

            return count;
        }

        /// <summary>
        /// v3:高效的解法
        /// </summary>
        public static int NumberOf1Solution3(long n)
        {
            int count = 0;

            while (n > 0)
            {
                count++;
                n = (n - 1) & n;
            }

            return count;
        }
    }
}
