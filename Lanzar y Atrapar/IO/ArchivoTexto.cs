using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace IO
{
    static class ArchivoTexto
    {
        public static void Guardar(string ruta, string texto)
        {
            try
            {
                using(StreamWriter  sw = new StreamWriter(ruta))
                {
                    sw.Write(texto);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static string Leer(string ruta)
        {
            try
            {
                string retorno = String.Empty;

                if(File.Exists(ruta))
                {
                    using(StreamReader sr = new StreamReader(ruta))
                    {
                        retorno = sr.ReadToEnd();
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }

                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
