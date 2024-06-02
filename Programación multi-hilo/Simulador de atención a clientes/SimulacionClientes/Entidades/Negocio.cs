using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        static RealNameGenerator generadorNombre;
        ConcurrentQueue<string> clientes;
        List<Caja> cajas;

        static Negocio()
        {
            generadorNombre = new RealNameGenerator();
        }

        public Negocio(List<Caja> cajas)
        {
            this.cajas = cajas;
            clientes = new ConcurrentQueue<string>();
        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> tasks = new List<Task>();

            foreach(Caja caja in cajas)
            {
                tasks.Add(caja.IniciarAtencion());
            }

            Task aniadirClientes = new(AniadirClientes);
            aniadirClientes.Start();

            tasks.Add(aniadirClientes);
            tasks.Add(Task.Run(AsignarClientes));

            return tasks;
        }

        public void AniadirClientes()
        {
            do
            {
                clientes.Enqueue(generadorNombre.Generate());
                Thread.Sleep(1000);
            } while (true);
        }

        public void AsignarClientes()
        {
            do
            {
                Caja primerCaja = cajas.OrderBy(x => x.CantidadDeClientesALaEspera).First();

                if(clientes.TryDequeue(out string cliente))
                {
                    if(!String.IsNullOrEmpty(cliente))
                    {
                        primerCaja.AgregarCliente(cliente);
                    }
                }
            } while (true);
        }
    }
}
