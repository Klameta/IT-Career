using System;

namespace _17_Aft_01_22._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollars = double.Parse(Console.ReadLine());
            double bPrice = double.Parse(Console.ReadLine());
            int sBit = int.Parse(Console.ReadLine());
            double bCanBuy = dollars / bPrice;
            double bTax = bCanBuy * (sBit * 1024) / 100000000;
            double bSum = bCanBuy - bTax;
            double payCheck = bSum * 0.1;
            double dTax = bTax * bPrice;
            double fsum = bSum - payCheck;
            Console.WriteLine($"Total bitcoin after expenses: {fsum} BTC");
            Console.WriteLine("Tax payed: {0:f2} USD", dTax);
            Console.WriteLine($"Programmer's payment: {payCheck} BTC");
        }
    }
}
