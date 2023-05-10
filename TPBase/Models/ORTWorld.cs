class ORTWorld{
public static List<string> ListaDestinos {get; private set;}=new List<string>{"Londres","Madrid","Paris","Nueva York","Bariloche","Sao pablo","Jerusalen","Montevideo","Toronto","Moscu"};
public static List<string> ListaHoteles {get; private set;}=new List<string>{"hotel_Londres_Hotel_de_Londres","hotel_Madrid_Palace","hotel_Paris_Ritz","hotel_Nueva_York_The_Plaza","hotel_Bariloche_Nevada","hotel_Sao_Pablo_Maksoud_Plaza","hotel_Jerusalen_Herbert_Samuel","hotel_Montevideo_ALOFT","hotel_Toronto_Intercontinental","hotel_Moscu_Radisson_Royal"};
public static List<string> ListaAereos {get; private set;}=new List<string>{"aereolinea_Inglesa","aereolinea_Española","aereolinea_Francesa","aereolinea_Estados_Unidos","aereolinea_Argentina","aereolineas_Brasilera","aereolinea_Israeli","aereolinea_Uruguay","aereolinea_Canada","aereolinea_Rusa"};
public static List<string> ListaExcursiones {get; private set;}=new List<string>{};
public static Dictionary<string, Paquete> Paquetes {get; private set;}
public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
{
bool ver=false;
if (destinoSeleccionado==Paquetes.ContainsKey)
{
    
    return ver;
}
}
}