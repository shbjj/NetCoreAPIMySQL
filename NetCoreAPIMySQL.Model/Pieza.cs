using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Model
{
    public class Pieza
    {
        public int idPieza { get; set; }
        public int idMarco { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string eje { get; set; }
        public string tipoLlegadas { get; set; }
        public int numero { get; set; }
        public int tipoElemento { get; set; }
    }
}
