using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boing747 : IVolador
{
        private int horasVuelo;

        public Boing747()
        {
            horasVuelo = 0;
        }

        public int HorasVuelo { get => horasVuelo; }

        public string Volador()
        {
            horasVuelo += 13;
            return "Estoy volando como un avión";
        }
    }
}
