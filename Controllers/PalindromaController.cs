using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class PalindromaController : Controller
    {
        public IActionResult Palabra(string id)
        {
            string palabra = id.ToLower();
            string invertida = new string(palabra.Reverse().ToArray());

            bool esPalindroma = palabra == invertida;

            ViewBag.Palabra = id;
            ViewBag.EsPalindroma = esPalindroma;

            return View();
        }
    }
}
