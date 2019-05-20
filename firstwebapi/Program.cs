using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using firstwebapi.Persistence.Contexts;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace firstwebapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var webHost =  CreateWebHostBuilder(args);
            EnsureDatabaseIsCreated(webHost);
            webHost.Run();
        }


        /**
         * Ensure that the application database is valid or else db context isn't created. 
         * https://github.com/aspnet/EntityFrameworkCore/issues/11666
        */
        public static void EnsureDatabaseIsCreated(IWebHost webHost)
        {
            using (var scope = webHost.Services.CreateScope())
            using (var context = scope.ServiceProvider.GetService<ApplicationDatabaseContext>())
            {
                context.Database.EnsureCreated();
            }
        }

        public static IWebHost CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
