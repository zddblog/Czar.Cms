using General.Core;
using General.Core.Data;
using General.Core.Extensions;
using General.Entities;
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

            var constr = Configuration.GetConnectionString("Defaultconnection");
            services.AddMvc();
            services.AddDbContext<GeneralDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Defaultconnection")));
            services.AddAuthentication("General").AddCookie(o=>{
                o.LoginPath ="";
            });

            //单个注入
           // services.AddScoped<ICategoryService, CategoryService>();

            //程序集依赖注入
            services.AddAssembly("General.Services");

            //仓储泛型依赖注入
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
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
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
