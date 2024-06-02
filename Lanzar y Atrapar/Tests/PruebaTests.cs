namespace Tests
{
    [TestClass]
    public class PruebaTests
    {
        [TestMethod]
        [ExpectedException (typeof (DivideByZeroException))]
        public void MiMetodoDeMiClase_CuandoSeLlamaAlMetodo_DeberiaLanzarDivideByZeroException()
        {
            //Act
            MiClase.MiMetodo();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void MiClase_CuandoSeLlamaAlConstructor_DeberiaLanzarUnaExcepcion()
        {
            //Act
            MiClase miClase = new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void MiMetodoDeMiOtraClase_CuandoSeLlamaAlMetodo_DeberiaLanzarMiExcepcion()
        {
            //Arrange
            MiOtraClase miOtraClase = new MiOtraClase();

            //Act
            miOtraClase.MiMetodo();
        }
    }
}