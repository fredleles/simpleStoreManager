using DesktopUI.Events;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Helpers.Events
{
    internal static class EventServiceExtensions
    {
        internal static void AddEventChannels(this IServiceCollection services)
        {
            services.AddSingleton<IEventChannel<LogOnEvent>, EventChannel<LogOnEvent>>();
            services.AddSingleton<IEventChannel<ChangeViewEvent>, EventChannel<ChangeViewEvent>>();
        }
    }
}
