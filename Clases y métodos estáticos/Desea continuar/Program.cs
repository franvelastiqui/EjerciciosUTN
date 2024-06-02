using Entidades;

namespace Desea_continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador = 0;
            bool flag;

            do
            {
                Console.Write("Ingrese un número: ");

                flag = int.TryParse(Console.ReadLine(), out numero);

                while (!flag)
                {
                    Console.Write("Error. Reingrese un número: ");

                    flag = int.TryParse(Console.ReadLine(), out numero);
                }

                acumulador += numero;

                Console.Write("¿Desea continuar?: ");
            } while (Validador.ValidarRespuesta(Console.ReadLine()));

            Console.WriteLine($"El número es {acumulador}");
        }
    }
}