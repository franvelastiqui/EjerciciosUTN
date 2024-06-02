using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoDeCarrera
    {
        protected short cantidadCombustible;
        protected bool enCompetencia;
        protected string escuderia;
        protected short numero;
        protected short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            cantidadCombustible = 0;
            enCompetencia = false;
            this.escuderia = escuderia;
            this.numero = numero;
            vueltasRestantes = 0;
        }

        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public string Escuderia { get => escuderia; set => escuderia = value; }
        public short Numero { get => numero; set => numero = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{escuderia}. Número {numero}.");

            if (enCompetencia)
            {
                sb.AppendLine($"Vueltas Restantes: {vueltasRestantes}.");
                sb.AppendLine($"Combustible: {cantidadCombustible}.");
            }
            else
            {
                sb.AppendLine("No está en competencia.");
            }

            return sb.ToString();
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return (v1.escuderia == v2.escuderia) && (v1.numero == v2.numero);
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}
