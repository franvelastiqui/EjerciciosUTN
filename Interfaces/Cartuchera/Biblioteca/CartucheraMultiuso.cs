using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CartucheraMultiuso
    {
        private List<IAcciones> lista;

        public CartucheraMultiuso()
        {
            lista = new List<IAcciones>();
        }

        public List<IAcciones> Lista { get => lista; }

        public bool RecorrerElementos()
        {
            bool noCargoTodos = false;

            if(lista is not null)
            {
                foreach (IAcciones item in lista)
                {
                    if(item.UnidadesDeEscritura > 0)
                    {
                        item.UnidadesDeEscritura -= 1;
                    }
                    else
                    {
                        noCargoTodos = true;
                    }

                    if(item.UnidadesDeEscritura < 0)
                    {
                        item.UnidadesDeEscritura += 20;
                    }
                }
            }
            else
            {
                noCargoTodos = true;
            }

            if(noCargoTodos)
            {
                return false;
            }
            return true;
        }
    }
}
