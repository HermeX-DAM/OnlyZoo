using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo_Project.Modelo
{
    public class Mascota
    {
        public int Id {  get; set; }
        public string Tipo { get; set; }
        public string Raza { get; set;}
        public string Descripcion { get; set; }
        public string Alimentacion { get; set; }
        public int Disponibilidad { get; set; }
        public Mascota()
        {

        }
        public Mascota(int id, string tipo, string raza, string descripcion, string alimentacion, int disponibilidad)
        {
            this.Id = id;
            this.Tipo = tipo;
            this.Raza = raza;
            this.Descripcion = descripcion;
            this.Alimentacion = alimentacion;
            this.Disponibilidad = disponibilidad;
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
