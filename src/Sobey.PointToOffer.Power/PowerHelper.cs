using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.Power
{
    public static class PowerHelper
    {
        public static bool isInvalidInput = false;

        public static double Power(double baseNumber, int exponent)
        {
            isInvalidInput = false;

            // 当底数（base）是零且指数是负数的时候提示参数非法
            if (Equals(baseNumber, 0.0) && exponent < 0)
            {
                isInvalidInput = true;
                return 0.0;
            }

            uint absExponent = (uint)exponent;
            if (exponent < 0)
            {
                absExponent = (uint)(-1 * exponent);
            }

            double result = PowerWithUintExponent(baseNumber, absExponent);

            // 当指数为负数的时候需算出次方的结果之后再取倒数
            if(exponent < 0)
            {
                result = 1.0 / result;
            }

            return result;
        }

        private static double PowerWithUintExponent(double baseNumber, uint exponent)
        {
            double result = 1.0;
            for (int i = 1; i <= exponent; i++)
            {
                result = result * baseNumber;
            }

            return result;
        }

        /// <summary>
        /// 在判断底数base是不是等于0时，不能直接写base==0，
        /// 这是因为在计算机内表示小数时（包括float和double型小数）都有误差。
        /// </summary>
        private static bool Equal(double num1, double num2)
        {
            if (num1 - num2 > -0.0000001 &&
                num1 - num2 < 0.0000001)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
