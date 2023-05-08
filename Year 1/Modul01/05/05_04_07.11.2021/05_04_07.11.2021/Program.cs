using System;

namespace _05_04_07._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            if(num1>=num2)
            {
                Console.WriteLine(num1);
            }
            else Console.WriteLine(num2);
        }
    }
}
