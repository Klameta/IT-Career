using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Library
{
    internal class Book
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

        public string Title { get;private set; }
        public int Year { get;private set; }
        public IReadOnlyList<string> Authors { get;private set; }

    }
}
