using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre { get => nombre; }
        public DateTime FechaCreacion { get => fechaCreacion; }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.Nombre == e2.Nombre && e1.FechaCreacion == e2.FechaCreacion;
        }
        public virtual string Ficha()
        {
            return $"{nombre} fundado el {fechaCreacion.ToString("dd/MM/yyyy")}";
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
    }
}
