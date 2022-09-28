using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnimalFarm
{
    abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        protected Animal(string animalName, string animalType, double animalWeight)
        {
            AnimalName = animalName;
            AnimalType = animalType;
            AnimalWeight = animalWeight;
        }

        public string AnimalName
        {
            get { return animalName; }
            set { animalName = value; }
        }
        public string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }
        public double AnimalWeight
        {
            get { return animalWeight; }
            set { animalWeight = value; }
        }
        public int FoodEaten
        {
            get { return foodEaten; }
            set { foodEaten = value; }
        }

        public virtual void MakeSound()
        {

        }
        public virtual void Eat(Food food)
        {

        }
       
    }
}
