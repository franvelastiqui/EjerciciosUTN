using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Suscriptor
    {
        private int id;
        private string nombre;

        public Suscriptor(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int Id => id;
        public string Nombre => nombre;

        //Cuando se lanze el evento, se ejecuta este código porque se lo asoció al evento
        public void RecibirNovedad(Newsletter sender, NewsletterEventArgs novedades)
        {
            using(SqlConnection connection = new(@"Data Source = .;Database = UTN_DB;Trusted_Connection = True;"))
            {
                string commandText = "INSERT INTO NOVEDADES (tema, contenido, id_usuario) VALUES (@tema, @contenido, @id)";
                SqlCommand cmd = new(commandText, connection);
                cmd.Parameters.AddWithValue("@tema", sender.Tema);
                cmd.Parameters.AddWithValue("@contenido", novedades.Contenido);
                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();

                cmd.ExecuteNonQuery();
            }

        }
    }
}
