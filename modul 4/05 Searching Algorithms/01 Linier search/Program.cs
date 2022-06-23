using System;
using System.Collections.Generic;
using System.Linq;
namespace _01_Linier_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int key = int.Parse(Console.ReadLine());
            int index = BinarySearch(nums, key);
            Console.WriteLine(index);
        }
        static int LiniarSearch(int[] nums, int key)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
        private static int BinarySearch(int[] nums, int key, int start, int end)
        {
            
            if (end<start)
            {
                return -1;
            }

            else
            {
                int mid = (start + end) / 2;
                if (nums[mid] > key)
                {
                    return BinarySearch(nums, key, start, mid - 1);
                }
                else if (nums[mid] < key)
                {
                    return BinarySearch(nums, key, mid + 1, end);
                }
                else
                {
                    return mid;
                }
            }
        }
        static int BinarySearch(int[] nums, int key)
        {
            Array.Sort(nums);

            int start = 0;
            int end = nums.Length - 1;
            return BinarySearch(nums, key, start, end);
        }

    }
}
