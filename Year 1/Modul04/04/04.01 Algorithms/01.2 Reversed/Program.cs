
using System;
using System.Collections.Generic;
using System.Linq;
namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SelectionSort(nums);
            Console.WriteLine(string.Join(" ", nums));
        }
        static void SelectionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int maxNum = nums[i];
                int index = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] > maxNum)
                    {
                        maxNum = nums[j];
                        index = j;
                    }
                }
                Swapped(nums, i, index);
                Console.WriteLine(string.Join(" ", nums));
            }
        }

        static void Swapped(int[] nums, int i, int index)
        {
            int swapped = nums[i];
            nums[i] = nums[index];
            nums[index] = swapped;
        }
    }
}

