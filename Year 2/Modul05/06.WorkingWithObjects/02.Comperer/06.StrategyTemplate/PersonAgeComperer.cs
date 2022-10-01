using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _06.StrategyTemplate
{
    internal class PersonAgeComperer : IComparer<Person>
    {
        public int Compare([AllowNull] Person x, [AllowNull] Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
