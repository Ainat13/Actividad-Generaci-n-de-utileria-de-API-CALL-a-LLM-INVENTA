using Generacion_de_utileria;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

internal class Consulta_BD
{
    //Consulta de los productos en la base de datos
    public DataTable consultar_productos()
    {
        DataTable tabla = new DataTable(); //tabla para almacenar los resultados

        //Conexión con la base de datos en AWS
        using (MySqlConnection conexion =
               new Conexion_AWS().Obtener_Conexion())
        {
            conexion.Open();

            //consulta en SQL para obtener información de la tabla de productos
            string sql = @"
                SELECT ID, Descripcion
                FROM CatProducto;";

            using (MySqlCommand comando =
                   new MySqlCommand(sql, conexion))
            {
                using (MySqlDataAdapter adaptador =
                       new MySqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }
        }

        return tabla;
    }

    //Consulta del personal en la base de datos
    public DataTable consultar_personal()
    {
        DataTable tabla = new DataTable(); //tabla para almacenar los datos de la tabla personal

        using (MySqlConnection conexion =
               new Conexion_AWS().Obtener_Conexion())
        {
            conexion.Open();

            //consulta en SQL para obtener información de la tabla de personal
            string sql = @"
                SELECT ID, Nombre, Cargo
                FROM CatPersonal;";

            using (MySqlCommand comando =
                   new MySqlCommand(sql, conexion))
            {
                using (MySqlDataAdapter adaptador =
                       new MySqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }
        }

        return tabla;
    }

    //Consulta del inventario en la base de datos

    public DataTable consultar_inventario()
    {
        DataTable tabla = new DataTable(); //tabla para almacenar los datos del inventario

        using (MySqlConnection conexion =
               new Conexion_AWS().Obtener_Conexion())
        {
            conexion.Open();

            //consulta en SQL para obtener información de la tabla de inventario
            string sql = @"
                SELECT *
                FROM tblInventario;";

            using (MySqlCommand comando =
                   new MySqlCommand(sql, conexion))
            {
                using (MySqlDataAdapter adaptador =
                       new MySqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }
        }

        return tabla;
    }

    //obtener la cantidad total de productos 
    //prueba para saber si funciona la conexión de la base de datos
    public int Contar_productos()
    {
        using (var conexion = new Conexion_AWS().Obtener_Conexion())
        {
            conexion.Open();

            string consulta = "SELECT COUNT(*) FROM CatProducto";

            using (var comando = new MySqlCommand(consulta, conexion))
            {
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }
    }

    //Obtener información de la base de datos para proporcionarla a Gemini
    public string Obtener_contexto_inventario()
    {
        StringBuilder datos = new StringBuilder();

        using (var conexion = new Conexion_AWS().Obtener_Conexion())
        {
            conexion.Open();

            // Contar productos
            string consultaProductos =
                "SELECT COUNT(*) FROM CatProducto";

            using (var comando = new MySqlCommand(
                consultaProductos, conexion))
            {
                int total = Convert.ToInt32(comando.ExecuteScalar());
                datos.AppendLine("TOTAL DE PRODUCTOS: " + total);
            }

            // Contar empleados
            string consultaPersonal =
                "SELECT COUNT(*) FROM CatPersonal";

            using (var comando = new MySqlCommand(
                consultaPersonal, conexion))
            {
                int total = Convert.ToInt32(comando.ExecuteScalar());
                datos.AppendLine("TOTAL DE EMPLEADOS: " + total);
            }

            // Obtener productos y existencias
            string consultaInventario = @"
            SELECT
                p.ID,
                p.Descripcion,
                COALESCE(SUM(i.Cantidad), 0) AS Existencias,
                GROUP_CONCAT(DISTINCT pe.Nombre SEPARATOR ', ') AS Responsables
            FROM CatProducto p
            LEFT JOIN tblInventario i ON p.ID = i.IDProducto
            LEFT JOIN CatPersonal pe ON i.IDPersonal = pe.ID
            GROUP BY p.ID, p.Descripcion
            ORDER BY p.ID;
        ";

            datos.AppendLine("\nPRODUCTOS Y EXISTENCIAS:");

            using (var comando = new MySqlCommand(
                consultaInventario, conexion))
            using (var lector = comando.ExecuteReader())
            {
                while (lector.Read())
                {
                    string responsables = lector.IsDBNull(3)
                        ? "Sin responsable asignado"
                        : lector.GetString(3);

                    datos.AppendLine(
                        "Producto: " + lector["Descripcion"] +
                        " | Existencias: " + lector["Existencias"] +
                        " | Responsables: " + responsables
                    );
                }
            }

            // 4. Obtener empleados y sus asignaciones
            string consultaEmpleados = @"
            SELECT
                pe.ID,
                pe.Nombre,
                pe.Cargo,
                COALESCE(SUM(i.Cantidad), 0) AS UnidadesAsignadas
            FROM CatPersonal pe
            LEFT JOIN tblInventario i ON pe.ID = i.IDPersonal
            GROUP BY pe.ID, pe.Nombre, pe.Cargo
            ORDER BY pe.ID;
        ";

            datos.AppendLine("\nPERSONAL Y ASIGNACIONES:");

            using (var comando = new MySqlCommand(
                consultaEmpleados, conexion))
            using (var lector = comando.ExecuteReader())
            {
                while (lector.Read())
                {
                    datos.AppendLine(
                        "Empleado: " + lector["Nombre"] +
                        " | Cargo: " + lector["Cargo"] +
                        " | Unidades asignadas: " +
                        lector["UnidadesAsignadas"]
                    );
                }
            }
        }

        return datos.ToString();
    }

}