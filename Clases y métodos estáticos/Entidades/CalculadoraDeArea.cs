using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }

        public static double CalcularAreaTriangulo(double baseT, double altura)
        {
            return (baseT * altura) / 2;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
