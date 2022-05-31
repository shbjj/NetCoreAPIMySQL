using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Model.Tornilleria
{
    public class ElementosTornilleria
    {
        public double Fy { get; set; }
        public double Fu { get; set; }
        public double Ubs { get; set; }
        public ElementoTornilleria[] ElementoTornillerias {get; set;}
    }
}
