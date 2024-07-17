

using ModuloPlayero;
using ModuloPromocion;


namespace ModuloSurtidor
{
    public class SurtidorControlador
    {

        public readonly List<Surtidor> _surtidores;
        public PlayeroControlador playeroControlador;


        public SurtidorControlador(PlayeroControlador playeroControlador)
        {
            _surtidores = new List<Surtidor>();

            this.playeroControlador = playeroControlador;
            
        }

        public void AgregarSurtidor(TipoCombustible tipoCombustible, double cantidadCombustible, double precioCombustiblePorLitro)
        {
            var nuevo_surtidor = new Surtidor(tipoCombustible, cantidadCombustible, precioCombustiblePorLitro);

            _surtidores.Add(nuevo_surtidor);
            Console.WriteLine("Se ha creado un surtidor!");
            Console.WriteLine("Recuerda asignarle un playero!");

        }


        public void ListarSurtidores() {



            if (_surtidores.Count == 0) 
            {
                Console.WriteLine("No hay surtidores disponibles");
                return;

             }

            foreach (var surtido in _surtidores)
            {
                Console.WriteLine(surtido.ToString());
            }

        }



        public void VerCantidadDeLitrosVendidos(int nroSurtidor)

        {

            var surtidor = _surtidores.Find(s => s.Nro == nroSurtidor);

            if (surtidor == null) { Console.WriteLine("No se encontró surtidor"); return; }

            Console.WriteLine($"Litros vendidos por surtirdor nro {nroSurtidor} es: {surtidor.CantidadLitrosVendidosEnElDia}");
        
        }



        public void CargarCombustible(Surtidor surtidor, double litros, double? promocion = null) {


            if(!surtidor.Estado)
            {
                Console.WriteLine("El surtirdor no está disponible");
                return;
            }

            surtidor.CambiarEstado();

            try
            {
               
                double? montoVenta = surtidor.CalcularMontoDeVenta(litros);
                
                surtidor.BajarStock(litros);
                surtidor.LitrosPorVenta(litros);
                surtidor.CalcularLitrosVendidosEnElDia();

                Pagar_DesocuparSurtidor(montoVenta, surtidor);

                if (promocion != null)
                {
                    var descuento = litros * surtidor.PrecioCombustiblePorLitro * (promocion / 100);
                    var montoFinal = montoVenta - descuento;
                    
                    PromocionControlador.DescuentoPromocion += descuento;
                    Console.WriteLine($"El monto total de la venta con descuento es: {montoFinal}.");
                  
                }
                else { Console.WriteLine($"El monto total de la venta es: {montoVenta}."); }

            }
            catch(StockException ex)
            {
                Console.WriteLine(ex);
            }
            
     

        
        }



        public void Pagar_DesocuparSurtidor(double? monto, Surtidor surtidor) {

            surtidor.MontoTotalVenta += monto;
            Playero? playeroAsignado = this.playeroControlador._playeros.Find(s => s.DNI == surtidor.PlayeroAsignado?.DNI);
            playeroAsignado?.CalcularMontoTotalVentas(monto);
            surtidor.CambiarEstado();

  
        }
    }
}
