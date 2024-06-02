using Entidades;

namespace ConsolaEst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(2, "utn");
            DirectorTecnico dt = new DirectorTecnico("dt", 222222, new DateTime(1980, 11, 14));
            DirectorTecnico dt2 = new DirectorTecnico("dt", 333333, new DateTime(1980, 11, 14));
            Jugador j1 = new Jugador(123, "nom1", 5, 20);
            Jugador j2 = new Jugador(485, "nom2", 3, 5);
            Jugador j3 = new Jugador(123, "nom3", 7, 3);
            Jugador j4 = new Jugador(789, "nom4", 3, 5);

            Console.WriteLine("DT " + dt.MostrarDatos());

            if(dt != dt2)
            {
                Console.WriteLine("DT2 " + dt2.MostrarDatos());
            }

            if (equipo + j1)
                Console.WriteLine(j1.MostrarDatos());

            if (equipo + j2)
                Console.WriteLine(j2.MostrarDatos());

            if (equipo + j3)
                Console.WriteLine(j3.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO " + j3.MostrarDatos());

            if (equipo + j4)
                Console.WriteLine(j4.MostrarDatos());

            else
                Console.WriteLine("NO SE AGREGO " + j4.MostrarDatos());
        }
    }
}