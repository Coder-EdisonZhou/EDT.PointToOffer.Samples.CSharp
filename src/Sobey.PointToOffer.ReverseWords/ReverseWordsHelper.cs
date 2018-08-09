using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.ReverseWords
{
    public static class ReverseWordsHelper
    {
        public static void Reverse(char[] array, int start, int end)
        {
            if (array == null || start < 0 || end > array.Length - 1)
            {
                return;
            }

            while (start < end)
            {
                char temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                start++;
                end--;
            }
        }

        public static string ReverseSentense(string sentense)
        {
            if (string.IsNullOrEmpty(sentense))
            {
                return null;
            }

            char[] array = sentense.ToCharArray();
            int start = 0;
            int end = array.Length - 1;

            // Step1.先翻转整个句子
            Reverse(array, start, end);
            // Step2.再翻转句中的每个单词
            start = end = 0;
            while (start < array.Length)
            {
                if (array[start] == ' ')
                {
                    start++;
                    end++;
                }
                else if (end == array.Length || array[end] == ' ')
                {
                    Reverse(array, start, --end);
                    start = end + 1;
                    end++;
                }
                else
                {
                    end++;
                }
            }

            return new string(array);
        }

        public static string LeftRotateString(string str, int num)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            int strLength = str.Length;
            char[] array = str.ToCharArray();

            if (strLength > 0 && num > 0 && num < strLength)
            {
                int firstStart = 0;
                int firstEnd = num - 1;
                int secondStart = num;
                int secondEnd = strLength - 1;

                // 翻转字符串的前面n个字符
                Reverse(array, firstStart, firstEnd);
                // 翻转字符串的后面部分
                Reverse(array, secondStart, secondEnd);
                // 翻转整个字符串
                Reverse(array, 0, strLength - 1);
            }

            return new string(array);
        }
    }
}
