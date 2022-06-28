using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Arrays_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ').ToList();

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string function = Console.ReadLine();

                    switch (function)
                    {
                        case "Reverse":
                              elements.Reverse();
                            break;
                        case "Distinct":
                              elements.Distinct();
                            break;
                        case "Replace":
                            int num = int.Parse(Console.ReadLine());
                            string thing = Console.ReadLine();
                            elements[num].Replace(elements[num], thing);
                            break;
                    }
            }
            foreach (var el in elements)
            {
                Console.Write($"{el}, ");
            }

        }
    }
}
