using System;
using System.Linq;
using System.Collections.Generic;
namespace _01_Words
{
    class Program
    {
        public static void Main()
        {
            String str = Console.ReadLine();
            int n = str.Length;
            List<string> PermList = new List<string>();
            permute(str, 0, n - 1, PermList);
            List<string> distinctPerm = CorrectPerm(PermList);
            int result = distinctPerm.Count;
            //Console.WriteLine(string.Join(" ", PermList));
            //Console.WriteLine();
            //Console.WriteLine(string.Join(" ", distinctPerm));
            //Console.WriteLine(result);
            //Console.WriteLine(PermList.Count);

            distinctPerm = distinctPerm.Distinct().ToList();
            Console.WriteLine(string.Join(" ", distinctPerm));
            Console.WriteLine(distinctPerm.Count);
        }
        static List<string> CorrectPerm(List<string> PermList)
        {
            int counter = PermList.Count;
            List<string> correctPerms = new List<string>();
            for (int i = 0; i < PermList.Count; i++)
            {
                char[] currentPerm = PermList[i].ToCharArray();
                bool distinct = true;

                for (int k = 0; k < currentPerm.Length - 1; k++)
                {
                    /*if (currentPerm[k] == currentPerm[k + 1])
                    {
                        counter--;
                        break;
                    }*/
                    if (currentPerm[k] == currentPerm[k + 1])
                    {
                        distinct = false;
                    }
                }

                if (distinct)
                {
                    correctPerms.Add(PermList[i]);
                }

            }
            return correctPerms;
        }

        private static void permute(String str, int l, int r, List<string> PermList)
        {
            if (l == r)
                PermList.Add(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r, PermList);
                    str = swap(str, l, i);
                }
            }
        }
        public static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
