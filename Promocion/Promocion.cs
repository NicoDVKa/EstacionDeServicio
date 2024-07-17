

namespace ModuloPromocion
{
    public class Promocion
    {

        private static uint CantidadPromociones = 0;


        public uint Id;
        public TipoPromocion TipoPromocion;
        public String NombreDeTarjeta;
        public double CantidadPromocion;


        public Promocion(int tipoPromocion, double cantidadPromocion, string nombreTarjeta)
        {
            CantidadPromociones++;
            this.Id = CantidadPromociones;
            this.TipoPromocion = tipoPromocion == 1 ? TipoPromocion.Puntos : TipoPromocion.Tarjeta;
            this.NombreDeTarjeta = nombreTarjeta;
            this.CantidadPromocion = cantidadPromocion;
        }




        public override string ToString()
        {


            return (this.TipoPromocion == TipoPromocion.Puntos
                ? $"Suma {this.CantidadPromocion} puntos por cada litro"
                : $"{this.CantidadPromocion}% de descuento") + $"con {this.NombreDeTarjeta}";

                
        }

    }



}
