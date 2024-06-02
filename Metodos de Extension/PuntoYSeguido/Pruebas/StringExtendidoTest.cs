namespace Pruebas
{
    [TestClass]
    public class StringExtendidoTest
    {
        [TestMethod]
        public void ContarCantidadSignosDePuntuacion_CuandoNoContengaSignosPuntuacion_DeberiaRetornarCero()
        {
            //Arrange
            string texto = "texto 1998";
            int expected = 0;

            //Act
            int actual = texto.ContarCantidadSignosDePuntuacion();

            //Arrange
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContarCantidadSignosDePuntuacion_CuandoContengaUnPunto_DeberiaRetornarUno()
        {
            //Arrange
            string texto = "texto.1998";
            int expected = 1;

            //Act
            int actual = texto.ContarCantidadSignosDePuntuacion();

            //Arrange
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContarCantidadSignosDePuntuacion_CuandoContengaDosPuntoYComaYUnaComa_DeberiaRetornarTres()
        {
            //Arrange
            string texto = ",texto;1998;";
            int expected = 3;

            //Act
            int actual = texto.ContarCantidadSignosDePuntuacion();

            //Arrange
            Assert.AreEqual(expected, actual);
        }
    }
}