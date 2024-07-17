

namespace ModuloPlayero
{
    public class PlayeroControlador
    {

        public readonly List<Playero> _playeros;


        public PlayeroControlador()
        {
            _playeros = new List<Playero>();
        }

        public void ListarPlayero()
        {
            if (_playeros.Count == 0)
            {
                Console.WriteLine("No hay playeros disponibles...");
                return;

            }

            for (int i = 0; i < _playeros.Count; i++)
            {
                Console.WriteLine($"{i + 1}- {_playeros[i].ToString()}");
            }

        }


        public void CrearPlayero()
        {
            //string dni, string nombre, string apellido, int horarioDeEntrada, int cantidadDeHoras = 8
            Console.Write("Ingrese nombre: ");
            String nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            String apellido = Console.ReadLine();
            Console.Write("Ingrese dni: ");
            String dni = Console.ReadLine();
            Console.Write("Ingrese horario de entrada: ");
            int horarioDeEntrada = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad de horas : ");
            int cantidadDeHoras = int.Parse(Console.ReadLine());

            var nuevo_playero = new Playero(dni, nombre, apellido, horarioDeEntrada, cantidadDeHoras);
            _playeros.Add(nuevo_playero);
            Console.WriteLine("Playero agregado con éxito!");
        }


        public void EliminarPlayero(int nro)
        {

            var playeroAEliminar = _playeros[nro];

            if (playeroAEliminar == null)
            {
                Console.WriteLine("No se encontro el playero");
                return;

            }
            _playeros.Remove(playeroAEliminar);
            Console.WriteLine("Playero eliminado con éxito!");

        }


    }

}