using ContractGpdWebApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RM.WebApp.Extensions;
using RM.WebApp.Models;
using RM.WebApp.Services;
using RM.WebApp.Services.AuthorizationHandlers;
using RM.WebApp.Services.AuthorizationRequirements;

namespace RM.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.RegisterDbContexts(Configuration);
            services.RegisterRepositories();
            services.RegisterServices();

            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddRazorPages();

            services.AddAuthorization(options =>
            {
                options.AddPolicy(Constants.CanAccessToWorkTypeDirectoryPolicy, p => p.AddRequirements(new CanAccessToWorkTypeDirectoryRequirement()));
            });

            services.AddSingleton<IAuthorizationHandler, IsAdminHandler>();
            services.AddSingleton<IAuthorizationHandler, IsShopEmployeeHandler>();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
