using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double Numero()
        {
            return numero;
        }

        public static double operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.Numero() + Conversor.ConvertirBinarioADecimal(nb.Numero());
        }
        public static double operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.Numero() - Conversor.ConvertirBinarioADecimal(nb.Numero());
        }
        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            return nb == nd;
        }
        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            return !(nd == nb);
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }
        public static explicit operator double(NumeroDecimal numero)
        {
            return numero.Numero();
        }
    }
}
