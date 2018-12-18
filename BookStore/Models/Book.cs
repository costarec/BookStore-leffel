///////////////////////////////////////////////////////////////////////
///Change History
///Developer    Date    Description
///Laurie       11/05   Add Book Class
///Laurie       11/05   Add class attributes (BookId, BookTiltle, BookAurthor
///                     AuthorID, BookDescription, PriceOfBook, PicUrl, SaleItem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    // This class highlights the attributes of 
    // the books that will be sold and on display on the website.
    public class Book
    {
        // Book attributes that will be needed and used.
        // Primary Key is the BookId number 
        public int BookId { get; set; }
        // Identifying factor is a booktile
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        // public string AuthorId { get; set; }
        public string BookDescription { get; set; }
        public decimal PriceOfBook { get; set; }
        public string PicUrl { get; set; }
        public string PicThumbnail { get; set; }

        public bool SaleItem { get; set; }
    }
}
