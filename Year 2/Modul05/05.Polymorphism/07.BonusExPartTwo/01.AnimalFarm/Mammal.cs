using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnimalFarm
{
   abstract class Mammal : Animal
    {
        private string livingRegion;

        public string LivingRegion
        {
            get { return livingRegion; }
            set { livingRegion = value; }
        }

        public Mammal(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight)
        {
            LivingRegion = livingRegion;
        }
        public override string ToString()
        {
            return $"{GetType().Name}[{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
