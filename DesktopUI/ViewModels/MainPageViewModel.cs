using ApiDataAccess.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.ViewModels
{
    internal class MainPageViewModel : ViewModelBase
    {
        public string UserName { get; set; }
        private ILoggedInUserModel _loggedInUser;

        public MainPageViewModel(ILoggedInUserModel loggedInUser)
        {
            _loggedInUser = loggedInUser;
            UserName = _loggedInUser.EmailAddress;
        }
    }
}
