using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class GestionImpuestos
    {
        protected List<IAduana> impuestosAduana;
        protected List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            impuestosAduana = new List<IAduana>();
            impuestosAfip = new List<IAfip>();
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            if(paquete is not null)
            {
                impuestosAduana.Add(paquete);

                if(paquete is IAfip)
                {
                    IAfip paqueteAfip = (IAfip)paquete;
                    impuestosAfip.Add(paqueteAfip);
                }
            }
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            if(paquetes is not null)
            {
                foreach(Paquete p in paquetes)
                {
                    RegistrarImpuestos(p);
                }
            }
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal total = 0;

            if (impuestosAduana is not null)
            {
                foreach (Paquete item in impuestosAduana)
                {
                    total += item.Impuestos;
                }
            }

            return total;
        }
        public decimal CalcularTotalImpuestosAfip()
        {
            decimal total = 0;

            if (impuestosAfip is not null)
            {
                foreach (Paquete item in impuestosAfip)
                {
                    total += ((IAfip)item).Impuestos;
                }
            }

            return total;
        }
    }
}
