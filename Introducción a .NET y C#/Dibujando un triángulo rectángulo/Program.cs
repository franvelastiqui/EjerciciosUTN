using System.Globalization;

namespace Dibujando_un_triángulo_rectángulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool respuesta;

            Console.Write("Indique la altura del triángulo: ");
            respuesta = int.TryParse(Console.ReadLine(), out numero);
            while (!respuesta)
            {
                Console.Write("Error. Reingrese un número válido: ");
            }

            for(int i = 1; i <= numero; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}