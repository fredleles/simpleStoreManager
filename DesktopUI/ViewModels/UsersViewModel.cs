using ApiDataAccess.Library.Api;
using ApiDataAccess.Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.ViewModels
{
    internal class UsersViewModel : ViewModelBase
    {
        IUserEndpoint _userEndpoint;

        public UsersViewModel(IUserEndpoint userEndpoint)
        {
            _userEndpoint = userEndpoint;
            LoadUsers();
        }

        private async void LoadUsers()
        {
            try
            {
                var userList = await _userEndpoint.GetAll();
                Users = new BindingList<UserModel>(userList);
            }
            catch
            {

            }
        }

        private BindingList<UserModel>? _users;
        public BindingList<UserModel>? Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }
    }
}
