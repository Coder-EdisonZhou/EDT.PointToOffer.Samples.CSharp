using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.FindInPartiallySortedMatrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------begin 二维数组中的查找------------");
            Console.WriteLine("------------end 二维数组中的查找------------");
            Console.ReadKey();
        }

        // 二维数组matrix中，每一行都从左到右递增排序，
        // 每一列都从上到下递增排序
        public static bool Find(int[,] matrix, int rows, int columns, int number)
        {
            bool isFind = false;

            if (matrix != null && rows > 0 && columns > 0)
            {
                // 从第一行开始
                int row = 0;
                // 从最后一列开始
                int column = columns - 1;
                // 行：从上到下，列：从右到左
                while (row < rows && column >= 0)
                {
                    if (matrix[row, column] == number)
                    {
                        isFind = true;
                        break;
                    }
                    else if (matrix[row, column] > number)
                    {
                        column--;
                    }
                    else
                    {
                        row++;
                    }
                }
            }

            return isFind;
        }
    }
}
