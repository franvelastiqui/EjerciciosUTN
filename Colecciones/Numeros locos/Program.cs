namespace Numeros_locos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                numeros[i] = random.Next(-100, 100);
            }

            Console.WriteLine("Array original: ");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine();

            Array.Sort(numeros, OrdenarDescendente);

            Console.WriteLine("Array de forma descreciente: ");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine();

            Array.Sort(numeros);

            Console.WriteLine("Array de forma creciente: ");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine();
        }

        static int OrdenarDescendente(int num1, int num2)
        {
            return num2 - num1;
        }
    }
}