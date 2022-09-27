using ApiDataAccess.Library.Api;
using DesktopUI.Helpers.ModelsMapping;
using DesktopUI.Models;
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
        private UsersDisplayListMapping _mapping;

        public UsersViewModel(IUserEndpoint userEndpoint, UsersDisplayListMapping mapping)
        {
            _userEndpoint = userEndpoint;
            _mapping = mapping;
            LoadUsers();
        }

        private async void LoadUsers()
        {
            try
            {
                var userList = await _userEndpoint.GetAll();
                var users = _mapping.CreateMap(userList);
                Users = new BindingList<UsersDisplayListModel>(users);
            }
            catch
            {
                // TODO
            }
        }

        private BindingList<UsersDisplayListModel>? _users;
        public BindingList<UsersDisplayListModel>? Users
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
