using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(5, "tosho");
            Dog dog = new Dog(7, "gosho");

            Console.WriteLine(cat.MakeTrick());
            Console.WriteLine(cat.MakeNoise());
            Console.WriteLine(dog.MakeNoise());
            Console.WriteLine(dog.MakeTrick());
        }
    }
}
