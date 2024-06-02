using Entidades;

namespace Calculadora_de_áreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el lado del cuadrado: ");
            Console.WriteLine($"El area es: {CalculadoraDeArea.CalcularAreaCuadrado(double.Parse(Console.ReadLine()))}");

            Console.Write("Ingrese la base y altura del triángulo: ");
            Console.WriteLine($"El area es: {CalculadoraDeArea.CalcularAreaTriangulo(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()))}");

            Console.Write("Ingrese el radio del círculo: ");
            Console.WriteLine($"El area es: {CalculadoraDeArea.CalcularAreaCirculo(double.Parse(Console.ReadLine()))}");
        }
    }
}