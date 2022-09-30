using System;

namespace _01.Points
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(2, 3);
            Point point1 = new Point(4, 5);
            Point point2= new Point(2, 3);
            Point point3 = new Point(2, 6);

            Console.WriteLine(point.CompareTo(point2));
            Console.WriteLine(point.CompareTo(point3));
        }
    }
}
