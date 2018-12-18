//////////////////////////////////////////////////////////////////////
///Change History
///Developer    Date    Description
///Argenis      11/26   Created the  read only interface _bookRepository (constructor) and MainController method was modified
///                     Changed MainController name to HomeController due to .net error complaints by the system, changed folder names AppModels and AppViews
///                      to just Models and Views
///Argenis      11/27   Added books to the inside of the return View() method because it was erroring out
///                     Removed Viewbag.Title and added homeViewModel variable, added using BookStore.ViewModels 
/// Laurie      12/05   Change using statement to .Models instead of .AppModels


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.AppControlers
{
    //Do not forget that for each Controller that is created, there has to be a view for it created in the Views directory
    public class HomeController : Controller

    {
        private readonly IBookInterfaceable _bookRepository;

        public HomeController(IBookInterfaceable bookRepository)
        {
            _bookRepository = bookRepository;
        } 
            // GET: /<controller>/
        public IActionResult Index()
        {

            // For now, the repository of all books will be acquired by GetAllBooks method and ordered by book title
            var books = _bookRepository.GetAllBooks().OrderBy(p => p.BookTitle);
            // The data on the view model is going to contain the Page title and a list of books
            var homeViewModel = new HomeViewModel()
            {
                PageTitle = "Welcome to Directed Reading's Book Store!",
                Books = books.ToList()
            };
            // we need to return homeViewModel back
            return View(homeViewModel);
        }
    }
}
