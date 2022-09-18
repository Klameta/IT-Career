using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ColourfulFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<ColouredFigure> figures = new List<ColouredFigure>();

            
            for (int i = 0; i < lines; i++)
            {
                string[] cmndsArgs = Console.ReadLine().Split();
                switch (cmndsArgs[0])
                {
                    case "Triangle":
                        string color = cmndsArgs[1];
                        int size = int.Parse(cmndsArgs[2]);
                        Triangle triangle = new Triangle(color, size);
                        figures.Add(triangle);
                        break;
                    case "Circle":
                        color = cmndsArgs[1];
                        size = int.Parse(cmndsArgs[2]);
                        Circle circle = new Circle(color, size);
                        figures.Add(circle);
                        break;
                    case "Square":
                        color = cmndsArgs[1];
                        size = int.Parse(cmndsArgs[2]);
                        Square square = new Square(color, size);
                        figures.Add(square);
                        break;
                }
            }
            foreach (var figure in figures)
            {
                Console.WriteLine(figure);
            }
        }
    }
}
