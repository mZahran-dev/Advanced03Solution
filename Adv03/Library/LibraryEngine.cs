using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv03.Library
{
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> blist, Func<Book, string> func)
        {
            foreach (Book book in blist)
            {
                Console.WriteLine(func(book));
            }
        }

    }
}
