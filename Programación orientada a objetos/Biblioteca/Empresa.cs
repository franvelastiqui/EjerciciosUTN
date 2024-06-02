using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public  class Empresa
    {
        private string nombre;
        private Conductor[] conductores;
        static int contadorConductores = 0;

        public Empresa(string nombre, int cantidadConductores)
        {
            this.nombre = nombre;
            conductores = new Conductor[cantidadConductores];
        }

        public void SetConductor(Conductor conductor)
        {
            if (contadorConductores < conductores.Length)
            {
                conductores[contadorConductores] = conductor;
                contadorConductores++;
            }
        }

        public string GetConductorMasKm()
        {
            Conductor conductorMasKm = default;
            int kmRecorridos = 0;
            int kmMayor = 0;
            string retorno;

            foreach (Conductor conductor in conductores)
            {
                for (int i = 0; i < 7; i++)
                {
                    kmRecorridos += conductor.GetKmPorDia(i);
                }

                if (kmMayor <= kmRecorridos)
                {
                    kmMayor = kmRecorridos;
                    conductorMasKm = conductor;
                }

                kmRecorridos = 0;
            }

            retorno = $"El conductor con mas km es {conductorMasKm.GetNombre()} con {kmMayor} km.";

            return retorno;
        }

        public string GetConductorMasKmEnDia(int dia)
        {
            Conductor conductorMasKm = default;
            int kmRecorridos = 0;
            int kmMayor = 0;

            foreach (Conductor conductor in conductores)
            {
                kmRecorridos += conductor.GetKmPorDia(dia);

                if (kmMayor <= kmRecorridos)
                {
                    kmMayor = kmRecorridos;
                    conductorMasKm = conductor;
                }

                kmRecorridos = 0;
            }

            string retorno = $"El conductor con mas km en el día {dia} es {conductorMasKm.GetNombre()} con {kmMayor} km.";

            return retorno;
        }
    }
}
