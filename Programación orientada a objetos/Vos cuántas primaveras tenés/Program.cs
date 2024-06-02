using Biblioteca;

namespace Vos_cuántas_primaveras_tenés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona marcos = new Persona("Marcos", 14, 3, 1985, "11111111");
            Persona carla = new Persona("Carla", 25, 9, 2005, "22222222");
            Persona juan = new Persona("Juan", 9, 5, 2012, "33333333");

            Console.WriteLine($"{marcos.EsMayorDeEdad()}");
            Console.WriteLine($"{carla.EsMayorDeEdad()}");
            Console.WriteLine($"{juan.EsMayorDeEdad()}");
        }
    }
}