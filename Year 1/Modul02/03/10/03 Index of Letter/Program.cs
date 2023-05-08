using System;
using System.Linq;

namespace _03_Index_of_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr= Console.ReadLine().Split().Select(char.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int value = arr[i].GetHashCode();



                Console.WriteLine(value);
            }
        }
    }
}
