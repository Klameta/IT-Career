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
                int minNums = nums[i];
                int index = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < minNums)
                    {
                        minNums = nums[j];
                        index = j;
                    }
                }

                int swapped = nums[i];
                nums[i] = nums[index];
                nums[index] = swapped;
            }
        }

        private static int Less(int[] nums, int i, int currentNum)
        {
            if (currentNum < i)
            {
                int temp = nums[i];
                nums[i] = currentNum;
                currentNum = temp;
            }

            return currentNum;
        }
    }
}
