using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new("Torneo de Fútbol Provincial");
            Torneo<EquipoBasquet> torneoBasquet = new("Liga de Básquet Regional");

            EquipoFutbol Platense = new("Platense", new DateTime(1990, 02, 18));
            EquipoFutbol Estudiantes = new("Estudiantes", new DateTime(1991, 12, 13));
            EquipoFutbol Chacarita = new("Chacarita", new DateTime(1992, 01, 26));

            EquipoBasquet Tigres = new("Tigres", new DateTime(2000, 08, 08));
            EquipoBasquet Jaguares = new("Jaguares", new DateTime(2001, 05, 14));
            EquipoBasquet Leones = new("Leones", new DateTime(2002, 11, 03));

            _ = torneoFutbol + Platense;
            _ = torneoFutbol + Estudiantes;
            _ = torneoFutbol + Chacarita;

            _ = torneoBasquet + Tigres;
            _ = torneoBasquet + Jaguares;
            _ = torneoBasquet + Leones;

            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine("--------------------------------------------------------\n");
            Console.WriteLine(torneoFutbol.Mostrar());

            Console.WriteLine("--------------------------------------------------------\n");
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine("--------------------------------------------------------\n");
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine("--------------------------------------------------------\n");
        }
    }
}