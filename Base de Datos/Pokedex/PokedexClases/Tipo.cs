using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexClases
{
    public class Tipo
    {
        string tipoPokemon;

        public Tipo(string tipo)
        {
            tipoPokemon = tipo;
        }

        public string TipoPokemon { get => tipoPokemon; set => tipoPokemon = value; }

        public override string ToString()
        {
            return tipoPokemon;
        }
    }
}
