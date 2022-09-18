using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HierarchyInheratence
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.Meow();
            cat.Eat();
            dog.Eat();
            dog.Bark();

        }
    }
}
