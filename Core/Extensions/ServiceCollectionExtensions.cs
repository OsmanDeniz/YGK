using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    /// <summary>
    /// Core katmani da dahil olmak uzere butun injectionlari bir arada toplayabilmek icin yazilan bir sinif.
    /// Extension yazabilmek icin siniflar static olmalidir.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependecyResolvers(this IServiceCollection serviceCollection, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }

            return ServiceTool.Create(serviceCollection);
        }
    }
}
