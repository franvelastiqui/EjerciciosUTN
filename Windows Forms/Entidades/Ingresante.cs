using System.Text;

namespace Entidades
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Dirección: {direccion}");
            sb.AppendLine($"Edad: {edad}");
            sb.AppendLine($"Género: {genero}");
            sb.AppendLine($"País: {pais}");
            sb.AppendLine($"Curso/s:");

            if (cursos.Length < 1)
            {
                sb.AppendLine("No tiene cursos registrados.");
            }
            else
            {
                foreach (string s in cursos)
                {
                    sb.AppendLine(s);
                }
            }

            return sb.ToString();
        }
    }
}