using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace WebAPI
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
            // bu kisim business e tasindi.Autofac klasorunde

            // singleton = bellekte 1 tane nesne uretir 1 milyon istekte gelse o referansi verir
            //    //services.AddScoped<IProductService,ProductManager>();
            //    services.AddSingleton<IProductService, ProductManager>(); // IoC = Bellekte bir kutu olsun icine newlenen seyleri atiyim kimin ihtiyaci olursa ona ilgili referansi veriyim. mantigi ile calisir.

            //    services.AddSingleton<IProductDal, efProductDal>(); // Product manager da iproductdal istiyordu o bagimliligi da bu asamada cozduk. biri productdal istediginde efproductdal i ver dedik.

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
