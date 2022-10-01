using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _06.StrategyTemplate
{
    internal class PersonNameLenghtComparer : IComparer<Person>
    {
        public int Compare([AllowNull] Person x, [AllowNull] Person y)
        {
            if (x.Name.Length != y.Name.Length)
            {
                return x.Name.Length - y.Name.Length;
            }

            return char.ToLower(x.Name[0]).CompareTo(char.ToLower(y.Name[0]));
        }
    }
}
