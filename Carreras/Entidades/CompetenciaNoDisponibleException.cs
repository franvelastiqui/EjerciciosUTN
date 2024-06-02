using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CompetenciaNoDisponibleException : Exception
    {
        string nombreClase;
        string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
        {
        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {
            nombreClase = clase;
            nombreMetodo = metodo;
        }

        public string NombreClase { get => nombreClase; }
        public string NombreMetodo { get => nombreMetodo; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Excepción en el método {nombreMetodo} de la clase {nombreClase}:");
            sb.AppendLine(base.Message);
            if(base.InnerException != null)
            {
                Exception e = base.InnerException;

                while(e is not null)
                {
                    sb.AppendLine(base.InnerException.Message);
                    e = e.InnerException;
                }
            }

            return sb.ToString();
        }
    }
}
