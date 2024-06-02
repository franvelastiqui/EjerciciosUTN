using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        private string nombre;
        private string especie;
        private DateTime fechaNacimiento;
        private Vacunas[] historialVacunacion;
        private int cantidadVacunas;
        private int contadorVacunas = 0;

        public Mascota(string nombre, string especie, int dia, int mes, int anio, int cantidadVacunas)
        {
            this.nombre = nombre;
            this.especie = especie;
            fechaNacimiento = new DateTime(anio, mes, dia);
            historialVacunacion = new Vacunas[cantidadVacunas];
        }

        public void Vacunar(Vacunas vacuna)
        {
            historialVacunacion[contadorVacunas] = vacuna;
            contadorVacunas++;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(nombre);
            sb.AppendLine(especie);
            sb.AppendLine($"Fecha de nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");

            if (historialVacunacion == null)
            {
                sb.AppendLine("No tiene vacunas");
            }
            else
            {
                sb.AppendLine("Vacunas: ");
                foreach (Vacunas vacuna in historialVacunacion)
                {
                    sb.AppendLine($"{vacuna}");
                }
            }
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
