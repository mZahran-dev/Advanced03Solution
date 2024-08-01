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
                new Book("123-33", "Book1", new[] { "Author1" }, new DateTime(2023, 1, 1), 19.99m),
                new Book("456-12", "Book2", new[] { "Author2", "Author3" }, new DateTime(2022, 5, 15), 29.99m)
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
            bool exists = books.Exists(b => b.Price > 20);
            Console.WriteLine($"Exists: {exists}");

            // Find
            Book expensiveBook = books.Find(b => b.Price > 20);
            Console.WriteLine($"Find: {expensiveBook}");

            // FindAll
            var expensiveBooks = books.FindAll(b => b.Price > 20);
            Console.WriteLine("FindAll:");
            foreach (var book in expensiveBooks)
            {
                Console.WriteLine(book);
            }

            // FindIndex
            int index = books.FindIndex(b => b.Price > 20);
            Console.WriteLine($"FindIndex: {index}");

            // FindLast
            Book lastExpensiveBook = books.FindLast(b => b.Price > 20);
            Console.WriteLine($"FindLast: {lastExpensiveBook}");

            // FindLastIndex
            int lastIndex = books.FindLastIndex(b => b.Price > 20);
            Console.WriteLine($"FindLastIndex: {lastIndex}");

            // ForEach
            Console.WriteLine("ForEach:");
            books.ForEach(b => Console.WriteLine(b));

            // TrueForAll
            bool allExpensive = books.TrueForAll(b => b.Price > 10);
            Console.WriteLine($"TrueForAll: {allExpensive}");
            #endregion
        }
    }
}
