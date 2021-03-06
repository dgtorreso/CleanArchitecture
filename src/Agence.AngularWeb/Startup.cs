using Autofac;
using Autofac.Extensions.DependencyInjection;
using Agence.Core.SharedKernel;
using Agence.Infrastructure.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.ComponentModel;
using System.Reflection;

namespace Agence.AngularWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public bool UsarMysql { get; set; } = true;

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // TODO: Add DbContext and IOC
            // TODO: Add DbContext and IOC
            if (UsarMysql)
            {

                services.AddDbContext<AppDbContext>( // replace "YourDbContext" with the class name of your DbContext
                    options => options.UseMySql("Server=localhost;Database=caol;User=inspeccion;Password=venga;", // replace with your Connection String
                        mysqlOptions =>
                        {
                            mysqlOptions.ServerVersion(new Version(5, 7, 17), ServerType.MySql); // replace with your Server Version and Type
                        }
                ));
            }
            else
            {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            }

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });

            return BuildDependencyInjectionProvider(services);
        }

        private static IServiceProvider BuildDependencyInjectionProvider(IServiceCollection services)
        {
            var builder = new ContainerBuilder();

            // Populate the container using the service collection
            builder.Populate(services);

            // TODO: Add Registry Classes to eliminate reference to Infrastructure
            Assembly webAssembly = Assembly.GetExecutingAssembly();
            Assembly coreAssembly = Assembly.GetAssembly(typeof(BaseEntity));
            Assembly infrastructureAssembly = Assembly.GetAssembly(typeof(EfRepository)); // TODO: Move to Infrastucture Registry
            builder.RegisterAssemblyTypes(webAssembly, coreAssembly, infrastructureAssembly).AsImplementedInterfaces();

            Autofac.IContainer applicationContainer = builder.Build();
            return new AutofacServiceProvider(applicationContainer);
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
