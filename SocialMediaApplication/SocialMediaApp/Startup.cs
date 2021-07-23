using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SocialMediaApp.Data;
using SocialMediaApp.Models.Models;

namespace SocialMediaApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContextPool<SocialMediaDbContext>(options => options.UseSqlite(Configuration.GetConnectionString("Default")));
            services.AddIdentity<AppUser, IdentityRole>(
               options =>
               {
                   options.Password.RequiredUniqueChars = 0;
                   options.Password.RequireNonAlphanumeric = false;
                   options.Password.RequiredLength = 5;
                   options.Password.RequireLowercase = false;
                   options.User.RequireUniqueEmail = true;
                    //options.SignIn.RequireConfirmedEmail = true;

                }
               ).AddEntityFrameworkStores<SocialMediaDbContext>().AddDefaultTokenProviders();
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(Configuration.GetSection("JWTConfigurations:SecretKey").Value)),
                    ValidateIssuer = true,
                    ValidIssuer = Configuration.GetSection("JWTConfigurations:Issuer").Value,
                    ValidateAudience = true,
                    ValidAudience = Configuration.GetSection("JWTConfigurations:Audience").Value
                };
            })
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
               
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            SocialMediaSeeder.SeedDatabase(app).Wait();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
