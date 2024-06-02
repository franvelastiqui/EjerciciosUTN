using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Lapiz : IAcciones
    {
        protected float tamanioMina;

        public Lapiz(int unidades)
        {
            tamanioMina = unidades;
        }

        ConsoleColor IAcciones.Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get { return tamanioMina; }
            set { tamanioMina = value; }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            if(!string.IsNullOrWhiteSpace(texto))
            {
                foreach (char c in texto.ToCharArray())
                {
                    if (!(c == ' ' || c == '\n' || c == '\t'))
                    {
                        ((IAcciones)this).UnidadesDeEscritura -= 0.1F;
                    }
                }
            }

            return new EscrituraWrapper(((IAcciones)this).Color, texto);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Lápiz:");
            sb.AppendLine($"Color: {((IAcciones)this).Color}");
            sb.AppendLine($"Tamaño de mina: {((IAcciones)this).UnidadesDeEscritura}");

            return sb.ToString();
        }
    }
}
