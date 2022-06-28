using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_modul2
{
    class Program
    {
        static void Main(string[] args)
        {
            long computerP = 5899;
            long chairP = 1699;
            long deskP = 1789;
            long sum = 0;
            var num = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            for (int i = 0; i < num; i++)
            {
                switch (command)
                {
                    case "desk":
                        sum += deskP;
                        break;
                    case "computer":
                        sum += computerP;
                        break;
                    case "chair":
                        sum += chairP;
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
