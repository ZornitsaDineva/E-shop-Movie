using System;
using E_shop_Movie.Areas.Identity.Data;
using E_shop_Movie.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(E_shop_Movie.Areas.Identity.IdentityHostingStartup))]
namespace E_shop_Movie.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<E_shop_MovieUserContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("E_shop_MovieUserContextConnection")));

                services.AddDefaultIdentity<E_shop_MovieUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<E_shop_MovieUserContext>();
            });
        }
    }
}