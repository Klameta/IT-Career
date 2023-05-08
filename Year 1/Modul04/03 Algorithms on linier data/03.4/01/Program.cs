using System;
using System.Collections.Generic;
using System.Linq;
namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> nums = new List<int>() { 1, 2, 3, 4, 4, 4, 5, 6 };
            int currCount = 1;
            int currVal = nums[0];
            int maxCount = 1;
            int maxVal = currVal;

            for (int i = 1; i < nums.Count; i++)
            {
                if (currVal == nums[i])
                {
                    maxCount = currCount;
                    maxVal = currVal;
                }
                else
                {
                    currCount = 1;
                    currVal= nums[i];
                }
            }
            Console.WriteLine($"maxValue - {maxVal}\nCount - {maxCount}");*/

            Console.WriteLine(Fib(60));
        }
        public static int Sum(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                return arr[index];
            }
            return arr[index] + Sum(arr, index + 1);
        }
        public static int Fact(int n)
        {
            if (n == 1)
            {
                return n;
            }
            return n * Fact(n - 1);
        }
        public static int Fib(int num)
        {
            if (num == 1 || num == 2)
            {
                return num;
            }

            return Fib(num - 1) + Fib(num - 2);
        }
    }


}
