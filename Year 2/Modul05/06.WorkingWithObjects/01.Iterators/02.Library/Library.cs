using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.Library
{
    internal class Library : IEnumerable<Book>
    {
        private List<Book> books { get; set; }

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
