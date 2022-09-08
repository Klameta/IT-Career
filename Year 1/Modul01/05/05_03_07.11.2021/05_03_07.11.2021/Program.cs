using System;

namespace _05_03_07._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            if (num % 2 ==0 )
            {
                Console.WriteLine("even");

            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
