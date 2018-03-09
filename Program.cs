using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                // .UseKestrel(options =>
                // {
                //     options.Listen(IPAddress.Loopback, 5000);
                //     options.Listen(IPAddress.Loopback, 5001, listenOptions =>
                //     {
                //         listenOptions.UseHttps("myKey.pfx", "password");
                //     });
                // })
                .UseStartup<Startup>()
                .Build();
    }
}
