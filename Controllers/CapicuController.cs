using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CapicuController : Controller
    {
        public IActionResult Verificar(int n)
        {
            string numeroStr = n.ToString();
            string numeroInvertido = new string(numeroStr.Reverse().ToArray());

            bool esCapicu = numeroStr == numeroInvertido;

            ViewBag.Numero = n;
            ViewBag.EsCapicu = esCapicu;

            return View();
        }
    }
}
