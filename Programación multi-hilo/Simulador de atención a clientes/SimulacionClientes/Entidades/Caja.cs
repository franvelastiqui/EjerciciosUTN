namespace Entidades
{
    public class Caja
    {
        static Random random;
        Queue<string> clienteALaEspera;
        string nombreCaja;
        private DelegadoClienteEnCaja delegadoClienteAtendido;

        static Caja()
        {
            random = new Random();
        }

        public Caja(string nombreCaja, DelegadoClienteEnCaja delegadoClienteAtendido)
        {
            clienteALaEspera = new Queue<string>();
            this.nombreCaja = nombreCaja;
            this.delegadoClienteAtendido = delegadoClienteAtendido;
        }

        public string NombreCaja { get => nombreCaja; }
        public int CantidadDeClientesALaEspera { get =>  clienteALaEspera.Count; }

        internal void AgregarCliente(string cliente)
        {
            clienteALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {
            //Task hilo = new(AtenderClientes);
            //hilo.Start();

            //return hilo;

            return Task.Run(AtenderClientes);
        }

        private void AtenderClientes()
        {
            do
            {
                if (clienteALaEspera.Any())
                {
                    string cliente = clienteALaEspera.Dequeue();
                    if(delegadoClienteAtendido is not null)
                    {
                        delegadoClienteAtendido.Invoke(this, cliente);
                    }

                    Thread.Sleep(random.Next(1000, 5000));
                }
            }while(true);
        }
    }
}