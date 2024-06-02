namespace Biblioteca
{
    public static class StringExtendido
    {
        public static int ContarCantidadSignosDePuntuacion(this string texto)
        {
            char[] signos = { ',', '.', ';' };
            int contador = 0;

            foreach (char c in texto)
            {
                if (signos.Contains(c))
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}