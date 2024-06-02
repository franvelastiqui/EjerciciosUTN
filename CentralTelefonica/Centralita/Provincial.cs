using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Centralita
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;
        private string ruta;

        public Provincial()
        {

        }

        public Provincial(float duracion, string nroDestino, string nroOrigen, Franja franja)
        : base(duracion, nroDestino, nroOrigen)
        {
            franjaHoraria = franja;
            string rutaDirectorios = Path.Combine(Directory.GetCurrentDirectory(), "Llamadas Provinciales");
            ruta = Path.Combine(rutaDirectorios, $"Llamada N{CantidadLlamadas+1} - Provincial.xml");
        }

        public Provincial(Franja franja, Llamada llamada)
        : this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, franja) { }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
            set
            {
            }
        }

        public string RutaDeArchivo
        {
            get
            {
                return ruta;
            }
            set
            {
                ruta = value;
            }
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine("Llamada Provincial");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {CostoLlamada}");
            sb.AppendLine($"Franja: {franjaHoraria}");

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float costo = 0;

            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    costo = duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    costo = duracion * 0.66f;
                    break;
                default:
                    break;
            }

            return costo;
        }
        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Provincial);
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public bool Guardar()
        {
            string archivo = Path.Combine(RutaDeArchivo);

            using (StreamWriter sw = new StreamWriter(archivo))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Provincial));

                serializer.Serialize(sw, this);

                return true;
            }
        }

        public Provincial Leer()
        {
            using (StreamReader sr = new StreamReader(RutaDeArchivo))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Provincial));

                try
                {
                    return deserializer.Deserialize(sr) as Provincial;
                }
                catch
                {
                    throw new InvalidCastException();
                }
            }
        }
    }

}
