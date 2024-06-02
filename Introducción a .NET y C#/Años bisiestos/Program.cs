namespace Años_bisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioInicial;
            int anioFinal;
            bool respuesta;

            Console.Write("Ingrese un año inicial: ");
            respuesta = int.TryParse(Console.ReadLine(), out anioInicial);
            while (!respuesta)
            {
                Console.Write("Error. Reingrese un año válido: ");

                respuesta = int.TryParse(Console.ReadLine(), out anioInicial);
            }

            Console.Write("Ingrese un año final: ");
            respuesta = int.TryParse(Console.ReadLine(), out anioFinal);
            while (!respuesta && anioInicial>=anioFinal)
            {
                Console.Write("Error. Reingrese un año válido: ");

                respuesta = int.TryParse(Console.ReadLine(), out anioFinal);
            }

            for(int i = anioInicial; i <= anioFinal; i++)
            {
                if(i%4 == 0 && i%100!=0)
                {
                    Console.WriteLine(i);
                }
                else if(i%400 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}