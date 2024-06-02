namespace Error_al_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double cuadrado;
            double cubo;
            bool respuesta;

            Console.Write("Ingrese un número: ");

            respuesta = double.TryParse(Console.ReadLine(), out numero);

            while (!respuesta && numero <=0)
            {
                Console.Write("ERROR. ¡Reingresar número!: ");

                respuesta = double.TryParse(Console.ReadLine(), out numero);
            }

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine($"El número es {numero}, el cuadrado es {cuadrado} y el cubo es {cubo}");
        }
    }
}