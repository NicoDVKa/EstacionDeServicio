
using ModuloPlayero;

namespace ModuloSurtidor
{
    public class Surtidor
    {
        private static uint CantidadSurtidores = 0;


        
        public Surtidor(TipoCombustible tipo, double cantidadCombustible,  double precioCombustiblePorLitro)
        {
            CantidadSurtidores++;
            this.Nro = CantidadSurtidores;
            this.TipoCombustible = tipo;
            this.Stock = cantidadCombustible;
            this.PrecioCombustiblePorLitro = precioCombustiblePorLitro;

        }

        // Sobrecarga de métodos
        public Surtidor()
        {
            CantidadSurtidores++;
            this.Nro = CantidadSurtidores;
        }


        public uint Nro;
        public Boolean Estado = false;
        public Playero? PlayeroAsignado;
        public TipoCombustible TipoCombustible = TipoCombustible.Infinia;
        public double? PrecioCombustiblePorLitro = 1;
        public double? Stock = 0;
        public double? CantidadLitrosParcialesPorVenta = 0;
        public double? MontoTotalVenta = 0;
        public double? CantidadLitrosVendidosEnElDia = 0;

        public void CambiarEstado()
        {

            Estado = !Estado;
            if (Estado == false)
            {
                PlayeroAsignado = null;
            }


        }
        
        public void AsignarPlayero(Playero playero)
        {

            this.PlayeroAsignado = playero;
        }

        public void CambiarPrecioPorLitro(double nuevoPrecio)
        {
            this.PrecioCombustiblePorLitro = nuevoPrecio;
        }

        public void BajarStock(double litros)
        {
            if (this.Stock == 0 || this.Stock < litros) throw new StockException("No hay suficiente stock de combustible"); 
            this.Stock -= litros;
        }

        public void SubirStock(double litros)
        {
            this.Stock += litros;
        }

        public void LitrosPorVenta(double litros)
        {
            this.CantidadLitrosParcialesPorVenta = litros;
        }

        public double? CalcularMontoDeVenta(double cantidadLitros)
        {
            

            return cantidadLitros * this.PrecioCombustiblePorLitro;

        }

        public void CalcularLitrosVendidosEnElDia()
        {
            this.CantidadLitrosVendidosEnElDia += CantidadLitrosParcialesPorVenta;
        }



        public override string ToString()
        {
          
           return $"Surtidor {this.Nro}, Stock: {this.Stock}, Estado: {(this.Estado ? "Habilitado" : "Deshabilitado")}";
        }

    }

}
