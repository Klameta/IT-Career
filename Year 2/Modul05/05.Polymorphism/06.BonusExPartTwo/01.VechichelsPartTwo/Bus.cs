using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.VechichelsPartTwo
{
    class Bus : Vechicle
    {
        public Bus(double fuel, double consumption, double tankCapacity) : base(fuel, consumption, tankCapacity)
        {
        }

        public override void Drive(double kmToBeDriven)
        {
            var kmNeeded = (Consumption) * kmToBeDriven;

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
        public void DriveEmpty(double kmToBeDriven)
        {
            var kmNeeded = (Consumption) * kmToBeDriven;
            if (kmNeeded <= this.Fuel)
            {
                this.Fuel -= kmNeeded;
                Console.WriteLine($"{GetType().Name} travelled {kmToBeDriven:F2} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needes refueling");
            }
        }
        public override void Refuel(double liters)
        {
            Fuel += liters;
        }

    }
}
