using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UniversalBoxOfInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Box<int> nums = new Box<int>();
            for (int i = 0; i < lines; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nums.Add(num);
            }
            Console.WriteLine(nums);
        }
    }
}
