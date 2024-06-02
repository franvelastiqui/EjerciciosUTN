using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTest
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            //Arrange
            PaquetePesado paquetePesado = new("BF100", 5, "Rosario", "Jujuy", 3);
            decimal expected = 8;

            //Act
            decimal actual = paquetePesado.AplicarImpuestos();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Impuestos_CuandoEsImplementacionExplicitaAfip_DeberiaRetornarValoImpuestoDel25PorcientoSobreCostoDeEnvio()
        {
            //Arrange
            PaquetePesado paquetePesado = new("BF100", 5, "Rosario", "Jujuy", 3);
            IAfip afip = paquetePesado;
            decimal expected = 1.25M;

            //Act
            decimal actual = afip.Impuestos;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Impuestos_CuandoEsImplementacionImplicita_DeberiaRetornarValoImpuestoDel35PorcientoSobreCostoDeEnvio()
        {
            //Arrange
            PaquetePesado paquetePesado = new("BF100", 5, "Rosario", "Jujuy", 3);
            decimal expected = 1.75M;

            //Act
            decimal actual = paquetePesado.Impuestos;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            //Arrange
            PaquetePesado paquetePesado = new("BF100", 5, "Rosario", "Jujuy", 3);

            //Assert
            Assert.IsFalse(paquetePesado.TienePrioridad);
        }
    }
}
