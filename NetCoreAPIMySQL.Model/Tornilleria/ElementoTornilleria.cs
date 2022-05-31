using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Model.Tornilleria
{
    public class ElementoTornilleria
    {
        public bool DatosCompletos { get; set; }
        public int Numero { get; set; }
        public Perfil Perfil { get; set; }
        public Tornillo Tornillo { get; set; }
        public Fuerzas Fuerzas { get; set; }
        public RevisionResistenciaCortante RevisionResistenciaCortante { get; set; }
        public RevisionAplastamiento RevisionAplastamiento { get; set; }
        public RevisionResistenciaDesgarre RevisionResistenciaDesgarre { get; set; }
        public RevisionResistenciaBloqueCortante RevisionResistenciaBloqueCortante { get; set; }
        public int NTot
        {
            get
            {   
                //Si los valores de los sig objetos no son nulos...
                if(RevisionResistenciaCortante != null && RevisionAplastamiento!= null && RevisionResistenciaDesgarre!=null && RevisionResistenciaBloqueCortante!=null)
                {
                    return Math.Max(RevisionResistenciaBloqueCortante.Nd, Math.Max(RevisionResistenciaDesgarre.Nd, Math.Max(RevisionResistenciaCortante.Nv, RevisionAplastamiento.Na))) ;
                }
                else//Si son nulos...   
                {
                    return 0;
                }
            }
        }

    }
}
