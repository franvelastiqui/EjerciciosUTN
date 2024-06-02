using Biblioteca;

namespace Creo_que_necesito_un_préstamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Carlos", 100);

            Console.WriteLine(cuenta1.Mostrar());

            cuenta1.Ingresar(52.12m);

            Console.WriteLine(cuenta1.Mostrar());

            cuenta1.Retirar(200m);

            Console.WriteLine(cuenta1.Mostrar());
        }
    }
}