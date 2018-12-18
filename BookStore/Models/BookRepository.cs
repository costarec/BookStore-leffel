///////////////////////////////////////////////////////////////////////
///Change History
///Developer    Date    Description
///Laurie       12/05   Add reference to the interface
///Laurie       11/05   Add dependency injection for database content


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BookRepository: IBookInterfaceable
    {
        private readonly AppDbContext _appDbcontext;

        // use dependency injection to get database conten
        public BookRepository(AppDbContext appDbContext)
        {
            _appDbcontext = appDbContext;
        }
        //  Check for data, if there isn't any, load the data
        public IEnumerable<Book> GetAllBooks()
        {
            return _appDbcontext.Books;
        }
        //  Have database pull first book that matches the Bookid
        //  or return a default book (still not sure what the 
        //  default book would be, will test for this later)
        public Book GetBookById(int BookId)
        {
            return _appDbcontext.Books.FirstOrDefault(b => b.BookId == BookId);
        }
    }
}
