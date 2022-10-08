using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ColourfulFigure
{
    class Triangle : ColouredFigure
    {

        public Triangle(string color, int size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            return ((base.size * base.size) * Math.Sqrt(3)) / 4;
        }

        public override string GetName()
        {
            return "Triangle";
        }
    }
}
