using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return titular;
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Titular: {GetTitular()}");
            sb.AppendLine($"Dinero en cuenta: ${GetCantidad()}");

            return sb.ToString();
        }

        public void Ingresar (decimal montoAIngresar)
        {
            if( montoAIngresar > 0 )
            {
                cantidad += montoAIngresar;
            }
        }
        public void Retirar(decimal montoARetirar)
        {
            cantidad -= montoARetirar;
        }
    }
}