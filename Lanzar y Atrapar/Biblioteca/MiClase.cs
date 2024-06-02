using System.Linq.Expressions;

namespace Biblioteca
{
    public class MiClase
    {
        private MiClase(int numero)
        {
            try
            {
                MiMetodo();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public MiClase()
        {
            try
            {
                MiClase clase = new MiClase(0);
            }
            catch (Exception e)
            {
                throw new UnaExcepcion(e);
            }
        }

        public static void MiMetodo()
        {
            throw new DivideByZeroException();
        }
    }
}