using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            caja = new PuestoAtencion(Puesto.Caja1);
            clientes = new Queue<Cliente>();
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                _ = this + value;
            }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente c2 in n.clientes)
            {
                if(c == c2)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }
        public static bool operator ~(Negocio n)
        {
            if(n.clientes.Count >0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count();
            }
        }
    }
}
