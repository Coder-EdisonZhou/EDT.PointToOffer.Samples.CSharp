using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.MinNumberInRotatedArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 1, 2, 3 };
            int minNum = GetMin(array);
            Console.WriteLine("Min num in roated array is {0}", minNum);
            Console.ReadKey();
        }

        public static int GetMin(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 0)
            {
                return int.MinValue;
            }

            int index1 = 0;
            int index2 = numbers.Length - 1;
            // 把indexMid初始化为index1的原因：
            // 一旦发现数组中第一个数字小于最后一个数字，表明该数组是排序的
            // 就可以直接返回第一个数字了
            int indexMid = index1;

            while (numbers[index1] >= numbers[index2])
            {
                // 如果index1和index2指向相邻的两个数，
                // 则index1指向第一个递增子数组的最后一个数字，
                // index2指向第二个子数组的第一个数字，也就是数组中的最小数字
                if (index2 - index1 == 1)
                {
                    indexMid = index2;
                    break;
                }
                indexMid = (index1 + index2) / 2;
                // 特殊情况：如果下标为index1、index2和indexMid指向的三个数字相等，则只能顺序查找
                if (numbers[index1] == numbers[indexMid] && numbers[indexMid] == numbers[index2])
                {
                    return GetMinInOrder(numbers, index1, index2);
                }
                // 缩小查找范围
                if (numbers[indexMid] >= numbers[index1])
                {
                    index1 = indexMid;
                }
                else if (numbers[indexMid] <= numbers[index2])
                {
                    index2 = indexMid;
                }
            }

            return numbers[indexMid];
        }

        public static int GetMinInOrder(int[] numbers, int index1, int index2)
        {
            int result = numbers[index1];
            for (int i = index1 + 1; i <= index2; ++i)
            {
                if (result > numbers[i])
                {
                    result = numbers[i];
                }
            }

            return result;
        }
    }
}
