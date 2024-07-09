
using ModuloPlayero;

namespace ModuloSurtidor
{
    public class Surtidor
    {
        private static uint CantidadSurtidores = 0;

        public Surtidor(TipoCombustible tipo)
        {
            CantidadSurtidores++;
            this.Nro = CantidadSurtidores;
   
            this.TipoCombustible = tipo;
        }

        public Surtidor()
        {
            CantidadSurtidores++;
            this.Nro = CantidadSurtidores;
        }
        
        public uint Nro;
        public Boolean Estado = true; 
        public Playero? PlayeroAsignado;
        public TipoCombustible TipoCombustible = TipoCombustible.Infinia;
        public double? PrecioCombustiblePorLitro = 1; 
        public double? Stock = 0; 
        public double? CantidadLitrosParcialesPorVenta = 0; 
        public double? MontoVenta = 0; 
        public double? CantidadLitrosVendidosEnElDia = 0; 

        
        public void CambiarEstado()
        {
            Estado = !Estado;
        }
        
        public void CambiarPlayero(Playero playero)
        {
            this.PlayeroAsignado = playero;
        }

        public void CambiarPrecioPorLitro(double nuevoPrecio)
        {
            this.PrecioCombustiblePorLitro = nuevoPrecio;
        }

        public void BajarStock(double litros)
        {
            this.Stock = this.Stock - litros;
        }

        public void SubirStock(double litros)
        {
            this.Stock = this.Stock + litros;
        }

        public void LitrosPorVenta(double litros)
        {
            this.CantidadLitrosParcialesPorVenta = litros;
        }

        public void CalcularMonto()
        {
            this.MontoVenta = this.PrecioCombustiblePorLitro * CantidadLitrosParcialesPorVenta;
        }

        public void CalcularLitrosVendidosEnElDia()
        {
            this.CantidadLitrosVendidosEnElDia = this.CantidadLitrosVendidosEnElDia + CantidadLitrosParcialesPorVenta;
        }
    }
    
}
