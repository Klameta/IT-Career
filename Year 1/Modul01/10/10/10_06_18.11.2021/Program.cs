using System;

namespace _10_06_18._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter a number in the range [1...100]: ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n>0||n<100)
                {
                 Console.WriteLine($"The number is: {n}");
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
                return;
            }
        }
    }
}
