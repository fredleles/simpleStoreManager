using DesktopUI.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesktopUI.ViewModels
{
    internal class LoginViewModel : ViewModelBase
    {
        public LoginCommand LoginCommand { get; }
        public LoginViewModel(LoginCommand command)
        {
            LoginCommand = command;
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        private string _userName = "";

        public string UserName
        {
            get { return _userName!; }
            set
            {
                _userName = value;
                LoginCommand.UserName = _userName;
                OnPropertyChanged(nameof(UserName));
            }
        }
    }
}
