namespace Tests
{
    [TestClass]
    public class JuegoDAOTest
    {
        [TestMethod]
        public void Leer_CuandoSeLlamaAlMetodo_DeberiaLeerListaDeBD()
        {
            List<Biblioteca> biblioteca;

            biblioteca = JuegoDAO.Leer();
        }
    }
}