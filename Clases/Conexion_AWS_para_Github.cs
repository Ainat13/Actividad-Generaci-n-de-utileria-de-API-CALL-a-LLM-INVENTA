using MySql.Data.MySqlClient; //Para trabajar con MySQL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generacion_de_utileria
{
    internal class Conexion_AWS //Clase creada para la conexión con AWS
    {
        private readonly string cadena_conexion = //cadena con los datos de conexión de la BD
            "Server Escribe aquí la liga de la base de datos = " +
            "Port = Escribe aquí el puesto de conexión con la base de datos;" +
            "Database = Escribe aquí el nombre de la base de datos;" +
            "Uid = Escribe aquí el nombre del usuario de la base de datos;" +
            "Pwd = Escribe aquí la contraseña de la base de datos;" +
            "SslMode = Required;";


        //Establecer conexión con la base de datos
        public MySqlConnection Obtener_Conexion()
        {
            return new MySqlConnection(cadena_conexion); //crea la conexión con los datos de la cadena
        }

        //Se prueba la conexión con la BD
        public bool probar_conexion()
        {
            try
            {
                using (MySqlConnection conexion = Obtener_Conexion())
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (MySqlException)
            {
                return false;

            }

        }
    }


}
