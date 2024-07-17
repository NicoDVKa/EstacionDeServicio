

using Menu;
using ModuloPromocion;

namespace EstacionDeServicio
{
    public class PromocionMenu : Main
    {
        PromocionControlador promocionControlador;
        public PromocionMenu(PromocionControlador promocionControlador) : base()
        {
            this.opciones = new List<string> { "Dar de alta una promocion", "Dar de baja una promocion", "Listar todas las promociones", "Volver" };
            this.title = "MODULO PROMOCION";


            this.promocionControlador = promocionControlador;
        }

        public override void MenuInteractivo()
        {

           
            String opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":

                    Console.Write("Ingrese tipo de promocion <1- puntos o 2- descuento>");
                    int tipoPromocion = int.Parse(Console.ReadLine());

                    if (tipoPromocion == 1) {
                        Console.Write("Ingrese cantidad de puntos a sumar por litros cargado: ");
                    } 
                    else
                    {
                        Console.Write("Ingrese cantidad de descuento: ");
                    };

                    int cantidadASumar = int.Parse(Console.ReadLine());


                    Console.Write("Nombre de la tarjeta: ");
                    String nombreTarjeta = Console.ReadLine();
                    this.promocionControlador.CrearPromocion(tipoPromocion, cantidadASumar, nombreTarjeta);

                    break;

                case "2":

                    List<Promocion> promociones = this.promocionControlador._promociones;

                    this.promocionControlador.ListarPromociones();

                    Console.Write("Ingrese el nro de la promocion a dar de baja: ");

                    int nroPromocion = int.Parse(Console.ReadLine());
                    this.promocionControlador.EliminarPromocion(promociones[nroPromocion].Id);
                    break;

                case "3":

                    this.promocionControlador.ListarPromociones();
                    break;

                case "4":
                    this.continuar = false;
                    break;

                default:
                    break;

            }

        }
    }
}
