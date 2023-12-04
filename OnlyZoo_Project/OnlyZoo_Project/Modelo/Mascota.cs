using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo_Project.Modelo
{
    internal class Mascota
    {
        private int id {  get; set; }
        private string tipo { get; set; }

        private string raza { get; set;}

        private string descripcion { get; set; }

        private string alimentacion { get; set; }

        private int disponibilidad { get; set; }

        public Mascota(int id, string tipo, string raza, string descripcion, string alimentacion, int disponibilidad)
        {
            this.id = id;
            this.tipo = tipo;
            this.raza = raza;
            this.descripcion = descripcion;
            this.alimentacion = alimentacion;
            this.disponibilidad = disponibilidad;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
