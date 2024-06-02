using Biblioteca;

namespace FizzBuz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [30];

            for(int i = 0; i < 30; i++)
            {
                numeros[i] = i + 1;
            }

            foreach(int i in numeros)
            {
                Console.WriteLine(i.FizzBuzz());
            }
        }
    }
}