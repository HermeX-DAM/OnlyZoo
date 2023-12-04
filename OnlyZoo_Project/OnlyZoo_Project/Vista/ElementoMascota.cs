using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyZoo_Project.VistaElementoMascota
{
    public partial class UCElementoMascota : UserControl
    {
        public string codigo { get; set; }
        public UCElementoMascota()
        {
            InitializeComponent();
        }

        public UCElementoMascota(String nombre, String tipo, Image imagen, String codigo)
        {
            lblNombre.Text = nombre;
            lblTipo.Text = tipo;
            imgMascota.Image = imagen;
            this.codigo = codigo;
        }
    }
}
