using System;
using System.Collections.Generic;

namespace LibraryTask
{
    public class Order
    {
        private static int Id { get; set; }
        private List<Book> Books { get;}
        public decimal TotalPrice { get;}
        public DateTime Date { get; set; }

        public Order(Book book)
        {
            Id++;
            Books.Add(book);
            TotalPrice += book.Price;
            Date = DateTime.Now;
        }
        
        public Order(List<Book> books)
        {
            Id++;
            Books = books;
            foreach (var book in books)
            {
                TotalPrice += book.Price;
            }
            Date = DateTime.Now;
        }
        
    }
}