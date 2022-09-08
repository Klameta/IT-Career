using System;

namespace test_2_21._11._2021
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int pDni = int.Parse(Console.ReadLine());
            int rDni = 365 - pDni;
            int vIgra = rDni * 63 + pDni * 127;
            double chas = vIgra / 60;

            if (vIgra > 30000)
            {
                int v = (vIgra - 30000) / 60;
                int mins = (vIgra - 30000) % 60;
                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{v} hours and {mins} less play");
            }
            else
            {
                int v = (30000 - vIgra)/60;
                int mins = (30000 - vIgra) % 60;
                Console.WriteLine($"Tom sleeps well");
                Console.WriteLine($"{v} hours and {mins} more play");
            }
            
        }
    }
}
