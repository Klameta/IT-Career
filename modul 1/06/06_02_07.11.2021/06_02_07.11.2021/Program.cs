using System;

namespace _06_02_07._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            double bp = 0;
            if (num < 100)
            {
                bp += 5;
            }
            if (num > 100)
            {
                bp = num * 0.20;
            }
            if (num > 1000)
            {
                bp = num * 0.10;
            }
            if (num % 2 == 0)
            {
                bp += 1;
            }
            else if (num % 10 == 5)
            {
                bp += 2;
            }
            Console.WriteLine(bp);
            Console.WriteLine(bp + num);
        }
    }
}
