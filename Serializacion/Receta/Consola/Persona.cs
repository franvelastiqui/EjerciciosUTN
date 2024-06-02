using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Consola
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona()
        {
        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        private string Archivo
        {
            get
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                string rutaArchivo = Path.Combine(ruta, "archivo.xml");

                return rutaArchivo;
            }
        }

        public void GuardarXML()
        {
            try
            {
                using (StreamWriter sw = new(Archivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));

                    xmlSerializer.Serialize(sw, this);
                }
            }
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine(MostrarMensajeExcepcion(ex, "Error al escribir el archivo de texto XML"));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(MostrarMensajeExcepcion(ex, "No hay un constructor sin parámetros"));
            }
        }

        public Persona LeerXML()
        {
            try
            {
                using(StreamReader sr = new StreamReader(Archivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));

                    return xmlSerializer.Deserialize(sr) as Persona;
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(MostrarMensajeExcepcion(ex, "Error al leer el archivo de texto XML"));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(MostrarMensajeExcepcion(ex, "No hay un constructor sin parámetros"));
            }
            return null;
        }

        public string GuardarJSON()
        {
            try
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;

                string jsonString = JsonSerializer.Serialize(this, opciones);

                return jsonString;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(MostrarMensajeExcepcion(ex, "Error al escribir el archivo de texto XML"));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(MostrarMensajeExcepcion(ex, "No hay un constructor sin parámetros"));
            }

            return "";
        }

        public Persona LeerJSON(string json)
        {
            try
            {
                Persona persona = JsonSerializer.Deserialize<Persona>(json);

                return persona;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(MostrarMensajeExcepcion(ex, "Error al leer el archivo de texto XML"));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(MostrarMensajeExcepcion(ex, "No hay un constructor sin parámetros"));
            }
            return null;
        }

        public override string ToString()
        {
            return $"{nombre} - {apellido}";
        }

        private string MostrarMensajeExcepcion(Exception ex, string mensaje)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{ex.Message}");
            sb.AppendLine(mensaje);
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
