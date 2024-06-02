namespace Entidades
{
    public class Producto
    {
        private string marca;
        private double precio;
        private int codigo;
        private static int ultimoCodigo;

        static Producto()
        {
            ultimoCodigo = 100;
        }
        public Producto(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigo = ultimoCodigo;
            ultimoCodigo++;
        }

        public string GetMarca()
        {
            return marca;
        }
        public double GetPrecio()
        {
            return precio;
        }
        public int GetCodigo()
        {
            return codigo;
        }
    }
}