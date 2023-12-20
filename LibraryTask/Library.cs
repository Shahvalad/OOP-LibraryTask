using System.Collections.Generic;
using System.Linq;

namespace LibraryTask
{
    public class Library
    {
        private List<Book> Books = new List<Book>();
        
        public void GetBooks()
        {
            foreach (var book in Books)
            {
                System.Console.WriteLine(book.Name);
            }
        }
        
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        
        public void AddBook(List<Book> books)
        {
            Books.AddRange(books);
        }
        
        public Book GetBook(string code)
        {
            return Books.FirstOrDefault(book => book.Code == code);
        }
        
        public List<Book> GetAllBooks()
        {
            return Books;
        }

        public IEnumerable<Book> FindAllBooks(string authorName)
        {
            foreach (var book in Books.Where(book => book.AuthorName == authorName))
            {
                yield return book;
            }
            yield return null;
        }

        public int RemoveAllBooks(string authorName)
        {
            int count = 0;
            foreach (var book in Books.Where(book => book.AuthorName == authorName))
            {
                Books.Remove(book);
                count++;
            }
            return count;
        }
    }
}