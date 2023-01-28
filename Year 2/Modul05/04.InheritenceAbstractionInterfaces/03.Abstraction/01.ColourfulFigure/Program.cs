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
                string color = cmndsArgs[1];
                int size = int.Parse(cmndsArgs[2]);
                ColouredFigure figure = null;
                switch (cmndsArgs[0])
                {
                    case "Triangle":
                        figure = new Triangle(color, size);
                        break;
                    case "Circle":
                        figure = new Circle(color, size);
                        break;
                    case "Square":
                        figure = new Square(color, size);
                        break;
                }
                figures.Add(figure);
            }

            foreach (var figure in figures)
            {
                Console.WriteLine(figure);
            }
        }
    }
}
