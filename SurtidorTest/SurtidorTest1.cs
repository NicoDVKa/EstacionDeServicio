using ModuloPlayero;
using ModuloSurtidor;


namespace ModuloSurtidorTests
{
    internal class SurtidorTest1
    {
        Surtidor surtidor;
        double stock;
        Playero playero;
        int cantidadSurtidores = 0;

        [SetUp]
        public void Setup()
        {
            surtidor = new Surtidor(TipoCombustible.Infinia);
            playero = new Playero("x", "x", "x", 1, 1);
            stock = 100;
            surtidor.Stock = stock;
            surtidor.PlayeroAsignado = playero;
            cantidadSurtidores++;
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

        [Test]
        public void CambioPlayeroTest()
        {
            //ARRANGE
            Playero nuevoPlayero = new Playero("x","x","x",1,1);

            //ACT
            surtidor.CambiarPlayero(nuevoPlayero);

            //ASSERT
            Assert.That(surtidor.PlayeroAsignado, Is.EqualTo(nuevoPlayero));
        }

        [Test]
        public void VerificarCantidadDeSurtidores()
        {
            //ASSERT
            Assert.That(surtidor.Nro, Is.EqualTo(cantidadSurtidores));
        }


    }
}
