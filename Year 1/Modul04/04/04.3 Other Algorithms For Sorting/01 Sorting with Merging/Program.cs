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
            MergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine(string.Join(" ", arr));
        }
        private static void MergeSort(int[] arr, int left, int right)
        {
            if (left == right) return;
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            int i = left, j = mid + 1, k = 0;
            int[] b = new int[right - left + 1];

            while ((i <= mid) && (j <= right))
                if (arr[i] < arr[j])
                {
                    b[k++] = arr[i++];
                }
                else
                {
                    b[k++] = arr[j++];
                }

            while (i <= mid)
            {
                b[k++] = arr[i++];
            }

            while (j <= right)
            {
                b[k++] = arr[j++];
            }

            for (i = left; i <= right; i++)
            {
                arr[i] = b[i - left];
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
