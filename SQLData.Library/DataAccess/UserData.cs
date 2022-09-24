using SQLData.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData.Library.DataAccess
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _sql;
        public record struct UserAuth(string Id);
        public UserData(ISqlDataAccess sql)
        {
            _sql = sql;
        }
        public string VerifyLogin(string username, string password)
        {            
            var user = _sql.LoadData<UserAuth, dynamic>("dbo.spUserGetAuth", new { EmailAddress = username, Password = password });

            return user[0].Id;
        }

        public List<UserModel> GetUserById(string Id)
        {
            return _sql.LoadData<UserModel, dynamic>("dbo.spUserGetInfo", new { Id });
        }

        public List<UserModel> GetAll()
        {
            return _sql.LoadData<UserModel, dynamic>("dbo.spUserGetAll", new { });
        }
    }
}
