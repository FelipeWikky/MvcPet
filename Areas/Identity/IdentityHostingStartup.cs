using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcPet.Areas.Identity.Data;

[assembly: HostingStartup(typeof(MvcPet.Areas.Identity.IdentityHostingStartup))]
namespace MvcPet.Areas.Identity
{
  public class IdentityHostingStartup : IHostingStartup
  {
    public void Configure(IWebHostBuilder builder)
    {
      builder.ConfigureServices((context, services) =>
      {
        services.AddDbContext<MvcPetIdentityDbContext>(options =>
            options.UseSqlite(
                context.Configuration.GetConnectionString("MvcPetIdentityDbContextConnection")));

        services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
          .AddRoles<IdentityRole>()
          .AddEntityFrameworkStores<MvcPetIdentityDbContext>();
          
        // services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
        //   .AddEntityFrameworkStores<MvcPetIdentityDbContext>();
      });
    }
  }
}