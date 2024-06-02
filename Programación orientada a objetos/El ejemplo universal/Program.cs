using Biblioteca;

namespace El_ejemplo_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Gomez", "123", "Juan");
            Estudiante e2 = new Estudiante("Perez", "456", "Carla");
            Estudiante e3 = new Estudiante("Diaz", "789", "Pedro");

            e1.SetNotaPrimerParcial(5);
            e1.SetNotaSegundoParcial(6);

            e2.SetNotaPrimerParcial(8);
            e2.SetNotaSegundoParcial(5);

            e3.SetNotaPrimerParcial(9);
            e3.SetNotaSegundoParcial(3);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());
        }
    }
}