using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sobey.PointToOffer.UglyNumber.Common;

namespace Sobey.PointToOffer.UglyNumber
{
    public class Program
    {
    public static void Main(string[] args)
    {
        Program p = new Program();
        //p.Test(1);
        //p.Test(2);
        //p.Test(3);
        //p.Test(4);
        //p.Test(5);
        //p.Test(6);
        //p.Test(7);
        //p.Test(8);
        //p.Test(9);
        //p.Test(10);
        //p.Test(11);
        p.Test(1500);
        //p.Test(0);

        Console.ReadKey();
    }

        #region Part01.功能实现
        #region Solution01.蛮力法
        public int GetUglyNumberNoSpace(int index)
        {
            if (index <= 0)
            {
                return 0;
            }

            int number = 0;
            int uglyCount = 0;

            while (uglyCount < index)
            {
                number++;

                if (IsUgly(number))
                {
                    uglyCount++;
                }
            }

            return number;
        }

        private bool IsUgly(int number)
        {
            while (number % 2 == 0)
            {
                number /= 2;
            }

            while (number % 3 == 0)
            {
                number /= 3;
            }

            while (number % 5 == 0)
            {
                number /= 5;
            }

            return number == 1 ? true : false;
        }
        #endregion

        #region Solution02.以空间换时间法
        public int GetUglyNumberWithSpace(int index)
        {
            if (index <= 0)
            {
                return 0;
            }

            int[] uglyNumbers = new int[index];
            uglyNumbers[0] = 1;
            int nextUglyIndex = 1;

            int multiply2 = 0;
            int multiply3 = 0;
            int multiply5 = 0;
            int min = 0;

            while (nextUglyIndex < index)
            {
                min = Min(uglyNumbers[multiply2] * 2, uglyNumbers[multiply3] * 3, uglyNumbers[multiply5] * 5);
                uglyNumbers[nextUglyIndex] = min;

                while (uglyNumbers[multiply2] * 2 <= uglyNumbers[nextUglyIndex])
                {
                    multiply2++;
                }

                while (uglyNumbers[multiply3] * 3 <= uglyNumbers[nextUglyIndex])
                {
                    multiply3++;
                }

                while (uglyNumbers[multiply5] * 5 <= uglyNumbers[nextUglyIndex])
                {
                    multiply5++;
                }

                nextUglyIndex++;
            }

            int result = uglyNumbers[index - 1];
            uglyNumbers = null;

            return result;
        }

        private int Min(int num1, int num2, int num3)
        {
            int min = num1 < num2 ? num1 : num2;
            min = min < num3 ? min : num3;

            return min;
        }
        #endregion
        #endregion

        #region Part02.单元测试
        public void Test(int index)
        {
            int result = 0;
            //CodeTimer.Time("GetUglyNumber_Simple_Test", 1, () =>
            //{
            //    result = GetUglyNumberNoSpace(index);
            //});
            //Console.WriteLine("Test result is {0}", result);
            CodeTimer.Time("GetUglyNumber_Advanced_Test", 1, () =>
            {
                result = GetUglyNumberWithSpace(index);
            });
            result = GetUglyNumberWithSpace(index);
            Console.WriteLine("Test result is {0}", result);
        }
        #endregion
    }
}
