namespace Numeros_locos_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            int[] aux = new int[20];
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                list.Add(random.Next(-100, 100));
                stack.Push(random.Next(-100, 100));
                queue.Enqueue(random.Next(-100, 100));
            }

            //LISTA
            Console.WriteLine("Lista original: ");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            list.Sort(OrdenarDescendente);

            Console.WriteLine("Lista de positivos de forma decreciente: ");
            foreach (int i in list)
            {
                if(i > 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

            list.Sort();

            Console.WriteLine("Lista de negativos de forma creciente: ");
            foreach (int i in list)
            {
                if (i < 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

            //Pila
            Console.WriteLine("Pila original: ");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for(int i = 0; i < 20; i++)
            {
                aux[i] = stack.Pop();
            }
            Array.Sort(aux);
            for (int i = 0; i < 20; i++)
            {
                stack.Push(aux[i]);
            }

            Console.WriteLine("Pila de positivos de forma decreciente: ");
            foreach (int i in stack)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                aux[i] = stack.Pop();
            }
            Array.Sort(aux,OrdenarDescendente);
            for (int i = 0; i < 20; i++)
            {
                stack.Push(aux[i]);
            }

            Console.WriteLine("Pila de negativos de forma creciente: ");
            foreach (int i in list)
            {
                if (i < 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

            //Fila
            Console.WriteLine("Fila original: ");
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                aux[i] = queue.Dequeue();
            }
            Array.Sort(aux,OrdenarDescendente);
            for (int i = 0; i < 20; i++)
            {
                queue.Enqueue(aux[i]);
            }

            Console.WriteLine("Fila de positivos de forma decreciente: ");
            foreach (int i in queue)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                aux[i] = queue.Dequeue();
            }
            Array.Sort(aux, OrdenarDescendente);
            for (int i = 0; i < 20; i++)
            {
                queue.Enqueue(aux[i]);
            }

            Console.WriteLine("Fila de negativos de forma creciente: ");
            foreach (int i in queue)
            {
                if (i < 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
        }
        static int OrdenarDescendente(int num1, int num2)
        {
            return num2 - num1;
        }
    }
}