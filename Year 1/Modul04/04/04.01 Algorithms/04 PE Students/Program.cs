using System.Linq;
using System;

namespace _04_PE_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            SelectionSort(nums);
            Console.WriteLine(nums[first - 1] + " " + nums[second - 1]);
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
