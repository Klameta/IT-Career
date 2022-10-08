
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<EvenNums> evens = new List<EvenNums>();
            foreach (var num in nums)
            {
                EvenNums even = new EvenNums(num);
                evens.Add(even);
            }
            Console.WriteLine(string.Join(", ", evens));
        }
    }
}
