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
        public UserData(ISqlDataAccess sql)
        {
            _sql = sql;
        }
        public async Task<bool> VerifyLogin(string username, string password)
        {
            var scalar = await _sql.VerifyLogin(username, password);

            if ((int)scalar == 0) return false;
            return true;
        }
    }
}
