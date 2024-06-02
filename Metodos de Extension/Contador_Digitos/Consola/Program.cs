using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long numero;
            Console.Write("Ingrese un número: ");

            if(Int64.TryParse(Console.ReadLine(), out numero))
            {
                int cantidadDigitos = numero.ContarCantidadDeDigitos();
                Console.WriteLine("Número de {0,10} dígito/s", cantidadDigitos);
            }
            else
            {
                Console.WriteLine("Valor ingresado inválido");
            }
        }
    }
}