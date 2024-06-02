using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(int dni, string nombre) : base(dni, nombre)
        {
            fechaNacimiento = DateTime.Now;
        }
        public DirectorTecnico(string nombre, int dni, DateTime fechaNacimiento) : this(dni, nombre)
        {
            this.fechaNacimiento=fechaNacimiento;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Director Técnico {nombre}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Fecha de nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");

            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return (dt1.nombre == dt2.nombre) && (dt1.fechaNacimiento == dt2.fechaNacimiento);
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }

    }
}
