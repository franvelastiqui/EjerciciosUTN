using Biblioteca;

namespace Lanzar_y_Atrapar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiOtraClase otraClase = new MiOtraClase();

            try
            {
                otraClase.MiMetodo();
            }
            catch(MiExcepcion e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine();
                Exception ex = e;
                while(ex.InnerException != null)
                {
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine(ex.InnerException);
                    ex = ex.InnerException;
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine();
                }

            }
        }
    }
}