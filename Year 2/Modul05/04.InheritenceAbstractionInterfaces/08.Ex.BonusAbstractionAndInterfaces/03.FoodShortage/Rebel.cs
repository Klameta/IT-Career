using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoodShortage
{
    class Rebel : IBuyer
    {
        private int food;
        private string name;
        private int age;
        private string group;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public int Food { get => food; set => food = value; }
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

        public string Group
        {
            get { return group; }
            private set { group = value; }
        }


        public void BuyFood()
        {
            Food += 5;
        }
        public override string ToString()
        {
            return $"{Name} {Age} {Group}";
        }
    }
}
