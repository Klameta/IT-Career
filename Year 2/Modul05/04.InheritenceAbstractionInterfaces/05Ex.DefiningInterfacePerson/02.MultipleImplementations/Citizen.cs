using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MultipleImplementations
{
    class Citizen : IPerson, IBirthable, IIdentifiable
    {
        string name;
        int age;
        string birthday;
        string id;

        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
        }

        public string Name { get => name; private set => name = value; }

        public int Age { get => age; private set => age = value; }

        public string Birthday { get => birthday; private set => birthday= value; }

        public string Id { get => id; private set => id= value; }
        
    }
}
