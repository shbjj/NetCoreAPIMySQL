using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Model.Tornilleria
{
    public class Perfil
    {
        public string NombrePerfil { get; set; }//Recibir desde la Interfaz
        public double Espesor { get; set; }//Recibir desde la Interfaz
        public double Dimension { get; set; }//Recibir desde la Interfaz
        public int Gramil
        {
            get
            {
                Dictionary<string, int> gramil = new Dictionary<string, int>();
                gramil.Add("L15152.5", 20);
                gramil.Add("L17172.5", 25);
                gramil.Add("L15153", 20);
                gramil.Add("L20202.5", 30);
                gramil.Add("L17173", 25);
                gramil.Add("L20203", 30);
                gramil.Add("L25252.5", 35);
                gramil.Add("L25253", 35);
                gramil.Add("L20204", 30);
                gramil.Add("L30303", 45);
                gramil.Add("L25254", 35);
                gramil.Add("L30304", 45);
                gramil.Add("L35354", 50);
                gramil.Add("L25256", 35);
                gramil.Add("L30305", 45);
                gramil.Add("L40404", 60);
                gramil.Add("L35355", 50);
                gramil.Add("L30306", 45);
                gramil.Add("L40405", 60);
                gramil.Add("L30308", 45);
                gramil.Add("L40406", 60);
                gramil.Add("L50505", 70);
                gramil.Add("L40407", 60);
                gramil.Add("L50506", 70);
                gramil.Add("L40408", 60);
                gramil.Add("L50507", 70);
                gramil.Add("L60606", 90);
                gramil.Add("L404010", 60);
                gramil.Add("L50508", 70);
                gramil.Add("L60607", 90);
                gramil.Add("L60608", 90);
                gramil.Add("L606010", 90);
                gramil.Add("L606012", 90);
                gramil.Add("L808012", 120);
                gramil.Add("L808014", 120);
                gramil.Add("LA15152.5", 20);
                gramil.Add("LA17172.5", 25);
                gramil.Add("LA15153", 20);
                gramil.Add("LA20202.5", 30);
                gramil.Add("LA17173", 25);
                gramil.Add("LA20203", 30);
                gramil.Add("LA25252.5", 35);
                gramil.Add("LA25253", 35);
                gramil.Add("LA20204", 30);
                gramil.Add("LA30303", 45);
                gramil.Add("LA25254", 35);
                gramil.Add("LA30304", 45);
                gramil.Add("LA35354", 50);
                gramil.Add("LA25256", 35);
                gramil.Add("LA30305", 45);
                gramil.Add("LA40404", 60);
                gramil.Add("LA35355", 50);
                gramil.Add("LA30306", 45);
                gramil.Add("LA40405", 60);
                gramil.Add("LA30308", 45);
                gramil.Add("LA40406", 60);
                gramil.Add("LA50505", 70);
                gramil.Add("LA40407", 60);
                gramil.Add("LA50506", 70);
                gramil.Add("LA40408", 60);
                gramil.Add("LA50507", 70);
                gramil.Add("LA60606", 90);
                gramil.Add("LA404010", 60);
                gramil.Add("LA50508", 70);
                gramil.Add("LA60607", 90);
                gramil.Add("LA60608", 90);
                gramil.Add("LA606010", 90);
                gramil.Add("LA606012", 90);
                gramil.Add("LA808012", 120);
                gramil.Add("LA808014", 120);

                return gramil[NombrePerfil];
            }
        }
    }
}
