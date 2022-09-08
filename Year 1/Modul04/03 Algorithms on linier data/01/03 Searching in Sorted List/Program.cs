using System;
using System.Linq;
using System.Collections.Generic;
namespace _03_Searching_in_Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = nums.Sum();
            double avr = nums.Average();
            Console.WriteLine($"Sum={sum}; Average={avr:F2}");
        }
    }
}
