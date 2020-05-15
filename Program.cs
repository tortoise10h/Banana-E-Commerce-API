using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Banana_E_Commerce_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // using (var context = new DataContext())
            // {
            //     var admin1 = context.Users.SingleOrDefault(u => u.Email == "tortoiseadmin@gmail.com");
            //     if (admin1 != null)
            //     {
            //     }
            // }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
