using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IO
{
    public class PuntoXml<T> : Archivo where T : class
    {
        protected override string Extension
        {
            get
            {
                return ".xml";
            }
        }

        public void Guardar(string ruta, T contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }
        public void GuardarComo(string ruta, T contenido)
        {
            if (ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }

        public T Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using(StreamReader sr = new StreamReader(ruta))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));

                    return xml.Deserialize(sr) as T;
                }
            }

            return null;
        }

        public void Serializar(string ruta, T contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamWriter sw = new(ruta))
                {
                    XmlSerializer xml = new(typeof(T));

                    xml.Serialize(sw, contenido);
                }
            }
        }
    }
}
