using System;
using System.Linq;

namespace Arr_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] condenst = new int[nums.Length];

            if (nums.Length==1)
            {
                Console.WriteLine($"{nums[0]} is already condensed to number");
            }
            while (nums.Length>1)
            {


                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condenst[i] = nums[i] + nums[i + 1];

                }
                nums = condenst.Take(condenst.Length - 1).ToArray();
                condenst = condenst.Take(condenst.Length - 1).ToArray();

            }
            Console.WriteLine($"{nums[0]}");
        }
    }
}
