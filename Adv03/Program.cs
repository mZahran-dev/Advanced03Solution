using Adv03.Library;

namespace Adv03
{
    internal class Program
    {
        public delegate string BookFunctionDelegate(Book book);
        static void Main(string[] args)
        {
            #region part 01
            var books = new List<Book>
            {
                new Book("123-4567890123", "Book1", new[] { "Author1" }, new DateTime(2023, 1, 1), 19.99m),
                new Book("456-1237890123", "Book2", new[] { "Author2", "Author3" }, new DateTime(2022, 5, 15), 29.99m)
            }; ;


            #region a.
            BookFunctionDelegate titleDelegate = new BookFunctionDelegate(BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(books, new Func<Book, string>(titleDelegate));
            #endregion

            #region b.
      
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

            #endregion

            #region c.
            // Anonymous Method (GetISBN)
            Func<Book, string> getISBN = delegate (Book book)
            {
                return book.ISBN;
            }; 
            LibraryEngine.ProcessBooks(books, getISBN);
            #endregion

            #region d.

            Func<Book, string> getPublicationDate = book => book.PublicationDate.ToString("yyyy-MM-dd");
            LibraryEngine.ProcessBooks(books, getPublicationDate);
            #endregion

            #endregion

            #region part 02

            #endregion
        }
    }
}
