using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _02.Cat
{
    internal class Cat //: IComparable<Cat>
    {
        public Cat(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int CompareTo([AllowNull] Cat other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
