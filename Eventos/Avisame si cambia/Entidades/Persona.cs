using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Persona
    {
        public event DelegadoString EventoString;

        private string nombre;
        private string apellido;

        public Persona()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public string Mostrar()
        {
            EventoString("Se realizó un cambio en el nombre de la persona");
            return $"{nombre} {apellido}";
        }
    }
}