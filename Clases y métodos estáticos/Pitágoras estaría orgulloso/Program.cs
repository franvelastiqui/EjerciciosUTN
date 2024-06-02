namespace Pitágoras_estaría_orgulloso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseT;
            double alturaT;
            double hipotenusa;
            bool respuesta;

            Console.WriteLine("Ingrese la base del triángulo: ");
            respuesta = double.TryParse(Console.ReadLine(), out baseT);
            while (!respuesta)
            {
                Console.WriteLine("Error. Reingrese la base del triángulo: ");
                respuesta = double.TryParse(Console.ReadLine(), out baseT);
            }

            Console.WriteLine("Ingrese la altura del triángulo: ");
            respuesta = double.TryParse(Console.ReadLine(), out alturaT);
            while (!respuesta)
            {
                Console.WriteLine("Error. Reingrese la altura del triángulo: ");
                respuesta = double.TryParse(Console.ReadLine(), out alturaT);
            }

            hipotenusa = Math.Sqrt(Math.Pow(baseT, 2) + Math.Pow(alturaT, 2));

            Console.WriteLine($"La hipotenusa del triángulo es {hipotenusa}");
        }
    }
}