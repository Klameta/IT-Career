using System;
using System.Collections.Generic;

namespace _04.ComperableBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bookone = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents", 2002, "Dorothy Sayers");
            Book bookThree = new Book("The Documents", 2003);

            BookComperator computer = new BookComperator();
            Console.WriteLine(computer.Compare(bookone, bookTwo));
            Console.WriteLine();

            SortedSet<Book> books = new SortedSet<Book>(computer);
            books.Add(bookone);
            books.Add(bookTwo);
            books.Add(bookThree);

            Console.WriteLine(String.Join(", ", books));

            List<Book> books1 = new List<Book>();
            books1.Add(bookone);
            books1.Add(bookTwo);
            books1.Add(bookThree);
            books1.Sort(computer);

            Console.WriteLine(String.Join(", ", books1));

        }
    }
}
