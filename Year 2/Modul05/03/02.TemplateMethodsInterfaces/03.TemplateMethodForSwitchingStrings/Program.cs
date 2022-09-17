using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TemplateMethodForSwitchingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                strings.Add(Console.ReadLine());
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            Switch.Swapper(strings, firstIndex, secondIndex);

            foreach (var str in strings)
            {
                Console.WriteLine($"{str.GetType()}: {str}");
            }
        }
    }
}
