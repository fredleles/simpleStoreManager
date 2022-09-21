using ApiDataAccess.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesktopUI.ViewModels
{
    internal class MainPageViewModel : ViewModelBase
    {
        public string UserName { get; set; }
        private ILoggedInUserModel _loggedInUser;

        public ICommand NavigateToPDV { get; }
        public ICommand NavigateToProducts { get; }
        public ICommand NavigateToSales { get; }
        public ICommand NavigateToUsers { get; }

        public ViewModelBase CurrentViewModel { get; }

        public MainPageViewModel(ILoggedInUserModel loggedInUser)
        {
            _loggedInUser = loggedInUser;
            UserName = _loggedInUser.EmailAddress;
            CurrentViewModel = new PdvViewModel();
        }
    }
}
