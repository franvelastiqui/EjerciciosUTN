using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        protected int dni;
        protected string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public Persona(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"DNI: {dni}");

            return sb.ToString();
        }
    }
}
