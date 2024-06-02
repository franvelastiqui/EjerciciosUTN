using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Centralita
{
    public class Local : Llamada, IGuardar<Local>
    {
        protected float costo;
        private string ruta;

        public Local()
        {

        }

        public Local(float duracion, string nroDestino, string nroOrigen, float costo)
        : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
            string rutaDirectorios = Path.Combine(Directory.GetCurrentDirectory(), "Llamadas Locales");
            ruta = Path.Combine(rutaDirectorios, $"Llamada N{CantidadLlamadas+1} - Local.xml");
        }

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


        public Local(Llamada llamada, float costo)
        : this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, costo)
        {

        }

        protected override string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine("Llamada Local");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {CostoLlamada.ToString("N2")}");

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return costo * duracion;
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Local);
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public bool Guardar()
        {
            string archivo = Path.Combine(RutaDeArchivo);

            using(StreamWriter sw = new StreamWriter(archivo))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Local));

                serializer.Serialize(sw, this);

                return true;
            }
        }

        public Local Leer()
        {
            using(StreamReader sr = new StreamReader(RutaDeArchivo))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Local));

                try
                {
                    return deserializer.Deserialize(sr) as Local;
                }
                catch
                {
                    throw new InvalidCastException();
                }
            }
        }
    }
}
