using Entidades;

namespace Sumador.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entidades.Sumador sum = new();
            Entidades.Sumador sum2 = new(2);

            Console.WriteLine($"suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum2.Sumar(100, 687)} Sumador {sum2.Cantidad()}");
            Console.WriteLine($"suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum.Sumar("HOla ", "Munjjjjjdo")} Sumador {sum.Cantidad()}");

            if (sum | sum2)
            {
                Console.WriteLine("ES true");
            }
            else
            {
                Console.WriteLine("ES false");
            }
            Console.WriteLine($"suma de objetos {sum + sum2}");
        }
    }
}