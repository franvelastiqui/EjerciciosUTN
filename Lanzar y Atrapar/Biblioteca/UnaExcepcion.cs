using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(Exception e) : base(e.Message, e)
        {
        }
        public UnaExcepcion(string mensaje, Exception e) : base(mensaje, e)
        {
        }
    }
}
