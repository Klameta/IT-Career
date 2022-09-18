using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ColourfulFigure
{
    abstract class ColouredFigure
    {
        private string color;
        private protected int size;

        protected ColouredFigure(string color, int size)
        {
            this.color = color;
            this.size = size;
        }
        public void Show()
        {
            Console.WriteLine($"{this.color} {this.size}");
        }

        abstract public string GetName();
        abstract public double GetArea();
        public override string ToString()
        {
            return $"{GetName()}:\nColor {this.color}\nSize: {GetArea():F2}";
        }

    }
}
