using System;
using System.Collections.Generic;

namespace LibraryTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Library library = new Library();
            List<Book> books = new List<Book>
            {
                new Book("Dune", "Frank Herbert", 750, 14.99m, "11111"),
                new Book("Lotr", "J.R. Tolkien", 750, 25.99m, "22222"),
                new Book("ASOIF", "George R.R. Martin", 1000, 35.99m, "33333")
            };
            library.AddBook(books);
            Order order = new Order(library.GetAllBooks());
            Console.WriteLine(order.TotalPrice);
            
        }
    }
}