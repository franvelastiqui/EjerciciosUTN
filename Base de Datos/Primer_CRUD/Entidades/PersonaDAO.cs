using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PersonaDAO
    {
        static string connectionString;
        static SqlConnection connection; // Puente.
        static SqlCommand command;      // Quien lleva la consulta.
        static SqlDataReader reader;   // Quien trae los datos.

        static PersonaDAO()
        {
            connectionString = @"Data Source=.;Initial Catalog=UTN_DB;Integrated Security = True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static void Guardar(Persona persona)
        {
            try
            {
                AbrirConexion();
                command.CommandText = "INSERT INTO Persona(Nombre, Apellido) VALUES (@nombre, @apellido)";
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@apellido", persona.Apellido);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                AbrirConexion();
                command.CommandText = "SELECT * FROM Persona";
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    personas.Add(new Persona(Convert.ToInt32(reader["ID"]), reader["Nombre"].ToString(), reader["Apellido"].ToString()));
                }

                return personas;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Persona LeerPorID(int id)
        {
            Persona persona;

            try
            {
                AbrirConexion();
                command.CommandText = "SELECT * FROM Persona WHERE ID = @id";
                command.Parameters.AddWithValue("@id", id);
                reader = command.ExecuteReader();

                persona = new (Convert.ToInt32(reader["ID"]), reader["Nombre"].ToString(), reader["Apellido"].ToString());

                return persona;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Modificar(Persona nuevaPersona)
        {
            try
            {
                AbrirConexion();
                command.CommandText = "UPDATE Persona SET Nombre = @nombre, Apellido = @apellido WHERE ID = @id";
                command.Parameters.AddWithValue("@nombre", nuevaPersona.Nombre);
                command.Parameters.AddWithValue("@apellido", nuevaPersona.Apellido);
                command.Parameters.AddWithValue("@id", nuevaPersona.Id);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Borrar(int id)
        {
            try
            {
                AbrirConexion();
                command.CommandText = "DELETE FROM Persona WHERE ID = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        private static void AbrirConexion()
        {
            command.Parameters.Clear();
            connection.Open();
        }
    }
}
