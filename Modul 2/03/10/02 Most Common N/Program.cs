using System;
using System.Linq;

namespace _02_Most_Common_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int mostCommon = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                mostCommon = arr[i].CompareTo(i + 1);
                

            }

        }
    }
}
