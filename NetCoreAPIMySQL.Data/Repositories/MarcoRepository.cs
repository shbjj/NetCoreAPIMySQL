using Dapper;
using MySql.Data.MySqlClient;
using NetCoreAPIMySQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Data.Repositories
{
    public class MarcoRepository : IMarcoRepository
    {
        private MySQLConfiguration _connectionString;
        public MarcoRepository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }
        public async Task<IEnumerable<Marco>> GetAllMarcos()
        {
            var db = dbConnection();
            var sql = @"select * 
                        from marco";
            return await db.QueryAsync<Marco>(sql, new { });
        }

        public async Task<Marco> GetMarcoDetails(int id)
        {
            var db = dbConnection();
            var sql = @"select * 
                        from marco 
                        where idMarco=@Id";
            return await db.QueryFirstOrDefaultAsync<Marco>(sql, new { Id = id });
        }

    }
}
