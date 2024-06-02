using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Circulo : Figura
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando círculo...";
        }

        public override double CalcularSuperficie()
        {
            return Math.PI + Math.Pow(radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2*Math.PI*radio;
        }
    }
}
