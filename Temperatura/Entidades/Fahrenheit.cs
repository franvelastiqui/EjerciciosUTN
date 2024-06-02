namespace Entidades
{
    public class Fahrenheit
    {
        private double temperatura;

        private Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        {
            return temperatura;
        }

        public static implicit operator Fahrenheit (double temperatura)
        {
            return new Fahrenheit(temperatura);
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            Fahrenheit f = default;

            if(c is not null)
            {
                f = (c.GetTemperatura() * ((double)9 / 5)) + 32;
            }

            return f;
        }
        public static explicit operator Fahrenheit(Kelvin k)
        {
            Fahrenheit f = default;

            if (k is not null)
            {
                f = (k.GetTemperatura() * ((double)9 / 5)) - 459.67;
            }

            return f;
        }
    }
}