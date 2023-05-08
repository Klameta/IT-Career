
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace _02.MostCommonNumber

{

    class Program

    {


        static void Main(string[] args)

        {


            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();




            int[] count = new int[65535];

            for (int i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }



            int maxValue = count[0];
            int maxIndex = 0;

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > maxValue)
                {

                    maxValue = count[i];

                    maxIndex = i;

                }
            }
            Console.WriteLine(maxIndex);




        }

    }

}