using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefiningInterfacePerson
{
    class Citizen : IPerson
    {
        string name;
        int age;

        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; private set => name = value; }

        public int Age { get => age; private set => age = value; }


    }
}
