using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    public class Flower
    {
        string type;
        string color;
        double price;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value>100)
                {
                    throw new ArgumentException("Invalid flower price!");
                }
                price = value;
            }
        }

        public Flower(string type, string color, double price)
        {
            this.type = type;
            this.color = color;
            this.price = price;

        }
        public override string ToString()
        {
            return $"Flower {this.type} with color {this.color} costs {this.price:F2}";
        }

    }
}
