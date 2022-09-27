using ApiDataAccess.Library.Models;
using DesktopUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Helpers.ModelsMapping
{
    internal class UsersDisplayListMapping : ModelMapping<UserModel, UsersDisplayListModel>
    {
        protected override UsersDisplayListModel SpecificMapping(UserModel fromObj)
        {
            UsersDisplayListModel model = new()
            {
                FullName = $"{fromObj.FirstName} {fromObj.LastName}",
                Role = "", // TODO
                EmailAddress = fromObj.EmailAddress,
                CreatedDate = fromObj.CreatedDate
            };
            return model;
        }
    }
}
