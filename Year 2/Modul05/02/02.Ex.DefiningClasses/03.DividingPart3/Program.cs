using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DividingPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, denum;
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<RationalNumber> rnms = new List<RationalNumber>();

            for (int i = 0; i < nums.Length-1; i+=2)
            {
                try
                {
                    num = nums[i];
                    denum = nums[i + 1];
                    RationalNumber rn = new RationalNumber(num, denum);
                    Console.Write(rn + " ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
