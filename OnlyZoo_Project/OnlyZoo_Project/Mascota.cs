using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo_Project
{
    internal class Mascota
    {

        public int Id { get; set; }
        public string tipo {  get; set; }

        public  string raza { get; set; }

        public string descripcion { get; set; }

        public string alimentacion { get; set; }

        public int disponibilidad { get; set; }

        public Mascota(int id, string tipo, string raza, string descripcion, string alimentacion, int disponibilidad)
        {
            Id = id;
            this.tipo = tipo;
            this.raza = raza;
            this.descripcion = descripcion;
            this.alimentacion = alimentacion;
            this.disponibilidad = disponibilidad;
        }

        public string toString()
        {
            return Id + tipo + raza + descripcion + alimentacion + disponibilidad;
        }

        public override bool Equals(object? obj)
        {
            return obj is Mascota mascota &&
                   Id == mascota.Id &&
                   tipo == mascota.tipo &&
                   raza == mascota.raza &&
                   descripcion == mascota.descripcion &&
                   alimentacion == mascota.alimentacion &&
                   disponibilidad == mascota.disponibilidad;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, tipo, raza, descripcion, alimentacion, disponibilidad);
        }
    }
}
