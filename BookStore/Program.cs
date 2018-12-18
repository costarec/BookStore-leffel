//////////////////////////////////////////////////////////////////////
///Change History
///Developer    Date    Description
///Argenis      11/24   Changed the name of the folder AppView to AppViews to better reflect
///                     the naming convention
///Argenis      11/24   Added the twitter-boostrap version 3.3.7 to the root of the folder
///Argenis      12/05   Added folder named content to the wwwroot and inside a file called site.css
///                     for custom CSS, re-named folder Images to images
///
///Laurie       12/05   Add using statement for dependency injection 
///Laurie       12/05   Add call for seed method created in Dbinitializer
///Laurie       12/14   Changed the web host creation call back to the version before the update to clear out the errors.
///Laurie       12/15   Database isn't loading, still can't find a reason why. Submitting assignment...

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //  This is the update
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<AppDbContext>();
                    DbInitializer.Seed(context);
                }
                catch (Exception)
                {
                    //Gill Cleerin says "we could log this in a real-world situation"
                    //  I think this means we could insert a text file for logging here
                }
            }

            host.Run();
            //CreateWebHostBuilder(args).Build().Run();
        }

        //  This is the previous version that works now
          public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();

        //  This is the update that I couldn't get to work
        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) => WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();

    }
}