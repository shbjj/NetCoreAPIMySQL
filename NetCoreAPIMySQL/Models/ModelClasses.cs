using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Models
{
    public class Datos
    {
        //Variables que vendran del usuario
        public string Nombre_tor {get; set;}
        public string Gpo {get; set;}
        public string Rosca { get; set; }
        public double Fza_T {get; set;}
        public double Fza_C { get; set; }
        public double Fu  {get; set;}
        public double Fy  {get; set;}
        public string Conexion { get; set; }
        public ICollection<Perfil> Perfiles { get; set; }
        /*public int dato1 { get; set; }
        public int dato2 { get; set; }
        public ICollection<Ids> ids { get; set; }*/
    }

    public class Perfil
    {
        public string Nombre { get; set; }
        public double Nbv { get; set; }
        public double T_Perfil { get; set; }
        public double B_Perfil { get; set; }
    }

    public class DatosViewModel
    {
        public Datos datosIniciales { get; set; }
        public Perfil[] perfiles { get; set; }

    }
}
