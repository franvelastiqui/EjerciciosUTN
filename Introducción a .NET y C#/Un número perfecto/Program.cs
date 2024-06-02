namespace Un_número_perfecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int cantidadNumeros = 0;
            int acumulador = 0;

            do
            {
                numero++;

                for(int i = 1; i < numero; i++)
                {
                    if(numero%i == 0)
                    {
                        acumulador += i;
                    }
                }

                if(numero == acumulador)
                {
                    cantidadNumeros++;
                    Console.WriteLine(numero);
                }

                acumulador = 0;
            } while (cantidadNumeros < 4);
        }
    }
}