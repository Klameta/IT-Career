using System;

namespace _06_03_07._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var vreme1 = int.Parse(Console.ReadLine());
            var vreme2 = int.Parse(Console.ReadLine());
            var vreme3 = int.Parse(Console.ReadLine());
            int vreme123 = vreme1 + vreme2 + vreme3;
            int sec;
            int chas;
            if (vreme123 <= 59)
            {
                chas = 0;
                sec = vreme123;
                if (sec < 10)
                {
                    Console.WriteLine($"{chas}:0{sec}");
                }
                else
                {
                    Console.WriteLine($"{chas}:{sec}");
                }
            }
            else if (vreme123 <= 119)
            {
                chas = 1;
                sec = vreme123 - 60;
                if (sec < 10)
                {
                    Console.WriteLine($"{chas}:0{sec}");
                }
                else
                {
                    Console.WriteLine($"{chas}:{sec}");
                }
            }
            else if (vreme123 <= 179)
            {
                chas = 2;
                sec = vreme123 - 120;
                if (sec < 10)
                {
                    Console.WriteLine($"{chas}:0{sec}");
                }
                else
                {
                    Console.WriteLine($"{chas}:{sec}");
                }
            }

        }
    }
}
