using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SocialMediaApp.Models.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SocialMediaApp.Data
{
    public static  class SocialMediaSeeder
    {
        private static string path = "../SocialMediaApp.Data/SocialMediaJsonFiles/";
        private const string adminPassword = "Admin123@";
        private const string regularPassword = "Regular123@";


        public static async Task SeedDatabase(IApplicationBuilder app)
        {
           
            var userManager = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<UserManager<AppUser>>();
            var roleManager = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var dbContext = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<SocialMediaDbContext>();


            SeedRole(roleManager);
            SeedAppUser(userManager);
           
           

        }

        private static async void SeedAppUser(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var appUsersStream = await File.ReadAllTextAsync("../SocialMediaApp.Data/SocialMediaJsonFiles/AppUser.json");
                var appUsers = JsonSerializer.Deserialize<IEnumerable<AppUser>>(appUsersStream);
                var count = 0;
                foreach (var appUser in appUsers)
                {
                    if (count == 0)
                    {
                        appUser.UserName = appUser.Email;
                        var result1 = await userManager.CreateAsync(appUser, adminPassword);
                        if (result1.Succeeded)
                        {
                            await userManager.AddToRoleAsync(appUser, "Admin");
                        }
                    }
                    else
                    {
                        appUser.UserName = appUser.Email;
                        var result = await userManager.CreateAsync(appUser, regularPassword);
                        if (result.Succeeded)
                        {
                            await userManager.AddToRoleAsync(appUser, "Regular");
                            count++;
                        }
                    }
                   
                   
                }
            }
           

        }

        private static async void SeedRole(RoleManager<IdentityRole> roleManager)
        {
            var roles = new string[] { "Admin", "Regular" };
            if (!roleManager.Roles.Any())
            {
                foreach (var role in roles)
                {
                    if (!roleManager.RoleExistsAsync(role).Result)
                    {
                        await roleManager.CreateAsync(new IdentityRole(role));
                    }
                }
            }
        }

        private static List<T> GetSampleData<T>(string location)
        {
            var output = JsonSerializer.Deserialize<List<T>>(location, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return output;
        }
    }
}
