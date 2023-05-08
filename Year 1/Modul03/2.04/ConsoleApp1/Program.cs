using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Car
    {
        string model;
        Engine engine;
        string weight ="n/a";
        string color = "n/a";

        public string Model { get => model; set => model = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public string Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }
        public override string ToString()
        {
            return 
        }
    }
    public class Engine
    {
        string model;
        string power;
        string displacement = "n/a";
        string efficiency = "n/a" ;

        public string Model { get => model; set => model = value; }
        public string Power { get => power; set => power = value; }
        public string Displacement { get => displacement; set => displacement = value; }
        public string Efficiency { get => efficiency; set => efficiency = value; }
    }
}
