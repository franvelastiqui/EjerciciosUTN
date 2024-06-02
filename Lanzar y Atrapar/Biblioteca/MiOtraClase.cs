using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MiOtraClase
    {
        public void MiMetodo()
        {
            try
            {
                MiClase clase = new MiClase();
            }
            catch(Exception ex)
            {
                throw new MiExcepcion(ex);
            }
        }
    }
}
