using System;
using Npgsql;

namespace GymYang
{
    internal class Conexion
    {
        // Método para obtener una conexión de base de datos
        public static NpgsqlConnection GetConnection()
        {
            string servidor = "localhost";
            string bd = "GymYang";
            string usuario = "postgres";
            string pass = "1234";

            string cadenaConexion = $"Host={servidor};Database={bd};Username={usuario};Password={pass}";

            NpgsqlConnection conexionBD = new NpgsqlConnection(cadenaConexion);

            try
            {
                // Intentamos abrir la conexión en este método
                conexionBD.Open();
                return conexionBD;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de conexión");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error");
                return null;
            }
        }
    }
}
