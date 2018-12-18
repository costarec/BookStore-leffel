///////////////////////////////////////////////////////////////////////
///Change History
///Developer    Date    Description
///Laurie       12/05   Added Database constructor
///Laurie       12/05   Set books database to be managed in books table
///Laurie       12/05   Add using statement for EF Core


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class AppDbContext: DbContext
    {   //  Add in options from entity framework for the database 
        //  to function properly.
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        //  Set books database to be managed in a table called Books
        public DbSet<Book> Books { get; set; }
    }
}
