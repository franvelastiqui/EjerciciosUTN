using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = true;

            if(e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach(Jugador j1 in e.jugadores)
                {
                    if(j1 == j)
                    {
                        retorno = false;
                    }
                }
            }
            else
            {
                retorno = false;
            }

            if(retorno)
            {
                e.jugadores.Add(j);
            }

            return retorno;
        }
    }
}
