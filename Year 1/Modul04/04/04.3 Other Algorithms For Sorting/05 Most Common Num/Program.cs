using System;
using System.Collections.Generic;
using System.Linq;
namespace _05_Most_Common_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] result = MostCommon(nums);
            Console.WriteLine(string.Join(" ", result));
        }
        static int[] MostCommon(int[] nums)
        {
            int biggestSes = 0;
            int biggestSesNum = 0;
            int currentSes = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                currentSes = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[j] == nums[i])
                    {
                        currentSes++;
                    }
                }
                if (currentSes > biggestSes)
                {
                    biggestSes = currentSes;
                    biggestSesNum = nums[j];
                }
            }
            int[] result = new int[] { biggestSes, biggestSesNum };
            return result;
        }
    }
}
