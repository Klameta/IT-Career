using System;
using System.Collections.Generic;
using System.Linq;
namespace _03_Fibbonaci
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = 12;
            int x = int.Parse(Console.ReadLine());
                int ind = fibMonaccianSearch(arr, x, n);
                if (ind >= 0)
                    Console.Write("Found at index: " + ind);
                else
                    Console.Write(x + " isn't present in the array");
        }
        public static int min(int x, int y)
        {
            return (x <= y) ? x : y;
        }
        public static int fibMonaccianSearch(int[] arr, int x,
                                            int n)
        {
            int fibMMm2 = 0; 
            int fibMMm1 = 1;
            int fibM = fibMMm2 + fibMMm1;
            while (fibM < n)
            {
                fibMMm2 = fibMMm1;
                fibMMm1 = fibM;
                fibM = fibMMm2 + fibMMm1;
            }
            int offset = -1;
            while (fibM > 1)
            {
                int i = min(offset + fibMMm2, n - 1);
                if (arr[i] < x)
                {
                    fibM = fibMMm1;
                    fibMMm1 = fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                    offset = i;
                }
                else if (arr[i] > x)
                {
                    fibM = fibMMm2;
                    fibMMm1 = fibMMm1 - fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                }
                else
                    return i;
            }
            if (fibMMm1 == 1 && arr[n - 1] == x)
                return n - 1;
            return -1;
        }
    }
}
