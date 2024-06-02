using System;
using Entidades;

namespace Aprendete_las_tablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculadora.ArmarTabla(numero));

        }
    }
}