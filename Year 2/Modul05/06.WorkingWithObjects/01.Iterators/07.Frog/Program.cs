using System;
using System.Linq;

namespace _07.Frog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pond = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Frog ints = new Frog(pond);
            Console.WriteLine(string.Join(", ", ints));
        }
    }
}
