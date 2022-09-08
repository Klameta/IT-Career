using System;

namespace _07_08_12._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            if (animal == "dog") Console.WriteLine("mammal");
            else if (animal == "tortoise" || animal == "crocodile" || animal == "snake") Console.WriteLine("reptile");
            else Console.WriteLine("unknown");
        }
    }
}
