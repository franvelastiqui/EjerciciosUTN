namespace Pruebas
{
    [TestClass]
    public class Int64ExtensionTest
    {
        [TestMethod]
        public void ContarCantidadDeDigitos_CuandoLePasamosCero_DeberiaRetornarCero()
        {
            //Arrange
            long numero = 0;
            int expected = 0;

            //Act
            int actual = numero.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContarCantidadDeDigitos_CuandoLePasamosUno_DeberiaRetornarUno()
        {
            //Arrange
            long numero = 1;
            int expected = 1;

            //Act
            int actual = numero.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContarCantidadDeDigitos_CuandoLePasamosCien_DeberiaRetornarTres()
        {
            //Arrange
            long numero = 100;
            int expected = 3;

            //Act
            int actual = numero.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContarCantidadDeDigitos_CuandoLePasamosDiezNegativo_DeberiaRetornarDos()
        {
            //Arrange
            long numero = -10;
            int expected = 2;

            //Act
            int actual = numero.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}