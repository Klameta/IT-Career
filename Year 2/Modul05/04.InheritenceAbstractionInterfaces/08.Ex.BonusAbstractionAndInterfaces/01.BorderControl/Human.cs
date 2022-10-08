using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BorderControl
{
    class Human : IInhabitant
    {
        private string name;
        private int age;
        private string id;


        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
        public string Id { get => id; private set => id = value; }

        public Human(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public override string ToString()
        {
            return $"{Id}";
        }
    }
}
