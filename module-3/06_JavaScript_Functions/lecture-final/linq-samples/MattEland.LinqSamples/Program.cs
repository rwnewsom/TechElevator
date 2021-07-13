using System;
using System.Collections.Generic;
using System.Linq;

namespace MattEland.LinqSamples
{
    class Program
    {
        static void Main()
        {
            BookProvider dataProvider = new BookProvider();

            IEnumerable<Book> books = dataProvider.Books.OrderBy(book => book.Title);

            // FirstOrDefault - finds the first book matching the query, or returns null
            Book favoriteBook = books.FirstOrDefault(book => book.Title == "Sphere");

            // First - finds the first book matching the query or throws an exception
            Book dinoBook = books.First(book => book.Title == "Jurassic Park");

            // Count - Get a number of things that match the query
            int numBooks = books.Count(book => book.Genre == Genre.Technical);

            // Filter - take many things and omit things that don't match the expression
            books = books.Where(book => book.Genre == Genre.Technical);

            // Min - Equivalent for reduce with find smallest logic
            decimal cheapestPrice = books.Min(book => book.Price); 

            // Max - Equivalent for reduce with find largest logic
            decimal largestPrice = books.Max(book => book.Price);

            Console.WriteLine("The books matching your search are:");

            // Select - Equivalent of Map
            foreach (string title in books.Select(book => book.Title))
            {
                Console.WriteLine(title);
            }

            Console.WriteLine($"There are {numBooks} book(s) with the cheapest price being {cheapestPrice:C} and the most expesive being {largestPrice:C}");
        }
    }
}
