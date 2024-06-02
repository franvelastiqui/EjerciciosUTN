using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTest
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            //Arrange
            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            PaqueteFragil pF = new("BF1", 100, "Rosario", "Bernal", 20);
            PaquetePesado pP = new("BF2", 50, "Escobar", "Lobos", 60);
            List<Paquete> paquetes = new List<Paquete>
            {
                pP,
                pF
            };

            //Act
            gestionImpuestos.RegistrarImpuestos(paquetes);
            decimal expected = 52.5M;

            decimal actual = gestionImpuestos.CalcularTotalImpuestosAduana();

            //Assert
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            //Arrange
            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            PaqueteFragil pF = new("BF1", 100, "Rosario", "Bernal", 20);
            PaquetePesado pP = new("BF2", 50, "Escobar", "Lobos", 60);
            PaquetePesado pP2 = new("BF2", 10, "Escobar", "Lobos", 60);
            List<Paquete> paquetes = new List<Paquete>
            {
                pP,
                pF,
                pP2
            };

            //Act
            gestionImpuestos.RegistrarImpuestos(paquetes);
            decimal expected = 15;

            decimal actual = gestionImpuestos.CalcularTotalImpuestosAfip();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
