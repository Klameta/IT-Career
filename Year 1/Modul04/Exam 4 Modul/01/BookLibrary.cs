using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BookLibrary
{
    private string name;

    private List<Book> books = new List<Book>();

    public BookLibrary(string name)
    {
        this.name = name;
        //TODO: Добавете вашия код тук …

    }

    public string Name
    {
        get { return name; }
        set { name = value; }
        //TODO: Добавете вашия код тук …

    }

    public List<Book> Books
    {
        get { return books; }
        set { books = value; }
        //TODO: Добавете вашия код тук …

    }

    public void AddBook(string title, double rating)
    {
        Book book = new Book(title, rating);
        this.books.Add(book);
        //TODO: Добавете вашия код тук …

    }

    public double AverageRating()

    {
        int count = 0;
        double sum = 0;
        foreach (var book in books)
        {
            sum += book.Rating;
            count++;
        }
        return (double)sum / count;
        //TODO: Добавете вашия код тук …

    }

    public List<string> GetBooksByRating(double rating)
    {
        List<Book> tempBooks = Books;
        tempBooks =tempBooks.Where(x => x.Rating > rating).ToList();
        List<string> bookTitles = new List<string>();
        foreach (var book in tempBooks)
        {
            bookTitles.Add(book.Title);
        }
        return bookTitles;
        //TODO: Добавете вашия код тук …

    }

    public List<Book> SortByTitle()

    {
        books = books.OrderBy(x => x.Title).ToList();
        return books;
        //TODO: Добавете вашия код тук …

    }

    public List<Book> SortByRating()

    {
        books = books.OrderByDescending(x => x.Rating).ToList();
        return books;
        //TODO: Добавете вашия код тук …

    }

    public string[] ProvideInformationAboutAllBooks()

    {
        string[] printInfo = new string[books.Count];
        for (int i = 0; i < books.Count; i++)
        {
            printInfo[i] = books[i].ToString();
        }
        return printInfo;

        //TODO: Добавете вашия код тук …

    }

    public bool CheckBookIsInBookLibrary(string title)

    {
        foreach (var book in books)
        {
            if (book.Title == title)
            {
                return true;
            }
        }
        return false;
        //TODO: Добавете вашия код тук …

    }
}
