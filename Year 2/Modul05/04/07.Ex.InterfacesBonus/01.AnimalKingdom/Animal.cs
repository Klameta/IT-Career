using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnimalKingdom
{
    public abstract class Animal : IMakeTrick, IMakeNoise
    {
        private int age;
        private string name;

        protected Animal(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }


        public virtual string MakeNoise()
        {
            return $"My name is {Name}. I am {Age} old";
        }

        public virtual string MakeTrick()
        {
            return "Look at my trick!";
        }
    }
}
