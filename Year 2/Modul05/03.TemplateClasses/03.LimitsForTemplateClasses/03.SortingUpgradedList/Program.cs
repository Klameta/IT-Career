using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortingUpgradedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> strings = new CustomList<string>();
            string[] cmdArgs = Console.ReadLine().Split();
            while (cmdArgs[0] != "END")
            {
                switch (cmdArgs[0])
                {
                    case "Add":
                        string element = cmdArgs[1];
                        strings.Add(element);
                        break;
                    case "Remove":
                        int index = int.Parse(cmdArgs[1]);
                        Console.WriteLine(strings.Remove(index));
                        break;
                    case "Contains":
                        element = cmdArgs[1];
                        Console.WriteLine(strings.Contains(element));
                        break;
                    case "Swap":
                        int index1 = int.Parse(cmdArgs[1]);
                        int index2 = int.Parse(cmdArgs[2]);
                        strings.Swap(index1, index2);
                        break;
                    case "Greater":
                        element = cmdArgs[1];
                        Console.WriteLine(strings.CountGreaterThan(element));
                        break;
                    case "Max":
                        Console.WriteLine(strings.Max());
                        break;
                    case "Min":
                        Console.WriteLine(strings.Min());
                        break;
                    case "Sort":
                        strings.Sort();
                        break;
                    case "Print":
                        Console.WriteLine(strings);
                        break;
                }
                cmdArgs = Console.ReadLine().Split();
            }
        }
    }
}
