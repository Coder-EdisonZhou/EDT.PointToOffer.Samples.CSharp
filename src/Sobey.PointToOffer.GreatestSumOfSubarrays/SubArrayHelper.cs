using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.GreatestSumOfSubarrays
{
    public static class SubArrayHelper
    {
        /// <summary>
        /// 计算连续子数组的最大和
        /// </summary>
        public static int FindGreatestSumOfSubArray(int[] array, out bool isValidInput)
        {
            if (array == null || array.Length <= 0)
            {
                isValidInput = false;
                return 0;
            }

            isValidInput = true;

            int currSum = 0;
            int greatestSum = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if(currSum <= 0)
                {
                    currSum = array[i];
                }
                else
                {
                    currSum += array[i];
                }

                if (currSum > greatestSum)
                {
                    greatestSum = currSum;
                }
            }

            return greatestSum;
        }
    }
}
