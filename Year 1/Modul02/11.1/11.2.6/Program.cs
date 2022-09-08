using System;
using System.Linq;
namespace _11._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var produces = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var inStock = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
            var prices = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var command = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int index = 0;
            int stock = 0;
            int kur = 0;
            while (command[0] != "done")
            {
                
                index = Array.IndexOf(produces, command[0]);
                if (stock<=inStock[index])
                {
                    stock = int.Parse(command[1]);
                    Console.WriteLine($"{produces[index]} x {inStock[index]} costs {double.Parse(command[1]) * prices[index]:F2}");
                    kur = (int)inStock[index];
                    kur -= stock;
                }
                else
                {
                    Console.WriteLine($"We so not have enough {produces[index]}");
                }

                command = Console.ReadLine()
                    .Split(' ')
                .ToArray(); 
            }



        }
    }
}
