namespace Tests
{
    [TestClass]
    public class CarrerasTests
    {
        [TestMethod]
        public void Competencia_CuandoSeInstanciaUnObjeto_DeberiaEstarInstanciadaListaCompetidores()
        {
            //Arrange
            Competencia<AutoF1> competencia = new(3, 2, TipoCompetencia.F1);

            //Assert
            Assert.IsNotNull(competencia.Competidores);
        }

        //[TestMethod]
        //[ExpectedException(typeof(CompetenciaNoDisponibleException))]
        //public void OperadorMas_CuandoSeCargaUnAutoF1EnCompetenciaMotoCross_DeberiaLanzarExcepcionCompetenciaNoDisponible()
        //{
        //    //Arrange
        //    Competencia competencia = new(3, 2, TipoCompetencia.MotoCross);
        //    AutoF1 auto = new(1, "2");

        //    //Act
        //    _ = competencia + auto;
        //}

        [TestMethod]
        public void OperadorMas_CuandoSeCargaUnaMotoEnCompetenciaMotoCross_DeberiaNuncaLanzarExcepcionCompetenciaNoDisponible()
        {
            //Arrange
            Competencia<MotoCross> competencia = new(3, 2, TipoCompetencia.MotoCross);
            MotoCross moto = new(1, "escudo", 20);
            CompetenciaNoDisponibleException actual = null;

            //Act
            try
            {
                _ = competencia + moto;
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                actual = ex;
            }

            //Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void OperadorMas_CuandoSeCargaUnVehículoEnLaCompetencia_DeberiaMostrarloEnLaLista()
        {
            //Arrange
            Competencia<MotoCross> competencia = new(3, 2, TipoCompetencia.MotoCross);
            MotoCross moto = new(1, "escudo", 20);

            //Act
            _ = competencia + moto;

            //Arrange
            CollectionAssert.Contains(competencia.Competidores, moto);
        }

        [TestMethod]
        public void OperadorMas_CuandoSeQuitaUnVehículoDeLaCompetencia_DeberiaQuitarloDeLaLista()
        {
            //Arrange
            Competencia<MotoCross> competencia = new(3, 2, TipoCompetencia.MotoCross);
            MotoCross moto = new(1, "escudo", 20);
            _ = competencia + moto;

            //Act
            _ = competencia - moto;

            //Arrange
            Assert.IsTrue(competencia != moto);
        }
    }
}