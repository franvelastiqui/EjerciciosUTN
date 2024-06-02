using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string Numero()
        {
            return numero;
        }

        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            if(nb != null && nd != null)
            {
                double numero;
                numero = Conversor.ConvertirBinarioADecimal(nb.Numero()) + nd.Numero();

                return Conversor.ConvertirDecimalABinario(numero);
            }
            return "Error";
        }
        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            if (nb != null && nd != null)
            {
                double numero;
                numero = Conversor.ConvertirBinarioADecimal(nb.Numero()) - nd.Numero();

                return Conversor.ConvertirDecimalABinario(numero);
            }
            return "Error";
        }
        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            return Conversor.ConvertirBinarioADecimal(nb.Numero()) == nd.Numero();
        }
        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb == nd);
        }

        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }
        public static explicit operator string(NumeroBinario numero)
        {
            return numero.Numero();
        }
    }
}
