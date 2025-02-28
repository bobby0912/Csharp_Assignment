//using System.Threading;

//**Constructor Overloading in a Library System**

//Implement a `Book` class with three different constructors: (1) Default constructor, (2) Constructor with `Title` and `Author`, (3) Constructor with `Title`, `Author`, and `ISBN`. Ensure each constructor initializes properties correctly.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Assignment
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        // Default constructor
        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            ISBN = "000-0000000000";
        }

        // Constructor with Title and Author
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = "000-0000000000";
        }

        // Constructor with Title, Author, and ISBN
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Book defaultBook = new Book();
    //        Console.WriteLine($"Title: {defaultBook.Title}, Author: {defaultBook.Author}, ISBN: {defaultBook.ISBN}");

    //        Book bookWithTitleAndAuthor = new Book("1984", "George Orwell");
    //        Console.WriteLine($"Title: {bookWithTitleAndAuthor.Title}, Author: {bookWithTitleAndAuthor.Author}, ISBN: {bookWithTitleAndAuthor.ISBN}");

    //        Book completeBook = new Book("1984", "George Orwell", "123-4567890123");
    //        Console.WriteLine($"Title: {completeBook.Title}, Author: {completeBook.Author}, ISBN: {completeBook.ISBN}");
    //    }
    //}
}
