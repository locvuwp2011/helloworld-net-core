using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace aspnetcore_web
{
    public class Program
    {
        // public static void Main(string[] args)
        // {
        //     BuildWebHost(args).Run();
        // }

        // public static IWebHost BuildWebHost(string[] args) =>
        //     WebHost.CreateDefaultBuilder(args)
        //         .UseStartup<Startup>()
        //         .Build();

        public static void Main(string[] args){
            var configure = new ConfigurationBuilder().AddCommandLine(args).Build();

            var host = new WebHostBuilder()
                            .UseKestrel()
                            .UseConfiguration(configure)
                            .UseContentRoot(Directory.GetCurrentDirectory())
                            .UseIISIntegration()
                            .UseStartup<Startup>()
                            .Build();

            host.Run();
        }
    }
}
