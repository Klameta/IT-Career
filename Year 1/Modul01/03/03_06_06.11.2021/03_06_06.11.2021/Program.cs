using System;

namespace _03_06_06._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double grad = (180 / Math.PI)*rad;
            Console.WriteLine(Math.Round(grad));
        }
    }
}
