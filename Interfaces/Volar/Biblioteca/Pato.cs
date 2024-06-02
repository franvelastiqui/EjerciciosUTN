using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pato : IVolador
    {
        private int cantidadEnergia;

        public Pato(int cantidadEnergia)
        {
            this.cantidadEnergia = cantidadEnergia;
        }

        public int CantidadEnergia { get => cantidadEnergia; set => cantidadEnergia = value; }

        public string Volador()
        {
            string retorno;

            if(cantidadEnergia >= 5)
            {
                cantidadEnergia -= 5;
                retorno = "Estoy volando como un pato ¡ Cuak !";
            }
            else
            {
                retorno = "No tengo suficiente energía ¡ Cuak !";
            }

            return retorno;
        }
    }
}
