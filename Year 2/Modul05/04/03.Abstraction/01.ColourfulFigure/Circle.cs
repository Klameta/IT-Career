using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ColourfulFigure
{
    class Circle : ColouredFigure
    {
        public Circle(string color, int size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            return (Math.Pow(base.size, 2)) * Math.PI;
        }

        public override string GetName()
        {
            return "Circle";
        }
    }
}
