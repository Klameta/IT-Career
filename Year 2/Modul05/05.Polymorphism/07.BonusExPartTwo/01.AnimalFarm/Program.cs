using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmdArgs = Console.ReadLine().Split();
            List<Animal> animals = new List<Animal>();

            switch (cmdArgs[0])
            {
                case "Cat":
                    Cat cat = new Cat(cmdArgs[1], cmdArgs[0], double.Parse(cmdArgs[2]), cmdArgs[3], cmdArgs[4]);
                    animals.Add(cat);
                    break;
                case "Tiger":
                    Tiger tiger = new Tiger(cmdArgs[0], cmdArgs[1], double.Parse(cmdArgs[2]), cmdArgs[3]);
                    animals.Add(tiger);
                    break;
                case "Zebra":
                    Zebra zebra = new Zebra(cmdArgs[0], cmdArgs[1], double.Parse(cmdArgs[2]), cmdArgs[3]);
                    animals.Add(zebra);
                    break;
                case "Mouse":
                    Mouse mouse = new Mouse(cmdArgs[0], cmdArgs[1], double.Parse(cmdArgs[2]), cmdArgs[3]);
                    animals.Add(mouse);
                    break;
            }
            string[] foodInfo = Console.ReadLine().Split();
            List<Food> foods = new List<Food>();

            if (foodInfo[0]=="Meat")
            {
                Meat meat = new Meat(int.Parse(foodInfo[1]));
                foods.Add(meat);
            }
            else
            {
                Vegetable vegetable = new Vegetable(int.Parse(foodInfo[1]));
                foods.Add(vegetable);
            }

            animals[0].MakeSound();
            animals[0].Eat(foods[0]);
            Console.WriteLine(animals[0]);


        }
    }
}
