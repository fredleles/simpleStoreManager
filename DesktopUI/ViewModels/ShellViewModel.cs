using DesktopUI.Events;
using DesktopUI.Helpers.Events;
using DesktopUI.Helpers.ViewModelFactory;
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
        private IDisposable unsubscriber;

        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel!; }
            set
            {
                _currentViewModel = value;
            }
        }

        public ShellViewModel(LoginViewModel view, IEventChannel<LogOnEvent> eventAggregator)
        {
            CurrentViewModel = view;
            eventAggregator.Subscribe(this);

        }

        public void Listener(LogOnEvent message)
        {
            // LogOn
        }
    }
}
