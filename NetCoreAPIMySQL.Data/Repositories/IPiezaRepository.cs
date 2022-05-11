using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoreAPIMySQL.Model;

namespace NetCoreAPIMySQL.Data.Repositories
{
    public interface IPiezaRepository
    {
        Task<IEnumerable<Pieza>> GetAllPiezas();
        /*Task<Pieza> GetPiezaDetails(int id);*/
        Task<IEnumerable<Pieza>> GetAllPiezasOfMarco(int id);
    }
}
