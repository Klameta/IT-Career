using System;

namespace test_1_21._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());
            double Oplosht= N*N;
            double Ppeika = M * O;
            double Ppokrivane = Oplosht - Ppeika;
            double Pplochki = W * L;
            double Nplochki = Ppokrivane / Pplochki;
            double Nvreme = Nplochki * 0.2;
            Console.WriteLine(Nplochki);
            Console.WriteLine(Nvreme);

        }
    }
}
