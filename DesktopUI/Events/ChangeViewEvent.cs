using DesktopUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Events
{
    internal class ChangeViewEvent : IEvent
    {
        public ViewModelBase _viewmodel;

        public ChangeViewEvent(ViewModelBase viewmodel)
        {
            _viewmodel = viewmodel;
        }
    }
}
