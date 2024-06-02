using Entidades;
using System.Threading.Channels;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Caja> cajas = new List<Caja>();
            DelegadoClienteEnCaja delegado = (x,y) => Console.WriteLine($"{DateTime.Now:HH:mm:ss} - Hilo {Task.CurrentId} - {x.NombreCaja} - Atendiendo a {y}. Quedan {x.CantidadDeClientesALaEspera} clientes en esta caja.");

            Caja caja01 = new("Caja 01", delegado);
            Caja caja02 = new("Caja 02", delegado);

            cajas.Add(caja01);
            cajas.Add(caja02);

            Negocio negocio = new(cajas);

            Console.WriteLine("Asignando cajas...");

            Task[] hilos = negocio.ComenzarAtencion().ToArray();

            Task.WaitAll(hilos);
        }
    }
}