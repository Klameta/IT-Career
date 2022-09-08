using System;
using System.Linq;
using System.Collections.Generic;

namespace _01_Sorting_with_Merging
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine(string.Join(" ", arr));
        }
        private static void QuickSort(int[] arr, int left, int right)
        {
            int i = left, j = right, x = arr[(left + right) / 2];
            while (i <= j)
            {
                while (arr[i] < x)
                {
                    i++;
                }

                while (arr[j] > x)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                    Console.WriteLine(string.Join(" ", arr));
                }
            }
            if (left < j)
            {
                QuickSort(arr, left, j);
            }
            if (i < right)
            {
                QuickSort(arr, i, right);
            }
        }
    }
}
