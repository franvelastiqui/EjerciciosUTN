using Entidades;

namespace Conversor.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double decimalIngresado;
            string binarioIngresado;
            bool respuesta;

            Console.WriteLine("Ingrese un número decimal: ");

            respuesta = double.TryParse(Console.ReadLine(), out decimalIngresado);

            while (!respuesta)
            {
                Console.WriteLine("Error. Reingrese un número decimal: ");

                respuesta = double.TryParse(Console.ReadLine(), out decimalIngresado);
            }

            Console.WriteLine("Ingrese un número binario: ");

            binarioIngresado = Console.ReadLine();

            Console.WriteLine($"Decimal ingresado es {decimalIngresado}, binario es {Entidades.Conversor.ConvertirDecimalABinario(decimalIngresado)}");
            Console.WriteLine($"Binario ingresado es {binarioIngresado}, binario es {Entidades.Conversor.ConvertirBinarioADecimal(binarioIngresado)}");
        }
    }
}