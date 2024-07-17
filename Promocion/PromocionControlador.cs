

namespace ModuloPromocion
{
    public class PromocionControlador
    {

        public readonly List<Promocion> _promociones;

        public static double? DescuentoPromocion = 0;
        public PromocionControlador() {

            _promociones = new List<Promocion>();
        }


        public void CrearPromocion(int tipoPromocion, double cantidadASumar, string nombreTarjeta) 
        {

            var nuevaPromocion = new Promocion(tipoPromocion, cantidadASumar, nombreTarjeta);
            _promociones.Add(nuevaPromocion);
            Console.WriteLine("Promocion agregada.");

        }


        public void EliminarPromocion(uint id)
        {
            var promocion = _promociones.Find(p => p.Id == id);


            if (promocion != null) 
            {
                _promociones.Remove(promocion);

                Console.WriteLine("Se eliminó la promoción");

     
            }

        }


        public void ListarPromociones()
        {
            if (_promociones.Count == 0)
            {
                Console.WriteLine("No hay promociones disponibles...");
                return;
            }

            for (int i = 0; i < _promociones.Count; i++)
            {
                Console.WriteLine("Listado de promociones vigentes: ");
                Console.WriteLine($"{i + 1}- " + _promociones[i].ToString());
            }


        }


    }
}
