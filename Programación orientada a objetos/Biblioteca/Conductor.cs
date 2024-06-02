using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conductor
    {
        private string nombre;
        private int[] kmPorDia;

        public Conductor(string nombre)
        {
            this.nombre = nombre;
            kmPorDia = new int[7];
        }

        public string GetNombre()
        {
            return nombre;
        }
        public int GetKmPorDia(int dia)
        {
            return kmPorDia[dia];
        }

        public void SetKmPorDia(int[] kmPorDia)
        {
            for (int i = 0; i < 7; i++)
            {
                this.kmPorDia[i] = kmPorDia[i];
            }
        }
    }
}
