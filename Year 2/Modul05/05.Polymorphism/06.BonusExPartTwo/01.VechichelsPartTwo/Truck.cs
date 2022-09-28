using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.VechichelsPartTwo
{
    class Truck : Vechicle
    {
        public Truck(double fuel, double consumption, double tankCapacity) : base(fuel, consumption, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            if (Fuel + liters > TankCapacity)
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
            var kmNeeded = kmToBeDriven * (1.6 + Consumption);
            if (kmNeeded <= this.Fuel)
            {
                this.Fuel -= kmNeeded;
                Console.WriteLine($"{this.GetType().Name} travelled {kmNeeded:F2} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needes refueling");
            }
        }
    }
}

