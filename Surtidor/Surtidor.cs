
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
        
        public uint Nro;
        public Boolean Estado; 
        public Playero? PlayeroAsignado; // Crear Clase Playero  <--
        public TipoCombustible TipoCombustible;
        public double? PrecioCombustiblePorLitro; 
        public double? Stock; 
        public double? CantidadLitrosParcialesPorVenta; 
        public double? MontoVenta; 
        public double? CantidadLitrosVendidosEnElDia; 

        
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
