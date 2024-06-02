using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Validador_de_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numMax = int.MinValue;
            int numMin = int.MaxValue;
            int acumulador = 0;
            double promedio;
            bool respuesta;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese 10 números entre -100 y 100: ");

                respuesta = int.TryParse(Console.ReadLine(), out numero);

                while (!respuesta || !Validador.Validar(numero, -100, 100))
                {
                    Console.Write("Error. Reingrese el número: ");

                    respuesta = int.TryParse(Console.ReadLine(), out numero);
                }

                if (numero < numMin)
                {
                    numMin = numero;
                }
                if (numero > numMax)
                {
                    numMax = numero;
                }

                acumulador += numero;
            }

            promedio = acumulador / 10.00;

            Console.WriteLine($"El numero máximo es {numMax}, el número mínimo es {numMin} y el promedio es {promedio}");
        }
    }
}