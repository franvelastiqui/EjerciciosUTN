using System.Text;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new("Juan", "Perez");
            Persona personajson = new("Maria", "Lopez");

            persona.GuardarXML();

            try
            {
                Persona persona2 = persona.LeerXML();
                Console.WriteLine($"XML\n{persona2}");

                string json = personajson.GuardarJSON();
                Persona personajson2 = persona2.LeerJSON(json);
                Console.WriteLine($"JSON\n{personajson2}");

            }
            catch (NullReferenceException ex)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"{ex.Message}");
                sb.AppendLine("Argumento null");
                sb.AppendLine();

                Console.WriteLine(sb.ToString());
            }
        }
    }
}