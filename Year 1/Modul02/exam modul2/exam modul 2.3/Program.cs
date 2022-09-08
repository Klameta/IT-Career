using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_modul_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int points = 0;
            int mostPoints = int.MinValue;
            string winName = "";
            while (command != "END OF GAME")
            {
                points = 0;
                if (command.Last()=='a')
                {
                    points += 10;
                }
                else if (command.Last()=='v')
                {
                    points += 13;
                }

                if (command.Length>=7)
                {
                    points += 33;
                }
                else
                {
                    points += 22;
                }

                if (points>mostPoints)
                {
                    winName = command;
                    mostPoints = points;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Winner is name: {winName}");
            Console.WriteLine($"Points: {mostPoints}");

        }
    }
}
