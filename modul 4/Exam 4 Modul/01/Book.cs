using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Book
    {
        private string title;

        private double rating;

        public Book(string title, double rating)
        {
            this.title = title;
            this.rating = rating;
            //TODO: Добавете вашия код тук …

        }
        public string Title
        {
        get { return title; }
        set { title = value; }
            //TODO: Добавете вашия код тук …

        }

        public double Rating

        {
        get { return rating; }
        set { rating = value; }
    }

        public override string ToString()

        {
            return $"Book {this.title} is with rating {this.rating} rating.";
            //TODO: Добавете вашия код тук …

        }
    }
