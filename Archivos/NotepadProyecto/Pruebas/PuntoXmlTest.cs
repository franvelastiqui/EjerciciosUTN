using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    [TestClass]
    public class PuntoXmlTest
    {
        [TestMethod]
        public void ValidarExtension_RetornaTrue_CuandoLaExtensionEsXml()
        {
            // Arrange
            PuntoXml<string> puntoJson = new PuntoXml<string>();

            // Act
            bool retorno = puntoJson.ValidarExtension("archivo.xml");

            // Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarExtension_LanzaArchivoInvalidoException_CuandoLaExtensionNoEsJson()
        {
            // Arrange
            PuntoXml<string> puntoJson = new PuntoXml<string>();

            // Act
            bool retorno = puntoJson.ValidarExtension("archivo.txt");
        }
    }
}
