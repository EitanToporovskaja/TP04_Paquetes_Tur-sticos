using Microsoft.AspNetCore.Mvc;

namespace Tp_Calculadora.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        return View();
    }
    public IActionResult Calcular (double num1, double num2, char operacion){
        ViewBag.Resultado = Calculadora.Calcular(num1,num2,operacion);
        return View("Index");
    }
}
