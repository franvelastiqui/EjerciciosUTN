using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return ((float)notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            }

            return -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{apellido}, {nombre}. Legajo {legajo}");
            sb.AppendLine($"Nota primer parcial: {notaPrimerParcial}");
            sb.AppendLine($"Nota segundo parcial: {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");

            if (CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"{CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }

            return sb.ToString();
        }
    }
}
