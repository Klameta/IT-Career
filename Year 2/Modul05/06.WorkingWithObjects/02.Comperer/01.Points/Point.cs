using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _01.Points
{
    internal class Point : IComparable<Point>
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public int CompareTo([AllowNull] Point other)
        {
            if (this.X != other.X)
            {
                return (this.X - other.X);
            }

            if (this.Y!=other.Y)
            {
                return (this.Y - other.Y);
            }
            return 0;
        }
    }
}
