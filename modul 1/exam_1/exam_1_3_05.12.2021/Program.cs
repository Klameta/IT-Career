using System;

namespace exam_1_3_05._12._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthD = double.Parse(Console.ReadLine());
            double lenghtD = double.Parse(Console.ReadLine());
            int kameriN = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double size = widthD * lenghtD;
            double cena = 0.00;
            if (kameriN ==3)
            {
                if (name == "Dogramichka4You")
                {
                    cena = size * 12;
                }
                else if (name == "TihoToplo")
                {
                    cena = size * 15;
                }
                else if (name == "ChukChuk")
                {
                    cena = size * 14;
                }
            }
            else if (kameriN==4)
            {
                if (name == "Dogramichka4You")
                {
                    cena = size * 15;
                }
                else if (name == "TihoToplo")
                {
                    cena = size * 14;
                }
                else if (name == "ChukChuk")
                {
                    cena = size * 20;
                }
            }
            else if (kameriN == 5)
            {
                if (name == "Dogramichka4You")
                {
                    cena = size * 20;
                }
                else if (name == "TihoToplo")
                {
                    cena = size * 18;
                }
                else if (name == "ChukChuk")
                {
                    cena = size * 22;
                }
            }
            Console.WriteLine($"Goshko has to spend {cena:F2} leva.");
        }
    }
}
