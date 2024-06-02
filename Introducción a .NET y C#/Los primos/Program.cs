namespace Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string textoIngresado;
            bool respuesta;
            bool esPrimo = true;

            do
            {
                Console.Write("Ingrese un valor: ");

                textoIngresado = Console.ReadLine();

                if (textoIngresado != "salir")
                {
                    respuesta = int.TryParse(textoIngresado, out numero);

                    while (!respuesta)
                    {
                        Console.Write("ERROR. ¡Reingresar número!: ");

                        respuesta = int.TryParse(Console.ReadLine(), out numero);
                    }

                    for(int i = 2; i<= numero; i++)
                    {
                        for(int j = 2; j < i; j++)
                        {
                            if(i%j == 0)
                            {
                                esPrimo = false;
                                break;
                            }
                        }

                        if(esPrimo)
                        {
                            Console.Write(i + " ");
                        }

                        esPrimo = true;
                    }

                    Console.Write("\nDesea seguir operando?: ");
                    textoIngresado = Console.ReadLine();
                }

            } while (textoIngresado is not "salir");
        }
    }
}