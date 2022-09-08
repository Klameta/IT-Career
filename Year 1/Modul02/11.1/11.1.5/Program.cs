using System;
using System.Linq;
namespace _11._1._5
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
            var command = Console.ReadLine();
            int index = 0;
            int index1 = 0;
            int index2 = 0;

            while (command != "done")
            {
                index = Array.IndexOf(produces, command);
                

                Console.WriteLine($"{produces[index]} costs: {prices[index]}; Available quantity: {inStock[index]}");
                command = Console.ReadLine();
            }



        }
    }
}
