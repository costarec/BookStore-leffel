//////////////////////////////////////////////////////////////////////
///Change History
///Developer    Date    Description
///Laurie       11/5    Add MVC to the application
///Laurie       11/5    Add middleware components
///Laurie       11/18   Add dependency injection for books 
///Laurie       11/18   Add using statement for Bookstore.appmodels
///Argenis      11/24   Changed services.AddTransient to use IBookInterfaceable name instead of BookInterface
///Argenis      11/26   Added the Index.cshtml view file
///Argenis      11/27   Added Razorpage ViewStart file in the Views folder (This is the master HTML layout so to speak)
///                     Added the ViewModels folder to the root of the project and the class HomeViewModel inside it.
/// Laurie      12/05   Change using statement to .Models instead of .AppModels
/// Laurie      12/05   Added Dbcontext service
/// Laurie      12/05   Replaced mockdata in services.addtransient with the data in bookrepository
/// Laurie      12/05   Use dependency injection to get the system configuration
/// Laurie      12/05   Added Using statement for dependency injection


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore
{
    public class Startup
    {
         // Use dependency injection to get system configuration
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {   
    
            // statement that dbcontext will be used referencing the
            //  type(app.dbcontext).
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //  Uses dependency injection. For everytime
            //  bookinterface is requested, a new mockdata repository
            //  is created.
            services.AddTransient<IBookInterfaceable, BookRepository>();

            // Since this project started as an empty shell, 
            // the MVC service was added here for use within the
            // application.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure
        //the HTTP request pipeline.
        // Another thing that is important to note for this section is 
        // that the order in which these components are listed is the 
        // order in which they will be executed according to Gill Cleeren,
        // the order does matter.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // This is here so that the application will signal when 
            // something goes wrong while developing.
            app.UseDeveloperExceptionPage();

            // This will show the code of a status exeption to 
            // further help identify any page errors.
            app.UseStatusCodePages();

            // This will allow the application to search for any static
            // files such as css and images. According to Gill Cleeren 
            // the files are seached for in the wwwroot folder, which is 
            // where they should be stored.
            app.UseStaticFiles();

            // This is to let the application know the routing that will
            // be used for mvc services.
            app.UseMvcWithDefaultRoute();


        }
    }
}
