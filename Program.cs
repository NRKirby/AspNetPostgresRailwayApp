using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AspNetPostgresRailwayApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var portVar = Environment.GetEnvironmentVariable("PORT");
                    if (portVar is {Length: > 0} && int.TryParse(portVar, out int port))
                    {
                        webBuilder.ConfigureKestrel(options =>
                        {
                            options.ListenAnyIP(port);
                        });
                    }

                    webBuilder.UseStartup<Startup>();
                });
    }
}
