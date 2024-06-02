using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public  class Boligrafo
    {
        const short cantidadTintaMaxima  = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }
        public short GetTinta()
        {
            return tinta;
        }
        private void SetTinta(short tinta)
        {
            if(this.tinta + tinta >= 0 && this.tinta + tinta <= cantidadTintaMaxima )
            {
                this.tinta += tinta;
            }
        }

        public void Recargar()
        {
            short tintaARecargar;

            tintaARecargar = (short)(cantidadTintaMaxima - tinta);

            SetTinta(tintaARecargar);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";

            if(gasto <= tinta)
            {
                for(int i = 0; i < gasto; i++)
                {
                    dibujo +=  "*";
                }

                dibujo += "\n";

                tinta -= gasto;
            }
            else
            {
                for (int i = 0; i < tinta; i++)
                {
                    dibujo += "*";
                }

                dibujo += "\n";

                tinta = 0;
            }

            return true;
        }

    }
}
