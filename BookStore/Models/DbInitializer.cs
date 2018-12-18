///////////////////////////////////////////////////////////////////////
///Change History
///Developer    Date    Description
///Laurie       12/05   Added method to set-up database if there isn't one
///Laurie       12/05   Set application to input data and save it, if there isn't data already


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {   //  Check for data in the database, if there isn't any,
            //  add the data provedid below and save it.
            if(!context.Books.Any())
            {
                context.AddRange
                (
                    new Book { BookId = 1, BookAuthor = "Victoria Schwab", BookTitle = "City of Ghosts", PriceOfBook = 12.95M, BookDescription = "A Spooky Delight!", PicUrl = "/Images/Original/CityOfGhosts.jpg", PicThumbnail = "/Images/Thumbnail/CityOfGhosts.jpg", SaleItem = true },
                    new Book { BookId = 2, BookAuthor = "Victoria Schwab", BookTitle = "Our Dark Duet", PriceOfBook = 22.95M, BookDescription = "A Dark Masterpiece!", PicUrl = "/Images/Original/OurDarkDuet.jpg", PicThumbnail = "/Images/Thumbnail/OurDarkDuet.jpg", SaleItem = false },
                    new Book { BookId = 3, BookAuthor = "Victoria Schwab", BookTitle = "A Dark Shade of Magic", PriceOfBook = 32.95M, BookDescription = "A Dark Shade of Magic", PicUrl = "/Images/Original/ADarkShadeOfMagic.jpg", PicThumbnail = "/Images/Thumbnail/ADarkShadeOfMagic.jpg", SaleItem = false },
                    new Book { BookId = 4, BookAuthor = "Victoria Schwab", BookTitle = "Broken Ground", PriceOfBook = 42.95M, BookDescription = "Broken Ground", PicUrl = "/Images/Original/BrokenGround.jpg", PicThumbnail = "/Images/Thumbnail/BrokenGround.jpg", SaleItem = false },
                    new Book { BookId = 5, BookAuthor = "Victoria Schwab", BookTitle = "The Dark Vault", PriceOfBook = 52.95M, BookDescription = "The Dark Vault", PicUrl = "/Images/Original/TheDarkVault.jpg", PicThumbnail = "/Images/Thumbnail/TheDarkVault.jpg", SaleItem = false },
                    new Book { BookId = 6, BookAuthor = "Victoria Schwab", BookTitle = "This Song", PriceOfBook = 62.95M, BookDescription = "This Song", PicUrl = "/Images/Original/ThisSong.jpg", PicThumbnail = "/Images/Thumbnail/ThisSong.jpg", SaleItem = false },
                    new Book { BookId = 7, BookAuthor = "Victoria Schwab", BookTitle = "Vicious", PriceOfBook = 72.95M, BookDescription = "Vicious", PicUrl = "/Images/Original/Vicious.jpg", PicThumbnail = "/Images/Thumbnail/Vicious.jpg", SaleItem = false },
                    new Book { BookId = 8, BookAuthor = "Kelli Stanley, Cynthia Robinson, Rip Gerber, Karen Dionne, Rebecca Cantrell, Lee Child, Bill Cameron, Grant McKenzie, Marc Paoletti, Daniel Palmer, CJ Lyons, J T Ellison", BookTitle = "First Thrill", PriceOfBook = 82.95M, BookDescription = "First Thrills", PicUrl = "/Images/Original/FirstThrills.jpg", PicThumbnail = "/Images/Thumbnail/FirstThrills.jpg", SaleItem = false }
                 );
                context.SaveChanges();
            }
        }
    }
}
