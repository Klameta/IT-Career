using System;

namespace _01.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4);
            Rectangle rectangle = new Rectangle(5, 10);

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
        }
    }
}
