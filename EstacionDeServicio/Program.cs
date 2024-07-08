// See https://aka.ms/new-console-template for more information

using ModuloSurtidor;
using ModuloPlayero;


Surtidor surtidor = new Surtidor(TipoCombustible.Infinia);
Surtidor surtidor1 = new Surtidor(TipoCombustible.UltraDiesel);

Playero playero = new Playero("46429629", "Lionel", "Farias", 16);

surtidor.CambiarPlayero(playero);


Console.WriteLine("{0} {1} {2}",surtidor.Nro, surtidor.TipoCombustible, surtidor.PlayeroAsignado);
Console.WriteLine("{0} {1} {2}",surtidor1.Nro, surtidor1.TipoCombustible, surtidor1.PlayeroAsignado);

