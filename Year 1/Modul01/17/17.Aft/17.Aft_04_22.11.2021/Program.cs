using System;

namespace _17.Aft_04_22._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            string cryName = "ne";
            double nMoney = 0;
            double nDOGE = 0;
            double nIOTA = 0;
            double nESTD = 0;
            double nNEO = 0;
            int cD = 0;
            int cI = 0;
            int cE = 0;
            int cN = 0;
            double sumMoney = 0;
            for (int i = 0; i < nInput; i++)
            {
                cryName = Console.ReadLine();
                nMoney = double.Parse(Console.ReadLine());
                switch (cryName)
                {
                    case "DOGE":
                        nMoney *= 0.07;
                        nDOGE = nMoney;
                        cD++;
                        break;
                    case "IOTA":
                        nMoney *= 1.44;
                        nIOTA = nMoney;
                        cI++;
                        break;
                    case "NEO":
                        nMoney *= 28.50;
                        nNEO = nMoney;
                        cN++;
                        break;
                    case "ESTD":
                        nMoney *= 25.00;
                        nESTD = nMoney;
                        cE++;
                        break;
                }
                sumMoney += nMoney;
               
            }
            nDOGE = Math.Round(((nDOGE / sumMoney) * 100), 2 );
            nESTD = Math.Round(((nESTD / sumMoney) * 100),2);
            nIOTA = Math.Round(((nIOTA / sumMoney) * 100),2);
            nNEO = Math.Round(((nNEO / sumMoney) * 100),2);
            Console.WriteLine($"Total votes = {nInput}, Money in market = {sumMoney,2} EUR");
            Console.WriteLine($"DOGE's contribution: {nDOGE}%; People who use DOGE: {cD}");
            Console.WriteLine($"IOTA's contribution: {nIOTA}%; People who use IOTA: {cI}");
            Console.WriteLine($"NEO's contribution: {nNEO}%; People who use NEO: {cN}");
            Console.WriteLine($"ESTD's contribution: {nESTD}%; People who use ESTD: {cE}");
        }
    }
}
