using System;
using System.Collections.Generic;
using System.Text;

namespace _08.VetenarianClinic
{
    internal class Animal
    {
        public string Name { get; private set; }
        public int Age { get; set; }
        public string Type { get; private set; }

        public Animal(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Name} {Age} {Type}";
        }
    }
}
