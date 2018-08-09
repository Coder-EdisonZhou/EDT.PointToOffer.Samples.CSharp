using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.PrintMatrix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            1    
            */
            PrintTestPortal(1, 1);

            /*
            1    2
            3    4
            */
            PrintTestPortal(2, 2);

            /*
            1    2    3    4
            5    6    7    8
            9    10   11   12
            13   14   15   16
            */
            PrintTestPortal(4, 4);

            /*
            1    2    3    4    5
            6    7    8    9    10
            11   12   13   14   15
            16   17   18   19   20
            21   22   23   24   25
            */
            PrintTestPortal(5, 5);

            /*
            1
            2
            3
            4
            5
            */
            PrintTestPortal(1, 5);

            /*
            1    2
            3    4
            5    6
            7    8
            9    10
            */
            PrintTestPortal(2, 5);

            /*
            1    2    3
            4    5    6
            7    8    9
            10   11   12
            13   14   15
            */
            PrintTestPortal(3, 5);

            /*
            1    2    3    4
            5    6    7    8
            9    10   11   12
            13   14   15   16
            17   18   19   20
            */
            PrintTestPortal(4, 5);

            /*
            1    2    3    4    5
            */
            PrintTestPortal(5, 1);

            /*
            1    2    3    4    5
            6    7    8    9    10
            */
            PrintTestPortal(5, 2);

            /*
            1    2    3    4    5
            6    7    8    9    10
            11   12   13   14    15
            */
            PrintTestPortal(5, 3);

            /*
            1    2    3    4    5
            6    7    8    9    10
            11   12   13   14   15
            16   17   18   19   20
            */
            PrintTestPortal(5, 4);

            Console.ReadKey();
        }

        public static void PrintTestPortal(int columns, int rows)
        {
            if (columns < 1 || rows < 1)
            {
                return;
            }

            Console.WriteLine("Test Begin:{0} columns,{1} rows.", columns, rows);
            int[,] numbers = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = i * columns + j + 1;
                }
            }

            PrintMatrixClockwisely(numbers, columns, rows);
            Console.WriteLine();
        }

        public static void PrintMatrixClockwisely(int[,] numbers, int columns, int rows)
        {
            if (numbers == null || columns <= 0 || rows <= 0)
            {
                return;
            }

            int start = 0;
            while (columns > start * 2 && rows > start * 2)
            {
                PrintMatrixInCircle(numbers, columns, rows, start);
                start++;
            }
        }

        public static void PrintMatrixInCircle(int[,] numbers, int columns, int rows, int start)
        {
            int endX = columns - 1 - start;
            int endY = rows - 1 - start;

            // 从左到右打印一行
            for (int i = start; i <= endX; ++i)
            {
                int number = numbers[start, i];
                Console.Write("{0}  ", number);
            }

            // 从上到下打印一列
            if (start < endY)
            {
                for (int i = start + 1; i <= endY; i++)
                {
                    int number = numbers[i, endX];
                    Console.Write("{0}  ", number);
                }
            }

            // 从右到左打印一行
            if (start < endX && start < endY)
            {
                for (int i = endX - 1; i >= start; i--)
                {
                    int number = numbers[endY, i];
                    Console.Write("{0}  ", number);
                }
            }


            // 从下到上打印一列
            if (start < endX && start < endY - 1)
            {
                for (int i = endY - 1; i >= start + 1; i--)
                {
                    int number = numbers[i, start];
                    Console.Write("{0}  ", number);
                }
            }
        }
    }
}
