﻿using CarDealer.Data.Models;
using CarDealer.Web.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace CarDealer.Web.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        //Administrator access
        public static IApplicationBuilder UseDatabaseMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetService<CarDealerDbContext>().Database.Migrate();

                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                var userManager = serviceScope.ServiceProvider.GetService<UserManager<User>>();

                Task
                     .Run(async () =>
                     {
                         var adminName = GlobalConstants.AdministratorRole;

                         var roleExists = await roleManager.RoleExistsAsync(adminName);

                         if (!roleExists)
                         {
                             await roleManager.CreateAsync(new IdentityRole
                             {
                                 Name = adminName
                             });
                         }

                         var adminUser = await userManager.FindByNameAsync(adminName);

                         if (adminUser == null)
                         {
                             adminUser = new User
                             {
                                 Email = "admin@abv.bg",
                                 UserName = "admin@abv.bg",
                             };

                             await userManager.CreateAsync(adminUser, "admin12");
                             await userManager.AddToRoleAsync(adminUser, adminName);
                         }
                     })
                     .Wait();
            }
            return app;
        }
    }
}
