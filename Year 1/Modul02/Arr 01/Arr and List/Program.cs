using System;
using System.Linq;

namespace Arr_and_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            
            Console.WriteLine(string.Join(' ', arr.Reverse()));

        }
    }
}
