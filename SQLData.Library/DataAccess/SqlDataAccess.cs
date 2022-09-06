using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData.Library.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;
        private string connectionString = "";
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
            connectionString = _config.GetConnectionString("DefaultConnection");
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure).ToList();

                return rows;
            }
        }

        public async Task<object> VerifyLogin(string username, string password)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                 object scalar = await connection.ExecuteScalarAsync("spUserGetAuth", new { EmailAddress = username, Password = password },
                    commandType: CommandType.StoredProcedure);

                return scalar;
            }
        }
    }
}
