using System.Linq;
using System;
using System.Collections.Generic;

namespace LearnLinq
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return $"{Title}: {Price}.";
        }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Title = "ADO.NET step by step", Price = 5},
                new Book { Title = "ASP.NET MVC", Price = 9.9f},
                new Book { Title = "ASP.NET web API", Price = 12},
                new Book { Title = "C# Advanced topics", Price = 9},
                new Book { Title = "C# Intern topics", Price = 7}
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Book> books = new BookRepository().GetBooks();
            System.Console.WriteLine("Book lists:");
            foreach (var book in books)
            {
                System.Console.WriteLine(book);
            }

            // Traditional way to get list of cheap books:
            // var cheapBooks = new List<Book>();
            // foreach (var book in books)
            // {
            //     if (book.Price < 10)
            //         cheapBooks.Add(book);
            // }

            // Using LINQ to get list of cheap books:
            // LINQ query operators
            var cheapBooks_0 =
                from b in books
                where b.Price < 10
                orderby b.Price
                select b.Title;

            // LINQ extension methods
            var cheapBooks = books
                                .Where(el => el.Price < 10)
                                .OrderBy(el => el.Price)
                                .Select(el => el.Title);

            System.Console.WriteLine("List of cheap books:");
            foreach (var book in cheapBooks)
            {
                System.Console.WriteLine(book);
            }
        }
    }
}
