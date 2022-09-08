using System;

namespace _04_05_06._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double ncena = double.Parse(Console.ReadLine());
            string v = Console.ReadLine();
            string v2 = Console.ReadLine();
            
            if (v == "USD") ncena = ncena * 1.79549;
            if (v == "EUR") ncena = ncena * 1.95583;
            if (v == "GBP") ncena = ncena * 2.53405;
            if (v2 == "USD") ncena = ncena / 1.79549;
            if (v2 == "EUR") ncena =ncena/ 1.95583;
            if (v2 == "GBP") ncena = ncena/ 2.53405;
            Console.WriteLine(Math.Round(ncena, 2) + " " + v2);
        }
    }
}
