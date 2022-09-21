using DesktopUI.Events;
using DesktopUI.Helpers.Events;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.ViewModels.Commands
{
    internal class NavigateCommand<T> : CommandBase, INavigateCommand<T>
        where T : ViewModelBase
    {
        private readonly IEventChannel<ChangeViewEvent> _evt;
        private readonly ViewModelBase _viewmodel;
        public NavigateCommand(T viewmodel, IEventChannel<ChangeViewEvent> evt)
        {
            _viewmodel = viewmodel;
            _evt = evt;
        }
        public override void Execute(object? parameter)
        {
            _evt.PublishEvent(new ChangeViewEvent(_viewmodel));
        }
    }
}
