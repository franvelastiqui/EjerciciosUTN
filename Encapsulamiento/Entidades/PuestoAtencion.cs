using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(3000);
            return true;
        }
    }
}
