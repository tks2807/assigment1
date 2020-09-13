using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;


namespace assgmnt1
{
    public class Program
    {
     
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        

            //GetById gbi = (id) => list.Where(food => food.Id == id).ToList();
            //var food = gbi(1);
            //System.Diagnostics.Debug.WriteLine(food);
        }
        

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
