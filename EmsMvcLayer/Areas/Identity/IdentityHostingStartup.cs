using System;
using EmsMvcLayer.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EmsMvcLayer.Areas.Identity.IdentityHostingStartup))]
namespace EmsMvcLayer.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<EmsMvcLayerContext>(options =>
                //    options.UseSqlServer(
                //        context.Configuration.GetConnectionString("EmsMvcLayerContextConnection")));

                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<EmsMvcLayerContext>();
            });
        }
    }
}