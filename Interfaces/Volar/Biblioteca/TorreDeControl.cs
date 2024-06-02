using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class TorreDeControl
    {
        protected List<IVolador> voladores;

        public TorreDeControl()
        {
            voladores = new List<IVolador>();
        }

        public List<IVolador> Voladores { get => voladores; }

        public string VuelenTodos()
        {
            StringBuilder sb = new StringBuilder();

            if(voladores.Count > 0)
            {
                foreach(IVolador item in voladores)
                {
                    sb.AppendLine(item.Volador());
                    sb.AppendLine("------------------");
                }
            }

            return sb.ToString();
        }

        public bool AgregarVolador(IVolador item)
        {
            if(item is not null)
            {
                voladores.Add(item);
                return true;
            }
            return false;
        }
    }
}
