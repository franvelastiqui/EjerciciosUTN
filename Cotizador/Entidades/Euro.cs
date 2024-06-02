using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        static double cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 1.17;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
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

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() * cotizRespectoDolar);
        }
        public static explicit operator Peso(Euro e)
        {
            return new Peso(((Dolar)e).GetCantidad() / Peso.GetCotizacion());
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e.GetCantidad() == ((Euro)d).GetCantidad();
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return e.GetCantidad() == ((Euro)p).GetCantidad();
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }
    }
}
