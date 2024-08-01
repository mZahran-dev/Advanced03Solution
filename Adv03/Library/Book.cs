using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Adv03.Library
{
    internal class Book
    {
        #region Propeties
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Constructors
        public Book(string _ISBN, string _title, string[] authors, DateTime _PublicationDate, decimal _price)
        {
            ISBN = _ISBN;
            Title = _title;
            Authors = authors;
            PublicationDate = _PublicationDate;
            Price = _price;

        } 
        #endregion
        public override string ToString()
        {
            return $"ISBN: {ISBN}\nTitle: {Title}\nAuthors: {Authors}\nPublicationDate: {PublicationDate}\nPrice: {Price} "
        }    
    }
}
