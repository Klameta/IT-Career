using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Animals
{
    class Animal
    {
        private string name;
        private string favFood;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public string FavFood
        {
            get { return favFood; }
            set { favFood = value; }
        }
        public Animal(string name, string favFood)
        {
            Name = name;
            FavFood = favFood;
        }

        public virtual string ExplainMyself()
        {
            return $"I am {this.Name} and my favourite food is {this.favFood}";
        }

    }
}
