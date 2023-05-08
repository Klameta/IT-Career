using System;

namespace _06_05_08._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            if (num<100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (num<=200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (num>200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
