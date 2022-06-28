using System;
using System.Linq;

namespace Arr_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //TBF
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] sum = new int[arr.Length];

            int nRotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = (i + nRotation) % arr[i];
            }

            for (int r =1; r<nRotation; r++)
            {
                for (int i = 0; i < ; i++)
                {

                }

                
            }
        }
    }
}
