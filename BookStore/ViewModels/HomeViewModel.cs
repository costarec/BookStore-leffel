//////////////////////////////////////////////////////////////////////
///Change History
///Developer    Date    Description
///Argenis      11/27   Added the PageTitle and List 
// All the data that is needed inside of the HomeView goes in this class
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.ViewModels
{
    public class HomeViewModel
    {
        public string PageTitle { get; set; }

        public List<Book> Books { get; set; }
    }
}
