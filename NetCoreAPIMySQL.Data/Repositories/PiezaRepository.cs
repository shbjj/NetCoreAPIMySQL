using Dapper;
using NetCoreAPIMySQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace NetCoreAPIMySQL.Data.Repositories
{
    public class PiezaRepository : IPiezaRepository
    {
        private MySQLConfiguration _connectionString;
        public PiezaRepository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }
        public async Task<IEnumerable<Pieza>> GetAllPiezas()
        {
            var db = dbConnection();
            var sql = @"select * 
                        from pieza";
            return await db.QueryAsync<Pieza>(sql, new { });
        }
       /* public async Task<Pieza> GetPiezaDetails(int id)
        {
            var db = dbConnection();
            var sql = @"select * 
                        from pieza 
                        where idPieza=@Id";
            return await db.QueryFirstOrDefaultAsync<Pieza>(sql, new { Id = id });
        }*/

        public async Task<IEnumerable<Pieza>> GetAllPiezasOfMarco(int id)
        {
            var db = dbConnection();
            var sql = @"select * 
                        from pieza 
                        where idMarco =@Id";
            return await db.QueryAsync<Pieza>(sql, new { Id = id });
        }
    }
}
