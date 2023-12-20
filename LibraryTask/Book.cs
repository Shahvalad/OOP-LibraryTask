namespace LibraryTask
{
    public class Book
    {
        public string Name { get; set; }      
        public string AuthorName { get; set; }     
        public int PageCount { get; set; }
        public decimal Price { get; set; }      
        public string Code { get; set; }

        public Book(string name, string authorName, int pageCount, decimal price, string code)
        {
            Name = name;
            AuthorName = authorName;
            Price = price;
            Code = code;
            PageCount = pageCount;
        }
    }
}