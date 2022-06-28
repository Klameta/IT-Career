using System;

namespace _04_03_06._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = x1 - x2;
            double y = y1 - y2;
            double plosht = Math.Abs(x)*Math.Abs(y);
            double perm = 2 * (Math.Abs(x) + Math.Abs(y));
            Console.WriteLine(plosht.ToString());
            Console.WriteLine(perm.ToString());
        }
    }
}
