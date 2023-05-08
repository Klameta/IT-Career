using System;

namespace exam_1_5_05._12._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            for (int n1 = 0; n1 <=9; n1++)
            {
                for (int n2 = 0; n2 <=9 ; n2++)
                {
                    for (int n3 = 0; n3 <= 9; n3++)
                    {
                        for (int n4 = 0; n4 <= 9; n4++)
                        {
                            if ((n1 +n4==nInput) && (n2%2!=0) && (n3==4||n3==7))
                            {
                                Console.Write($"{n1}{n2}{n3}{n4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
