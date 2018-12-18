///////////////////////////////////////////////////////////////////////
/// Change History
/// Developer   Date    Description
/// Laurie      11/18   Add method to get all books
/// Laurie      11/18   Add method to get book by bookid
/// Laurie      11/18   Add method to get book by author or authorid
/// Argenis     11/24   Changed Name of interface to IBookInterfaceable from BookInterface
/// Argenis     11/26   Added public in front of the interface, Changed Models folder to AppModels
/// Laurie      12/05   Change using statement to .Models instead of .AppModels


using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public interface IBookInterfaceable
    {
        // Method to get all of the books
        IEnumerable<Book> GetAllBooks();
        // Method to find books by bookid
        Book GetBookById(int BookId);
        // Find books by author, or authorid. Ask Professor??
       // Book GetBookByAuthor(int AuthorId);
    }
}
