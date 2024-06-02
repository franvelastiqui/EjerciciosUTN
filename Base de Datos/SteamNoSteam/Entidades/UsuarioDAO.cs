using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class UsuarioDAO
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static UsuarioDAO()
        {
            cadenaConexion = @"Data Source=DESKTOP-FFTBHH9;Initial Catalog=UTN_DB;Integrated Security=True";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                AbrirConexion();
                comando.CommandText = "SELECT USERNAME, CODIGO_USUARIO FROM USUARIOSJUEGO";
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    usuarios.Add(new Usuario(reader["USERNAME"].ToString(), Convert.ToInt32(reader["CODIGO_USUARIO"])));
                }

                return usuarios;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        private static void AbrirConexion()
        {
            conexion.Open();
            comando.Parameters.Clear();
        }
    }
}
