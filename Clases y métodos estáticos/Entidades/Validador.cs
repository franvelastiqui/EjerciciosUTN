using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (min <= valor && valor <= max)
            {
                return true;
            }
            return false;
        }

        public static bool ValidarRespuesta(string respuesta)
        {
            if(respuesta.ToLower() == "s")
            {
                return true;
            }

            return false;
        }
    }
}
