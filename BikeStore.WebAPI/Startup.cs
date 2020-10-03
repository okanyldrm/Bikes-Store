using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeStore.Business.Abstract;
using BikeStore.Business.Concrete.Managers;
using BikeStore.DataAccess.Abstract;
using BikeStore.DataAccess.Concrete.EntityFramework;
using BikeStore.WebAPI.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BikeStore.WebAPI
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
            services.AddControllers();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<IBrandService, BrandManager>();
            services.AddScoped<IBrandDal, EfBrandDal>();
            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo
                    {
                        Title = "BikeStore Swagger",
                        Description = "Bikestore hakkýnda api açýklamalarý içerir",
                        Version = "v1"
                    });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json","Swagger BikeStoreName");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller}/{action}/{id?}",
                //    defaults: new { controller = "Product", action = "getall" });

                //endpoints.MapControllerRoute(
                //name: "default",
                //pattern: "api/{controller=swagger}/{action=index}");
            });
        }
    }
}
