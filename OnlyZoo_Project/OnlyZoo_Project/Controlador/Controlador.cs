using MySql.Data.MySqlClient;
using OnlyZoo_Project.Conexion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyZoo_Project.Controlador
{
    internal class Controlador
    {


    }


    public List<Mascota> MostrarMascotas()
    {
        List<Mascota> mascotas = new List<Mascota>();
        ConexionBBDD conexionBBDD = new ConexionBBDD("localhost", "tuBaseDeDatos", "tuUsuario", "tuContraseña");
        // Abre la conexión
        conexionBBDD.AbrirConexion();
        string query = "SELECT * FROM Mascotas";

        using (MySqlCommand command = new MySqlCommand(query, conexionBBDD.conexion))
        using (MySqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Mascota mascota = new Mascota()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nombre = Convert.ToString(reader["Nombre"]),
                    Raza = Convert.ToString(reader["Raza"]),
                    Edad = Convert.ToInt32(reader["Edad"]),
                    Dueño = Convert.ToString(reader["Dueño"]),
                    Vacunada = Convert.ToBoolean(reader["Vacunada"]),
                    Color = Convert.ToString(reader["Color"]),
                };
                reader.Close();
                mascotas.Add(mascota);
            }
        }
        conexionBBDD.CerrarConexion();
        return mascotas;
    }

      



}

    

            

