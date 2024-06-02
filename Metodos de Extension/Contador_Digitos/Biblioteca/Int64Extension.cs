using System.Runtime.CompilerServices;

namespace Biblioteca
{
    public static class Int64Extension
    {
        public static int ContarCantidadDeDigitos(this long numero)
        {
            string digitosString = numero.ToString();
            int contador = 0;

            if(numero != 0)
            {
                digitosString = digitosString.Replace("-","");

                foreach (char digito in digitosString)
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}