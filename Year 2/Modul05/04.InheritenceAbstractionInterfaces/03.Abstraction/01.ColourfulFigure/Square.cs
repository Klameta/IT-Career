using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ColourfulFigure
{
    class Square : ColouredFigure
    {
        public Square(string color, int size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            return base.size * base.size;
        }

        public override string GetName()
        {
            return "Square";
        }
    }
}
