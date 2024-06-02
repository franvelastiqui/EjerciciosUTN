namespace PaqueteTest
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            //Arrange
            PaqueteFragil paqueteFragil = new("BF100", 5, "Rosario", "Jujuy", 3);
            decimal expected = 6.75M;

            //Act
            decimal actual = paqueteFragil.AplicarImpuestos();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoDeEnvio()
        {
            //Arrange
            PaqueteFragil paqueteFragil = new("BF100", 5, "Rosario", "Jujuy", 3);
            decimal expected = 1.75M;

            //Act
            decimal actual = paqueteFragil.Impuestos;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //Arrange
            PaqueteFragil paqueteFragil = new("BF100", 5, "Rosario", "Jujuy", 3);

            //Assert
            Assert.IsTrue(paqueteFragil.TienePrioridad);
        }
    }
}