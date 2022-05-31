using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Controllers
{
    public class LeerCSV
    {
        public static Dictionary<string,Model.Tornilleria.Tornillo> LeerListaTornillos(String path)
        {
            //Variable contadora
            int cont = 0;


            //Guardar en una lista de Tornillos
            Dictionary<string, Model.Tornilleria.Tornillo> listA = new Dictionary<string, Model.Tornilleria.Tornillo>();

            //Obtener todo el texto del archivo CSV
            string csvData = System.IO.File.ReadAllText(path + "/csv/Tornillos.csv");

            //Recorrer la informacion, por cada renglon
            foreach (string row in csvData.Split("\n"))
            {
                //Si el renglon no esta vacio
                if (!string.IsNullOrEmpty(row))
                {
                    if (cont > 1)
                    {
                        listA.Add(row.Split(",")[0], 
                            new Model.Tornilleria.Tornillo(row.Split(",")[0], 
                            Convert.ToDouble(row.Split(",")[1]), 
                            Convert.ToDouble(row.Split(",")[2])));
                    }
                }

                //Aumentar contador
                cont++;
            }
            return listA;
        }
    }
}
