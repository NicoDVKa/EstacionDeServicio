
using EstacionDeServicio;

namespace Menu
{
    public class Main
    {
        public List<String> opciones;
        public String title;
        public Boolean continuar = true;

        protected SurtidorMenu surtidorMenu;
        protected PlayeroMenu playeroMenu;
        protected PromocionMenu promocionMenu;
        protected AdministracionMenu administracionMenu;


        public Main() 
        
        {
            opciones = new List<String> { "Surtidores", "Playeros", "Promociones", "Administracion", "Salir" };
            title = "ESTACION DE SERVICIO";
        }

        public Main(SurtidorMenu surtidorMenu, PlayeroMenu playeroMenu, PromocionMenu promocionMenu, AdministracionMenu administracionMenu)
        {
            opciones = new List<String> { "Surtidores", "Playeros", "Promociones", "Administracion", "Salir" };
            title = "ESTACION DE SERVICIO";
            this.surtidorMenu = surtidorMenu;
            this.playeroMenu = playeroMenu;
            this.promocionMenu = promocionMenu;
            this.administracionMenu = administracionMenu;
        }

        public virtual void ShowMenu()
        {
            this.continuar = true;
            while (continuar)
            {
                Console.Clear();
                MenuTitle();
                IterarOpciones();
                MenuInteractivo();

                if (continuar)
                {
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }

        }

        public void IterarOpciones()
        {
            for (int i = 0; i < opciones.Count; i++)
            {
                Console.WriteLine($"{i + 1}- {opciones[i]}");
            }
        }

        public void MenuTitle()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine(new String('*', 5) + $"   {title}    " + new String('*', 5));

            Console.WriteLine("Seleccione una opcion: ");
        }


        public virtual void MenuInteractivo()
        {
            
            String opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    surtidorMenu.ShowMenu();
                    break;
                case "2":
                    playeroMenu.ShowMenu();
                    break;
                case "3":
                    promocionMenu.ShowMenu(); 
                    break;
                case "4":
                    administracionMenu.ShowMenu();
                    break;
                case "5":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;

            }
        }

    }



 
}
