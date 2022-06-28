using System;

namespace _08_01_12._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string dn = Console.ReadLine();
            double cena = 1;
            if (km < 20)
            {
                cena = 0.70;
                if (dn == "day")
                    cena += km * 0.79;
                else if (dn == "night")
                    cena += km * 0.90;
            }
            else if (km < 100)
            {
                cena = 0.09 * km;
            }
            else cena = 0.06 * km;
            Console.WriteLine("{0:f2}",cena);
        }       
    }
}
