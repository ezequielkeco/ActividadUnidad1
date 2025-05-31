using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class TablaController : Controller
    {
        public IActionResult Multiplicar(int n)
        {
            List<string> resultados = new List<string>();

            for (int i = 1; i <= 12; i++)
            {
                resultados.Add($"{n} x {i} = {n * i}");
            }

            ViewBag.Numero = n;
            ViewBag.Resultados = resultados;

            return View();
        }
    }
}
