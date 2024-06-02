using System.Text;

namespace Biblioteca
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }

        public List<T> Equipos { get => equipos; }
        public string Nombre { get => nombre; }
        public string JugarPartido
        {
            get
            {
                Random equipo = new Random();
                T e1;
                T e2;

                if(equipos.Count >= 2)
                {
                    do
                    {
                        e1 = equipos[equipo.Next(equipos.Count)];
                        e2 = equipos[equipo.Next(equipos.Count)];
                    } while (e1 == e2);

                    return CalcularPartido(e1, e2);
                }
                return "No hay suficientes equipos en el torneo";
            }
        }

        private string CalcularPartido(T e1, T e2)
        {
            Random gol = new Random();

            return $"{e1.Nombre} {gol.Next(6)} - {e2.Nombre} {gol.Next(6)}";
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"{this.nombre.ToUpper()}");
            datos.AppendLine("Equipos participantes:");

            foreach (T item in equipos)
            {
                datos.AppendLine($"{item.Ficha()}");
            }

            return datos.ToString();
        }

        public static bool operator ==(Torneo<T> t, T e)
        {
            foreach ( T item in t.equipos )
            {
                if (item == e)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }
        public static bool operator +(Torneo<T> t, T e)
        {
            if((t is not null && e is not null) && t != e)
            {
                t.equipos.Add(e);
                return true;
            }
            return false;
        }
    }
}