using Biblioteca;

namespace Veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Carlos", "Perez", "Av Anchoa", "1111", 1);
            Cliente c2 = new Cliente("Maria", "Gomez", "Calle Sardina", "2222", 1);
            Cliente c3 = new Cliente("Juan", "Diaz", "Av Merluza", "3333", 2);

            Mascota m1 = new Mascota("tobi", "perro", 6, 8, 2023, 0);
            Mascota m2 = new Mascota("tom", "gato", 9, 11, 2020, 1);
            Mascota m31 = new Mascota("horus", "gato", 12, 9, 2023, 0);
            Mascota m32 = new Mascota("pancho", "perro", 25, 4, 2012, 2);

            m2.Vacunar(Vacunas.TripleFelina);
            m32.Vacunar(Vacunas.Rabia);

            c1.SetMascota(m1);
            c2.SetMascota(m2);
            c3.SetMascota(m31);
            c3.SetMascota(m32);

            Console.WriteLine(c1.Mostrar());
            Console.WriteLine(c2.Mostrar());
            Console.WriteLine(c3.Mostrar());
        }
    }
}