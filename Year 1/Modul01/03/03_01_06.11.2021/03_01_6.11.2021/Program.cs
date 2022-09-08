using System;

namespace _03_01_6._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("area = " + Math.Pow(a, 2) );
        }
    }
}
