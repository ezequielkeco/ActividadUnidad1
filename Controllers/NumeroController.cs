using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class NumeroController : Controller
    {
        public IActionResult ParImpar(int n)
        {
            string resultado;

            if (n % 2 == 0)
            {
                resultado = "es un número par.";
            }
            else
            {
                resultado = "es un número impar.";
            }

            ViewBag.Numero = n;
            ViewBag.Resultado = resultado;

            return View();
        }
    }
}
