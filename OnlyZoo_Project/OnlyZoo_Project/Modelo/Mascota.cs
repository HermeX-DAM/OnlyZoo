using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo_Project
{
    internal class Mascota
    {
        public Mascota()
        {

        }
        public Mascota(int id, string nombre, string raza, int edad, string dueño, bool vacunada, string color)
        {
            Id = id;
            Nombre = nombre;
            Raza = raza;
            Edad = edad;
            Dueño = dueño;
            Vacunada = vacunada;
            Color = color;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Dueño { get; set; }
        public bool Vacunada { get; set; }
        public string Color { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Mascota mascota &&
                   Id == mascota.Id &&
                   Nombre == mascota.Nombre &&
                   Raza == mascota.Raza &&
                   Edad == mascota.Edad &&
                   Dueño == mascota.Dueño &&
                   Vacunada == mascota.Vacunada &&
                   Color == mascota.Color;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nombre, Raza, Edad, Dueño, Vacunada, Color);
        }
    }
}