using System;
using System.Linq;

namespace _05.Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            ListIterator<string> listIterator = new ListIterator<string>();
            while (cmdArgs[0] != "END")
            {
                switch (cmdArgs[0])
                {
                    case "Create":
                        listIterator = new ListIterator<string>(cmdArgs
                            .Skip(1)
                            .Take(cmdArgs.Length - 1)
                            .ToArray());
                        break;
                    case "Move":
                        Console.WriteLine(listIterator.Move());
                        break;
                    case "Print":
                        listIterator.Print();
                        break;
                    case "HasNext":
                        Console.WriteLine(listIterator.HasNext());
                        break;
                    case "PrintAll":
                        listIterator.PrintAll();
                        break;
                    default:
                        break;
                }
                cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

        }
    }
}
