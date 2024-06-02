using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(Exception e) : base(e.Message, e)
        {
        }
        public MiExcepcion(string mensaje, Exception e) : base(mensaje, e)
        {
        }
    }
}
