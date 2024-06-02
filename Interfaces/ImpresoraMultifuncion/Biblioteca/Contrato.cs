using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Contrato : IImprimible
    {
        protected string texto;
        public Contrato()
        {
            texto = "";
        }

        public string Texto { get { return texto; } }

        public string Imprimir()
        {
            return "Soy un contrato muy legal";
        }
    }
}
