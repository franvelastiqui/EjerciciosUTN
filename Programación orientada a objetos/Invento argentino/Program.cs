using Biblioteca;

namespace Invento_argentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujo;

            Boligrafo azul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo rojo = new Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine($"Tinta del azul: {azul.GetTinta()}");
            Console.WriteLine($"Tinta del rojo: {rojo.GetTinta()}");

            Console.ForegroundColor = azul.GetColor();
            _ = azul.Pintar(50, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta del azul: {azul.GetTinta()}");
            azul.Recargar();
            _ = azul.Pintar(150, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta del azul: {azul.GetTinta()}");

            Console.ForegroundColor = rojo.GetColor();
            _ = rojo.Pintar(100, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta del rojo: {rojo.GetTinta()}");
            rojo.Recargar();
            _ = rojo.Pintar(20, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta del rojo: {rojo.GetTinta()}");
            _ = rojo.Pintar(20, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta del rojo: {rojo.GetTinta()}");

        }
    }
}