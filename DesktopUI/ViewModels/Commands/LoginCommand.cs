using ApiDataAccess.Library.Api;
using DesktopUI.Events;
using DesktopUI.Helpers.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace DesktopUI.ViewModels.Commands
{
    internal class LoginCommand : CommandBase
    {
        private readonly IEventChannel<LogOnEvent> _evt;
        public string UserName { get; set; }
        private string Password = "";
        private readonly IAPIHelper _apiHelper;

        public LoginCommand(IEventChannel<LogOnEvent> evt, IAPIHelper apiHelper)
        {
            _evt = evt;
            UserName = "";
            _apiHelper = apiHelper;
        }
        public override void Execute(object? parameter)
        {
            var passwordBox = parameter as PasswordBox;
            Password = passwordBox?.Password ?? "";
            _ = LogIn();
        }

        private async Task LogIn()
        {
            try
            {
                // TODO - Tratar a resposta da API (token)
                var result = await _apiHelper.Authenticate(UserName, Password);
                _evt.PublishEvent(new LogOnEvent());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
