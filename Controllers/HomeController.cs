using Microsoft.AspNetCore.Mvc;

namespace TP04_Paquetes_Turísticos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Paquetes=ORTWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete()
    {
        CargarListas();
        return View();
    }
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {
        if(Destino>0 && Hotel>0 && Aereo>0 && Excursion>0)
        {
           Paquete p1 = new Paquete(ORTWorld.ListaHoteles[Hotel-1],ORTWorld.ListaAereos[Aereo-1],ORTWorld.ListaExcursiones[Excursion-1]);
           ORTWorld.Paquetes.Add(ORTWorld.ListaDestinos[Destino-1],p1);
           ViewBag.Paquetes=ORTWorld.Paquetes;
           return View("Index");
        }
        else{
            CargarListas();
            ViewBag.error="Error en el ingreso de datos";
            return View ("SelectPaquete");
        }
    }
    public void CargarListas()
    {
        ViewBag.imgHotel=ORTWorld.ListaHoteles;
        ViewBag.destino=ORTWorld.ListaDestinos;
        ViewBag.imgExcursion=ORTWorld.ListaExcursiones;
        ViewBag.imgAereos=ORTWorld.ListaAereos;
    }
}
