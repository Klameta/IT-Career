using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Shapes
{
    public abstract class Shape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return string.Empty;
        }
    }
}
