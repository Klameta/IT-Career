using System;

namespace _09_01_14._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter < 1000; counter++)
            {
                if (counter % 10 == 7)
                    Console.WriteLine(counter);
            }
        }
    }
}
