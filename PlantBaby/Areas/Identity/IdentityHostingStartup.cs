using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlantBaby.Areas.Identity.Data;

[assembly: HostingStartup(typeof(PlantBaby.Areas.Identity.IdentityHostingStartup))]
namespace PlantBaby.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PlantDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PlantDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<PlantDbContext>();
            });
        }
    }
}