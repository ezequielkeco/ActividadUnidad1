using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class AnioController : Controller
    {
        public IActionResult Bisiesto(int n)
        {
            bool esBisiesto = (n % 4 == 0 && (n % 100 != 0 || n % 400 == 0));

            ViewBag.Anio = n;
            ViewBag.EsBisiesto = esBisiesto;

            return View();
        }
    }
}
