
namespace ModuloPlayero
{
    public class Playero
    {
        public String DNI;
        public String Nombre;
        public String Apellido;
        public int HorarioEntrada;
        public int HorarioSalida;
        public double MontoTotalVentas;

     
        
        public Playero(String dni, String nombre, String apellido, int horarioEntrada, int cantidadDeHoras = 8)
        {
            this.DNI = dni;
            this.Nombre = nombre; 
            this.Apellido = apellido;
            this.HorarioEntrada = horarioEntrada;
            this.HorarioSalida = this.HorarioEntrada + cantidadDeHoras;
        }

        public void CambiarHorarioEntrada(int nuevoHorario, int cantidadDeHoras = 8)
        {
            this.HorarioEntrada = nuevoHorario;
            this.HorarioSalida = this.HorarioEntrada + cantidadDeHoras;
        }


        public void CalcularMontoTotalVentas(double monto)
        {
            this.MontoTotalVentas = this.MontoTotalVentas + monto;
        }


        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Playero other = (Playero)obj;
            return Nombre == other.Nombre &&
                   Apellido == other.Apellido &&
                   DNI == other.DNI;
        }

    }
}
