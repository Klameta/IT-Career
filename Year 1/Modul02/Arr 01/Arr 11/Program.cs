using System;
using System.Linq;

namespace Arr_11
{
    class Program
    {
        static void Main(string[] args)
        {
           

            char[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
                

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }


        }
    }
}
