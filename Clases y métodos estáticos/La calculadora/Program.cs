using System.Net;
using Entidades;

namespace La_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primerOperando;
            double segundoOperando;
            string operacion;

            Console.WriteLine("Inrgese dos nuúmeros y la operacion: ");

            primerOperando = double.Parse(Console.ReadLine());
            segundoOperando = double.Parse(Console.ReadLine());
            operacion = Console.ReadLine();

            Console.WriteLine("El resultado es = " + Calculadora.Calcular(primerOperando, segundoOperando, operacion));
        }
    }
}