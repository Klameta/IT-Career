using System;

namespace _04_02_06._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            double perm = 2 * Math.PI * r;
            Console.WriteLine("Area = " +Math.Round(area, 2));
            Console.WriteLine("Perimator = " + Math.Round(perm,2));
        }
    }
}
