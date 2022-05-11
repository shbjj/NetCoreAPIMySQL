using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoreAPIMySQL.Model;

namespace NetCoreAPIMySQL.Data.Repositories
{
    public interface IMarcoRepository
    {
        Task<IEnumerable<Marco>> GetAllMarcos();
        Task<Marco> GetMarcoDetails(int id);
    }
}
