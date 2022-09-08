using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Buuble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            BubbleSort(nums);
            Console.WriteLine(string.Join(" ", nums));
        }
        static void BubbleSort(int[] nums)
        {
            bool swapped = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] < nums[j + 1])
                    {
                        Swapped(nums, j);
                        Console.WriteLine(string.Join(" ", nums));
                    }
                }
            }
        }
        private static void Swapped(int[] nums, int i)
        {
            int temp = nums[i];
            nums[i] = nums[i + 1];
            nums[i + 1] = temp;
        }
    }
}
