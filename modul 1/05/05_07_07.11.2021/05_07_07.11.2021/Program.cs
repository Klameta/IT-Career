using System;

namespace _05_07_07._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            int min2 = min + 15;
            if (min2 >59)
            {
                hour++;
                min2 -= 60;
            }
            if(hour >23)
            {
                hour -= 24;

            }
            if (min2 <10)
            {
                Console.WriteLine($"{hour}:0{min2}");
            }
            else
            {
                Console.WriteLine($"{hour}:{min2}");
            }
        }
    }
}
