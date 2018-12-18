//////////////////////////////////////////////////////////////////////
/// Change History
/// Developer   Date    Description
/// Laurie      11/18   Create Mochdata Class
/// Laurie      11/18   Included BookInterface class
/// Laurie      11/18   Create MockData 
/// Laurie      11/18   Create getallbooks method
/// Laurie      11/18   Create getbookbyauthorId method
/// Laurie      11/18   Create getbookbybookId method
/// Argenis     11/24   Changed Class MockData to inherit from IBookInterfaceable due to name change
/// Argenis     11/26   Added  hard coded mock data to the books and comments on implementation of CSS for pictures
/// Argenis     11/27   Modified the price of the books for better values (incrementing the tens of the price) for better troubleshooting
/// Laurie      12/05   Added path for book images in the mockdata.
/// Laurie      12/05   Change using statement to .Models instead of .AppModels

using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// The Purpose of this class is to create some test data to test
/// test out the application and be sure everything is working right.
/// </summary>
namespace BookStore.Models
{
    public class MockData : IBookInterfaceable
    {
        private List<Book> _books;
        public MockData()
        {
            if (_books == null)
            {
                InitializeBooks();
            }
        }

        private void InitializeBooks()
        {
            // Need data for books. This data is based off of 
            // the attributes listed in the Book Class.
            // Refer to that class for the information needed here.
            _books = new List<Book>
            {  // The PicURL is only for the big picture, and the 
               //thumbnail is the SmallPicture. The URL will have
               //to be implemented in CSS via relative path
               // /Images/Thumbnail.jpg
                new Book {BookId = 1, BookAuthor = "Victoria Schwab", BookTitle = "City of Ghosts", PriceOfBook = 12.95M, BookDescription = "A Spooky Delight!", PicUrl = "/Images/Original/CityOfGhosts.jpg", PicThumbnail = "/Images/Thumbnail/CityOfGhosts.jpg", SaleItem = true},
                new Book {BookId = 2, BookAuthor = "Victoria Schwab", BookTitle = "Our Dark Duet", PriceOfBook = 22.95M, BookDescription = "A Dark Masterpiece!", PicUrl = "/Images/Original/OurDarkDuet.jpg", PicThumbnail = "/Images/Thumbnail/OurDarkDuet.jpg", SaleItem = false},
                new Book {BookId = 3, BookAuthor = "Victoria Schwab", BookTitle = "A Dark Shade of Magic", PriceOfBook = 32.95M, BookDescription = "A Dark Shade of Magic", PicUrl = "/Images/Original/ADarkShadeOfMagic.jpg", PicThumbnail = "/Images/Thumbnail/ADarkShadeOfMagic.jpg", SaleItem = false},
                new Book {BookId = 4, BookAuthor = "Victoria Schwab", BookTitle = "Broken Ground", PriceOfBook = 42.95M, BookDescription = "Broken Ground", PicUrl = "/Images/Original/BrokenGround.jpg", PicThumbnail = "/Images/Thumbnail/BrokenGround.jpg", SaleItem = false},
                new Book {BookId = 5, BookAuthor = "Victoria Schwab", BookTitle = "The Dark Vault", PriceOfBook = 52.95M, BookDescription = "The Dark Vault", PicUrl = "/Images/Original/TheDarkVault.jpg", PicThumbnail = "/Images/Thumbnail/TheDarkVault.jpg", SaleItem = false},
                new Book {BookId = 6, BookAuthor = "Victoria Schwab", BookTitle = "This Song", PriceOfBook = 62.95M, BookDescription = "This Song", PicUrl = "/Images/Original/ThisSong.jpg", PicThumbnail = "/Images/Thumbnail/ThisSong.jpg", SaleItem = false},
                new Book {BookId = 7, BookAuthor = "Victoria Schwab", BookTitle = "Vicious", PriceOfBook = 72.95M, BookDescription = "Vicious", PicUrl = "/Images/Original/Vicious.jpg", PicThumbnail = "/Images/Thumbnail/Vicious.jpg", SaleItem = false},
                new Book {BookId = 8, BookAuthor = "Kelli Stanley, Cynthia Robinson, Rip Gerber, Karen Dionne, Rebecca Cantrell, Lee Child, Bill Cameron, Grant McKenzie, Marc Paoletti, Daniel Palmer, CJ Lyons, J T Ellison", BookTitle = "First Thrill", PriceOfBook = 82.95M, BookDescription = "First Thrills", PicUrl = "/Images/Original/FirstThrills.jpg", PicThumbnail = "/Images/Thumbnail/FirstThrills.jpg", SaleItem = false}
            };
        }

        //  The methods below are included here as part of the
        //  bookinterface and can be referenced back to the 
        //  bookinterface class.

        //  This method will return all books from the mock data above
        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        // This will return the book found by the bookId if the bookid
        // can not be found it will return the first book in the list
        // that has a relatable id.
        public Book GetBookById(int BookId)
        {
            return _books.FirstOrDefault(b => b.BookId == BookId);
        }

        //  This will do the same as what the above method does but 
        // it is looking for the authorid instead of the bookid
        //public Book GetBookByAuthorId(int AuthorId)
        //{
        //    return _books.FirstOrDefault(a => a.AId == AuthorId);
        //}
    }
}
