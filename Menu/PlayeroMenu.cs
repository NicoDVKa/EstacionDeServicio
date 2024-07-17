
using Menu;
using ModuloPlayero;
using ModuloSurtidor;

namespace EstacionDeServicio
{
    public class PlayeroMenu : Main
    {

        public PlayeroControlador playeroControlador;
        public SurtidorControlador surtidorControlador;

        public PlayeroMenu(PlayeroControlador playeroControlador, SurtidorControlador surtidorControlador) : base()
        {
            this.opciones = new List<string> { "Dar de alta un playero", "Dar de baja un playero", "Asignar un playero", "Listar todos los playeros", "Volver" };
            this.title = "MODULO PLAYERO";

            this.playeroControlador = playeroControlador;
            this.surtidorControlador = surtidorControlador;
        }

        public override void MenuInteractivo()
        {

            
            String opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    playeroControlador.CrearPlayero();
                    break;

                case "2":

                    if (playeroControlador._playeros.Count == 0)
                    {
                        Console.WriteLine("No hay playeros disponibles...");
                        return;
                    }
                    playeroControlador.ListarPlayero();

                    Console.Write("Ingrese el nro del playero a dar de baja: ");
                    int nro = int.Parse(Console.ReadLine()); 
                    this.playeroControlador.EliminarPlayero(nro);
                    break;

                case "3":

                    if (this.playeroControlador._playeros.Count == 0)
                    {
                        Console.WriteLine("No hay playeros disponibles...");
                        return;
                    }

                    
                    List<Surtidor> surtidores = this.surtidorControlador._surtidores;

                    if (surtidores.FindAll(s => s.Estado == true).Count == 0)
                    {
                        Console.WriteLine("No hay surtidores disponibles...");
                        return;
                    }

                    this.playeroControlador.ListarPlayero();
                    Console.Write("Ingrese el nro del playero a asignar: ");
                    int nroPlayero = int.Parse(Console.ReadLine()) - 1;

                    var playero = this.playeroControlador._playeros[nroPlayero];

                                                                                                            
                    Console.Write($"Ingrese el nro del surtidor a asignarle: <1-{surtidores.Count}> ");
                    int nroSurtidor = int.Parse(Console.ReadLine());
                    surtidores[nroSurtidor - 1].AsignarPlayero(playero);

                    break;

                case "4":
                    playeroControlador.ListarPlayero();
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
