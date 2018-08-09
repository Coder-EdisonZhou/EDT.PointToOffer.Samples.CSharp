using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.StringToInt
{
    public static class StringHelper
    {
        public static ConvertResult StrToInt(string str)
        {
            ConvertResult result = new ConvertResult();
            result.State = ConvertState.InValid;
            result.Number = 0;

            if (!string.IsNullOrEmpty(str))
            {
                bool minus = false;
                char[] strArray = str.ToCharArray();
                int startIndex = 0;
                if (strArray[startIndex] == '+')
                {
                    startIndex++;
                }
                else if (strArray[startIndex] == '-')
                {
                    minus = true;
                    startIndex++;
                }

                if (startIndex != strArray.Length)
                {
                    StrToIntCore(strArray, startIndex, minus, ref result);
                }
            }

            return result;
        }

        private static void StrToIntCore(char[] strArray, int index, bool minus, ref ConvertResult result)
        {
            long number = 0;

            while (index < strArray.Length)
            {
                if (strArray[index] >= '0' && strArray[index] <= '9')
                {
                    // 首先需要注意正负号
                    int flag = minus ? -1 : 1;
                    number = number * 10 + flag * (strArray[index] - '0');
                    // 正整数的最大值是0x7FFFFFFF，最小的负整数是0x80000000
                    // 因此需要考虑整数是否发生上溢出或者下溢出
                    if ((flag == 1 && number > int.MaxValue) ||
                        (flag == -1 && number < int.MinValue))
                    {
                        number = 0;
                        break;
                    }
                    index++;
                }
                else
                {
                    number = 0;
                    break;
                }
            }

            if (index == strArray.Length)
            {
                result.State = ConvertState.Valid;
                result.Number = (int)number;
            }
        }
    }
}
