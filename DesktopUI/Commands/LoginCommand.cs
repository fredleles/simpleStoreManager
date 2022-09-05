using DesktopUI.Events;
using DesktopUI.Helpers.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace DesktopUI.Commands
{
    internal class LoginCommand : CommandBase
    {
        private readonly IEventChannel<LogOnEvent> _evt;
        public string UserName { get; set; }

        public LoginCommand(IEventChannel<LogOnEvent> evt)
        {
            _evt = evt;
            UserName = "";
        }
        public override void Execute(object? parameter)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
            var passwordBox = parameter as PasswordBox;
            //var password = passwordBox.Password;
            _evt.PublishEvent(new LogOnEvent());
        }
    }
}
