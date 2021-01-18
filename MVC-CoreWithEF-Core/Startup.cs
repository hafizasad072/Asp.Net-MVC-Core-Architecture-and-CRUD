using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.EmployeeRepo;
using DBCoreLayer.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVCCoreWithEFCore.ExtensionMethods;
using ServiceLayer.Employee;
using ServiceLayer.UnitOfWork;

namespace MVC_CoreWithEF_Core
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

            services.AddDbContext<MVCEFCoreContext>();
            services.AddSession(opt => opt.IdleTimeout = TimeSpan.FromMinutes(30));

            #region Inversion of Control(DI)

            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            services.AddScoped<MVCEFCoreContext>();

            #endregion
            //          opts =>
            //opts.UseSqlServer(Configuration["DefaultConnection:MVCEFCoreContext"]));
            services.AddMvc();
            //services.AddDbContext<MVCEFCoreContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MVCEFCoreContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseSession();
            app.Use(async (context, next) =>
            {
                context.Session.SetObject("CurrentUser",
                    new { Username = "James", Email = "james@bond.com" });
                await next();
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
