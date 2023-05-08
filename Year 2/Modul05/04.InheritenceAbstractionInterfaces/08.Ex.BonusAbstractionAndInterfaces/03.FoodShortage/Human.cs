using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoodShortage
{
    class Human : IBuyer, IBirthable
    {
        private string name;
        private int age;
        private string id;
        private string birthday;
        private int food;

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
        public int Food { get => food; set => food = value; }

        public string Birthday { get => birthday; private set => birthday = value; }

        public Human(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{Name} {Age} {Id} {Birthday}";
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
