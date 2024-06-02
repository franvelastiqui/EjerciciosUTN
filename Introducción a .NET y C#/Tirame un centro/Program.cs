using System.Globalization;

namespace Tirame_un_centro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int ladoIzquierdo = 0;
            int ladoDerecho = 0;
            bool respuesta;

            Console.Write("Ingrese un número: ");

            respuesta = int.TryParse(Console.ReadLine(), out numero);

            while(!respuesta)
            {
                Console.Write("Error. Reingrese un número: ");

                respuesta = int.TryParse(Console.ReadLine(), out numero);
            }

            for(int i = 1;  i <= numero; i++)
            {
                for(int j=1; j<i; j++)
                {
                    ladoIzquierdo += j;
                }

                for(int k = i + 1; k <= ladoIzquierdo; k++)
                {
                    ladoDerecho += k;

                    if(ladoDerecho>=ladoIzquierdo)
                    {
                        break;
                    }
                }

                if(ladoDerecho == ladoIzquierdo && ladoDerecho != 0 && ladoIzquierdo != 0)
                {
                    Console.WriteLine(i);
                }

                ladoIzquierdo = 0;
                ladoDerecho = 0;
            }
        }
    }
}