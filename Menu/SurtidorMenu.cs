

using Menu;
using ModuloPromocion;
using ModuloSurtidor;

namespace EstacionDeServicio
{
    public class SurtidorMenu : Main
    {

        private SurtidorControlador surtidorControlador;
        private PromocionControlador promocionControlador;
        public SurtidorMenu(SurtidorControlador surtidorControlador, PromocionControlador promocionControlador) : base()
        {
            this.opciones = new List<string> { "Agregar surtidor", "Habilitar un surtidor", "Deshabilitar un surtidor", "Ver cantidad de litros vendidos", "Cargar combustible", "Listar todos los surtidores", "Volver" };
            this.title = "MODULO SURTIDOR";

            this.surtidorControlador = surtidorControlador;
            this.promocionControlador = promocionControlador;
        }

        public override void MenuInteractivo()
        {
            
            String opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese tipo de combustible: ");
                    String combustible = Console.ReadLine();

                    if (Enum.TryParse<TipoCombustible>(combustible, true, out TipoCombustible tipoCombustible))
                    {
                        Console.Write("Cantidad Combustible: ");
                        double cantidadCombustible = double.Parse(Console.ReadLine());

                        Console.Write("Ingrese precio por litro: ");
                        double precioCombustiblePorLitro = double.Parse(Console.ReadLine());
                        
                        surtidorControlador.AgregarSurtidor(tipoCombustible, cantidadCombustible, precioCombustiblePorLitro);
                    }
                    else
                    {
                        Console.WriteLine("El tipo de combustible no es valido");
                    }

                    break;
                case "2":

                    List<Surtidor> surtidoresDeshabilitados = surtidorControlador._surtidores.FindAll(s => s.Estado == false);


                    if (surtidoresDeshabilitados.Count == 0)
                    {
                        Console.WriteLine("No hay surtidores deshabilitados");
                        return;
                    }
                    Console.WriteLine("Listado de surtidores deshabilitados: ");
                    foreach (Surtidor surtidor in surtidoresDeshabilitados)
                    {
                        Console.WriteLine($"Surtidor: {surtidor.Nro} - TipoCombustible: {surtidor.TipoCombustible}");
                    }


                    Console.Write("\nIngrese el nro del surtidor a habilitar: ");
                    int nroSurtidor = int.Parse(Console.ReadLine()) - 1;

                    surtidoresDeshabilitados[nroSurtidor].CambiarEstado();

                    Console.WriteLine("El surtidor fue habilitado-");


                    break;
                case "3":

                    List<Surtidor> surtidoresHabilitados = surtidorControlador._surtidores.FindAll(s => s.Estado == true);

                    if (surtidoresHabilitados.Count == 0)
                    {
                        Console.WriteLine("No hay surtidores habilitados");
                        return;
                    }
                    Console.WriteLine("Listado de surtidores habilitados: ");
                    foreach (Surtidor surtidor in surtidoresHabilitados)
                    {
                        Console.WriteLine($"Surtidor: {surtidor.Nro} - TipoCombustible: {surtidor.TipoCombustible}");
                    }

                    Console.WriteLine("\nIngrese el nro del surtidor a deshabilitar");

                    int nroSurtidorHabilitado = int.Parse(Console.ReadLine()) - 1;

                    surtidoresHabilitados[nroSurtidorHabilitado].CambiarEstado();

                    Console.WriteLine("El surtidor fue deshabilitado-");

                    break;
                case "4":
                    Console.Write("Ingrese el nro de surtidor a consultar: ");

                    int nro = int.Parse(Console.ReadLine());
                    surtidorControlador.VerCantidadDeLitrosVendidos(nro);
                    break;

                case "5":

                    List<Surtidor> surtidores = surtidorControlador._surtidores.FindAll(s => s.Estado == true);


                    if (surtidores.Count == 0)
                    {
                        Console.WriteLine("No hay surtidores");
                        return;
                    }



                    Console.WriteLine("Listado de surtidores habilitados: ");
                    for (int i = 0; i < surtidores.Count; i++)
                    {
                        Console.WriteLine($"Surtidor: {i + 1} - TipoCombustible: {surtidores[i].TipoCombustible}");
                    }

                    Console.WriteLine("\nIngrese el nro de surtidor a ocupar: ");

                    int nroSurtidorParaCargarCombustible = (int.Parse(Console.ReadLine()) - 1);



                    if (surtidores[nroSurtidorParaCargarCombustible].PlayeroAsignado == null)
                    {
                        Console.WriteLine("Se le debe asignar un playero al surtirdor antes de continuar...");
                        return;
                    }



                    Console.Write("Ingrese cantidad de litros cargados: ");

                    double litrosCargados = int.Parse(Console.ReadLine());

                        

              
                    if (this.promocionControlador._promociones.Count != 0 )
                    {
                        Console.Write("Paga con promocion? S/N ");

                        Boolean conPromocion = Console.ReadLine().ToUpper() == "S" ? true : false;


                        if (conPromocion)
                        {

                            this.promocionControlador.ListarPromociones();
                            Console.Write("Ingrese el tipo de promocion a utilizar: ");

                            int promocionAUtilizar = int.Parse(Console.ReadLine()) - 1;

                            List<Promocion> listadoPromociones = this.promocionControlador._promociones;
                            Promocion promocion = listadoPromociones[promocionAUtilizar];

                            if (promocion.TipoPromocion == TipoPromocion.Tarjeta)
                            {
                                this.surtidorControlador.CargarCombustible(surtidores[nroSurtidorParaCargarCombustible], litrosCargados, promocion.CantidadPromocion);
                            } 
                            else 
                            { 
                                this.surtidorControlador.CargarCombustible(surtidores[nroSurtidorParaCargarCombustible], litrosCargados, null); 
                            }
                        } 
                        else 
                        {
                            this.surtidorControlador.CargarCombustible(surtidores[nroSurtidorParaCargarCombustible], litrosCargados, null);
                        }
                    }
                    else
                    {
                        this.surtidorControlador.CargarCombustible(surtidores[nroSurtidorParaCargarCombustible], litrosCargados, null);
                    }
                  
                    break;

                case "6":
                    surtidorControlador.ListarSurtidores();
                    break;

                case "7":
                    this.continuar = false;
                    break;
                default:
                    break;

            }
        }
    }
}
