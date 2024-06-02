using Biblioteca;
using System.Text;

namespace IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiOtraClase otraClase = new MiOtraClase();

            string ruta = Directory.GetCurrentDirectory();
            string nombreArchivo = $"{DateTime.Now.ToString("yyyyMMdd-HHmm")}.txt";
            ruta = Path.Combine(ruta, nombreArchivo);

            try
            {
                otraClase.MiMetodo();
            }
            catch (MiExcepcion e)
            {

                StringBuilder sb = new StringBuilder();

                sb.AppendLine(e.Message);
                sb.AppendLine("-----------------------------------------------------------------------");
                if(e.InnerException is not null)
                {
                    sb.AppendLine(e.InnerException.ToString());

                }

                ArchivoTexto.Guardar(ruta, sb.ToString());
            }

            Console.WriteLine(ArchivoTexto.Leer(""));
        }
    }
}