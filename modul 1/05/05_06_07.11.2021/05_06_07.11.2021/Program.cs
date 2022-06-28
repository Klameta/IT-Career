using System;

namespace _05_06_07._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var word1 = Console.ReadLine();
            var word2 = Console.ReadLine();
            word1 = word1.ToLower();
            word2 = word2.ToLower();

            if (word1 == word2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
