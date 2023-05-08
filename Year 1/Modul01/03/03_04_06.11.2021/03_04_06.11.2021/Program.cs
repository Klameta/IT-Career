using System;

namespace _03_04_06._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string stname = Console.ReadLine();
            string fname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-year old person from {3}.", stname, fname, age, town);
           
        }
    }
}
