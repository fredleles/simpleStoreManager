using ApiDataAccess.Library.Models;
using DesktopUI.Events;
using DesktopUI.Helpers.Events;
using DesktopUI.ViewModels.Commands;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesktopUI.ViewModels
{
    internal class MainPageViewModel : ViewModelBase, IHandle<ChangeViewEvent>
    {
        public string UserName { get; set; }
        private ILoggedInUserModel _loggedInUser;
        private ViewModelBase? _currentViewModel;

        // private IDisposable unsubscriber;

        public ICommand NavigateToPDV { get; } // falta inicializar os comandos
        public ICommand NavigateToProducts { get; }
        public ICommand NavigateToSales { get; }
        public ICommand NavigateToUsers { get; }

        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel!; }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public MainPageViewModel(
            ILoggedInUserModel loggedInUser,
            IEventChannel<ChangeViewEvent> eventAggregator,
            IServiceProvider provider,
            INavigateCommand<PdvViewModel> pdvCommand,
            INavigateCommand<ProductsViewModel> prodCommand,
            INavigateCommand<SalesViewModel> salesCommand,
            INavigateCommand<UsersViewModel> usersCommand
            )
        {
            _loggedInUser = loggedInUser;
            UserName = _loggedInUser.EmailAddress;

            eventAggregator.Subscribe(this);
            CurrentViewModel = provider.GetService<PdvViewModel>()!;

            NavigateToPDV = (ICommand)pdvCommand;
            NavigateToProducts = (ICommand)prodCommand;
            NavigateToSales = (ICommand)salesCommand;
            NavigateToUsers = (ICommand)usersCommand;
        }

        public void Listener(ChangeViewEvent message)
        {
            CurrentViewModel = message._viewmodel;
        }
    }
}
