using Microsoft.AspNetCore.Mvc;

namespace TP04_Paquetes_Turísticos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        return View();
    }
    public IActionResult SelectPaquete()
    {

        return View();
    }
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {

        return View();
    }
}
