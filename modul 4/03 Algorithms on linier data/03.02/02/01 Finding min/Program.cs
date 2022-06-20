using System;
using System.Linq;
namespace _01_Finding_min
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int min = int.MaxValue;
            foreach (var num in nums)
            {
                if (min>num)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }
    }
}
