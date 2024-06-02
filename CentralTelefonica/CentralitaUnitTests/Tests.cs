namespace CentralitaUnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Centralita_CuandoSeCreaUnObjetoCentralita_DeberiaInstanciarseListaLlamadas()
        {
            //Arrange

            //Act
            Centralita.Centralita centralita = new();

            //Assert
            Assert.IsNotNull(centralita.ListaLlamada);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Centralita_CuandoSeCargaSegundaLlamadaConSoloMismosDatosDeOrigenYDestinoDeLlamadaLocalExistente_DeberiaLanzarCentralitaException()
        {
            //Arrange
            Centralita.Centralita c = new Centralita.Centralita("Fede Center");
            Local l1 = new Local(30, "Bernal", "Rosario", 2.65f);
            Local l2 = new Local(36, "Bernal", "Rosario", 30f);

            //Act
            _ = c + l1;
            _ = c + l2;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Centralita_CuandoSeCargaSegundaLlamadaConSoloMismosDatosDeOrigenYDestinoDeLlamadaProvincialExistente_DeberiaLanzarCentralitaException()
        {
            //Arrange
            Centralita.Centralita c = new Centralita.Centralita("Fede Center");
            Provincial p1 = new Provincial(21, "Morón", "Bernal", Provincial.Franja.Franja_1);
            Provincial p2 = new Provincial(96, "Morón", "Bernal", Provincial.Franja.Franja_3);

            //Act
            _ = c + p1;
            _ = c + p2;
        }

        [TestMethod]
        public void Centralita_CuandoSeCarganDosLlamadasProvincialesYDosLocalesYTodasTienenMismosDatosDeDestinoYOrigen_DeberiaMostrarIgualdadSoloEntreLocalesYProvicnialesEntreSiMismas()
        {
            //Arrange
            Centralita.Centralita c = new Centralita.Centralita("Fede Center");
            Local l1 = new Local(30, "Bernal", "Rosario", 2.65f);
            Local l2 = new Local(36, "Bernal", "Rosario", 30f);
            Provincial p1 = new Provincial(21, "Bernal", "Rosario", Provincial.Franja.Franja_1);
            Provincial p2 = new Provincial(96, "Bernal", "Rosario", Provincial.Franja.Franja_3);

            //Act
            bool l1l2 = l1 == l2;
            bool l1p1 = l1 == p1;
            bool l1p2 = l1 == p2;

            bool l2p1 = l2 == p1;
            bool l2p2 = l2 == p2;

            bool p1p2 = p1 == p2;

            //Assert
            Assert.IsTrue(l1l2);
            Assert.IsFalse(l1p1);
            Assert.IsFalse(l1p2);

            Assert.IsFalse(l2p1);
            Assert.IsFalse(l2p2);
            Assert.IsTrue(p1p2);

        }
    }
}