using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PokedexClases
{
    public static class PokemonDAO
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static PokemonDAO()
        {
            cadenaConexion = @"Data Source=DESKTOP-FFTBHH9;Initial Catalog=UTN_DB;Integrated Security=True";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        private static void AbrirConexion()
        {
            if(conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }

            comando.Parameters.Clear();
        }

        public static List<Tipo> LeerTipos()
        {
            List<Tipo> tipos = new List<Tipo>();

            try
            {
                AbrirConexion();
                comando.CommandText = "SELECT nombre FROM Tipos";
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    tipos.Add(new Tipo(reader["nombre"].ToString()));
                }

                return tipos;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static int LeerTipoIdPorNombre(string nombre)
        {
            try
            {
                AbrirConexion();
                int id = default;

                comando.CommandText = "SELECT idTipo FROM Tipos WHERE nombre = @nombrePokemon";
                comando.Parameters.AddWithValue("@nombrePokemon", nombre);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["idTipo"]);
                }

                return id;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<Pokemon> LeerPokemon()
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            try
            {
                AbrirConexion();
                comando.CommandText = "SELECT p.id, p.nombre, t.nombre AS tipo, p.entrenador, p.urlimagen FROM Pokemon p INNER JOIN Tipos t ON p.tipo = t.idTipo";
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pokemons.Add(new Pokemon(Convert.ToInt32(reader["id"]), reader["nombre"].ToString(), reader["tipo"].ToString(), reader["entrenador"].ToString(), reader["urlimagen"].ToString()));
                }

                return pokemons;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static Pokemon LeerPokemonPorNombre(string nombre)
        {
            Pokemon pokemon = null;

            try
            {
                AbrirConexion();
                comando.CommandText = "SELECT p.id, p.nombre, t.nombre AS tipo, p.entrenador, p.urlimagen FROM Pokemon p INNER JOIN Tipos t ON p.tipo = t.idTipo WHERE p.nombre = @nombrePokemon";
                comando.Parameters.AddWithValue("@nombrePokemon", nombre);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pokemon = new(Convert.ToInt32(reader["id"]), reader["nombre"].ToString(), reader["tipo"].ToString(), reader["entrenador"].ToString(), reader["urlimagen"].ToString());
                }

                return pokemon;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static Pokemon LeerPokemonPorId(int id)
        {
            Pokemon pokemon = null;

            try
            {
                AbrirConexion();
                comando.CommandText = "SELECT p.id, p.nombre, t.nombre AS tipo, p.entrenador, p.urlimagen FROM Pokemon p INNER JOIN Tipos t ON p.tipo = t.idTipo WHERE p.id = @idPokemon";
                comando.Parameters.AddWithValue("@idPokemon", id);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pokemon = new(Convert.ToInt32(reader["id"]), reader["nombre"].ToString(), reader["tipo"].ToString(), reader["entrenador"].ToString(), reader["urlimagen"].ToString());
                }

                return pokemon;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<Pokemon> LeerPokemonPorEntrenador(string entrenador)
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            try
            {
                AbrirConexion();
                comando.CommandText = "SELECT p.id, p.nombre, t.nombre AS tipo, p.entrenador, p.urlimagen FROM Pokemon p INNER JOIN Tipos t ON p.tipo = t.idTipo WHERE entrenador = @entrenadorPokemon";
                comando.Parameters.AddWithValue("@entrenadorPokemon", entrenador);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pokemons.Add(new Pokemon(Convert.ToInt32(reader["id"]), reader["nombre"].ToString(), reader["tipo"].ToString(), reader["entrenador"].ToString(), reader["urlimagen"].ToString()));
                }

                return pokemons;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<Pokemon> LeerPokemonPorTipo(string tipo)
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            int idTipoPokemon = LeerTipoIdPorNombre(tipo);

            try
            {
                AbrirConexion();
                comando.CommandText = "SELECT p.id, p.nombre, t.nombre AS tipoP, p.entrenador, p.urlimagen FROM Pokemon p INNER JOIN Tipos t ON p.tipo = t.idTipo WHERE tipo = @tipoPok";
                comando.Parameters.AddWithValue("@tipoPok", idTipoPokemon);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pokemons.Add(new Pokemon(Convert.ToInt32(reader["id"]), reader["nombre"].ToString(), reader["tipoP"].ToString(), reader["entrenador"].ToString(), reader["urlimagen"].ToString()));
                }

                return pokemons;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<Pokemon> LeerPokemonPorRango(int rangoInicial, int rangoFinal)
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            try
            {
                AbrirConexion();
                comando.CommandText = "SELECT p.id, p.nombre, t.nombre AS tipo, p.entrenador, p.urlimagen FROM Pokemon p INNER JOIN Tipos t ON p.tipo = t.idTipo WHERE id >= @menor AND id <= @mayor";
                comando.Parameters.AddWithValue("@menor", rangoInicial);
                comando.Parameters.AddWithValue("@mayor", rangoFinal);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pokemons.Add(new Pokemon(Convert.ToInt32(reader["id"]), reader["nombre"].ToString(), reader["tipo"].ToString(), reader["entrenador"].ToString(), reader["urlimagen"].ToString()));
                }

                return pokemons;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Guardar(Pokemon pokemon)
        {
            int idTipo = LeerTipoIdPorNombre(pokemon.Tipo);

            try
            {
                AbrirConexion();
                comando.CommandText = "INSERT INTO Pokemon(id, nombre, tipo, entrenador, urlimagen) VALUES (@id, @nombre, @tipo, @entrenador, @urlimagen)";
                comando.Parameters.AddWithValue("@id", pokemon.Id);
                comando.Parameters.AddWithValue("@nombre", pokemon.Nombre);
                comando.Parameters.AddWithValue("@tipo", idTipo);
                comando.Parameters.AddWithValue("@entrenador", pokemon.Entrenador);
                comando.Parameters.AddWithValue("@urlimagen", pokemon.UrlImagen);
                comando.ExecuteNonQuery();

            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Eliminar(Pokemon pokemon)
        {
            try
            {
                AbrirConexion();
                comando.CommandText = "DELETE FROM Pokemon WHERE id = @idPokemon";
                comando.Parameters.AddWithValue("@idPokemon", pokemon.Id);
                comando.ExecuteNonQuery();

            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
