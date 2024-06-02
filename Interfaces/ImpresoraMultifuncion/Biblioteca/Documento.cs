using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Documento : IImprimible
    {
        protected string texto;
        public Documento()
        {
            texto = "";
        }
        public string Texto { get { return texto; } }

        public string Imprimir()
        {
            return "Soy un documento de word";
        }
    }
}
