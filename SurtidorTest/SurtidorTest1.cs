using ModuloSurtidor;


namespace ModuloSurtidorTests
{
    internal class SurtidorTest1
    {
        Surtidor surtidor;
        double stock;

        [SetUp]
        public void Setup()
        {
            surtidor = new Surtidor(TipoCombustible.Infinia);
            stock = 100;
            surtidor.Stock = stock;
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Test ejecutado. ");
        }

        [Test]
        public void BajarStockTest()
        {
            //ARRANGE
            double cantidadABajarDeLitros = 50;
            double esperado = stock - cantidadABajarDeLitros;

            //ACT
            surtidor.BajarStock(cantidadABajarDeLitros);

            //ASSERT
            Assert.That(surtidor.Stock, Is.EqualTo(esperado));
        }

        [Test]
        public void SubirStockTest()
        {
            //ARRANGE
            double cantidadASubirDeLitros = 50;
            double esperado = stock + cantidadASubirDeLitros;

            //ACT
            surtidor.SubirStock(cantidadASubirDeLitros);

            //ASSERT
            Assert.That(surtidor.Stock, Is.EqualTo(esperado));
        }


    }
}
