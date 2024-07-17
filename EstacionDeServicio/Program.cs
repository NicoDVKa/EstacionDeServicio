using EstacionDeServicio;
using Menu;
using ModuloAdministracion;



ModuloPlayero.PlayeroControlador playeroControlador = new ModuloPlayero.PlayeroControlador();
ModuloSurtidor.SurtidorControlador surtidorControlador = new ModuloSurtidor.SurtidorControlador(playeroControlador);
ModuloPromocion.PromocionControlador promocionControlador = new ModuloPromocion.PromocionControlador();
ModuloAdministracion.Administracion administracion = new ModuloAdministracion.Administracion(surtidorControlador._surtidores, playeroControlador._playeros);

Main main = new(
    new SurtidorMenu(surtidorControlador, promocionControlador), 
    new PlayeroMenu(playeroControlador, surtidorControlador), 
    new PromocionMenu(promocionControlador), 
    new AdministracionMenu(administracion));

main.ShowMenu();