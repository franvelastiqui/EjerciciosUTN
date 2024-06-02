namespace Biblioteca
{
    public static class Calculadora
    {
        public static int Add(string numeros)
        {
            int resultado = 0;

            if (!String.IsNullOrWhiteSpace(numeros))
            {
                string[] numerosSplit = numeros.Split(new char[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                if (numerosSplit.Length == 1 )
                {
                    resultado  = int.Parse(numerosSplit[0]);
                }
                else if (numerosSplit.Length > 1)
                {
                    foreach (string numero in numerosSplit)
                    {
                        resultado += int.Parse(numero);
                    }
                }
            }

            return resultado;
        }
    }
}