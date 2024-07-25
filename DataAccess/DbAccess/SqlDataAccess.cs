using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }
        // The point of this class, the db access layer, is that its methods can be reused by the data
        // layer. The LoadData method takes two generic types, T and U. T is used to specify the return 
        // type; U specifies the parameters. Take note that LoadData returns a Task which on resolution
        // gives a LIST of the specified type!
        public async Task<IEnumerable<T>> LoadData<T, U>(string sql, U parameters, string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

            return await connection.QueryAsync<T>(sql, parameters);
        }

        public async Task<int> SaveData<T>(string sql, T parameters, string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

            return await connection.ExecuteAsync(sql, parameters);
        }
    }
}
