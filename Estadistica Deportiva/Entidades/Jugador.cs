using System.Text;

namespace Entidades
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre) : base(dni, nombre)
        {
            partidosJugados = 0;
            totalGoles = 0;
        }
        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : base(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public int PartidosJugados
        {
            get
            {
                return partidosJugados;
            }
            set
            {
                partidosJugados = value;
            }
        }
        public int TotalGoles
        {
            get
            {
                return totalGoles;
            }
            set
            {
                totalGoles= value;
            }
        }
        public float PromedioGoles
        {
            get
            {
                return (float)totalGoles / (float)partidosJugados;
            }
        }
     

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Jugador {nombre}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Total goles: {totalGoles}");
            sb.AppendLine($"Promedio goles: {PromedioGoles}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador a, Jugador b)
        {
            return a.dni == b.dni;
        }

        public static bool operator !=(Jugador a, Jugador b)
        {
            return !(a == b);
        }
    }
}