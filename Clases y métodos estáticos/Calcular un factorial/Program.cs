namespace Calcular_un_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool respuesta;

            Console.WriteLine("Ingrese un número: ");
            respuesta = int.TryParse(Console.ReadLine(), out numero);
            while (!respuesta)
            {
                Console.WriteLine("Reingrese el número: ");
                respuesta = int.TryParse(Console.ReadLine(), out numero);
            }

            Console.WriteLine($"El factorial de {numero} es {CalcularFactorial(numero)}");
        }

        static public int CalcularFactorial(int numero)
        {
            int acumulador = 1;

            for(int i = 1; i <= numero; i++)
            {
                acumulador *= i;
            }

            return acumulador;
        }
    }
}