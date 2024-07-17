using ModuloAdministracion;


namespace Menu
{
    public class AdministracionMenu : Main
    {


        public Administracion administracion;

        public AdministracionMenu(Administracion administracion) : base()
        {

            this.opciones = new List<string> { "Recaudacion final de la Estacion", "Recaudacion de un surtirdor", "Recaudacion de un playero", "MontoTotal descontado correspondiente a ventas con promociones", "Volver" };
            this.title = "MODULO ADMINISTRACION";

        
            this.administracion = administracion;
        }

        public override void MenuInteractivo()
        {

         
            String opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    this.administracion.DineroRecaudadoPorLaEstacionDeServicio();
                    break;
                case "2":

                    this.administracion.DineroRecaudadoDeCadaSurtidor();
                    break;
                case "3":

                    this.administracion.DineroRecaudadoDeCadaPlayero();  
                    break;
                case "4":

                    this.administracion.DineroAhorradoPorClientesAnteCargaDeCombustibleConPromociones();
                    break;
                case "5":
                    this.continuar = false;
                    break;

                default:
                    break;

            }
        }
    }
}
