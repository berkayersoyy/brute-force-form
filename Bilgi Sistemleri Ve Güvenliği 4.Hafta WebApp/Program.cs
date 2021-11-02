using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Bilgi_Sistemleri_Ve_Güvenliği_4.Hafta_WebApp
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
                    webBuilder.UseStartup<Startup>();
                });
    }
}
