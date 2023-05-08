using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Arr_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int k = list.Count / 4;

            var fList = new List<int>();
            var sList = new List<int>();
            var tList = new List<int>();
            var sum = new List<int>();

            fList = list.Take(k).Reverse().ToList();
            sList = list.Skip(k).Take(2*k).ToList();
            tList = list.Skip(3*k).Take(k).Reverse().ToList();

            fList = fList.Concat(tList).ToList();

            sum = fList.Select((x, index) => x + sList[index]).ToList();

            Console.WriteLine(string.Join(' ', sum));


        }
    }
}
