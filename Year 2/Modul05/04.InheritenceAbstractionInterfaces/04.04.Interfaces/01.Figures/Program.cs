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
            Circle circle = new Circle(10);
            circle.Draw();

            Rectangle rectangle = new Rectangle(10, 5);
            rectangle.Draw();
        }
    }
}
