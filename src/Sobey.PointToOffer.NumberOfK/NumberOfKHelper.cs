using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.NumberOfK
{
    public static class NumberOfKHelper
    {
        public static int GetNumberOfK(int[] data, int k)
        {
            int number = 0;
            if (data != null && data.Length > 0)
            {
                int first = GetFirstK(data, k, 0, data.Length - 1);
                int last = GetLastK(data, k, 0, data.Length - 1);

                if (first > -1 && last > -1)
                {
                    number = last - first + 1;
                }
            }
            return number;
        }

        // 找到数组中第一个k的下标。如果数组中不存在k，返回-1
        private static int GetFirstK(int[] data, int k, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }

            int middIndex = (start + end) / 2;
            int middData = data[middIndex];

            if (middData == k)
            {
                if ((middIndex > 0 && data[middIndex - 1] != k) || middIndex == 0)
                {
                    return middIndex;
                }
                else
                {
                    end = middIndex - 1;
                }
            }
            else if (middData > k)
            {
                end = middIndex - 1;
            }
            else
            {
                start = middIndex + 1;
            }

            return GetFirstK(data, k, start, end);
        }

        // 找到数组中最后一个k的下标。如果数组中不存在k，返回-1
        private static int GetLastK(int[] data, int k, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }

            int middIndex = (start + end) / 2;
            int middData = data[middIndex];

            if (middData == k)
            {
                if ((middIndex < data.Length - 1 && data[middIndex + 1] != k) || middIndex == end)
                {
                    return middIndex;
                }
                else
                {
                    start = middIndex + 1;
                }
            }
            else if (middData > k)
            {
                end = middIndex - 1;
            }
            else
            {
                start = middIndex + 1;
            }

            return GetLastK(data, k, start, end);
        }
    }
}
