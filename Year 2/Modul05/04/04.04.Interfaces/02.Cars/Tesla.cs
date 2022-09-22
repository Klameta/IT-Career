using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cars
{
    class Tesla : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int battery;

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Battery { get => battery; set => battery = value; }

        public string Start()
        {
            return "Engine Start";

        }

        public string Stop()
        {
           return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} Tesla {Model} with {Battery} Batteries\n{Start()}\n{Stop()}";
        }
    }
}
