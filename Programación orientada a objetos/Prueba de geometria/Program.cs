using System.Drawing;
using Biblioteca;

namespace Prueba_de_geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(new Punto(0, 3), new Punto(5, 0));

            Console.WriteLine($"El área es: {rectangulo.Area()}");
            Console.WriteLine($"El perímetro es: {rectangulo.Perimetro()}");
        }
    }
}