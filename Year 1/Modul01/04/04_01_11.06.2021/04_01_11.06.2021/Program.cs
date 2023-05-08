using System;

namespace _04_01_11._06._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double lice = (b1 + b2) * h / 2;
            Console.WriteLine(lice.ToString());
        }
    }
}
