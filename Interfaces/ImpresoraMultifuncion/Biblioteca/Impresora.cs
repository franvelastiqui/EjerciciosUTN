using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Impresora
    {
        protected List<IImprimible> colaDelmpresion;

        public Impresora()
        {
            colaDelmpresion = new List<IImprimible>();
        }

        public string ImprimirTodo()
        {
            StringBuilder sb = new StringBuilder();
            if(colaDelmpresion.Count > 0)
            {
                foreach(IImprimible item in colaDelmpresion)
                {
                    sb.AppendLine(item.Imprimir());
                    sb.AppendLine("----------------------------------");
                }
            }

            return sb.ToString();
        }

        public bool AgregarImprimible(IImprimible item)
        {
            if(item is not null)
            {
                colaDelmpresion.Add(item);
                return true;
            }
            return false;
        }
    }
}
