using MySql.Data.MySqlClient;
using OnlyZoo_Project.Cliente;
using OnlyZoo_Project.Conexion;
using OnlyZoo_Project.Modelo;
using OnlyZoo_Project.Utils;
using OnlyZoo_Project.VistaElementoMascota;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyZoo_Project.Controladores
{
    public class Controlador
    {
        public Vista_Mascotas Vista_Mascotas { get; set; }
        public Controlador(Vista_Mascotas vista_Mascotas)
        {
            Vista_Mascotas = vista_Mascotas;
            MostrarMascota();
        }
        public void MostrarMascota()
        {
            List<Mascota> listaMascotas = ClienteMascota.Instance.GetAll();
            foreach (Mascota mascota in listaMascotas)
            {
                Image imagen = Image.FromFile(Path.Combine(Constantes.CARPETA_IMAGENES, mascota.Id.ToString()+".jpg"));
                Vista_Mascotas.flpCatalogoMascotas.Controls.Add(new UCElementoMascota(mascota, imagen));
            }
        }
    }
}





