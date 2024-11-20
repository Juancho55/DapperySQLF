using DapperBD.Interface;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace DapperBD
{
    public class DapperConectionContext : IDapperConectionContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _database;

        public DapperConectionContext(IConfiguration configuration, string database)
        {
            _configuration = configuration;
            _database = database;
        }

        public IDbConnection GetSqlCnn()
        {
            return new SqlConnection(_configuration.GetConnectionString(_database));
        }
    }
}
