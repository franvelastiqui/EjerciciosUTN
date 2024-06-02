using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class BuzzLightyear : IVolador
    {
        private int experiencia;

        public BuzzLightyear()
        {
            experiencia = 0;
        }

        public int Experiencia { get => experiencia; }

        public string Volador()
        {
            experiencia += 3;
            return "Al infinito y mas alla";
        }
    }
}
