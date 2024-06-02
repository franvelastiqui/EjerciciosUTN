namespace Dibujando_un_triángulo_equilátero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string espacios = "";
            string cantidad = "";
            string cantidadAnterior = "";
            bool respuesta;

            Console.Write("Indique la altura del triángulo: ");
            respuesta = int.TryParse(Console.ReadLine(), out numero);
            while (!respuesta)
            {
                Console.Write("Error. Reingrese un número válido: ");
            }

            for (int i = 1; i <= numero; i++)
            {
                for(int j = 0; j < numero-i; j++)
                {
                    espacios += " ";
                }
                Console.Write(espacios);

                for (int k = 1; k <= i; k++)
                {
                    cantidad += "*";
                }
                Console.Write(cantidad);
                Console.Write(cantidadAnterior);
                Console.Write(espacios);
                
                cantidadAnterior = cantidad;
                cantidad = "";
                espacios = "";

                Console.Write("\n");
            }
        }
    }
}