using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _07.LogicForEquality
{
    internal class PersonComperer : IComparer<Person>
    {
        public int Compare([AllowNull] Person x, [AllowNull] Person y)
        {
            if (x.Name != y.Name)
            {
                return x.Name.CompareTo(y.Name);
            }
            return x.Age.CompareTo(y.Age);
        }
    }
}
