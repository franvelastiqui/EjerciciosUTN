using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        public Persona(string nombre, int diaNacimiento, int mesNacimiento, int anioNacimiento, string dni)
        {
            this.nombre = nombre;
            fechaDeNacimiento = new DateTime(anioNacimiento, mesNacimiento, diaNacimiento);
            this.dni = dni;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public string GetFechaDeNacimiento()
        {
            return fechaDeNacimiento.ToString("dd/MM/yyyy");
        }
        public string GetDNI()
        {
            return dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetFechaDeNacimiento(int diaNacimiento, int mesNacimiento, int anioNacimiento)
        {
            fechaDeNacimiento = new DateTime(anioNacimiento, mesNacimiento, diaNacimiento);
        }
        public void SetDNI(string dni)
        {
            this.dni = dni;
        }

        private int CalcularEdad()
        {
            int anios;

            anios = DateTime.Now.Year - fechaDeNacimiento.Year;

            if(DateTime.Now.Month < fechaDeNacimiento.Month)
            {
                anios --;
            }
            else if(DateTime.Now.Month == fechaDeNacimiento.Month && DateTime.Now.Day < fechaDeNacimiento.Day)
            {
                anios --;
            }

            return anios;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Fecha de nacimiento: {fechaDeNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Edad: {CalcularEdad()}");

            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            if(CalcularEdad() < 18)
            {
                return "Es menor de edad";
            }

            return "Es mayor de edad";
        }
    }
}
