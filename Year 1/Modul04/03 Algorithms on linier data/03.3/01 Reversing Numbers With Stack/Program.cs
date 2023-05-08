using System;
using System.Linq;
using System.Collections.Generic;
namespace _01_Reversing_Numbers_With_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Stack<string> reversedWords = new Stack<string>();
            foreach (var word in words)
            {
                reversedWords.Push(word);
            }
            Console.WriteLine(string.Join(" ", reversedWords));
        }
    }
}
