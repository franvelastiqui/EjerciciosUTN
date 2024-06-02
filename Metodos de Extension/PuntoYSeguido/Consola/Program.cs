using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.Write("Ingrese un texto: ");
            texto = Console.ReadLine();

            Console.WriteLine($"El texto contiene {texto.ContarCantidadSignosDePuntuacion()} signos de puntuación.");
        }
    }
}