using DesktopUI.ViewModels.Commands.SalesView;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.ViewModels.Commands
{
    internal static class CommandServiceExtensions
    {
        public static void AddCommands(this IServiceCollection services)
        {
            services.AddTransient<INavigateCommand<PdvViewModel>, NavigateCommand<PdvViewModel>>();
            services.AddTransient<INavigateCommand<ProductsViewModel>, NavigateCommand<ProductsViewModel>>();
            services.AddTransient<INavigateCommand<SalesViewModel>, NavigateCommand<SalesViewModel>>();
            services.AddTransient<INavigateCommand<UsersViewModel>, NavigateCommand<UsersViewModel>>();

            services.AddTransient<LoginCommand>();
        }
    }
}
