using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TemplateMethodForCountingDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<double> nums = new List<double>();
            for (int i = 0; i < lines; i++)
            {
                nums.Add(double.Parse(Console.ReadLine()));
            }

            double compare = double.Parse(Console.ReadLine());

            int count = Comperer<double>.CountGreater(compare, nums);
            Console.WriteLine(count);
        }
    }
}

