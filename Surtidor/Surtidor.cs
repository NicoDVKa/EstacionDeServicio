

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
        public String? PlayeroAsignado; // Crear Clase Playero  <--
        public TipoCombustible TipoCombustible;
        public double? PrecioCombustiblePorLitro; 
        public double? Stock; 
        public double? CantidadLitrosParcialesPorVenta; 
        public double? MontoVenta; 
        public double? CantidadLitrosVendidosEnElDia; 
        

    }
    
}
