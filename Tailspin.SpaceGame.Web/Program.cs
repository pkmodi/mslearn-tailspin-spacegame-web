using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace TailSpin.SpaceGame.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            //.ConfigureAppConfiguration((hostingContext, config) =>
            // {
            //     config.AddJsonFile($"appsettings.machinename.json", optional: true);
            //     config.AddCommandLine(args);
            // })
            //.ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
            .UseStartup<Startup>();
    }
}
