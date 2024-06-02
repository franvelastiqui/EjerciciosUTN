using System.Net.Http.Json;
using System.Text;
using Entidades;

namespace ConsolaMaquina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> filaDeClientes = new Queue<string>();
            string cliente;
            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();
            int codigo;
            string respuesta = "";

            //maquinaExpendedora.Add(1, new Producto("Pepsi", 250));
            //maquinaExpendedora.Add(2, new Producto("Lays", 599));
            //maquinaExpendedora.Add(3, new Producto("Twistos", 540));
            //maquinaExpendedora.Add(4, new Producto("Paso de los Toros", 218));
            //maquinaExpendedora.Add(5, new Producto("Mirinda", 250));
            //maquinaExpendedora.Add(6, new Producto("Doritos", 1373));
            //maquinaExpendedora.Add(7, new Producto("Cheetos", 556));
            //maquinaExpendedora.Add(8, new Producto("7UP", 250));
            //maquinaExpendedora.Add(9, new Producto("H20", 190));
            //maquinaExpendedora.Add(10, new Producto("PeP Palitos", 300));

            filaDeClientes.Enqueue("Carla");
            filaDeClientes.Enqueue("Juan");
            filaDeClientes.Enqueue("Pablo");
            filaDeClientes.Enqueue("María");
            filaDeClientes.Enqueue("José");

            Stack<Producto> pepsi = new Stack<Producto>();
            pepsi.Push(new Producto("Pepsi", 250));
            pepsi.Push(new Producto("Pepsi", 250));
            pepsi.Push(new Producto("Pepsi", 250));
            pepsi.Push(new Producto("Pepsi", 250));
            pepsi.Push(new Producto("Pepsi", 250));

            Stack<Producto> lays = new Stack<Producto>();
            lays.Push(new Producto("Lays", 599));
            lays.Push(new Producto("Lays", 599));
            lays.Push(new Producto("Lays", 599));
            lays.Push(new Producto("Lays", 599));
            lays.Push(new Producto("Lays", 599));

            Stack<Producto> twistos = new Stack<Producto>();
            twistos.Push(new Producto("Twistos", 540));
            twistos.Push(new Producto("Twistos", 540));
            twistos.Push(new Producto("Twistos", 540));
            twistos.Push(new Producto("Twistos", 540));
            twistos.Push(new Producto("Twistos", 540));

            maquinaExpendedora.Add(1, pepsi);
            maquinaExpendedora.Add(2, lays);
            maquinaExpendedora.Add(3, twistos);

            do
            {
                cliente = filaDeClientes.Peek();

                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine($"Cantidad de clientes en fila: {filaDeClientes.Count}");
                Console.WriteLine($"\nSe esta atendiendo a {cliente}");

                foreach (KeyValuePair<int, Stack<Producto>> producto in maquinaExpendedora)
                {
                    Console.WriteLine($"\n{producto.Value.Peek().GetMarca()}\t\t\t\t${producto.Value.Peek().GetPrecio().ToString("N2")}\t\tCantidad: {producto.Value.Count}\t\tCódigo {producto.Key}");
                }

                Console.Write($"\nElija el producto elegido por {cliente} con el número de código: ");

                while (!(int.TryParse(Console.ReadLine(), out codigo)) || !maquinaExpendedora.ContainsKey(codigo))
                {
                    Console.Write("\nError. Elija un producto con código válido: ");
                }

                Console.WriteLine($"\n{cliente} recibió el producto {maquinaExpendedora[codigo].Peek().GetMarca()}. Código {maquinaExpendedora[codigo].Peek().GetCodigo()}");

                maquinaExpendedora[codigo].Pop();

                if (maquinaExpendedora[codigo].Count == 0)
                {
                    maquinaExpendedora.Remove(codigo);
                }

                filaDeClientes.Dequeue();

                if(filaDeClientes.Count == 0)
                {
                    Console.Write("\nNo hay más clientes. Presione S si desea agregar mas clientes: ");

                    respuesta = Console.ReadLine();

                    if(respuesta.ToLower() == "s")
                    {
                        filaDeClientes.Enqueue("Cliente Agregado");
                    }

                }
                Console.WriteLine();

            } while (filaDeClientes.Count != 0);
        }
    }
}