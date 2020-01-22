using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using _13.Identity_lab.Data;
using Microsoft.EntityFrameworkCore;
using _13.Identity_lab.Models;

namespace _13.Identity_lab.Infrastructure.Extension
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseDatabaseMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetService<ApplicationDbContext>().Database.Migrate();

                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                var userManager = serviceScope.ServiceProvider.GetService<UserManager<ApplicationUser>>();

                Task.Run(async() =>
                {
                   var adminName = GlobalConstants.AdministratorRole;

                   var roleExists = await roleManager.RoleExistsAsync(adminName);

                   if (!roleExists)
                   {
                       await roleManager.CreateAsync(new IdentityRole{Name = adminName });
                   }

                   var adminEmail = "admin@mysite.com";
                   var adminUser = await userManager.FindByNameAsync(adminEmail);

                   if (adminUser == null)
                   {
                       adminUser = new ApplicationUser {Email = adminEmail, UserName = adminEmail};
                       await userManager.CreateAsync(adminUser, "admin12");
                       await userManager.AddToRoleAsync(adminUser, adminName);
                   }
                }).Wait();



            }
            return app;
        }
    }
}

