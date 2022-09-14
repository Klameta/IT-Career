
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DivingPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RationalNumber> nums = new List<RationalNumber>();
            string[] commandArgs = Console.ReadLine().Split();
            for (int i = 0; i < commandArgs.Length-1; i+= 2)
            {
                int num = int.Parse(commandArgs[i]);
                int de = int.Parse(commandArgs[i+1]);
                RationalNumber ratNum = new RationalNumber(num, de);
                nums.Add(ratNum);
            }
            Console.WriteLine(string.Join($"; ", nums));
        }
    }
}
