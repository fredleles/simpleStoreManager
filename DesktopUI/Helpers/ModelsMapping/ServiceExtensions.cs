using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Helpers.ModelsMapping
{
    internal static class ServiceExtensions
    {
        internal static void AddModelMappings(this IServiceCollection services)
        {
            services.AddTransient<ProductDisplayListMapping>();
            services.AddTransient<UsersDisplayListMapping>();
        }
    }
}
