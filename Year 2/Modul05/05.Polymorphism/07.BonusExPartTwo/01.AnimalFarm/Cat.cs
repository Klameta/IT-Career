using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnimalFarm
{
    class Cat : Felime
    {
        private string breed;

        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breen) : base(animalName, animalType, animalWeight, livingRegion)
        {
            Breed = breen;
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public override string ToString()
        {
            return $"{GetType().Name}[{AnimalName}, {Breed}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quanity;
        }
    }
}
