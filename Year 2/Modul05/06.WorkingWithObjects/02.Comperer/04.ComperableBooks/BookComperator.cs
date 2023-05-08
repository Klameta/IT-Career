using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _04.ComperableBooks
{
    internal class BookComperator : IComparer<Book>
    {
        public int Compare([AllowNull] Book x, [AllowNull] Book y)
        {
            if (x.Year != y.Year)
            {
                return x.Year - y.Year;
            }
            if (x.Title != y.Title)
            {
                return x.Title.CompareTo(y.Title);
            }
            return 0;

        }
    }
}
