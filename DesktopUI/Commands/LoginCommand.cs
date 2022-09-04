using DesktopUI.Events;
using DesktopUI.Helpers.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesktopUI.Commands
{
    internal class LoginCommand : CommandBase
    {
        private readonly IEventChannel<LogOnEvent> _evt;

        public LoginCommand(IEventChannel<LogOnEvent> evt)
        {
            _evt = evt;
        }
        public override void Execute(object? parameter)
        {
            _evt.PublishEvent(new LogOnEvent());
        }
    }
}
