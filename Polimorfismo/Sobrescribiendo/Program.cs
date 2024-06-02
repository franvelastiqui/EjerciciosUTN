namespace Sobrescribiendo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            SobreSobrescrito objetoSobrescrito = new SobreSobrescrito();

            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.MiMetodo());
        }

    }

    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            return GetType() == obj.GetType();
        }
        public override int GetHashCode()
        {
            return 1142510181;
        }
    }

    public class SobreSobrescrito : Sobrescrito
    {
        public override string MiPropiedad
        {
            get
            {
                return miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}