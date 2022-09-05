using DesktopUI.ViewModels;
using DesktopUI.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DesktopUI.Helpers.ViewModelFactory
{
    internal static class ServiceExtensions
    {
        internal static void AddMVVMs(this IServiceCollection services)
        {
            services.AddSingleton<ShellView>();
            services.AddSingleton<ShellViewModel>();
            services.AddTransient<LoginViewModel>();
            services.AddTransient<MainPageViewModel>();
        }
    }
}
