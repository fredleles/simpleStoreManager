using DesktopUI.Helpers.ViewModelFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DesktopUI.ViewModels
{
    internal class ShellViewModel : ViewModelBase
    {
        private ViewModelBase? _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel!; }
            set
            {
                _currentViewModel = value;
            }
        }

        public ShellViewModel(LoginViewModel view)
        {
            CurrentViewModel = view;
        }


    }
}
