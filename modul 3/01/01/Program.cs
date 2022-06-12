using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Age = 5;
            person1.Name = "Pesho";

            Console.WriteLine($"Hello i am {person1.Name} i am {person1.Age}");
        }
    }

    class Person
    {

        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


    }
}
