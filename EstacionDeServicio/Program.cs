// See https://aka.ms/new-console-template for more information

using ModuloSurtidor;


Surtidor surtidor = new Surtidor(TipoCombustible.Infinia);
Surtidor surtidor1 = new Surtidor(TipoCombustible.UltraDiesel);


Console.WriteLine("{0} {1}",surtidor.Nro, surtidor.TipoCombustible);
Console.WriteLine("{0} {1}",surtidor1.Nro, surtidor1.TipoCombustible);

