using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dividing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RationalNumber> nums = new List<RationalNumber>();
            for (int i = 0; i < 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int de = int.Parse(Console.ReadLine());
                RationalNumber ratNum = new RationalNumber(num, de);
                nums.Add(ratNum);
            }
            Console.WriteLine(string.Join($"\n", nums));
        }
    }
}
