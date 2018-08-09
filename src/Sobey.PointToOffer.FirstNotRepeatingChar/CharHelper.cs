using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.FirstNotRepeatingChar
{
    public static class CharHelper
    {
        public static char FirstNotRepeatingChar(string str)
        {
            if(string.IsNullOrEmpty(str))
            {
                return '\0';
            }

            char[] array = str.ToCharArray();
            const int size = 256;
            // 借助数组来模拟哈希表，只用1K的空间消耗
            uint[] hastTable = new uint[size];
            // 初始化数组
            for (int i = 0; i < size; i++)
            {
                hastTable[i] = 0;
            }

            for (int i = 0; i < array.Length; i++)
            {
                hastTable[array[i]]++;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (hastTable[array[i]] == 1)
                {
                    return array[i];
                }
            }

            return '\0';
        }
    }
}
