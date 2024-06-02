using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class CentralitaException : Exception
    {
        private string nombreClass;
        private string nombreMetodo;

        public CentralitaException(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
        {
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {
            nombreClass = clase;
            nombreMetodo = metodo;
        }

        protected string NombreClass { get => nombreClass; }
        protected string NombreMetodo { get => nombreMetodo; }
    }
}
