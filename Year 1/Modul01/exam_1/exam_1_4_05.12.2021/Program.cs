using System;

namespace exam_1_4_05._12._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            double sLight = 0;
            double sMod = 0;
            double sStrong = 0;
            double sVstrong = 0;
            double counter = 0;
            for (int i = 0; i < nInput; i++)
            {
                double strenght = double.Parse(Console.ReadLine());
                if (strenght>0 &&strenght<=4)
                {
                    sLight++;
                }
                else if (strenght <6)
                {
                    sMod++;
                }
                else if (strenght <7)
                {
                    sStrong++;
                }
                else
                {
                    sVstrong++;
                }
                counter++;
            }
            double pLight = (sLight / counter) * 100;
            double pMod = (sMod / counter) * 100;
            double pStrong = (sStrong / counter) * 100;
            double pVstrong = (sVstrong / counter)* 100;
            Console.WriteLine($"Light: {pLight:F2}%");
            Console.WriteLine($"Moderate: {pMod:F2}%");
            Console.WriteLine($"Strong: {pStrong:F2}%");
            Console.WriteLine($"Very Strong: {pVstrong:F2}%");
        }
    }
}
