using System;

namespace test_5_21._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string w1 = Console.ReadLine();
            string w2 = Console.ReadLine();
            int nInput = int.Parse(Console.ReadLine());
            int br = 0;

           
             for (int n1 = 1; n1 <= 9; n1++)
             {
                for (int n2 = 0; n2 <= 9; n2++)
                {
                    for (int n3 = 1; n3 <= 9; n3++)
                    {
                        for (int n4 = 0; n4 <= 9; n4++)
                        {
                            if (br < nInput)
                            {
                                

                                if (n1 + n2 + n3 + n4 == (n1 * n3) - nInput)
                                {
                                    Console.WriteLine($" {w1}{n1}{n2}{n3}{n4}{w2}");
                                    br++;
                                }

                            }
                               
                        }

                    }
                }
             }
                


            
        }
    }
}
