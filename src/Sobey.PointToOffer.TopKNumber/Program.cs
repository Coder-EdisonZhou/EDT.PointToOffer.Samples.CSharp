using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.TopKNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
            Test6();
            Test7();

            Console.ReadKey();
        }

        #region 01.功能实现

        #region 需要改变数据源的O(n)解法：基于Partition方法
        public static void GetLeastNumbersByPartition(int[] input, int n, int[] output, int k)
        {
            if (input == null || output == null || input.Length <= 0 || output.Length <= 0 || k <= 0)
            {
                return;
            }

            int start = 0;
            int end = n - 1;
            int index = Partition(input, n, start, end);

            while (index != k - 1)
            {
                if (index > k - 1)
                {
                    end = index - 1;
                    index = Partition(input, n, start, end);
                }
                else
                {
                    start = index + 1;
                    index = Partition(input, n, start, end);
                }
            }

            for (int i = 0; i < k; i++)
            {
                output[i] = input[i];
            }
        }

        private static int Partition(int[] arr, int n, int low, int high)
        {
            if (arr == null || n <= 0 || low < 0 || high >= n)
            {
                throw new ArgumentOutOfRangeException();
            }

            int i = low, j = high;
            int temp = arr[i]; // 确定第一个元素作为"基准值"

            while (i < j)
            {
                // Stage1:从右向左扫描直到找到比基准值小的元素
                while (i < j && arr[j] >= temp)
                {
                    j--;
                }
                // 将比基准值小的元素移动到基准值的左端
                arr[i] = arr[j];

                // Stage2:从左向右扫描直到找到比基准值大的元素
                while (i < j && arr[i] <= temp)
                {
                    i++;
                }
                // 将比基准值大的元素移动到基准值的右端
                arr[j] = arr[i];
            }

            // 记录归位
            arr[i] = temp;

            return i;
        }
        #endregion

        #region 适合处理海量数据的O(nlogk)解法：基于红黑树结构
        public static void GetLeastNumbersByRedBlackTree(List<int> data, SortedDictionary<int, int> leastNumbers, int k)
        {
            leastNumbers.Clear();

            if (k < 1 || data.Count < k)
            {
                return;
            }

            for (int i = 0; i < data.Count; i++)
            {
                int num = data[i];
                if (leastNumbers.Count < k)
                {
                    leastNumbers.Add(num, num);
                }
                else
                {
                    int greastNum = leastNumbers.ElementAt(leastNumbers.Count - 1).Value;
                    if (num < greastNum)
                    {
                        leastNumbers.Remove(greastNum);
                        leastNumbers.Add(num, num);
                    }
                }
            }
        }
        #endregion

        #endregion

        #region 02.单元测试

        public static void TestPortal(string testName, int[] data, int[] expected, int k)
        {
            if (!string.IsNullOrEmpty(testName))
            {
                Console.WriteLine("{0} begins:", testName);
            }

            Console.WriteLine("Result for solution:");
            if (expected != null)
            {
                Console.WriteLine("Expected result:");
                for (int i = 0; i < expected.Length; i++)
                {
                    Console.Write("{0}\t", expected[i]);
                }
                Console.WriteLine();
            }

            if(data == null)
            {
                return;
            }

            List<int> dataList = new List<int>();
            for (int i = 0; i < data.Length; i++)
            {
                dataList.Add(data[i]);
            }
            SortedDictionary<int, int> leastNumbers = new SortedDictionary<int, int>();
            GetLeastNumbersByRedBlackTree(dataList, leastNumbers, k);
            Console.WriteLine("Actual result:");
            foreach (var item in leastNumbers)
            {
                Console.Write("{0}\t", item.Value);
            }
            Console.WriteLine("\n");
        }

        // k小于数组的长度
        public static void Test1()
        {
            int[] data = { 4, 5, 1, 6, 2, 7, 3, 8 };
            int[] expected = { 1, 2, 3, 4 };
            TestPortal("Test1", data, expected, expected.Length);
        }

        // k等于数组的长度
        public static void Test2()
        {
            int[] data = { 4, 5, 1, 6, 2, 7, 3, 8 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            TestPortal("Test2", data, expected, expected.Length);
        }

        // k大于数组的长度
        public static void Test3()
        {
            int[] data = { 4, 5, 1, 6, 2, 7, 3, 8 };
            int[] expected = null;
            TestPortal("Test3", data, expected, 10);
        }

        // k等于1
        public static void Test4()
        {
            int[] data = { 4, 5, 1, 6, 2, 7, 3, 8 };
            int[] expected = { 1 };
            TestPortal("Test4", data, expected, expected.Length);
        }

        // k等于0
        public static void Test5()
        {
            int[] data = { 4, 5, 1, 6, 2, 7, 3, 8 };
            int[] expected = null;
            TestPortal("Test5", data, expected, 0);
        }

        // 数组中有相同的数字
        public static void Test6()
        {
            int[] data = { 4, 5, 1, 6, 2, 7, 2, 8 };
            int[] expected = { 1, 2 };
            TestPortal("Test6", data, expected, expected.Length);
        }

        // 输入空指针
        public static void Test7()
        {
            TestPortal("Test7", null, null, 0);
        }

        #endregion
    }
}
