using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.ReplaceBlank
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int length = 100;
            char[] target = new char[length];
            for (int i = 0; i < length; i++)
            {
                target[i] = '\0';
            }
            target[0] = 'h';
            target[1] = 'e';
            target[2] = 'l';
            target[3] = 'l';
            target[4] = 'o';
            target[5] = ' ';
            target[6] = 'w';
            target[7] = 'o';
            target[8] = 'r';
            target[9] = 'l';
            target[10] = 'd';

            ReplaceBlank(target, length);

            char[] newTarget = GenerateNewTarget(target);

            for (int i = 0; i < newTarget.Length; i++)
            {
                Console.Write(newTarget[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < length && target[i] != '\0'; i++)
            {
                Console.Write(target[i]);
            }

            Console.ReadKey();
        }

        public static char[] GenerateNewTarget(char[] target)
        {
            int length = 0;
            for (int i = 0; i < 100 && target[i] != '\0'; i++)
            {
                length++;
            }

            char[] newTarget = new char[length];

            for (int i = 0; i < 100 && target[i] != '\0'; i++)
            {
                newTarget[i] = target[i];
            }

            return newTarget;
        }

        public static void ReplaceBlank(char[] target, int maxLength)
        {
            if (target == null || maxLength <= 0)
            {
                return;
            }

            // originalLength 为字符串target的实际长度
            int originalLength = 0;
            int blankCount = 0;
            int i = 0;

            while (target[i] != '\0')
            {
                originalLength++;
                // 计算空格数量
                if (target[i] == ' ')
                {
                    blankCount++;
                }
                i++;
            }

            // newLength 为把空格替换成'%20'之后的长度
            int newLength = originalLength + 2 * blankCount;
            if (newLength > maxLength)
            {
                return;
            }

            // 设置两个指针，一个指向原始字符串的末尾，另一个指向替换之后的字符串的末尾
            int indexOfOriginal = originalLength;
            int indexOfNew = newLength;

            while (indexOfOriginal >= 0 && indexOfNew >= 0)
            {
                if (target[indexOfOriginal] == ' ')
                {
                    target[indexOfNew--] = '0';
                    target[indexOfNew--] = '2';
                    target[indexOfNew--] = '%';
                }
                else
                {
                    target[indexOfNew--] = target[indexOfOriginal];
                }

                indexOfOriginal--;
            }
        }
    }
}
