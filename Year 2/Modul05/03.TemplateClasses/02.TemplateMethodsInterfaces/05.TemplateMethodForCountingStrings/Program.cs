using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TemplateMethodForCountingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> strings = new List<string>();
            for (int i = 0; i < lines; i++)
            {
                strings.Add(Console.ReadLine());
            }

            string compare = Console.ReadLine();

            int count = Comperer<string>.CountGreater(compare, strings);
            Console.WriteLine(count);
        }
    }
}

