using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.LibraryIterator
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
            foreach (var book in books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
