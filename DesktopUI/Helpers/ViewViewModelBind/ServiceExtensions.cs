using DesktopUI.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DesktopUI.Helpers.ViewViewModelBind
{
    internal static class ServiceExtensions
    {
        internal static void AddMVVMFactory<TView, UViewModel>(this IServiceCollection services)
            where TView : UserControl
            where UViewModel : ViewModelBase
        {
            services.AddTransient<TView>();
            services.AddTransient<UViewModel>();
            services.AddSingleton<Func<TView>>(x => () =>
            {
                TView view = x.GetService<TView>()!;
                UViewModel viewModel = x.GetService<UViewModel>()!;
                view.DataContext = viewModel;
                return view;
            });
            services.AddSingleton<IWindowFactory<TView>, WindowFactory<TView>>();
        }
    }
}
