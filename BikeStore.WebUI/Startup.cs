using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeStore.Business.Abstract;
using BikeStore.Business.Concrete.Managers;
using BikeStore.DataAccess.Abstract;
using BikeStore.DataAccess.Concrete.EntityFramework;
using BikeStore.WebUI.AuthIdentity;
using BikeStore.WebUI.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BikeStore.WebUI
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

            //db
           

            //new identity

            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConStr")));
            services.AddIdentity<AppIdentityUser, AppIdentityRole>()
                .AddEntityFrameworkStores<IdentityContext>()
                .AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;//sayý zorunluluðu
                options.Password.RequireLowercase = true;//küçük harf
                options.Password.RequiredLength = 8;//minimum 8 karakter
                options.Password.RequireNonAlphanumeric = true;//alfanümerik olmasý
                options.Password.RequireUppercase = true;//büyük harf zorunluluðu

                options.Lockout.MaxFailedAccessAttempts = 5;//max hatalý giriþ sayýsý
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);//kullanýcý ne kadar süre boyunca sisteme giriþ yapamasýn
                options.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/administrator/login";
                options.LogoutPath = "/administrator/log-out";
                options.AccessDeniedPath = "/administrator/access-denied";
                options.SlidingExpiration = true;
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".AspNetCoreIdentity",
                    Path = "/",
                    SameSite = SameSiteMode.Strict
                };
            });

            //identitiy finish

            services.AddAuthentication(options =>
                {
                    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                })
                .AddCookie(options =>
                {
                    options.LoginPath = "account/google-login";
                })
                .AddGoogle(options =>
                {
                   

                    options.ClientId = "761113825363-t0omb1gv8r67il9irtu1nl3m6o7eq732.apps.googleusercontent.com";
                    options.ClientSecret = "PjcEc-mK6IVt2AKgBclqOAWq";
                });



            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddControllersWithViews();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<IBrandService, BrandManager>();
            services.AddScoped<IBrandDal, EfBrandDal>();





            //services.AddDbContext<CustomIdentityDbContext>(options => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=BikeStores; Trusted_Connection=True"));

            //services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
            //    .AddEntityFrameworkStores<CustomIdentityDbContext>().AddDefaultTokenProviders();
            services.AddMvc();

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
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

        }
    }
}
