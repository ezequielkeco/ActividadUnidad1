using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class FraseController : Controller
    {
        public IActionResult ContarPalabras(string id)
        {
            var palabras = id.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int cantidad = palabras.Length;

            ViewBag.Frase = id;
            ViewBag.Cantidad = cantidad;

            return View();
        }
    }
}
