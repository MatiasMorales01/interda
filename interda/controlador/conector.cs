using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace interda.controlador
{
    public class conector
    {
        static string servidor = "localhost";
        static string db = "cgato";
        static string user = "root";
        static string pass = "root";
        static string cadenaConexion = $"Server={servidor};Database={db};User ID={user};Password={pass};";

        public MySqlConnection crear_conexion()
        {
            MySqlConnection conexion = null;

            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                //MessageBox.Show("Se conectó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar. Error: " + ex.Message);
            }

            return conexion;
        }
        public DataTable obtenerDatos(string tabla)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conexion = crear_conexion())
            {
                try
                {
                    string query = "SELECT * FROM " + tabla;
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos: " + ex.Message);
                }
            }

            return dataTable;
        }
        public bool ejecutarConsulta(string query)
        {
            try
            {
                using (MySqlConnection conexion = crear_conexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.ExecuteNonQuery();
                        // MessageBox.Show("Consulta ejecutada correctamente");
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return false;
            }
        }
    }
}
