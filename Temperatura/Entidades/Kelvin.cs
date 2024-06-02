using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Kelvin
    {
        private double temperatura;

        private Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        {
            return temperatura;
        }

        public static implicit operator Kelvin(double temperatura)
        {
            return new Kelvin(temperatura);
        }

        public static explicit operator Kelvin(Celsius c)
        {
            Kelvin k = default;

            if(c is not null)
            {
                k = c.GetTemperatura() + 273.15;
            }

            return k;
        }
        public static explicit operator Kelvin(Fahrenheit f)
        {
            Kelvin k = default;

            if (f is not null)
            {
                k = (f.GetTemperatura() + 459.67) * 5 / 9;
            }

            return k;
        }
    }
}
