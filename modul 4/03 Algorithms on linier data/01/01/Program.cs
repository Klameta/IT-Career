using System;
using System.Collections.Generic;
using System.Linq;
namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());
            nums.Sort();
            int index = nums.BinarySearch(num);
            if (index<0)
            {
                Console.WriteLine($"{num} Not exists in the List");
            }
            else
            {
                Console.WriteLine($"{num} Exists in the List");
            }
        }
    }
}
