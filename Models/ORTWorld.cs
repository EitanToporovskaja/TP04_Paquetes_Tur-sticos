class ORTWorld{
public static List<string> ListaDestinos {get; private set;}=new List<string>{"Londres","Madrid","Paris","Nueva York","Bariloche","Sao pablo","Jerusalen","Montevideo","Toronto","Moscu"};
public static List<string> ListaHoteles {get; private set;}=new List<string>{"hotel_Londres_Hotel_de_Londres.jfif","hotel_Madrid_Palace.jfif","hotel_Paris_Ritz.jfif","hotel_Nueva_York_The_Plaza.jfif","hotel_Bariloche_Nevada.jfif","hotel_Sao_Pablo_Maksoud_Plaza.jfif","hotel_Jerusalen_Herbert_Samuel.jfif","hotel_Montevideo_ALOFT.jfif","hotel_Toronto_Intercontinental.jfif","hotel_Moscu_Radisson_Royal.jfif"};
public static List<string> ListaAereos {get; private set;}=new List<string>{"aereolinea_Inglesa.jfif","aereolinea_Española.jfif","aereolinea_Francesa.jfif","aereolinea_Estados_Unidos.jfif","aereolinea_Argentina.jfif","aereolineas_Brasilera.jfif","aereolinea_Israeli.jfif","aereolinea_Uruguay.jfif","aereolinea_Canada.jfif","aereolinea_Rusa.jfif"};
public static List<string> ListaExcursiones {get; private set;}=new List<string>{"excursion_en_autobús_por_la_ciudad_Oxford_Street_Park_Lane_Londres.jfif","excursion_tour_de_Madrid.jfif","excursion_Recorridos_en_autobús_por_París.jfif","excursion_estatua_de_la_libertad.jfif","excursion_en_Bariloche_ A_volar_en_el_Cerro_Otto_Zipline.jfif","excursion_Recorrido_privado_por_la_ciudad_de_São_Paulo.jfif","excursion_de_visitas_guiadas_en_Jerusalen.jfif","excursion_Tour_completo_a_Uruguay_visitando_Colonia_Montevideo_Punta_del_Este.jfif","excursion_Catarata_del_niagara_Toronto.jfif","excursion_a_la_Plaza_Roja_Turismo_en_Rusia.jfif"};
public static Dictionary<string, Paquete> Paquetes {get; private set;}=new Dictionary<string, Paquete>();
public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
{
bool ver=false;
if (Paquetes.ContainsKey(destinoSeleccionado))
{

    return ver;
}
else{
    return ver=true;
}
}
}