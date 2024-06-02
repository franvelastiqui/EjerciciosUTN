using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private Mascota[] mascotas;
        int contadorMascotas = 0;

        public Cliente(string nombre, string apellido, string domicilio, string telefono, int cantidadMascotas)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            mascotas = new Mascota[cantidadMascotas];
        }

        public void SetMascota(Mascota mascota)
        {
            if (contadorMascotas < mascotas.Length)
            {
                mascotas[contadorMascotas] = mascota;
            }
            contadorMascotas++;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cliente: {apellido}, {nombre}");
            sb.AppendLine(domicilio);
            sb.AppendLine(telefono);
            sb.AppendLine("Mascotas:");

            foreach (Mascota mascota in mascotas)
            {
                sb.AppendLine(mascota.Mostrar());
                sb.AppendLine("--");
            }
            sb.AppendLine("---------------------------");

            return sb.ToString();
        }
    }
}
