using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class TemperaturaController : Controller
    {
        public IActionResult Convertir(double n)
        {
            double fahrenheit = (n * 9 / 5) + 32;

            ViewBag.Celsius = n;
            ViewBag.Fahrenheit = fahrenheit;

            return View();
        }
    }
}
