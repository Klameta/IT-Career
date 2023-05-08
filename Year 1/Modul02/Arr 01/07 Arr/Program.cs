using System;
using System.Linq;

namespace _07_Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] arrBackup = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrBackup[i] = arr[i];
            }


            int counter = 0;
            int number = 0;
            int maxcount = 0;
            int maxNumber = 0;
            int leftestNumber = 0;


            /* for (int i = 0; i < arrBackup.Length - 1; i++)
             {
                 if (counter==maxcount)
                 {
                     leftestNumber = number;
                 }
                 else if (counter > maxcount)
                 {
                     maxNumber = number;

                 }
                 */



            Array.Sort(arr);

            for (int k = 0; k < arr.Length - 1; k++)
            {
                number = arr[k];
                if (number == arr[k + 1])
                {
                    counter++;
                }


                if (counter == maxcount)
                {
                    leftestNumber = number;
                }
                else if (counter > maxcount)
                {
                    maxNumber = number;

                }
            }
            //}


            Console.WriteLine(maxNumber);
        }
    }
}
