using System;

namespace _05_01_07._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = double.Parse(Console.ReadLine());
            if (g >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else Console.WriteLine("Not excellent.");

        }
    }
}
