using System;

namespace _06_07_08._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = Console.ReadLine();
            if(shape =="square")
            {
                double a = double.Parse(Console.ReadLine());
                double S = Math.Pow(a,2);
                Console.WriteLine(Math.Round(S, 3));
            }
            else if (shape =="rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double S = a * b;
                Console.WriteLine(Math.Round(S,3));
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double S = Math.PI * Math.Pow(r,2);
                Console.WriteLine(Math.Round(S,3));
            }
            else if (shape == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                double S = (a * ha) / 2;
                Console.WriteLine(Math.Round(S,3));
            }
        }
    }
}
