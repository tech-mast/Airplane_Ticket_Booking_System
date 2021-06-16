using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using EagleFlight.Data;
using EagleFlight.Models;
using Microsoft.AspNetCore.Identity;
using EagleFlight.Services;

namespace EagleFlight
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
            services.AddRazorPages();
            // added for Identity
            services.AddDbContext<EagleFlightDbContext>(); 
            services.AddIdentity<EagleFlightUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<EagleFlightDbContext>()
                .AddDefaultTokenProviders();// to generate tokens for reset passwords, change email and change telephone number
            
            // services.AddAuthentication().AddGoogle(options =>
            //     {
            //         IConfigurationSection googleAuthNSection =
            //             Configuration.GetSection("Authentication:Google");

            //         options.ClientId = googleAuthNSection["ClientId"];
            //         options.ClientSecret = googleAuthNSection["ClientSecret"];
            //     });
            
            services.Configure<IdentityOptions>(options =>
                {
                    // Password settings.
                    options.Password.RequireDigit = true;
                    options.Password.RequireLowercase = true;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = true;
                    options.Password.RequiredLength = 8;
                    options.Password.RequiredUniqueChars = 5;

                    // Lockout settings.
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                    options.Lockout.MaxFailedAccessAttempts = 5;
                    options.Lockout.AllowedForNewUsers = true;

                    // User settings.
                    options.User.AllowedUserNameCharacters =
                        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                    options.User.RequireUniqueEmail = true;
                    // allow users with EmailConfirmed value 0/false to log in
                    options.SignIn.RequireConfirmedAccount = true;
            });

            services.ConfigureApplicationCookie(options =>
                {
                    // Cookie settings
                    options.Cookie.HttpOnly = true;
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(25);

                    options.LoginPath = "/Account/Login";
                    options.AccessDeniedPath = "/AccessDenied";
                    options.SlidingExpiration = true;
            });

            services.AddTransient<ITicketService, TicketService>(); // WEB API
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();// added for authentication with identityuser

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
