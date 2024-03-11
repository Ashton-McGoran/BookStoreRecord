using System;
using System.Collections.Generic;

namespace bookStoreRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many books do you want to add?");
            int numBooks = int.Parse(Console.ReadLine());

            List<Bookstore> books = new List<Bookstore>();

            for (int i = 0; i < numBooks; i++)
            {
                Console.WriteLine($"Enter details for Book {i + 1}:");
                Bookstore book = CreateBook();
                books.Add(book);
            }

            Console.WriteLine("\nBooks added successfully:");
            foreach (var book in books)
            {
                DisplayBookInfo(book);
            }
        }

        static Bookstore CreateBook()
        {
            Console.WriteLine("Enter Book ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Author:");
            string author = Console.ReadLine();

            Console.WriteLine("Enter Price:");
            double price = double.Parse(Console.ReadLine());

            return new Bookstore(id, title, author, price);
        }

        static void DisplayBookInfo(Bookstore book)
        {
            Console.WriteLine($"Book ID: {book.ID}");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Price: ${book.Price}");
            Console.WriteLine();
        }
    }

    public record Bookstore(int ID, string Title, string Author, double Price);
}
