using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.DependecyResolvers.Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
               
                // ---------- Dotnet IoC yerine AutoFac kullanmak istersek bu ayarlari yapmak lazim

                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>(builder =>
                {
                    // Ioc ayarlarini da Business te AutofacBusinessModule yazmak 
                    builder.RegisterModule(new AutofacBusinessModule());
                })

            //--------------------------------------------------------

    .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
