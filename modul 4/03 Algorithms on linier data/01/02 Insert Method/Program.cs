using System.Linq;
using System.Collections.Generic;
using System;
namespace _02_Insert_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", nums));
            for (int i = 0; i < nums.Count-1; i++)
            {
                if (num>nums[i]&& num<nums[i+1])
                {
                    nums.Insert(i+1, num);
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
