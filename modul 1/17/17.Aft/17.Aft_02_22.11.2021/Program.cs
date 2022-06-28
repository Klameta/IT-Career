using System;

namespace _17.Aft_02_22._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double bBought = double.Parse(Console.ReadLine());
            double fPrice = double.Parse(Console.ReadLine());
            double nowPrice = double.Parse(Console.ReadLine());
            double kHad = double.Parse(Console.ReadLine());
            double nHad = double.Parse(Console.ReadLine());

            double pDiffB = bBought * nowPrice - bBought * fPrice;
            double pEter = nowPrice * 0.75;

            double pNeo = pEter * 0.4;
            double mNeeded = pEter*kHad+
        }
    }
}
