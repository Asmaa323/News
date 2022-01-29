using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using News.Areas.Identity.Data;
using News.Data;

[assembly: HostingStartup(typeof(News.Areas.Identity.IdentityHostingStartup))]
namespace News.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<NewsDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("NewsDbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;

                    options.Password.RequireUppercase = false;

                    options.Password.RequireLowercase = false;



                })
                    .AddEntityFrameworkStores<NewsDbContext>();
            });
        }
    }
}