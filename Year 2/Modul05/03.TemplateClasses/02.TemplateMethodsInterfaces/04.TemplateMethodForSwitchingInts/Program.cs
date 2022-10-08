using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TemplateMethodForSwitchingInts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums= new List<int>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            Switch.Swapper(nums, firstIndex, secondIndex);

            foreach (var str in nums)
            {
                Console.WriteLine($"{str.GetType()}: {str}");
            }
        }
    }
}
