using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    [TestClass]
    public class PuntoTxtTest
    {
        [TestMethod]
        public void ValidarExtension_RetornaTrue_CuandoLaExtensionEsXml()
        {
            // Arrange
            PuntoTxt puntoJson = new PuntoTxt();

            // Act
            bool retorno = puntoJson.ValidarExtension("archivo.txt");

            // Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarExtension_LanzaArchivoInvalidoException_CuandoLaExtensionNoEsJson()
        {
            // Arrange
            PuntoTxt puntoJson = new PuntoTxt();

            // Act
            bool retorno = puntoJson.ValidarExtension("archivo.json");
        }
    }
}
