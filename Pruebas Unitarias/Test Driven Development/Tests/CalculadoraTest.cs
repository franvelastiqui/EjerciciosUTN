namespace Tests
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Add_CuandoRecibeStringVacio_DeberiaRetornarCero()
        {
            //Arrange
            string expected = "0";

            //Act
            int actual = Calculadora.Add("");

            //Assert
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void Add_CuandoRecibeUnNumero_DeberiaRetornarMismoNumero()
        {
            //Arrange
            string expected = "1";

            //Act
            int actual = Calculadora.Add("1");

            //Assert
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void Add_CuandoRecibeUDosNumeros_DeberiaRetornarSuSuma()
        {
            //Arrange
            string expected = "6";

            //Act
            int actual = Calculadora.Add("1\n2,3");

            //Assert
            Assert.AreEqual(expected, actual.ToString());
        }
    }
}