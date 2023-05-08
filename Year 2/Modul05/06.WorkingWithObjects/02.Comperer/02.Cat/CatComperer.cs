using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _02.Cat
{
    internal class CatComperer : IComparer<Cat>
    {
        public int Compare([AllowNull] Cat x, [AllowNull] Cat y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
