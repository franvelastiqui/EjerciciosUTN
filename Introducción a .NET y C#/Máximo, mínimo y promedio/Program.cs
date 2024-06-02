namespace Máximo__mínimo_y_promedio
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

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese 5 números: ");

                respuesta = int.TryParse(Console.ReadLine(), out numero);

                while(!respuesta)
                {
                    Console.Write("Error. Reingrese 5 números: ");

                    respuesta = int.TryParse(Console.ReadLine(), out numero);
                }

                if (numero < numMin)
                {
                    numMin = numero;
                }
                else if (numero > numMax)
                {
                    numMax = numero;
                }

                acumulador += numero;
            }

            promedio = acumulador / 5.00;

            Console.WriteLine($"El numero máximo es {numMax}, el número mínimo es {numMin} y el promedio es {promedio}");
        }
    }
}