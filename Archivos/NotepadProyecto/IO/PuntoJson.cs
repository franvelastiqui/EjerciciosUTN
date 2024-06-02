using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IO
{
    public class PuntoJson<T> : Archivo, IArchivo<T> where T : class
    {
        protected override string Extension
        {
            get
            {
                return ".json";
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
            if(ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using(StreamReader sr = new StreamReader(ruta))
                {
                    string jsonString = sr.ReadToEnd();

                    return JsonSerializer.Deserialize<T>(jsonString);
                }
            }

            return null;
        }

        private void Serializar(string ruta, T contenido)
        {
            using(StreamWriter sw = new(ruta))
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;

                string jsonString = JsonSerializer.Serialize(contenido);

                sw.WriteLine(jsonString);
            }
        }
    }

}
