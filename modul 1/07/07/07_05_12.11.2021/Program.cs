using System;

namespace _07_05_12._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 100 || num >200 || num!=0)
                Console.WriteLine("invalid");

        }
    }
}
