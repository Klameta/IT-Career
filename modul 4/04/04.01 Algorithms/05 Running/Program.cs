using System;
using System.Linq;
namespace _05_Running
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstDay = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondDay = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] result = new int[firstDay.Length + secondDay.Length];
            Combining(result, firstDay, secondDay);
            SelectionSort(result);
            Console.WriteLine(string.Join(" ", result));
        }

        static void Combining(int[] result, int[] firstDay, int[] secondDay)
        {
            int counter = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (i < firstDay.Length)
                {
                    result[i] = firstDay[i];
                }
                else
                {
                    result[i] = secondDay[counter];
                    counter++;
                }
            }
        }
        static void SelectionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int maxNum = nums[i];
                int index = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < maxNum)
                    {
                        maxNum = nums[j];
                        index = j;
                    }
                }
                Swapped(nums, i, index);
            }

            static void Swapped(int[] nums, int i, int index)
            {
                int swapped = nums[i];
                nums[i] = nums[index];
                nums[index] = swapped;
            }
        }
    }
}
