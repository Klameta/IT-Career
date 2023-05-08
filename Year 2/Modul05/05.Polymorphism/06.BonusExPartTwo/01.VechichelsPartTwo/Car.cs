using System;
using System.Collections.Generic;
using System.Text;

namespace _01.VechichelsPartTwo
{
    public class Car : Vechicle
    {
        public Car(double fuel, double consumption, double tankCapacity) : base(fuel, consumption, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            if (this.Fuel+liters>TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                Fuel += liters;
            }
        }
        public override void Drive(double kmToBeDriven)
        {
            var kmNeeded = (Consumption + 0.9) * kmToBeDriven;

            if (kmNeeded <= this.Fuel)
            {
                this.Fuel -= kmNeeded;
                Console.WriteLine($"{GetType().Name} travelled {kmNeeded:F2} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needes refueling");
            }
        }
    }
}
