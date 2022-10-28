using AccessWebsite.Data;
using AccessWebsite.Models.Webstart;
using AccessWebsite.Models.Advantage;
using AccessWebsite.Models.User;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AccessWebsite.Services;
using AccessWebsite.Data.Data_Providers;

namespace AccessWebsite
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
            // Database Connections 
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("testing")));

            services.AddDbContext<Website_AdvantageContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("Advantage")));

            services.AddDbContext<Website_Advantage_UserContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("User")));

            // Data Providers:
            services.AddTransient<ICustomerDataProvider, CustomerDataProvider>();
            services.AddTransient<IDirectSalesOrderDetailDataProvider, DirectSalesOrderDetailDataProvider>();
            services.AddTransient<IDirectSalesOrderHeaderDataProvider, DirectSalesOrderHeaderDataProvider>();
            services.AddTransient<IDirectSalesOrderStatusDataProvider, DirectSalesOrderStatusDataProvider>();
            services.AddTransient<IPriceClassCodeDataProvider, PriceClassCodeDataProvider>();
            services.AddTransient<IPriceDiscDataProvider, PriceDiscDataProvider>();
            services.AddTransient<IPriceHistoryDataProvider, PriceHistoryDataProvider>();
            services.AddTransient<IProductDataProvider, ProductDataProvider>();
            services.AddTransient<IProductDescriptionDataProvider, ProductDescriptionDataProvider>();
            services.AddTransient<IProductReferenceDataProvider, ProductReferenceDataProvider>();
            services.AddTransient<IUnitMeasureDataProvider, UnitMeasureDataProvider>();
            services.AddTransient<IVwCustomerDataProvdier, VwCustomerDataProvider>();
            services.AddTransient<IVwDirectSalesAnalysisDataProvider, VwDirectSalesAnalysisDataProvider>();
            services.AddTransient<IVwTestviewDataProvider, VwTestviewDataProvider>();

            // Services:
            services.AddTransient<ICustomerService, CustomerService>();

            // Identity
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            // Boiler Plate Code
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
