using DesktopUI.Helpers.ViewViewModelBind;
using DesktopUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DesktopUI.ViewModels
{
    public class ShellViewModel
    {
        private UserControl? _currentView; //ViewModelBase

        public UserControl CurrentView //ViewModelBase
        {
            get { return _currentView!; }
            set
            {
                _currentView = value;
            }
        }

        public ShellViewModel(IWindowFactory<LoginView> view)
        {
            CurrentView = view.Show();
        }
    }
}
