namespace Entidades
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(double numeroEntero)
        {
            string binario = "";
            double resto;

            do
            {
                resto = numeroEntero % 2;

                if (resto == 0)
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }

                numeroEntero /= 2;

            } while (numeroEntero > 1);

            binario = "1" + binario;

            return binario;
        }

        public static double ConvertirBinarioADecimal(string binario)
        {
            double acumulador = 0;
            int potencia = 0;

            for (int i = binario.Length - 1; i >= 0; i--)
            {
                if (binario[i] == '1')
                {
                    acumulador += Math.Pow(2, potencia);
                }
                potencia++;
            }

            return acumulador;
        }
    }
}