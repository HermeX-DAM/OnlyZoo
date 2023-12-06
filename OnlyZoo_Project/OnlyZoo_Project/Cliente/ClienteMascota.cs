using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using OnlyZoo_Project.Data;
using OnlyZoo_Project.Utils;
using OnlyZoo_Project.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo_Project.Cliente
{
    public class ClienteMascota : IData<Mascota>
    {
        private static ClienteMascota instance;

        private ClienteMascota() { 
        
        }
        public static ClienteMascota Instance
        {
            get
            {
                instance ??= new ClienteMascota();
                return instance;
            }
        }
        public List<Mascota> GetAll()
        {
            List<Mascota>listaMascotas = new List<Mascota>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.ConnectionString = Constantes.CONEXION_STRING;
                    conn.Open();
                    MySqlCommand comando = conn.CreateCommand();
                    comando.CommandText = $"SELECT * FROM {Constantes.NOMBRE_TABLA_MASCOTA}";

                    MySqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        Mascota mascota = new Mascota
                        {
                            Id = lector.GetInt32(0),
                            Tipo = lector.GetString(1),
                            Raza = lector.GetString(2),
                            Descripcion = lector.GetString(3),
                            Alimentacion = lector.GetString(4),
                            Disponibilidad = lector.GetInt16(5),
                        };
                        listaMascotas.Add(mascota);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaMascotas;
        }
    }
}
