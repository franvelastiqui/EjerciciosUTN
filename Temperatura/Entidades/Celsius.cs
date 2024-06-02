using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celsius
    {
        private double temperatura;

        private Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        {
            return temperatura;
        }

        public static implicit operator Celsius(double temperatura)
        {
            return new Celsius(temperatura);
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            Celsius c = default;

            if(f is not null)
            {
                c = (f.GetTemperatura() - 32) * ((double)5 / 9);
            }

            return c;
        }
        public static explicit operator Celsius(Kelvin k)
        {
            Celsius c = default;

            if (k is not null)
            {
                c = k.GetTemperatura() - 273.15;
            }

            return c;
        }
    }
}
