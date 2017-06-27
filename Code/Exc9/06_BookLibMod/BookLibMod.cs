using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace _06_BookLibMod
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    public class BookLibMod
    {
        public static void Main()
        {
            var lineNum = int.Parse(Console.ReadLine());

            var theLibrary = new Library
            {
                Name = "Lib",
                Books = new List<Book>()
            };

            for (int i = 1; i <= lineNum; i++)
            {
                var bookDetails = Console.ReadLine().Split(' ').ToArray();
                var title = bookDetails[0];
                var author = bookDetails[1];
                var publisher = bookDetails[2];
                var date = DateTime
                    .ParseExact(bookDetails[3], "dd.MM.yyyy", CultureInfo.InstalledUICulture);
                var isbn = bookDetails[4];
                var price = double.Parse(bookDetails[5]);

                var nextBook = CreateBook(title, author, publisher, date, isbn, price);

                theLibrary.Books.Add(nextBook);
            }

            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InstalledUICulture);

            var authorTotalPrice = theLibrary
                .Books
                .Where(b => b.ReleaseDate > startDate)
                .ToDictionary(b => b.Title, b => b.ReleaseDate)
                .OrderBy(b => b.Value)
                .ThenBy(b => b.Key)
                .ToDictionary(b => b.Key, b => b.Value);


            foreach (var athr in authorTotalPrice)
            {
                Console.WriteLine($"{athr.Key} -> {athr.Value:dd.MM.yyyy}");
            }
        }

        public static Book CreateBook(string title, string author, string publisher, DateTime date, string isbn, double price)
        {
            var newBook = new Book
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                ReleaseDate = date,
                ISBN = isbn,
                Price = price
            };

            return newBook;
        }
    }
}
