﻿using General.Core;
using General.Entities;
using General.Services.Category;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GeneralMVC
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
            //services.Configure<CookiePolicyOptions>(options =>
            //{

            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});


            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            var constr = Configuration.GetConnectionString("Defaultconnection");
            services.AddMvc();
            services.AddDbContextPool<GeneralDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Defaultconnection")));
            services.AddAuthentication();
            services.AddScoped<ICategoryService,CategoryService>();
        //    services.BuildServiceProvider().GetService<ICategoryService>();
            EngineContext.Initialize(new GeneralEngin(services.BuildServiceProvider()));
        }

       
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            // app.UseCookiePolicy();
            app.UseAuthentication(); 
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
