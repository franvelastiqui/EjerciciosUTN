using System.Runtime.CompilerServices;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        static double cotizRespectoDolar;

        static Peso()
        {
            cotizRespectoDolar = 0.0097418412079883;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        #region Getters
        public double GetCantidad()
        {
            return cantidad;
        }
        static public double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        #endregion

        public void SetCotizacion(double cotizacion)
        {
            cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.GetCantidad() * cotizRespectoDolar);
        }
        public static explicit operator Euro(Peso p)
        {
            return new Euro(((Dolar)p).GetCantidad() / Euro.GetCotizacion());
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() + ((Peso)d).GetCantidad());
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() - ((Peso)d).GetCantidad());
        }
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() + ((Peso)e).GetCantidad());
        }
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() - ((Peso)e).GetCantidad());
        }
    }
}