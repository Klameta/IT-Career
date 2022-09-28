using System;
using System.Collections.Generic;
using System.Text;

namespace _01.VechichelsPartTwo
{

    public class Vechicle
    {
        private double fuel;
        private double consumption;
        private double tankCapicity;

        public Vechicle(double fuel, double consumption, double tankCapacity)
        {
            Fuel = fuel;
            Consumption = consumption;
            TankCapacity = tankCapacity;
        }

        public double Fuel
        {
            get { return fuel; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Fuel must be a positive number");
                }
                else
                {
                    fuel = value;
                }
            }
        }
        public double Consumption
        {
            get { return consumption; }
            set
            {
                consumption = value;
            }
        }

        public double TankCapacity
        {
            get { return tankCapicity; }
            set { tankCapicity = value; }
        }

        public virtual void Drive(double kmToBeDriven)
        {
        }

        public virtual void Refuel(double liters)
        {

        }
        public override string ToString()
        {
            return $"{GetType().Name}: {this.Fuel:F2}";
        }

    }
}
