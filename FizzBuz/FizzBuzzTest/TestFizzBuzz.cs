namespace FizzBuzzTest
{
    [TestClass]
    public class TestFizzBuzz
    {
        [TestMethod]
        public void FizzBuzz_CuandoEsDivisibleSoloPorTres_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 6;
            string expected = "Fizz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FizzBuzz_CuandoEsDivisibleSoloPorCinco_DeberiaRetornarBuzz()
        {
            //Arrange
            int numero = 10;
            string expected = "Buzz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuandoEsDivisiblePorTresYCinco_DeberiaRetornarFizzBuzz()
        {
            //Arrange
            int numero = 30;
            string expected = "Fizz Buzz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuandoNoEsDivisiblePorTresOCinco_DeberiaRetornarNumero()
        {
            //Arrange
            int numero = 7;
            string expected = numero.ToString();

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}