using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
        double fuelAmount;
        double wastePerKm;
        double drivenKm = 0;
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value.Length <3)
                {
                    throw new ArgumentException();
                }
                else
                {
                    model = value;
                }
            }
        }
        public double FuelAmount
        {
            get
            {
                return fuelAmount;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    fuelAmount = value;
                }
            }
        }
        public double WastePerKm
        {
            get
            {
                return wastePerKm;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    WwstePerKm = value;
                }
            }
        }

        public double DrivenKm { get => drivenKm; set => drivenKm = value; }

        public double Drive(double fuelAmount, double wasteperkm, double kmToDrive)
        {
            //(Litres used X 100) ÷ km travelled = Litres per 100km.
            if (this)
            {
                
            }
        }
    }

}
