using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo_Project.Conexion
{
    internal class ConexionBBDD
    {
        public readonly string cadenaConexion;
        public MySqlConnection conexion;

        public ConexionBBDD(string servidor, string baseDatos, string usuario, string contraseña)
        {
            cadenaConexion = $"Server={servidor};Database={baseDatos};User ID={usuario};Password={contraseña};";
        }

        public void AbrirConexion()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                Console.WriteLine("Conexión abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    Console.WriteLine("Conexión cerrada");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cerrar la conexión: {ex.Message}");
            }
        }

    }
}