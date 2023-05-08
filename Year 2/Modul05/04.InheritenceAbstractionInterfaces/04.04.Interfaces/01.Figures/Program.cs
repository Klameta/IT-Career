using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            int circleSize = int.Parse(Console.ReadLine());
            Circle circle = new Circle(circleSize);
            circle.Draw();

            int rectangleWidth = int.Parse(Console.ReadLine());
            int rectangleHeight = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(rectangleHeight, rectangleWidth);
            rectangle.Draw();
        }
    }
}
