using System;

namespace _03_07._06._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double lev = usd * 1.79549;
            Console.WriteLine(Math.Round(lev, 2)+ " BGN");
        }
    }
}
