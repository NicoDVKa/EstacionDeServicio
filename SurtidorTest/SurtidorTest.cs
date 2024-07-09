using ModuloPlayero;
using ModuloSurtidor;


namespace ModuloSurtidorTests
{
    internal class SurtidorTest
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
            Playero nuevoPlayero = new Playero("a","a","a",1,1);

            //ACT
            surtidor.CambiarPlayero(nuevoPlayero);

            //ASSERT
            Assert.That(surtidor.PlayeroAsignado, Is.EqualTo(nuevoPlayero));
        }

        [Test]
        public void InicializacionDelNroDeSurtidorTest()
        {
            //ARRANGE
            Surtidor nuevoSurtidor = new Surtidor();
            cantidadSurtidores++;

            //ASSERT
            Assert.That(nuevoSurtidor.Nro, Is.EqualTo(cantidadSurtidores));
        }

        [Test]
        public void CambiarEstadoTest()
        {
            surtidor.CambiarEstado();

            Assert.IsFalse(surtidor.Estado);

            surtidor.CambiarEstado();

            Assert.IsTrue(surtidor.Estado);
        }

        [Test]
        public void CambiarPrecioPorLitro()
        {
            //ARRANGE
            double nuevoPrecio = 10.5;
            
            //ACT
            surtidor.CambiarPrecioPorLitro(nuevoPrecio);

            //ASSERT
            Assert.That(surtidor.PrecioCombustiblePorLitro, Is.EqualTo(nuevoPrecio));
        }

        [Test]
        public void CambiarLitrosParcialesPorVenta()
        {
            //ARRANGE
            double nuevoLitroParcial = 10.5;

            //ACT
            surtidor.LitrosPorVenta(nuevoLitroParcial);

            //ASSERT
            Assert.That(surtidor.CantidadLitrosParcialesPorVenta, Is.EqualTo(nuevoLitroParcial));
        }

    }
}
