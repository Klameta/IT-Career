using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_FInding_the_Smallest_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int min = nums.Min();
            Console.WriteLine(min);
        }
    }
}
