using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Calcular(double primerOperando, double segundoOperando, string opearación)
        {
            double resultado = 0;

            switch (opearación)
            {
                case "+":
                    resultado = primerOperando + segundoOperando;
                    break;
                case "-":
                    resultado = primerOperando - segundoOperando;
                    break;
                case "*":
                    resultado = primerOperando * segundoOperando;
                    break;
                case "/":
                    if(Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else
                    {
                        resultado = -1;
                    }
                    break;
            }

            return resultado;
        }

        private static bool Validar(double divisor)
        {
            if(divisor == 0)
            {
                return false;
            }
            return true;
        }

        public static string ArmarTabla(int numero)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tabla de multiplicar del número {numero}:");
            sb.AppendLine($"{numero} x 1 = {numero * 1}");
            sb.AppendLine($"{numero} x 2 = {numero * 2}");
            sb.AppendLine($"{numero} x 3 = {numero * 3}");
            sb.AppendLine($"{numero} x 4 = {numero * 4}");
            sb.AppendLine($"{numero} x 5 = {numero * 5}");
            sb.AppendLine($"{numero} x 6 = {numero * 6}");
            sb.AppendLine($"{numero} x 7 = {numero * 7}");
            sb.AppendLine($"{numero} x 8 = {numero * 8}");
            sb.AppendLine($"{numero} x 9 = {numero * 9}");

            return sb.ToString();
        }
    }
}
