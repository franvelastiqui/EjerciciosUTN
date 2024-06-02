using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
            cilindrada = 0;
        }
        public MotoCross(short numero, string escuderia, short cilindrada) : base(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada { get => cilindrada; set => cilindrada = value; }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"Cilindrada: {cilindrada}");

            return sb.ToString();
        }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return (a1 == a2) && (a1.cilindrada == a2.cilindrada);
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
