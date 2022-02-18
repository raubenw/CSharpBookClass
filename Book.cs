using System;

namespace Defining
{

    public class Book
    {

        //Member variables
        string _author;
        string _title;
        int _pages;

        public Book(string author, string title, int pages)
        {
            _author = author;
            _title = title;
            _pages = pages;
        }

        public string GetDescription()
        {
            return $"Book: {_title} by {_author} contains {_pages} pages.";
        }

        //Declaring properties of the class

        // Long version
        public string Author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
            }
        }

        public string Title
        {
            get => _author;
            set => _author = value;
        }

        public int Pages
        {
            get => _pages;
            set => _pages = value;
        }

        // Computed property value
        public string Description
        {
            get => $"{_title} by {_author} contains {_pages} pages.";
        }

        // Auto generated properties. No backup field.
        // They hold the values
        public string ISBN
        {
            get; set;
        }

        public decimal Price
        {
            get; set;
        }
    }
}