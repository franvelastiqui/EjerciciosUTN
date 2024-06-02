using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo : IAcciones
    {
        protected ConsoleColor colorTinta;
        protected float tinta;

        public Boligrafo(int unidades, ConsoleColor colorTinta)
        {
            this.colorTinta = colorTinta;
            tinta = unidades;
        }

        public ConsoleColor Color
        {
            get { return colorTinta; }
            set { colorTinta = value; }
        }
        public float UnidadesDeEscritura
        {
            get { return tinta; }
            set { tinta = value; }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            if (!string.IsNullOrWhiteSpace(texto))
            {
                foreach (char c in texto.ToCharArray())
                {
                    if (!(c == ' ' || c == '\n' || c == '\t'))
                    {
                        UnidadesDeEscritura -= 0.3F;
                    }
                }
            }

            return new EscrituraWrapper(Color, texto);
        }

        public bool Recargar(int unidades)
        {
            if(unidades > 0)
            {
                UnidadesDeEscritura += unidades;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Bolígrafo:");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Nivel de tinta: {UnidadesDeEscritura}");

            return sb.ToString();
        }
    }
}
