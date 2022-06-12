using System;
using System.Linq;

namespace _01_IsNumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Contains(nums, num)? $"{num} Exists in the List" : $"{num} Not exists in the List");

        }
        static bool Contains(int[] nums, int number)
        {
            foreach (var num in nums)
            {
                if (number==num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
