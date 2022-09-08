using System;
using System.Collections.Generic;
using System.Linq;
namespace _05__Needles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cAndN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numsC = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numsN = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] result = FindingPlaceForNeedles(numsC, numsN);
            Console.WriteLine(string.Join(" ", result));
        }
        static int[] FindingPlaceForNeedles(int[] numsC, int[] numsN)
        {
            int[] result = new int[numsN.Length];
            int counter = 0;
            for (int i = 0; i < numsN.Length; i++)
            {
                int currentNeedle = numsN[i];
                for (int k = 0; k < numsC.Length - 1; k++)
                {

                    if (numsC[k] < currentNeedle && currentNeedle <= numsC[k + 1])
                    {
                        if (numsC[k] == 0)
                        {
                            result[counter] = k;
                            counter++;
                            break;
                        }
                        else
                        {
                            result[counter] = k + 1;
                            counter++;
                            break;
                        }
                    }
                    else if (k == 0 && currentNeedle <= numsC[k])
                    {
                        result[counter] = k;
                        counter++;
                        break;
                    }
                    else if (numsC[k + 1] == 0)
                    {
                        int zeroCount = 0;
                        while (numsC[k+1+zeroCount]==0)
                        {
                            zeroCount++;
                        }
                        if (numsC[zeroCount+k+1+1]>=currentNeedle)
                        {
                            result[counter] = k + 1;
                            counter++;
                            break;
                        }
                    }
                }
            }
            return result;
        }
    }
}
