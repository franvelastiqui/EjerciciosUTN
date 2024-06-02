using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivo<string>
    {
        protected override string Extension
        {
            get
            {
                return ".txt";
            }
        }

        public void Guardar(string ruta, string contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                GuardarArchivo(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, string contenido)
        {
            if (ValidarExtension(ruta))
            {
                GuardarArchivo(ruta, contenido);
            }
        }

        public string Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    return sr.ReadToEnd();
                }
            }

            return string.Empty;
        }

        private void GuardarArchivo(string ruta, string contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                streamWriter.WriteLine(contenido);
            }
        }
    }
}
