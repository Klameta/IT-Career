using System;
using System.Collections.Generic;
using System.Text;

namespace _00.Demo
{
    internal class Person : IPerson
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
        
        public Person()
        {
            Name = String.Empty;
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
