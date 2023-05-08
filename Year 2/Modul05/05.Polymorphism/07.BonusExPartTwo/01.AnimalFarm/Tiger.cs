using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnimalFarm
{
    class Tiger :Felime
    {
        public Tiger(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!");
        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name=="Vegetable")
            {
                Console.WriteLine($"{GetType().Name} are not eating that type of food!");
            }
            else
            {
                FoodEaten += food.Quanity;
            }
        }
    }
}
