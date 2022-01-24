using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.WebSite.Areas.Identity.Data;
using OnlineShop.WebSite.Data;

[assembly: HostingStartup(typeof(OnlineShop.WebSite.Areas.Identity.IdentityHostingStartup))]
namespace OnlineShop.WebSite.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<OnlineShopWebSiteContext>(options =>
                    options.UseNpgsql(
                        context.Configuration.GetConnectionString("PostgreDB")));

                services.AddDefaultIdentity<OnlineShopWebSiteUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<OnlineShopWebSiteContext>();
            });
        }
    }
}