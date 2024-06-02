using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Foto : IImprimible
    {
        protected string texto;
        public Foto()
        {
            texto = "";
        }

        public string Texto { get { return texto; } }

        public string Imprimir()
        {
            return "Soy una selfie pal insta";
        }
    }
}
