using System;
using System.Linq;

namespace Arr_09
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            char[] arr = word.ToArray();
            double value = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                value = char.ToUpper(arr[i]) - 65;
                Console.WriteLine($"{arr[i]} -> {value}");
            }
        }
    }
}
