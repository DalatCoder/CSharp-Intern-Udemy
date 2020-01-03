using System;
using System.Threading;

namespace LearnLambdaExpression
{

    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
            }

            // Get books that cheaper than $10 using lambda expression
            var cheapBooksLambda = books.FindAll(el => el.Price < 10);
            foreach (var book in cheapBooksLambda)
            {
                Console.WriteLine(book);
            }
        }

        // Predicate method
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }

        static void LogMessage(string message, Action<string> logger)
        {
            logger(message);
        }

        static void SetTimeout(string message, Action<string> handler, int duration)
        {
            Thread.Sleep(duration);
            handler(message);
        }
    }
}
