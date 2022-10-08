using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Person
{
    class Person
    {
        private int age;
        private string name;
        protected string EGN;

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is Sleeping...");
            Console.WriteLine($"{this.GetType().Name} is Sleeping");
        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
