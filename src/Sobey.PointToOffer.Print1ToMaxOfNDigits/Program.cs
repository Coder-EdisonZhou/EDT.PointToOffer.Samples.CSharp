using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.Print1ToMaxOfNDigits
{
    public class Program
    {
    static void Main(string[] args)
    {
        //Print1ToMaxOfNDigitsSimple(3);
        // 字符串模拟加法运算
        //Print1ToMaxOfNDigits(3);

        PrintTest(1);
        PrintTest(2);
        PrintTest(3);
        PrintTest(0);
        PrintTest(-1);

        Console.ReadKey();
    }

        #region 解法一：不加思索的解法（陷入陷阱）
        // 1.不加思索的解法（陷入陷阱）
        static void Print1ToMaxOfNDigitsSimple(int n)
        {
            int number = 1;
            int i = 0;

            while (i < n)
            {
                number = number * 10;
                i++;
            }

            for (i = 1; i < number; i++)
            {
                Console.Write("{0}\t", i);
            }
        }
        #endregion

        #region 解法二：使用字符串模拟数字加法的解法
        // 2.使用字符串模拟数字加法的解法
        static void Print1ToMaxOfNDigits(int n)
        {
            if (n <= 0)
            {
                return;
            }
            // memset(number,'0',n);
            char[] number = new char[n + 1];
            for (int i = 0; i < n; i++)
            {
                number[i] = '0';
            }
            number[n] = '\0';

            // Increment实现在表示数字的字符串number上增加1
            while (!Increment(number))
            {
                // PrintNumber负责打印出number
                PrintNumber(number);
            }

            number = null;
        }

        static bool Increment(char[] number)
        {
            bool isOverflow = false;
            int takeOver = 0;
            int length = number.Length - 1;

            for (int i = length - 1; i >= 0; i--)
            {
                int sum = number[i] - '0' + takeOver;
                if (i == length - 1)
                {
                    sum++;
                }

                if (sum >= 10)
                {
                    if (i == 0)
                    {
                        // 标识已经溢出了
                        isOverflow = true;
                    }
                    else
                    {
                        sum -= 10;
                        takeOver = 1;
                        number[i] = (char)('0' + sum);
                    }
                }
                else
                {
                    number[i] = (char)('0' + sum);
                    break;
                }
            }

            return isOverflow;
        }

        static void PrintNumber(char[] number)
        {
            bool isBeginning0 = true;

            for (int i = 0; i < number.Length; i++)
            {
                if (isBeginning0 && number[i] != '0')
                {
                    isBeginning0 = false;
                }

                if (!isBeginning0)
                {
                    Console.Write("{0}", number[i]);
                }
            }

            Console.Write("\t");
        }
        #endregion

        #region 单元测试代码
        static void PrintTest(int n)
        {
            Console.WriteLine("Test for {0} begins:", n);
            Print1ToMaxOfNDigits(n);
            Console.WriteLine("\nTest for {0} ends.\n", n);
        }
        #endregion
    }
}
