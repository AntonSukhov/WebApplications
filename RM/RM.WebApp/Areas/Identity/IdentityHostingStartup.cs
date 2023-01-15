using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(RM.WebApp.Areas.Identity.IdentityHostingStartup))]
namespace RM.WebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}