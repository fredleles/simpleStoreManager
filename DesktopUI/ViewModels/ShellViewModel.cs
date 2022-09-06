using DesktopUI.Events;
using DesktopUI.Helpers.Events;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DesktopUI.ViewModels
{
    internal class ShellViewModel : ViewModelBase, IHandle<LogOnEvent>
    {
        private ViewModelBase? _currentViewModel;
        private IServiceProvider _provider;
        // private IDisposable unsubscriber;

        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel!; }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ShellViewModel(LoginViewModel view, IEventChannel<LogOnEvent> eventAggregator, IServiceProvider provider)
        {
            CurrentViewModel = view;
            _provider = provider;

            eventAggregator.Subscribe(this);
        }

        public void Listener(LogOnEvent message)
        {
            if (message.Code == 200)
            {
                CurrentViewModel = _provider.GetService<MainPageViewModel>()!;
            }
            
        }
    }
}
