using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    class Person
    {
        private int age;
        private string name;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
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


        public string IntroduceYourself()
        {
            return $"Hello! I'm {Name} and I'm {Age} years old.";

        }
    }
}
