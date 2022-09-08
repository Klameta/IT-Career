using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Numerics;

namespace test02Anonynous03
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentance = Console.ReadLine();
            string sentanceReversed = sentance.Reverse().ToString();
            bool foudIt = false;

            char word1 = 'a';
            char word2 = 'a';
            StringBuilder sb1 = new StringBuilder();
            //StringBuilder sb2 = new StringBuilder();

            foreach (var item in sentance)
            {
                word1 = item;
                foreach (var item2 in sentanceReversed)
                {
                    if (foudIt)
                    {
                        break;
                    }
                    if (word1 == item2)
                    {
                        word2 = item2;
                        sb1.Append(word2);
                        if (word1 == sentanceReversed[0])
                        {
                            foudIt = true;
                        }
                        break;
                    }
                }
            }
            Console.WriteLine(sb1);
        }
    }
}
