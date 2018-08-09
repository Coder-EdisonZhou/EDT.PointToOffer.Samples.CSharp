using System;
using System.Collections.Generic;
using System.Text;

namespace Sobey.PointToOffer.StringPermutation
{
    /// <summary>
    /// 字符串的排列
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();

            Console.ReadKey();
        }

        #region 01.功能实现
        public static void Permutation(char[] str)
        {
            if (str == null)
            {
                return;
            }

            Permutation(str, str, 0);
        }

        public static void Permutation(char[] str, char[] begin, int startIndex)
        {
            if (startIndex == str.Length)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = startIndex; i < str.Length; i++)
                {
                    char temp = begin[i];
                    begin[i] = begin[startIndex];
                    begin[startIndex] = temp;

                    Permutation(str, begin, startIndex + 1);

                    temp = begin[i];
                    begin[i] = begin[startIndex];
                    begin[startIndex] = temp;
                }
            }
        }
        #endregion

        #region 02.单元测试
        public static void TestPortal(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Test for NULL begins:");
                Permutation(null);
            }
            else
            {
                Console.WriteLine("Test for {0} begins:", str);
                Permutation(str.ToCharArray());
            }

            Console.WriteLine();
        }

        public static void Test1()
        {
            TestPortal(null);
        }

        public static void Test2()
        {
            string str = "";
            TestPortal(str);
        }

        public static void Test3()
        {
            string str = "a";
            TestPortal(str);
        }

        public static void Test4()
        {
            string str = "ab";
            TestPortal(str);
        }

        public static void Test5()
        {
            string str = "abc";
            TestPortal(str);
        }
        #endregion
    }
}
