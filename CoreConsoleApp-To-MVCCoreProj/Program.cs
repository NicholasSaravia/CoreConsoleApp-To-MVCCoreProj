using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CoreConsoleApp_To_MVCCoreProj
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder BuildWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder().UseStartup<Startup>();
    }
}
