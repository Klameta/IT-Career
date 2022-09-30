using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Pesho");
            Cat cat1 = new Cat("Peshi");
            Cat cat2 = new Cat("Tonka");

            Console.WriteLine(cat.CompareTo(cat1));

            IComparer<Cat> comperer = new CatComperer();
            Console.WriteLine(comperer.Compare(cat1, cat2));

            SortedSet<Cat> sorted = new SortedSet<Cat>(comperer);
            sorted.Add(new Cat("sadf"));
            sorted.Add(new Cat("ssdf"));
            sorted.Add(new Cat("ssdff"));
            sorted.Add(new Cat("sjgf"));

            Console.WriteLine(String.Join(" ", sorted.Select(x=>x.Name)));
        }
    }

}
