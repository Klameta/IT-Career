using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Shapes
{
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }


        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return Width * 2 + Height * 2;
        }

        public override string Draw()
        {
            return "Imagine a rectangle...";
        }
    }
}
