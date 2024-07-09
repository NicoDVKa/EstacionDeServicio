

using ModuloPlayero;

namespace ModuloPlayeroTests
{
    internal class PlayeroTest
    {
        Playero playero;
        int horasTrabajadas = 2;

        [SetUp]
        public void SetUp()
        {
            playero = new Playero("x","x","x",1,horasTrabajadas);
            playero.MontoTotalVentas = 100;

        }

        [Test]
        public void CambiarSoloHorarioEntrada()
        {
            //ARRANGE
            int nuevoHorarioEntrada = 4;
            int nuevoHorarioSalida = nuevoHorarioEntrada + 8;

            //ACT
            playero.CambiarHorarioEntrada(nuevoHorarioEntrada);

            //ASSERT
            Assert.That(playero.HorarioEntrada, Is.EqualTo(nuevoHorarioEntrada));
            Assert.That(playero.HorarioSalida, Is.EqualTo(nuevoHorarioSalida));
        }

        [Test]
        public void CambiarSoloHorasTrabajadas()
        {
            //ARRANGE
            int nuevaCantidadDeHorasTrabajadas = 4;
            int horarioSalidaEsperado = playero.HorarioEntrada + nuevaCantidadDeHorasTrabajadas;

            //ACT
            playero.CambiarHorarioEntrada(playero.HorarioEntrada, nuevaCantidadDeHorasTrabajadas);

            //ASSERT
            Assert.That(playero.HorarioSalida, Is.EqualTo(horarioSalidaEsperado));
        }

        [Test]
        public void CambiarMontoTotalVentas()
        {
            //ARRANGE
            double montoParcial = 50;
            double montoTotalEsperado = playero.MontoTotalVentas + montoParcial;

            //ACT
            playero.CalcularMontoTotalVentas(montoParcial);

            //ASSERT
            Assert.That(playero.MontoTotalVentas, Is.EqualTo(montoTotalEsperado));
        }
    }
}
