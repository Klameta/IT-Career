using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Shapes
{
    class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return Math.PI * 2 * Radius;
        }

        public override string Draw()
        {
            return "Imagine a circle...";
        }
    }
}
