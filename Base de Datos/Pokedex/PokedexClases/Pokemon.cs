namespace PokedexClases
{
    public class Pokemon
    {
        private int id;
        private string nombre;
        private string tipo;
        private string entrenador;
        private string urlImagen;

        public Pokemon()
        {

        }

        public Pokemon(int id, string nombre, string tipo, string entrenador, string urlImagen)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipo = tipo;
            this.entrenador = entrenador;
            this.urlImagen = urlImagen;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Entrenador { get => entrenador; set => entrenador = value; }
        public string UrlImagen { get => urlImagen; set => urlImagen = value; }
    }
}