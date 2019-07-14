using System;
using DeviceWebApi.Models;
using DeviceWebApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wangkanai.Detection;

namespace DeviceWebApi
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
            services.AddDetectionCore()
            .AddDevice()
            .AddBrowser()
            .AddCrawler();

            services.AddScoped<IService<MobileNews>, MobileService<MobileNews>>();
            services.AddScoped<IService<TabletNews>, TabletService<TabletNews>>();
            services.AddScoped<IService<DesktopNews>, DesktopService<DesktopNews>>();

            services.AddSingleton(typeof(IDataService<>), typeof(DataService<>));

            // services.AddTransient<Func<DeviceType, IService<T>>>(serviceProvider => key =>
            //   {
            //       switch (key)
            //       {
            //           case Device.Mobile:
            //               return serviceProvider.GetService<MobileService<MobileNews>>();
            //           case Device.Desktop:
            //               return serviceProvider.GetService<DesktopService<DesktopNews>>();
            //           case Device.Tablet:
            //               return serviceProvider.GetService<TabletService<TabletNews>>();
            //           default:
            //               return serviceProvider.GetService<DesktopService<DesktopNews>>();
            //       }
            //   });

            services.AddMvc()
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
