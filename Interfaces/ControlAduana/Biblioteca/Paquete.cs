using System.Text;

namespace Biblioteca
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        public Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public virtual bool TienePrioridad { get; }

        public decimal Impuestos
        {
            get
            {
                return costoEnvio * 0.35M;
            }
        }

        public virtual decimal AplicarImpuestos()
        {
            return costoEnvio + Impuestos;
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendLine($"Código de seguimiento: {codigoSeguimiento}");
            texto.AppendLine($"Cósto de envió: {costoEnvio.ToString("N2")}");
            texto.AppendLine($"Destino: {destino}");
            texto.AppendLine($"Orígen: {origen}");
            texto.AppendLine($"Peso: {pesoKg.ToString("N2")} kg");
            if (TienePrioridad)
            {
                texto.AppendLine("Este paquete tiene prioridad");
            }

            return texto.ToString();
        }
    }
}