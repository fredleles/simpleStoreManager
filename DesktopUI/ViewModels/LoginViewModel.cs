using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _userName = "";

        public string UserName
        {
            get { return _userName!; }
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public LoginViewModel()
        {

            UserName = "fred";
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }

}
