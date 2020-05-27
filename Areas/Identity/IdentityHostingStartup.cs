using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyBlazor.Areas.Identity.Data;
using MyBlazor.Data;
using Microsoft.Data.SqlClient;

[assembly: HostingStartup(typeof(MyBlazor.Areas.Identity.IdentityHostingStartup))]
namespace MyBlazor.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {

            //var connBuilder = new SqlConnectionStringBuilder(
            //context.Configuration.GetConnectionString("AccountDBContextConnection"))
            //{
            //    UserID = context.Configuration["DbUsername"],
            //    Password = context.Configuration["DbPassword"]
            //};

            services.AddDbContext<AccountDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CallCenterDbContext")));

                services.AddDefaultIdentity<MyBlazorUser>(options => {
                    options.Password.RequiredLength = 4;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;

                    options.SignIn.RequireConfirmedEmail = false;
                }).AddEntityFrameworkStores<AccountDBContext>();
            });
        }
    }
}