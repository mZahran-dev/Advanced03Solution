using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv03.Library
{
    internal class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title; 
        }
        public static string GetAuthors(Book B)
        {
            if (B != null)
            {
                foreach(var i in B.Authors)
                {
                    Console.WriteLine(i);
                }
            }
            return String.Empty;
        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString("C");
        }

    
    }
}
