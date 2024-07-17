
using ModuloSurtidor;
using ModuloPlayero;
using ModuloPromocion;


namespace ModuloAdministracion
{
    public class Administracion
    {

        public readonly List<Surtidor> _surtidores;
        public readonly List<Playero> _playeros;


        public Administracion(List<Surtidor> surtidores, List<Playero> playeros)
        {
            _surtidores = surtidores;
            _playeros = playeros;
        }

        public void DineroRecaudadoPorLaEstacionDeServicio()
        {
            double? total = 0;

            foreach (var surtidor in _surtidores)
            {
                total += surtidor.MontoTotalVenta;
            }

            Console.WriteLine($"Monto total recaudado por la estacion de servicio: {total.ToString()}");
        }

        public void DineroRecaudadoDeCadaSurtidor() 
        {
            Console.WriteLine("Listado de surtidores:");
            foreach(var surtidor in _surtidores)
            {
                if (surtidor.Estado)
                {
                    Console.WriteLine($"Surtidor={surtidor.Nro} - Tipo Combustible {surtidor.TipoCombustible} - Recaudacion:{surtidor.MontoTotalVenta}");
                }
            }

        }

        public void DineroRecaudadoDeCadaPlayero()
        {

            Console.WriteLine("Listado de playeros: ");
            for (int i = 0; i < _playeros.Count; i++)
   
            {
                Console.WriteLine($"{i}- {_playeros[i].Nombre} {_playeros[i].Apellido} - {_playeros[i].MontoTotalVentas}");
            }
        }

        public void DineroAhorradoPorClientesAnteCargaDeCombustibleConPromociones() {

            Console.WriteLine($"Monto total por descuento en ventas de promociones: {PromocionControlador.DescuentoPromocion}");
        
        }


    }
}
