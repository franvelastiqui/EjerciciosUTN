using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class JuegoDAO
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static JuegoDAO()
        {
            cadenaConexion = @"Data Source=DESKTOP-FFTBHH9;Initial Catalog=UTN_DB;Integrated Security=True";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static void Eliminar(int codigoJuego)
        {
            try
            {
                AbrirConexion();
                comando.CommandText = "DELETE FROM JUEGOS WHERE CODIGO_JUEGO = @id";
                comando.Parameters.AddWithValue("@id", codigoJuego);
                comando.ExecuteNonQuery();

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

        public static void Modificar(Juego juego)
        {
            try
            {
                AbrirConexion();
                comando.CommandText = "UPDATE JUEGOS SET NOMBRE = @nombre, PRECIO = @precio, GENERO = @genero WHERE CODIGO_JUEGO = @id";
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                comando.Parameters.AddWithValue("@id", juego.CodigoJuego);
                comando.ExecuteNonQuery();

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

        public static void Guardar(Juego juego)
        {
            try
            {
                AbrirConexion();
                comando.CommandText = "INSERT INTO JUEGOS(CODIGO_USUARIO, NOMBRE, PRECIO, GENERO) VALUES (@codigo, @nombre, @precio, @genero)";
                comando.Parameters.AddWithValue("@codigo", juego.CodigoUsuario);
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                comando.ExecuteNonQuery();

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

        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> bibliotecas = new List<Biblioteca>();

            try
            {
                AbrirConexion();
                comando.CommandText = "SELECT j.CODIGO_JUEGO, j.GENERO, j.NOMBRE, u.USERNAME FROM JUEGOS j INNER JOIN USUARIOSJUEGO u ON j.CODIGO_USUARIO = u.CODIGO_USUARIO";
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    bibliotecas.Add(new Biblioteca(reader["USERNAME"].ToString(), reader["GENERO"].ToString(), reader["NOMBRE"].ToString(), Convert.ToInt32(reader["CODIGO_JUEGO"])));
                }

                return bibliotecas;
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

        public static Juego LeerPorId(int codigoJuego)
        {
            Juego juego  =null;

            try
            {
                AbrirConexion();
                comando.CommandText = "SELECT * FROM JUEGOS WHERE CODIGO_JUEGO = @id";
                comando.Parameters.AddWithValue("@id", codigoJuego);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    juego = new(reader["NOMBRE"].ToString(), Convert.ToDouble(reader["PRECIO"]), reader["GENERO"].ToString(), Convert.ToInt32(reader["CODIGO_USUARIO"]));
                }

                //juego = new(reader["NOMBRE"].ToString(), Convert.ToDouble(reader["PRECIO"]), reader["GENERO"].ToString(), Convert.ToInt32(reader["CODIGO_USUARIO"]));

                return juego;
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
