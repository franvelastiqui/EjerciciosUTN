using Biblioteca;

namespace Placa.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new(2025, 9, 21);
            //DateTime fecha = DateTime.Now;

            Console.WriteLine(fecha.ObtenerPlacaCronicaTV(Estaciones.otoño));
        }
    }
}