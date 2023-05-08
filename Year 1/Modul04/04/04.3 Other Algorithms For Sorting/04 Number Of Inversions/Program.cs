using System;
using System.Linq;
using System.Collections.Generic;

namespace _04_Number_Of_Inversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Console.WriteLine("Number of "
                                  + "inversions are "
                                  + getInvCount(arr.Length, arr));
        }
        /*private static void MergeSort(int[] arr, int left, int right, int counter)
        {
            if (left == right) return;
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid, counter);
            MergeSort(arr, mid + 1, right, counter);
            int i = left, j = mid + 1, k = 0;
            int[] b = new int[right - left + 1];

            if(arr[i] > arr[j] || i < j)
            {
                counter++;
                Console.WriteLine(counter);
            }

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
                //Console.WriteLine(string.Join(" ", arr));
            }
        }*/
        static int getInvCount(int n, int[] arr)
        {
            int inv_count = 0;

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] > arr[j])
                        inv_count++;

            return inv_count;
        }

        // Driver code
        
    }

}

