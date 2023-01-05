using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections;
namespace Todo.Mvc.Ui
{
    public class Program
    {
        public static void Main(string[] args)
        {

            BuildWebHost(args).Run();

        }
        
        public static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseUrls($"http://*:{System.Environment.GetEnvironmentVariable("PORT")};http://localhost:3000")
            .Build();

    
  }
}
