using System.Data.Common;
using System.Text;
using System.Xml.Serialization;

namespace Centralita
{
    [XmlInclude(typeof(Local))]
    [XmlInclude(typeof(Provincial))]
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public Llamada()
        {
        }

        public abstract float CostoLlamada { get; set; }

        public float Duracion { get => duracion; set => duracion = value; }
        public string NroDestino { get => nroDestino; set => nroDestino = value; }
        public string NroOrigen { get => nroOrigen; set => nroOrigen = value; }

        protected int CantidadLlamadas
        {
            get
            {
                string[] lineas = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), $"Bitácora.txt"));

                return lineas.Length;
            }
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)(llamada1.duracion - llamada2.duracion);
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Duracion: {duracion}");
            sb.AppendLine($"Destino: {nroDestino}");
            sb.Append($"Origen: {nroOrigen}");

            return sb.ToString();
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
    }
}