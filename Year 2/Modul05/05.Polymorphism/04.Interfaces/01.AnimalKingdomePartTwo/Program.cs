using System;

namespace _01.AnimalKingdomePartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();

            Trainer pesho = new Trainer(cat);
            Trainer tanya = new Trainer(dog);

            Console.WriteLine(pesho.Make());
            Console.WriteLine(tanya.Make());
        }
    }
}
