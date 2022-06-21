using System;
using System.Linq;
namespace _02_InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            InsertionSort.Sort(nums);
            Console.WriteLine(string.Join(" ", nums));
        }
        public class InsertionSort
        {
            public static void Swap<T>(T[] arr, int first, int second)
            {
                T temp = arr[first];
                arr[first] = arr[second];
                arr[second] = temp;
            }
            public static bool IsLess(IComparable first, IComparable second)
            {
                return first.CompareTo(second) < 0;
            }
            public static void Sort<T>(T[] arr) where T : IComparable
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    int j = i;
                    while (j > 0 && IsLess(arr[j], arr[j - 1]))
                    {
                        Swap(arr, j, j - 1);
                        j--;
                    }
                }
            }
        }
    }
}

