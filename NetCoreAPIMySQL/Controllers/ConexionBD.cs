using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Controllers
{
    public class ConexionBD
    {
        public static double ConsultaEspesorPerfil(string id)
        {
            double espesor=0;
            string sql;
            MySqlDataReader reader = null;

            // Muestra el marco y nombre del marco para la SEs
            sql = "SELECT espesor FROM perfilcelosia WHERE idPerfilcelosia=" + id;
            MySqlConnection connectionDB = Conexion.conexion();
            connectionDB.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, connectionDB);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        espesor=reader.GetFloat(0);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron registros");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                connectionDB.Close();
            }
            return espesor;
        }
    }
}
